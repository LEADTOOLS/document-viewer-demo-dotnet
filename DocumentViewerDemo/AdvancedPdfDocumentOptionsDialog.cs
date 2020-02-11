// *************************************************************
// Copyright (c) 1991-2019 LEAD Technologies, Inc.              
// All Rights Reserved.                                         
// *************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Leadtools.Document.Writer;

namespace Leadtools.Demos
{
   public partial class AdvancedPdfDocumentOptionsDialog : Form
   {
      private PdfDocumentOptions _pdfOptions;
      private int _totalPages;
      private int _advancedPdfOptionsDefaultSelectedTabIndex = 0;
      public bool ShowLinearized = true;

      public AdvancedPdfDocumentOptionsDialog(PdfDocumentOptions pdfOptions, int totalPages, int advancedPdfOptionsDefaultSelectedTabIndex)
      {
         InitializeComponent();

         _pdfOptions = pdfOptions;
         _totalPages = totalPages;
         _advancedPdfOptionsDefaultSelectedTabIndex = advancedPdfOptionsDefaultSelectedTabIndex;
      }

      protected override void OnLoad(EventArgs e)
      {
         if(!DesignMode)
         {
            Array a = Enum.GetValues(typeof(DocumentFontEmbedMode));
            foreach(DocumentFontEmbedMode i in a)
               _fontEmbeddingComboBox.Items.Add(i);

            a = Enum.GetValues(typeof(PdfDocumentEncryptionMode));
            foreach(PdfDocumentEncryptionMode i in a)
               _encryptionModeComboBox.Items.Add(i);

            _fontEmbeddingComboBox.SelectedItem = _pdfOptions.FontEmbedMode;
            _linearizedCheckBox.Checked = _pdfOptions.Linearized;
            _linearizedCheckBox.Visible = ShowLinearized;
            _titleTextBox.Text = _pdfOptions.Title;
            _subjectTextBox.Text = _pdfOptions.Subject;
            _authorTextBox.Text = _pdfOptions.Author;
            _creatorTextBox.Text = string.IsNullOrEmpty(_pdfOptions.Creator) ? "LEADTOOLS PDFWriter" : _pdfOptions.Creator;
            _producerTextBox.Text = string.IsNullOrEmpty(_pdfOptions.Producer) ? "LEAD Technologies, Inc." : _pdfOptions.Producer;
            _keywordsTextBox.Text = _pdfOptions.Keywords;

            _protectedCheckBox.Checked = _pdfOptions.Protected;
            _encryptionModeComboBox.SelectedItem = _pdfOptions.EncryptionMode;
            _userPasswordTextBox.Text = _pdfOptions.UserPassword;
            _ownerPasswordTextBox.Text = _pdfOptions.OwnerPassword;
            _copyEnabledCheckBox.Checked = _pdfOptions.CopyEnabled;
            _editEnabledCheckBox.Checked = _pdfOptions.EditEnabled;
            _annotationsEnabledCheckBox.Checked = _pdfOptions.AnnotationsEnabled;
            _printEnabledCheckBox.Checked = _pdfOptions.PrintEnabled;
            _assemblyEnabledCheckBox.Checked = _pdfOptions.AssemblyEnabled;
            _highQualityPrintEnabledCheckBox.Checked = _pdfOptions.HighQualityPrintEnabled;

            // Compression options
            a = Enum.GetValues(typeof(OneBitImageCompressionType));
            foreach (OneBitImageCompressionType i in a)
               _oneBitImageCompressionComboBox.Items.Add(i);
            _oneBitImageCompressionComboBox.SelectedItem = _pdfOptions.OneBitImageCompression;

            a = Enum.GetValues(typeof(ColoredImageCompressionType));
            foreach (ColoredImageCompressionType i in a)
               _coloredImageCompressionComboBox.Items.Add(i);
            _coloredImageCompressionComboBox.SelectedItem = _pdfOptions.ColoredImageCompression;

            _qualityFactorNumericUpDown.Value = _pdfOptions.QualityFactor;

            a = Enum.GetValues(typeof(DocumentImageOverTextSize));
            foreach (DocumentImageOverTextSize i in a)
               _imageOverTextSizeComboBox.Items.Add(i);
            _imageOverTextSizeComboBox.SelectedItem = _pdfOptions.ImageOverTextSize;

            a = Enum.GetValues(typeof(DocumentImageOverTextMode));
            foreach (DocumentImageOverTextMode i in a)
               _imageOverTextModeComboBox.Items.Add(i);
            _imageOverTextModeComboBox.SelectedItem = _pdfOptions.ImageOverTextMode;

            // Initial View Options
            a = Enum.GetValues(typeof(PdfDocumentPageModeType));
            foreach (PdfDocumentPageModeType i in a)
               _pageModeComboBox.Items.Add(i);
            _pageModeComboBox.SelectedItem = _pdfOptions.PageModeType;

            a = Enum.GetValues(typeof(PdfDocumentPageLayoutType));
            foreach (PdfDocumentPageLayoutType i in a)
               _pageLayoutComboBox.Items.Add(i);
            _pageLayoutComboBox.SelectedItem = _pdfOptions.PageLayoutType;

            a = Enum.GetValues(typeof(PdfDocumentPageFitType));
            foreach (PdfDocumentPageFitType i in a)
               _pageFitTypeComboBox.Items.Add(i);

            int[] predefinedZoomValues = { 25, 50, 75, 100, 125, 150, 200, 400, 800, 1600, 2400, 3200, 6400 };
            foreach (int i in predefinedZoomValues)
               _pageFitTypeComboBox.Items.Add(string.Format("{0}%", i));
            if(_pdfOptions.ZoomPercent == 0)
               _pageFitTypeComboBox.SelectedItem = _pdfOptions.PageFitType;
            else
            {
               for (int i = Enum.GetValues(typeof(PdfDocumentPageFitType)).Length; i < _pageFitTypeComboBox.Items.Count; i++)
               {
                  string pageFitType = _pageFitTypeComboBox.Items[i] as string;
                  if (!string.IsNullOrEmpty(pageFitType))
                  {
                     double value;
                     char[] characterToTrim = { ' ', '%' };
                     if (double.TryParse(pageFitType.Trim(characterToTrim), out value))
                     {
                        if (value == _pdfOptions.ZoomPercent)
                        {
                           _pageFitTypeComboBox.SelectedIndex = i;
                           break;
                        }
                     }
                  }
               }
            }

            if (_pageFitTypeComboBox.SelectedItem == null)
            {
               if (_pdfOptions.ZoomPercent == 0)
                  _pageFitTypeComboBox.SelectedIndex = 0;
               else
                  _pageFitTypeComboBox.Text = string.Format("{0}%", _pdfOptions.ZoomPercent);
            }

            _initialPageNumberNumericUpDown.Maximum = _totalPages;
            _initialPageNumberNumericUpDown.Value = (_pdfOptions.InitialPageNumber <= _totalPages) ? _pdfOptions.InitialPageNumber : _totalPages;
            _numberOfPagesLabel.Text = string.Format("of {0}", _totalPages);
            _resizeWindowCheckBox.Checked = _pdfOptions.FitWindow;
            _centerWindowCheckBox.Checked = _pdfOptions.CenterWindow;

            _showDocumentTitleComboBox.Items.Add("File Name");
            _showDocumentTitleComboBox.Items.Add("Document Title");
            _showDocumentTitleComboBox.SelectedIndex = (_pdfOptions.DisplayDocTitle) ? 1 : 0;
            _hideMenuBarCheckBox.Checked = _pdfOptions.HideMenubar;
            _hideToolBarCheckBox.Checked = _pdfOptions.HideToolbar;
            _hideWindowControlsCheckBox.Checked = _pdfOptions.HideWindowUI;

            UpdateUIState();

            if (_advancedPdfOptionsDefaultSelectedTabIndex >= _tabControl.TabPages.Count)
               _advancedPdfOptionsDefaultSelectedTabIndex = _tabControl.TabPages.Count - 1;
            _tabControl.SelectedIndex = _advancedPdfOptionsDefaultSelectedTabIndex;
         }

         base.OnLoad(e);
      }

      public TabControl TabControl
      {
         get { return _tabControl; }
      }

      private void UpdateUIState()
      {
         // Disable all controls in this dialog except the "Fast web view (Linearized)" option.
         if(_pdfOptions.DocumentType == PdfDocumentType.PdfA)
         {
            _fontEmbeddingLabel.Enabled = false;
            _fontEmbeddingComboBox.Enabled = false;
            _securityGroupBox.Enabled = false;
         }
         else
         {
            bool protectedDocument = _protectedCheckBox.Checked;

            _encryptionModeComboBox.Enabled = protectedDocument;
            _userPasswordTextBox.Enabled = protectedDocument;
            _ownerPasswordTextBox.Enabled = protectedDocument;
            _permissionsGroupBox.Enabled = protectedDocument;

            if (protectedDocument && _encryptionModeComboBox.SelectedItem != null)
            {
               PdfDocumentEncryptionMode encryptionMode = (PdfDocumentEncryptionMode)_encryptionModeComboBox.SelectedItem;
               _assemblyEnabledCheckBox.Enabled = (encryptionMode == PdfDocumentEncryptionMode.RC128Bit) && !_editEnabledCheckBox.Checked;
               _highQualityPrintEnabledCheckBox.Enabled = (encryptionMode == PdfDocumentEncryptionMode.RC128Bit && _printEnabledCheckBox.Checked);
            }
         }

         // Disable the image over text options if not image over text
         _imageOverTextSizeLabel.Enabled = _pdfOptions.ImageOverText;
         _imageOverTextSizeComboBox.Enabled = _pdfOptions.ImageOverText;
         _imageOverTextModeLabel.Enabled = _pdfOptions.ImageOverText;
         _imageOverTextModeComboBox.Enabled = _pdfOptions.ImageOverText;

         if (_coloredImageCompressionComboBox.SelectedItem != null)
         {
            ColoredImageCompressionType coloredImageCompression = (ColoredImageCompressionType)_coloredImageCompressionComboBox.SelectedItem;
            if (coloredImageCompression == ColoredImageCompressionType.FlateJpeg ||
               coloredImageCompression == ColoredImageCompressionType.LzwJpeg ||
               coloredImageCompression == ColoredImageCompressionType.Jpeg ||
               coloredImageCompression == ColoredImageCompressionType.FlateJpx ||
               coloredImageCompression == ColoredImageCompressionType.LzwJpx ||
               coloredImageCompression == ColoredImageCompressionType.Jpx)
            {
               _qualityFactorLabel.Enabled = true;
               _qualityFactorNumericUpDown.Enabled = true;
            }
            else
            {
               _qualityFactorLabel.Enabled = false;
               _qualityFactorNumericUpDown.Enabled = false;
            }
         }
      }

      private void _protectedCheckBox_CheckedChanged(object sender, EventArgs e)
      {
         UpdateUIState();
      }

      private void _encryptionModeComboBox_SelectedIndexChanged(object sender, EventArgs e)
      {
         UpdateUIState();
      }

      private void _okButton_Click(object sender, EventArgs e)
      {
         _pdfOptions.FontEmbedMode = (DocumentFontEmbedMode)_fontEmbeddingComboBox.SelectedItem;
         _pdfOptions.Linearized = _linearizedCheckBox.Checked;
         _pdfOptions.Title = _titleTextBox.Text;
         _pdfOptions.Subject = _subjectTextBox.Text;
         _pdfOptions.Author = _authorTextBox.Text;
         _pdfOptions.Creator = _creatorTextBox.Text;
         _pdfOptions.Producer = _producerTextBox.Text;
         _pdfOptions.Keywords = _keywordsTextBox.Text;

         _pdfOptions.Protected = _protectedCheckBox.Checked;
         _pdfOptions.EncryptionMode = (PdfDocumentEncryptionMode)_encryptionModeComboBox.SelectedItem;
         _pdfOptions.UserPassword = _userPasswordTextBox.Text;
         _pdfOptions.OwnerPassword = _ownerPasswordTextBox.Text;
         _pdfOptions.CopyEnabled = _copyEnabledCheckBox.Checked;
         _pdfOptions.EditEnabled = _editEnabledCheckBox.Checked;
         _pdfOptions.AnnotationsEnabled = _annotationsEnabledCheckBox.Checked;
         _pdfOptions.PrintEnabled = _printEnabledCheckBox.Checked;
         _pdfOptions.AssemblyEnabled = _assemblyEnabledCheckBox.Checked;
         _pdfOptions.HighQualityPrintEnabled = _highQualityPrintEnabledCheckBox.Checked;

         // Compression options
         _pdfOptions.OneBitImageCompression = (OneBitImageCompressionType)_oneBitImageCompressionComboBox.SelectedItem;
         _pdfOptions.ColoredImageCompression = (ColoredImageCompressionType)_coloredImageCompressionComboBox.SelectedItem;
         _pdfOptions.QualityFactor = (int)_qualityFactorNumericUpDown.Value;
         _pdfOptions.ImageOverTextSize = (DocumentImageOverTextSize)_imageOverTextSizeComboBox.SelectedItem;
         _pdfOptions.ImageOverTextMode = (DocumentImageOverTextMode)_imageOverTextModeComboBox.SelectedItem;

         // Initial View Options
         _pdfOptions.PageModeType = (PdfDocumentPageModeType)_pageModeComboBox.SelectedItem;
         _pdfOptions.PageLayoutType = (PdfDocumentPageLayoutType)_pageLayoutComboBox.SelectedItem;
         if (_pageFitTypeComboBox.SelectedIndex >= 0 && _pageFitTypeComboBox.SelectedIndex < Enum.GetValues(typeof(PdfDocumentPageFitType)).Length)
         {
            // Selected item is one of the original enum members, so just use it
            _pdfOptions.PageFitType = (PdfDocumentPageFitType)_pageFitTypeComboBox.SelectedItem;
            _pdfOptions.ZoomPercent = 0;
         }
         else
         {
            string pageFitType = _pageFitTypeComboBox.Text;
            double value;
            char[] characterToTrim = { ' ', '%' };
            if (double.TryParse(pageFitType.Trim(characterToTrim), out value))
               _pdfOptions.ZoomPercent = value;
         }

         _pdfOptions.InitialPageNumber = (int)_initialPageNumberNumericUpDown.Value;
         _pdfOptions.FitWindow = _resizeWindowCheckBox.Checked;
         _pdfOptions.CenterWindow = _centerWindowCheckBox.Checked;
         _pdfOptions.DisplayDocTitle = (_showDocumentTitleComboBox.SelectedIndex == 1) ? true : false;
         _pdfOptions.HideMenubar = _hideMenuBarCheckBox.Checked;
         _pdfOptions.HideToolbar = _hideToolBarCheckBox.Checked;
         _pdfOptions.HideWindowUI = _hideWindowControlsCheckBox.Checked;
      }

      private void _printEnabledCheckBox_CheckedChanged(object sender, EventArgs e)
      {
         UpdateUIState();
      }

      private void _editEnabledCheckBox_CheckedChanged(object sender, EventArgs e)
      {
         UpdateUIState();
      }

      private void _coloredImageCompressionComboBox_SelectedIndexChanged(object sender, EventArgs e)
      {
         UpdateUIState();
      }

      private void _hideMenuBarCheckBox_CheckedChanged(object sender, EventArgs e)
      {
         // Hide Window Controls and Hide Menubar doesn't work together even on Adobe Acrobat side, so we will uncheck the other one if one of them is checked
         if (_hideWindowControlsCheckBox.Checked)
         {
            _hideWindowControlsCheckBox.CheckedChanged -= new System.EventHandler(_hideWindowControlsCheckBox_CheckedChanged);
            _hideWindowControlsCheckBox.Checked = false;
            _hideWindowControlsCheckBox.CheckedChanged += new System.EventHandler(_hideWindowControlsCheckBox_CheckedChanged);
         }
      }

      private void _hideWindowControlsCheckBox_CheckedChanged(object sender, EventArgs e)
      {
         // Hide Window Controls and Hide Menubar doesn't work together even on Adobe Acrobat side, so we will uncheck the other one if one of them is checked
         if (_hideMenuBarCheckBox.Checked)
         {
            _hideMenuBarCheckBox.CheckedChanged -= new System.EventHandler(_hideMenuBarCheckBox_CheckedChanged);
            _hideMenuBarCheckBox.Checked = false;
            _hideMenuBarCheckBox.CheckedChanged += new System.EventHandler(_hideMenuBarCheckBox_CheckedChanged);
         }
      }
   }
}
