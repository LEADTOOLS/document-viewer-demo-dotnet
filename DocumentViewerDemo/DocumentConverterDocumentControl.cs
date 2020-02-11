// *************************************************************
// Copyright (c) 1991-2019 LEAD Technologies, Inc.              
// All Rights Reserved.                                         
// *************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

using Leadtools;
using Leadtools.Document.Writer;
using Leadtools.Document;
using Leadtools.Document.Converter;

namespace Leadtools.Demos
{
   public partial class DocumentConverterDocumentControl : UserControl
   {
      public DocumentConverterDocumentControl()
      {
         InitializeComponent();
      }

      private DocumentConverterPreferences _preferences;
      private LEADDocument _inputDocument;

      private DocumentFormatSelector _documentFormatSelector;

      // Raster formats supported by this demo
      // You can add as many as you want here
      private static readonly DocumentConverterRasterFormat[] _rasterFormats =
      {
         new DocumentConverterRasterFormat
         {
            FriendlyName = "TIFF Color",
            BitsPerPixel = 24,
            RasterImageFormat = RasterImageFormat.TifJpeg422,
            Extension = "tif"
         },
         new DocumentConverterRasterFormat
         {
            FriendlyName = "TIFF B/W",
            BitsPerPixel = 1,
            RasterImageFormat = RasterImageFormat.CcittGroup4,
            Extension = "tif"
         },
         new DocumentConverterRasterFormat
         {
            FriendlyName = "PDF Color with JPEG",
            BitsPerPixel = 24,
            RasterImageFormat = RasterImageFormat.RasPdfJpeg422,
            Extension = "pdf"
         },
         new DocumentConverterRasterFormat
         {
            FriendlyName = "PDF Color with JPEG 2000",
            BitsPerPixel = 24,
            RasterImageFormat = RasterImageFormat.RasPdfJpx,
            Extension = "pdf"
         },
         new DocumentConverterRasterFormat
         {
            FriendlyName = "PDF B/W",
            BitsPerPixel = 1,
            RasterImageFormat = RasterImageFormat.RasPdfG4,
            Extension = "pdf"
         }
      };

      private void CleanUp()
      {
         _documentFormatSelector.SelectedFormatChanged -= _documentFormatSelector_SelectedFormatChanged;
         _documentFormatSelector.Dispose();
      }

      // Populate the UI from preferences
      public void Populate(LEADDocument document, DocumentConverterPreferences preferences)
      {
         _preferences = preferences;
         _inputDocument = document;

         _documentFormatSelector = new DocumentFormatSelector();
         _documentFormatSelector.Dock = DockStyle.Fill;
         _outputFormatPanel.Controls.Add(_documentFormatSelector);
         _documentFormatSelector.BringToFront();

         _documentFormatSelector.SetDocumentWriter(_preferences.DocumentWriterInstance, true);

         if (_preferences.OcrEngineInstance != null)
            _documentFormatSelector.SetOcrEngineType(_preferences.OcrEngineInstance.EngineType);

         _documentFormatSelector.SelectedFormatChanged += _documentFormatSelector_SelectedFormatChanged;

         foreach (var format in _rasterFormats)
            _rasterImageFormatComboBox.Items.Add(format);

         // Input ...
         if (_inputDocument == null)
         {
            _inputDocumentFileTextBox.Text = _preferences.InputDocumentFileName;
            if (_preferences.LoadEmbeddedAnnotation)
               _inputAnnotationsModeComboBox.SelectedIndex = 1; // Load embedded
            else if (!string.IsNullOrEmpty(_preferences.InputAnnotationsFileName))
               _inputAnnotationsModeComboBox.SelectedIndex = 2; // Import from external file
            else
               _inputAnnotationsModeComboBox.SelectedIndex = 0; // Do not import annotations

            _inputAnnotationsFileTextBox.Text = _preferences.InputAnnotationsFileName;
         }
         else
         {
            string documentPath;
            var documentUri = _inputDocument.Uri;
            if (documentUri != null)
            {
               if (documentUri.IsFile)
                  documentPath = documentUri.LocalPath;
               else
                  documentPath = documentUri.ToString();
            }
            else
            {
               documentPath = "input.ext";
            }

            _inputDocumentFileTextBox.Text = documentPath;
            _inputDocumentFileTextBox.ReadOnly = true;
            _inputDocumentFileBrowseButton.Visible = false;
            _inputAnnotationsModeLabel.Visible = false;
            _inputAnnotationsModeComboBox.Visible = false;
            _inputAnnotationsFileLabel.Visible = false;
            _inputAnnotationsFileTextBox.Visible = false;
            _inputAnnotationsFileBrowseButton.Visible = false;
         }

         // Output ...
         if (_preferences.DocumentFormat == DocumentFormat.User && _preferences.RasterImageFormat == RasterImageFormat.Unknown)
         {
            // Cannot do that, lets pick PDF
            _preferences.DocumentFormat = DocumentFormat.Pdf;
         }

         _documentFormatSelector.SelectedFormat = _preferences.DocumentFormat;

         foreach (var format in _rasterFormats)
         {
            if (format.RasterImageFormat == _preferences.RasterImageFormat)
            {
               _rasterImageFormatComboBox.SelectedItem = format;
               break;
            }
         }

         if (_rasterImageFormatComboBox.SelectedIndex == -1)
            _rasterImageFormatComboBox.SelectedIndex = 0;

         // 0 = Document, 1 = Raster
         if (_preferences.DocumentFormat != DocumentFormat.User)
            _outputFormatComboBox.SelectedIndex = 0;
         else
            _outputFormatComboBox.SelectedIndex = 1;

         if (_inputDocument == null || _inputDocument.Uri != null)
         {
            _outputDocumentFileTextBox.Text = _preferences.OutputDocumentFileName;
            _outputAnnotationsModeComboBox.SelectedIndex = (int)_preferences.OutputAnnotationsMode;
            _outputAnnotationsFileTextBox.Text = _preferences.OutputAnnotationsFileName;
         }
         else
         {
            _outputDocumentFileTextBox.Text = "output.ext";
            _outputAnnotationsModeComboBox.SelectedIndex = (int)_preferences.OutputAnnotationsMode;
            _outputAnnotationsFileTextBox.Text = _preferences.OutputAnnotationsFileName;

            _outputDocumentFileTextBox.ReadOnly = true;
            _outputDocumentFileBrowseButton.Enabled = false;
            _outputAnnotationsModeComboBox.Enabled = false;
         }

         UpdateInputPages(false);
      }

      // Populate preferences from the UI
      public void ApplyToPreferences()
      {
         // Input ...
         if (_inputDocument == null)
            _preferences.InputDocumentFileName = _inputDocumentFileTextBox.Text.Trim();

         _preferences.InputFirstPage = _fromPageNumericUpDown.Enabled ? (int)_fromPageNumericUpDown.Value : 1;
         _preferences.InputLastPage = _toPageNumericUpDown.Enabled ? (int)_toPageNumericUpDown.Value : -1;

         if (_inputDocument == null)
         {
            if (_inputAnnotationsModeComboBox.SelectedIndex == 0) // Do not import annotations
            {
               _preferences.LoadEmbeddedAnnotation = false;
               _preferences.InputAnnotationsFileName = null;
            }
            else if (_inputAnnotationsModeComboBox.SelectedIndex == 1) // Load embedded
            {
               _preferences.LoadEmbeddedAnnotation = true;
               _preferences.InputAnnotationsFileName = null;
            }
            else // Load from external
            {
               _preferences.LoadEmbeddedAnnotation = false;
               _preferences.InputAnnotationsFileName = _inputAnnotationsFileTextBox.Text.Trim();
            }
         }

         // Output ...
         _preferences.OutputDocumentFileName = _outputDocumentFileTextBox.Text.Trim();

         // 0 = Document, 1 = Raster
         if (_outputFormatComboBox.SelectedIndex == 0)
         {
            // Get the document format
            _preferences.DocumentFormat = _documentFormatSelector.SelectedFormat;
            // Ignore the raster format
            _preferences.RasterImageFormat = RasterImageFormat.Unknown;
         }
         else
         {
            // Get the raster format
            var rasterFormat = (DocumentConverterRasterFormat)_rasterImageFormatComboBox.SelectedItem;
            _preferences.RasterImageFormat = rasterFormat.RasterImageFormat;
            _preferences.RasterImageBitsPerPixel = rasterFormat.BitsPerPixel;

            // Ignore the document format
            _preferences.DocumentFormat = DocumentFormat.User;
         }

         _preferences.OutputAnnotationsMode = (DocumentConverterAnnotationsMode)_outputAnnotationsModeComboBox.SelectedIndex;
         if (_preferences.OutputAnnotationsMode == DocumentConverterAnnotationsMode.External)
            _preferences.OutputAnnotationsFileName = _outputAnnotationsFileTextBox.Text.Trim();
         else
            _preferences.OutputAnnotationsFileName = null;

         UpdateUIState();
      }

      public bool CanApplyToPreferences
      {
         get
         {
            // Input ...

            // We must have a input document file
            if (_inputDocument == null && string.IsNullOrEmpty(_inputDocumentFileTextBox.Text.Trim()))
               return false;

            // If input annotations mode is external file, then we must have one
            if (_inputDocument == null && _inputAnnotationsModeComboBox.SelectedIndex == 2 && // load external file
               string.IsNullOrEmpty(_inputAnnotationsFileTextBox.Text.Trim()))
               return false;

            // Output ...

            if (string.IsNullOrEmpty(_outputDocumentFileTextBox.Text.Trim()))
               return false;

            // If output annotations mode is external file, then we must have one
            if (_outputAnnotationsModeComboBox.SelectedIndex == (int)DocumentConverterAnnotationsMode.External &&
               string.IsNullOrEmpty(_outputAnnotationsFileTextBox.Text.Trim()))
               return false;

            return true;
         }
      }

      public event EventHandler UIStateChanged;
      private void UpdateUIState()
      {
         // 2 = Load external file
         _inputAnnotationsFileTextBox.Enabled = (_inputAnnotationsModeComboBox.SelectedIndex == 2);
         _inputAnnotationsFileLabel.Enabled = _inputAnnotationsFileTextBox.Enabled;
         _inputAnnotationsFileBrowseButton.Enabled = _inputAnnotationsFileTextBox.Enabled;

         _outputAnnotationsFileTextBox.Enabled = (_outputAnnotationsModeComboBox.SelectedIndex == (int)DocumentConverterAnnotationsMode.External);
         _outputAnnotationsFileLabel.Enabled = _outputAnnotationsFileTextBox.Enabled;
         _outputAnnotationsFileBrowseButton.Enabled = _outputAnnotationsFileTextBox.Enabled;

         if (UIStateChanged != null)
            UIStateChanged(this, EventArgs.Empty);
      }

      private void UpdateInputPages(bool reset)
      {
         try
         {
            using (var wait = new WaitCursor())
            {
               var fileName = _inputDocumentFileTextBox.Text.Trim();
               if (File.Exists(fileName))
               {
                  _preferences.InputDocumentPageCount = _preferences.RasterCodecsInstance.GetTotalPages(fileName);
               }
            }
         }
         catch (Exception ex)
         {
            // We do not know
            _preferences.InputDocumentPageCount = 0;
            Debug.WriteLine(ex.Message);
         }

         // Reset the pages
         if (_preferences.InputDocumentPageCount > 0)
         {
            // We know the pages
            _fromPageNumericUpDown.Maximum = _preferences.InputDocumentPageCount;
            _toPageNumericUpDown.Maximum = _preferences.InputDocumentPageCount;
         }
         else
         {
            // We do not know the pages
            _fromPageNumericUpDown.Maximum = Int16.MaxValue;
            _toPageNumericUpDown.Maximum = Int16.MaxValue;
         }

         if (reset || _preferences.InputFirstPage > _preferences.InputDocumentPageCount || _preferences.InputLastPage > _preferences.InputDocumentPageCount || (_preferences.InputFirstPage == 1 && (_preferences.InputLastPage == -1 || _preferences.InputLastPage == _preferences.InputDocumentPageCount)))
         {
            if(_preferences.InputLastPage > _preferences.InputDocumentPageCount) _preferences.InputLastPage = _preferences.InputDocumentPageCount;
            _fromPageNumericUpDown.Value = 1;
            _toPageNumericUpDown.Value = Math.Max(1, Math.Max(_preferences.InputLastPage, _preferences.InputDocumentPageCount));

            _firstPageCheckBox.Checked = true;
            _lastPageCheckBox.Checked = true;
         }
         else
         {
            _fromPageNumericUpDown.Value = _preferences.InputFirstPage;
            if (_preferences.InputLastPage == -1)
            {
               if (_preferences.InputDocumentPageCount > 0)
                  _toPageNumericUpDown.Value = _preferences.InputDocumentPageCount;
               else
                  _toPageNumericUpDown.Value = 1;
            }
            else
            {
               _toPageNumericUpDown.Value = _preferences.InputLastPage;
            }

            _firstPageCheckBox.Checked = false;
            _lastPageCheckBox.Checked = (_preferences.InputLastPage == -1);
         }

         UpdateActualTotalPages();
      }

      private void UpdateOutputDocumentExtension()
      {
         var documentFileName = _outputDocumentFileTextBox.Text.Trim();
         if (string.IsNullOrEmpty(documentFileName))
            return;

         string extension;

         // Get the current format
         if (_outputFormatComboBox.SelectedIndex == 0)
         {
            var format = _documentFormatSelector.SelectedFormat;
            extension = DocumentWriter.GetFormatFileExtension(format);
         }
         else
         {
            var format = (DocumentConverterRasterFormat)_rasterImageFormatComboBox.SelectedItem;
            extension = format.Extension;
         }

         try
         {
            documentFileName = Path.ChangeExtension(documentFileName, extension);
            _outputDocumentFileTextBox.Text = documentFileName;
         }
         catch { }
      }

      private void _inputDocumentFileBrowseButton_Click(object sender, EventArgs e)
      {
         using (var dlg = new OpenFileDialog())
         {
            dlg.Filter = "All files|*.*";
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
               _inputDocumentFileTextBox.Text = dlg.FileName;
               UpdateInputPages(true);
            }
         }
      }

      private void _inputDocumentFileTextBox_TextChanged(object sender, EventArgs e)
      {
         if (File.Exists(_inputDocumentFileTextBox.Text))
            UpdateInputPages(true);
         UpdateUIState();
      }

      private void _inputAnnotationsModeComboBox_SelectedIndexChanged(object sender, EventArgs e)
      {
         if (_inputAnnotationsModeComboBox.SelectedIndex == 0) // Do not import annotations
         {
            // Then nothing to export either
            _outputAnnotationsModeComboBox.SelectedIndex = (int)DocumentConverterAnnotationsMode.None;
            _outputAnnotationsModeComboBox.Enabled = false;
         }
         else
         {
            _outputAnnotationsModeComboBox.Enabled = true;
         }

         UpdateUIState();
      }

      private void _inputAnnotationsFileBrowseButton_Click(object sender, EventArgs e)
      {
         using (var dlg = new OpenFileDialog())
         {
            dlg.Filter = "Annotation files (*.xml)|*.xml|All files|*.*";
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
               _inputAnnotationsFileTextBox.Text = dlg.FileName;
               UpdateUIState();
            }
         }
      }

      private void _inputAnnotationsFileTextBox_TextChanged(object sender, EventArgs e)
      {
         UpdateUIState();
      }

      private void _documentFormatSelector_SelectedFormatChanged(object sender, EventArgs e)
      {
         // Change the output file extension when the document format is changed
         // ???
         // also disable annotations on LTD!
         UpdateOutputDocumentExtension();
      }

      private void _outputFormatComboBox_SelectedIndexChanged(object sender, EventArgs e)
      {
         // 0 = Document, 1 = Raster
         _documentFormatSelector.Visible = (_outputFormatComboBox.SelectedIndex == 0);
         _rasterImageFormatComboBox.Visible = (_outputFormatComboBox.SelectedIndex == 1);
         UpdateOutputDocumentExtension();
      }

      private void _rasterImageFormatComboBox_SelectedIndexChanged(object sender, EventArgs e)
      {
         UpdateOutputDocumentExtension();
      }

      private void _outputDocumentFileBrowseButton_Click(object sender, EventArgs e)
      {
         string friendlyName;
         string extension;

         // Get the current format
         if (_outputFormatComboBox.SelectedIndex == 0)
         {
            var format = _documentFormatSelector.SelectedFormat;
            friendlyName = DocumentWriter.GetFormatFriendlyName(format);
            extension = DocumentWriter.GetFormatFileExtension(format);
         }
         else
         {
            var format = (DocumentConverterRasterFormat)_rasterImageFormatComboBox.SelectedItem;
            friendlyName = format.FriendlyName;
            extension = format.Extension;
         }

         using (var dlg = new SaveFileDialog())
         {
            dlg.Filter = string.Format("{0} (*.{1}) files|*.{1}|All files|*.*", friendlyName, extension);
            dlg.DefaultExt = extension;
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
               _outputDocumentFileTextBox.Text = dlg.FileName;
               UpdateUIState();
            }
         }
      }

      private void _outputDocumentFileTextBox_TextChanged(object sender, EventArgs e)
      {
         UpdateUIState();
      }

      private void _outputAnnotationsModeComboBox_SelectedIndexChanged(object sender, EventArgs e)
      {
         UpdateUIState();
      }

      private void _outputAnnotationsFileTextBox_TextChanged(object sender, EventArgs e)
      {
         UpdateUIState();
      }

      private void _outputAnnotationsFileBrowseButton_Click(object sender, EventArgs e)
      {
         using (var dlg = new SaveFileDialog())
         {
            dlg.Filter = "Annotation files (*.xml)|*.xml|All files|*.*";
            dlg.DefaultExt = "xml";
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
               _outputAnnotationsFileTextBox.Text = dlg.FileName;
               UpdateUIState();
            }
         }
      }

      private void _firstPageCheckBox_CheckedChanged(object sender, EventArgs e)
      {
         if (_firstPageCheckBox.Checked)
            _fromPageNumericUpDown.Value = 1;

         _fromPageNumericUpDown.Enabled = !_firstPageCheckBox.Checked;
         UpdateActualTotalPages();
      }

      private void _fromPageNumericUpDown_ValueChanged(object sender, EventArgs e)
      {
         if (_toPageNumericUpDown.Enabled && _toPageNumericUpDown.Value < _fromPageNumericUpDown.Value)
            _toPageNumericUpDown.Value = _fromPageNumericUpDown.Value;

         UpdateActualTotalPages();
      }

      private void _lastPageCheckBox_CheckedChanged(object sender, EventArgs e)
      {
         if (_lastPageCheckBox.Checked)
            _toPageNumericUpDown.Value = _preferences.InputDocumentPageCount > 0 ? _preferences.InputDocumentPageCount : 1;

         _toPageNumericUpDown.Enabled = !_lastPageCheckBox.Checked;
         UpdateActualTotalPages();
      }

      private void _toPageNumericUpDown_ValueChanged(object sender, EventArgs e)
      {
         if (_fromPageNumericUpDown.Enabled && _fromPageNumericUpDown.Value > _toPageNumericUpDown.Value)
            _fromPageNumericUpDown.Value = _toPageNumericUpDown.Value;

         UpdateActualTotalPages();
      }

      private void UpdateActualTotalPages()
      {
         if (_preferences == null) return;

         int firstPage = (_firstPageCheckBox.Checked) ? 1 : (int)_fromPageNumericUpDown.Value;
         int lastPage = (_lastPageCheckBox.Checked) ? _preferences.InputDocumentPageCount : (int)_toPageNumericUpDown.Value;

         _documentFormatSelector.TotalPages = lastPage - firstPage + 1;
      }
   }
}
