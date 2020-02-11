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

using Leadtools.Document;
using Leadtools.Document.Converter;

namespace Leadtools.Demos
{
   public partial class DocumentConverterOptionsControl : UserControl
   {
      public DocumentConverterOptionsControl()
      {
         InitializeComponent();
      }

      private DocumentConverterPreferences _preferences;

      // Populate the UI from preferences
      public void Populate(LEADDocument inputDocument, DocumentConverterPreferences preferences)
      {
         _preferences = preferences;

         if (_preferences.OcrEngineInstance == null)
         {
            _enableSvgConversionCheckBox.Checked = true;
            _enableSvgConversionCheckBox.Enabled = false;
         }
         else
         {
            _enableSvgConversionCheckBox.Checked = _preferences.EnableSvgConversion;
         }

         _svgImagesRecognitionModeComboBox.Items.Clear();
         foreach (var i in Enum.GetValues(typeof(DocumentConverterSvgImagesRecognitionMode)))
         {
            _svgImagesRecognitionModeComboBox.Items.Add(i);
         }
         _svgImagesRecognitionModeComboBox.SelectedItem = (_preferences.OcrEngineInstance != null && _preferences.OcrEngineInstance.IsStarted) ? _preferences.SvgImagesRecognitionMode : DocumentConverterSvgImagesRecognitionMode.Disabled;
         _svgImagesRecognitionModeLabel.Enabled = _preferences.OcrEngineInstance != null && _preferences.OcrEngineInstance.IsStarted;
         _svgImagesRecognitionModeComboBox.Enabled = _preferences.OcrEngineInstance != null && _preferences.OcrEngineInstance.IsStarted;

         _emptyPageModeComboBox.Items.Clear();
         foreach (var i in Enum.GetValues(typeof(DocumentConverterEmptyPageMode)))
         {
            _emptyPageModeComboBox.Items.Add(i);
         }
         _emptyPageModeComboBox.SelectedItem = _preferences.EmptyPageMode;

         _useThreadsCheckBox.Checked = _preferences.UseThreads;

         _deskewCheckBox.Checked = _preferences.PreprocessingDeskew;
         _invertCheckBox.Checked = _preferences.PreprocessingInvert;
         _orientCheckBox.Checked = _preferences.PreprocessingOrient;

         _continueOnRecoverableErrorsCheckBox.Checked = (_preferences.ErrorMode == DocumentConverterJobErrorMode.Continue);
         _enableTraceCheckBox.Checked = _preferences.EnableTrace;
         _jobNameTextBox.Text = _preferences.JobName;

         if (_preferences.OpenOutputDocumentAllowed)
         {
            _openOutputDocumentCheckBox.Checked = _preferences.OpenOutputDocument;
         }
         else
         {
            _openOutputDocumentCheckBox.Checked = false;
            _openOutputDocumentCheckBox.Enabled = false;
            _openOutputDocumentCheckBox.Visible = false;
         }

         if(inputDocument != null)
         {
            _redactionOptionsControl.Options = inputDocument.Annotations.RedactionOptions.ConvertOptions.Clone();
         }

         UpdateHelp();
      }

      // Populate preferences from the UI
      public void ApplyToPreferences()
      {
         _preferences.EnableSvgConversion = _enableSvgConversionCheckBox.Checked;
         if(_preferences.OcrEngineInstance != null && _preferences.OcrEngineInstance.IsStarted)
            _preferences.SvgImagesRecognitionMode = (DocumentConverterSvgImagesRecognitionMode)_svgImagesRecognitionModeComboBox.SelectedItem;
         _preferences.EmptyPageMode = (DocumentConverterEmptyPageMode)_emptyPageModeComboBox.SelectedItem;
         _preferences.UseThreads = _useThreadsCheckBox.Checked;

         _preferences.PreprocessingDeskew = _deskewCheckBox.Checked;
         _preferences.PreprocessingInvert = _invertCheckBox.Checked;
         _preferences.PreprocessingOrient = _orientCheckBox.Checked;

         _preferences.ErrorMode = _continueOnRecoverableErrorsCheckBox.Checked ? DocumentConverterJobErrorMode.Continue : DocumentConverterJobErrorMode.Abort;
         _preferences.EnableTrace = _enableTraceCheckBox.Checked;
         _preferences.JobName = _jobNameTextBox.Text;
         _preferences.OpenOutputDocument = _openOutputDocumentCheckBox.Checked;

         UpdateUIState();
      }

      public bool CanApplyToPreferences
      {
         get
         {
            return true;
         }
      }

      public AnnotationsRedactionOptions RedactionOptions
      {
         get
         {
            return this._redactionOptionsControl.Options;
         }
         set
         {
            if(value != null)
               this._redactionOptionsControl.Options = value;
         }
      }

      private static readonly string[] _svgImagesRecognitionModeHelp =
      {
         "Use OCR on raster only pages found in the document.",
         "Do not use OCR at all.",
         "Use OCR on the image elements found in a page."
      };

      private void UpdateHelp()
      {
         var svgImagesRecognitionMode = (DocumentConverterSvgImagesRecognitionMode)_svgImagesRecognitionModeComboBox.SelectedItem;
         _svgImagesRecognitionModeHelpLabel.Text = _svgImagesRecognitionModeHelp[(int)svgImagesRecognitionMode];
      }

      public event EventHandler UIStateChanged;
      private void UpdateUIState()
      {
         if (UIStateChanged != null)
            UIStateChanged(this, EventArgs.Empty);
      }

      private void _svgImagesRecognitionModeComboBox_SelectedIndexChanged(object sender, EventArgs e)
      {
         UpdateHelp();
      }

      private void _defaultButton_Click(object sender, EventArgs e)
      {
         _svgImagesRecognitionModeComboBox.SelectedIndex = 0;
         _emptyPageModeComboBox.SelectedIndex = 0;
         _enableSvgConversionCheckBox.Checked = true;
         _useThreadsCheckBox.Checked = true;
         _deskewCheckBox.Checked = false;
         _invertCheckBox.Checked = false;
         _orientCheckBox.Checked = false;
         _continueOnRecoverableErrorsCheckBox.Checked = true;
         _openOutputDocumentCheckBox.Checked = _preferences.OpenOutputDocumentAllowed;
         _redactionOptionsControl.Options = new AnnotationsRedactionOptions();
      }
   }
}
