// *************************************************************
// Copyright (c) 1991-2019 LEAD Technologies, Inc.              
// All Rights Reserved.                                         
// *************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

using Leadtools.Document;
using Leadtools.Ocr;
using Leadtools.Demos.Dialogs;
using System.IO;
using Leadtools.Document.Writer;

namespace Leadtools.Demos
{
   public partial class DocumentConverterDialog : Form
   {
      public DocumentConverterDialog()
      {
         InitializeComponent();

         _optionsControl.RedactionOptions = new ConvertRedactionOptions();
      }

      // Preferences, input and output options from this dialog
      private DocumentConverterPreferences _preferences;
      [Browsable(false)]
      [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
      public DocumentConverterPreferences Preferences
      {
         get { return _preferences; }
         set { _preferences = value; }
      }

      // Document to convert, if null, will as for an input file
      private LEADDocument _inputDocument;
      [Browsable(false)]
      [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
      public LEADDocument InputDocument
      {
         get { return _inputDocument; }
         set { _inputDocument = value; }
      }

      [Browsable(false)]
      [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
      public ConvertRedactionOptions RedactionOptions
      {
         get { return _optionsControl.RedactionOptions as ConvertRedactionOptions; }
         set { _optionsControl.RedactionOptions = value; }
      }

      protected override void OnLoad(EventArgs e)
      {
         if (!DesignMode)
         {
            if (this.Preferences == null)
               throw new InvalidOperationException("Set Preferences before calling this method");

            if (this.Preferences.RasterCodecsInstance == null)
               throw new InvalidOperationException("Set RasterCodecsInstance before calling this method");

            if (this.Preferences.DocumentWriterInstance == null)
               throw new InvalidOperationException("Set DocumentWriterInstance before calling this method");

            if (_preferences.OcrEngineInstance == null || !_preferences.OcrEngineInstance.IsStarted)
            {
               _tabControl.TabPages.Remove(_ocrSettingsTabPage);
               _tabControl.TabPages.Remove(_ocrLanguagesTabPage);
            }
            else
            {
               _ocrEngineLabel.Text = _ocrEngineLabel.Text.Replace("###", _preferences.OcrEngineInstance.EngineType.ToString());
            }

            // Set the preferences
            _documentControl.UIStateChanged += (sender, e1) => this.UpdateUIState();
            _optionsControl.UIStateChanged += (sender, e1) => this.UpdateUIState();

            _documentControl.Populate(_inputDocument, _preferences);
            _optionsControl.Populate(_inputDocument, _preferences);

            try // this can fail if the OCR Engine is missing
            {
               if (_preferences.OcrEngineInstance != null)
               {
                  _ocrEngineSettingsControl.SetEngine(_preferences.OcrEngineInstance);
                  InitOCRLanguages(_preferences.OcrEngineInstance);
               }
            }
            catch (Exception ex)
            {
               System.Diagnostics.Debug.WriteLine(ex.Message);
            }

            UpdateUIState();
         }

         base.OnLoad(e);
      }

      private void UpdateUIState()
      {
         var ocrEngine = _preferences.OcrEngineInstance;
         if (ocrEngine != null)
         {
            var engineType = ocrEngine.EngineType;
            _languagesHintLabel.Visible = engineType == OcrEngineType.LEAD;
            _languagesMoveTopButton.Visible = engineType == OcrEngineType.LEAD;

            _languagesMoveRightButton.Enabled = _languagesListBox.SelectedItems.Count > 0;
            _languagesMoveLeftButton.Enabled = _enabledLanguagesListBox.SelectedItems.Count > 0;
            _languagesMoveTopButton.Enabled = _enabledLanguagesListBox.SelectedItems.Count == 1;
         }

         var okState = _documentControl.CanApplyToPreferences && _optionsControl.CanApplyToPreferences;
         if (okState && ocrEngine != null && ocrEngine.IsStarted)
         {
            // Must have selected at least one enabled OCR language
            okState = _enabledLanguagesListBox.Items.Count > 0;
         }

         _okButton.Enabled = okState;
      }

      // Language/Friendly name combo
      private struct MyLanguage
      {
         public MyLanguage(string language, string friendlyName, int supportedIndex)
         {
            Language = language;
            FriendlyName = friendlyName;
            SupportedIndex = supportedIndex;
         }

         public string Language;
         public string FriendlyName;
         public int SupportedIndex;

         public override string ToString()
         {
            return this.FriendlyName;
         }

         public static string GetLanguageFriendlyName(string language)
         {
            CultureInfo ci;

            if (language == "sr-Cyrl-CS" || language == "sr-SP-Cyrl")
               ci = new CultureInfo(0x0C1A);
            else if (language == "sr-Latn-CS")
               ci = new CultureInfo(0x081A);
            else if (language == "zh-Hans")
               ci = new CultureInfo(0x0004);
            else if (language == "zh-Hant")
               ci = new CultureInfo(0x7C04);
            else
               ci = new CultureInfo(language);

            return ci.EnglishName;
         }
      }

      private void InitOCRLanguages(IOcrEngine ocrEngine)
      {
         var languageManager = ocrEngine.LanguageManager;

         // Get the languages supported by this engine and fill the list box
         string[] languages = languageManager.GetSupportedLanguages();
         string[] enabledLanguages = languageManager.GetEnabledLanguages();
         var languagesDictionary = new Dictionary<string, string>();

         var friendlyNames = new string[languages.Length];

         int index = 0;
         foreach (var language in languages)
         {
            friendlyNames[index] = MyLanguage.GetLanguageFriendlyName(language);
            languagesDictionary.Add(friendlyNames[index], language);
            index++;
         }

         index = 0;
         foreach (var friendlyName in friendlyNames)
         {
            // Don't add the enabled languages to the available languages list
            bool languageEnabled = false;
            foreach (var enabledLanguage in enabledLanguages)
            {
               if (languagesDictionary[friendlyName].Equals(enabledLanguage))
               {
                  languageEnabled = true;
                  break;
               }
            }

            if (!languageEnabled)
            {
               var ml = new MyLanguage(languagesDictionary[friendlyName], friendlyName, index);
               _languagesListBox.Items.Add(ml);
            }
            index++;
         }

         // Fill the 'Enabled Languages' list box
         foreach (var enabledLanguage in enabledLanguages)
         {
            index = 0;
            foreach (var entry in languagesDictionary)
            {
               if (entry.Value.Equals(enabledLanguage))
                  break;
               index++;
            }

            string friendlyName = MyLanguage.GetLanguageFriendlyName(enabledLanguage);
            var ml = new MyLanguage(enabledLanguage, friendlyName, index);
            _enabledLanguagesListBox.Items.Add(ml);
         }

         if (!languageManager.SupportsEnablingMultipleLanguages || _languagesListBox.Items.Count <= 1)
            _languagesListBox.SelectionMode = SelectionMode.One;

         string[] additionalLanguages = languageManager.GetAdditionalLanguages();
         if (additionalLanguages != null && additionalLanguages.Length > 0)
         {
            _languagesAdditionalLabel.Text = "There are more languages supported by this engine that are not installed on this machine.\r\nVisit our website at http://www.leadtools.com for more information.";
         }
      }

      private void _languagesListBox_SelectedIndexChanged(object sender, EventArgs e)
      {
         UpdateUIState();
      }

      private void _enabledLanguagesListBox_SelectedIndexChanged(object sender, EventArgs e)
      {
         UpdateUIState();
      }

      private void _languagesMoveRightButton_Click(object sender, EventArgs e)
      {
         var selectedItems = new List<MyLanguage>();
         foreach (MyLanguage i in _languagesListBox.SelectedItems)
            selectedItems.Add(i);

         foreach (var ml in selectedItems)
         {
            var index = _enabledLanguagesListBox.Items.Add(ml);
            _enabledLanguagesListBox.SetSelected(index, true);
            _languagesListBox.Items.Remove(ml);
         }
      }

      private void _languagesMoveLeftButton_Click(object sender, EventArgs e)
      {
         var selectedItems = new List<MyLanguage>();
         foreach (MyLanguage i in _enabledLanguagesListBox.SelectedItems)
            selectedItems.Add(i);

         foreach (var ml in selectedItems)
         {
            var insertionIndex = 0;
            foreach (MyLanguage item in _languagesListBox.Items)
            {
               if (ml.SupportedIndex < item.SupportedIndex)
                  break;

               insertionIndex++;
            }

            _languagesListBox.Items.Insert(insertionIndex, ml);
            _languagesListBox.SetSelected(insertionIndex, true);
            _enabledLanguagesListBox.Items.Remove(ml);
         }
      }

      private void _languagesMoveTopButton_Click(object sender, EventArgs e)
      {
         var ml = (MyLanguage)_enabledLanguagesListBox.SelectedItem;
         var index = _enabledLanguagesListBox.Items.IndexOf(ml);
         if (index <= 0)
            return;

         _enabledLanguagesListBox.Items.RemoveAt(index);
         _enabledLanguagesListBox.Items.Insert(0, ml);
         _enabledLanguagesListBox.SetSelected(0, true);
      }

      private bool GetOCRLanguages(IOcrEngine ocrEngine)
      {
         // Enable the languages selected by the user
         var languages = new List<string>();
         foreach (MyLanguage ml in _enabledLanguagesListBox.Items)
            languages.Add(ml.Language);

         if (languages.Count > 0)
         {
            try
            {
               ocrEngine.LanguageManager.EnableLanguages(languages.ToArray());
            }
            catch (Exception ex)
            {
               Messager.ShowError(this, ex);
               return false;
            }
         }

         return true;
      }

      private void _okButton_Click(object sender, EventArgs e)
      {
         if (_documentControl.CanApplyToPreferences && _optionsControl.CanApplyToPreferences)
         {
            _documentControl.ApplyToPreferences();
            _optionsControl.ApplyToPreferences();

            if (_inputDocument != null)
            {
               var redactionOptions = new DocumentRedactionOptions();
               redactionOptions.ViewOptions = _inputDocument.Annotations.RedactionOptions.ViewOptions;
               redactionOptions.ConvertOptions = RedactionOptions;
               _inputDocument.Annotations.RedactionOptions = redactionOptions;
            }

            bool deleteExistingFile = File.Exists(_preferences.OutputDocumentFileName);
            if (deleteExistingFile && _preferences.DocumentFormat == DocumentFormat.Ltd)
            {
               // This is an LTD file that already exists, so ask the user what to do here, delete or append to it
               string message = string.Format("Delete the existing output file '{0}' first?{1}The file already exists. Select 'Yes' to delete it and create a new one or 'No' to append this result to it.",
                  _preferences.OutputDocumentFileName, Environment.NewLine);
               switch (Messager.ShowQuestion(null, message, MessageBoxButtons.YesNo))
               {
                  case DialogResult.Yes:
                     deleteExistingFile = true;
                     break;

                  case DialogResult.No:
                     deleteExistingFile = false;
                     break;
               }
            }

            // Delete the output file first
            if (deleteExistingFile)
            {
               try
               {
                  File.Delete(_preferences.OutputDocumentFileName);
               }
               catch (Exception ex)
               {
                  Messager.ShowError(this, ex);
                  DialogResult = DialogResult.None;
                  return;
               }
            }

            // Get the languages
            if (_preferences.OcrEngineInstance != null)
            {
               if (!GetOCRLanguages(_preferences.OcrEngineInstance))
                  DialogResult = DialogResult.None;
            }
         }
      }

      private void _aboutButton_Click(object sender, EventArgs e)
      {
         using (AboutDialog aboutDialog = new AboutDialog(DocumentConverterPreferences.DemoName, ProgrammingInterface.CS))
            aboutDialog.ShowDialog(this);
      }
   }
}
