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

using Leadtools.Ocr;
using Leadtools.Document.Writer;

namespace Leadtools.Demos
{
   public partial class DocumentFormatOptionsDialog : Form
   {
      private OcrEngineType _ocrEngineType;
      private DocumentWriter _documentWriter;
      private DocumentFormat _format;
      private PdfDocumentOptions _pdfOptions;
      private int _totalPages;

      public DocumentFormatOptionsDialog(OcrEngineType ocrEngineType, DocumentWriter docWriter, DocumentFormat format, int totalPages)
      {
         InitializeComponent();

         _ocrEngineType = ocrEngineType;
         _documentWriter = docWriter;
         _format = format;
         _totalPages = totalPages;

         _optionsTabControl.TabPages.Clear();

         switch(_format)
         {
            case DocumentFormat.Pdf:
               // Update the PDF options page
               {
                  _optionsTabControl.TabPages.Add(_pdfOptionsTabPage);

                  PdfDocumentOptions pdfOptions = _documentWriter.GetOptions(DocumentFormat.Pdf) as PdfDocumentOptions;

                  // Clone it in case we change it in the Advance PDF options dialog
                  _pdfOptions = pdfOptions.Clone() as PdfDocumentOptions;

                  Array a = Enum.GetValues(typeof(PdfDocumentType));
                  foreach (PdfDocumentType i in a)
                  {
                     // PDFA does NOT support Arabic characters so we are not adding it in case of Arabic OCR engine.
                     if (ocrEngineType == OcrEngineType.OmniPageArabic && i == PdfDocumentType.PdfA)
                        continue;

                     _pdfDocumentTypeComboBox.Items.Add(i);
                  }
                  _pdfDocumentTypeComboBox.SelectedItem = pdfOptions.DocumentType;

                  _pdfImageOverTextCheckBox.Checked = pdfOptions.ImageOverText;
                  _pdfLinearizedCheckBox.Checked = pdfOptions.Linearized;
               }
               break;

            case DocumentFormat.Doc:
               // Update the DOC options page
               {
                  _optionsTabControl.TabPages.Add(_docOptionsTabPage);
                  DocDocumentOptions docOptions = _documentWriter.GetOptions(DocumentFormat.Doc) as DocDocumentOptions;
                  _docFramedCheckBox.Checked = (docOptions.TextMode == DocumentTextMode.Framed) ? true : false;
               }
               break;

            case DocumentFormat.Docx:
               // Update the DOCX options page
               {
                  _optionsTabControl.TabPages.Add(_docxOptionsTabPage);
                  DocxDocumentOptions docxOptions = _documentWriter.GetOptions(DocumentFormat.Docx) as DocxDocumentOptions;
                  _docxFramedCheckBox.Checked = (docxOptions.TextMode == DocumentTextMode.Framed) ? true : false;
               }
               break;

            case DocumentFormat.Rtf:
               // Update the RTF options page
               {
                  _optionsTabControl.TabPages.Add(_rtfOptionsTabPage);
                  RtfDocumentOptions rtfOptions = _documentWriter.GetOptions(DocumentFormat.Rtf) as RtfDocumentOptions;
                  _rtfFramedCheckBox.Checked = (rtfOptions.TextMode == DocumentTextMode.Framed) ? true : false;
               }
               break;

            case DocumentFormat.Html:
               // Update the HTML options page
               {
                  _optionsTabControl.TabPages.Add(_htmlOptionsTabPage);

                  HtmlDocumentOptions htmlOptions = _documentWriter.GetOptions(DocumentFormat.Html) as HtmlDocumentOptions;

                  Array a = Enum.GetValues(typeof(DocumentFontEmbedMode));
                  foreach(DocumentFontEmbedMode i in a)
                     _htmlEmbedFontModeComboBox.Items.Add(i);
                  _htmlEmbedFontModeComboBox.SelectedItem = htmlOptions.FontEmbedMode;

                  _htmlUseBackgroundColorCheckBox.Checked = htmlOptions.UseBackgroundColor;

                  _htmlBackgroundColorValueLabel.BackColor = Leadtools.Demos.Converters.ToGdiPlusColor(htmlOptions.BackgroundColor);

                  _htmlBackgroundColorLabel.Enabled = _htmlUseBackgroundColorCheckBox.Checked;
                  _htmlBackgroundColorValueLabel.Enabled = _htmlUseBackgroundColorCheckBox.Checked;
                  _htmlBackgroundColorButton.Enabled = _htmlUseBackgroundColorCheckBox.Checked;
               }
               break;

            case DocumentFormat.Text:
               // Update the TEXT options page
               {
                  _optionsTabControl.TabPages.Add(_textOptionsTabPage);

                  TextDocumentOptions textOptions = _documentWriter.GetOptions(DocumentFormat.Text) as TextDocumentOptions;

                  Array a = Enum.GetValues(typeof(TextDocumentType));
                  foreach (TextDocumentType i in a)
                  {
                     if (i == TextDocumentType.Ansi && ocrEngineType == OcrEngineType.OmniPageArabic)
                        continue;

                     _textDocumentTypeComboBox.Items.Add(i);
                  }
                  _textDocumentTypeComboBox.SelectedItem = textOptions.DocumentType;

                  _textAddPageNumberCheckBox.Checked = textOptions.AddPageNumber;
                  _textAddPageBreakCheckBox.Checked = textOptions.AddPageBreak;
                  _textFormattedCheckBox.Checked = textOptions.Formatted;
               }
               break;

            case DocumentFormat.AltoXml:
               // Update the ALTOXML options page
               {
                  _optionsTabControl.TabPages.Add(_altoXmlOptionsTabPage);
                  AltoXmlDocumentOptions altoXmlOptions = _documentWriter.GetOptions(DocumentFormat.AltoXml) as AltoXmlDocumentOptions;

                  Array a = Enum.GetValues(typeof(AltoXmlMeasurementUnit));
                  foreach (AltoXmlMeasurementUnit i in a)
                  {
                     _altoXmlMeasurementUnitComboBox.Items.Add(i);
                  }
                  _altoXmlMeasurementUnitComboBox.SelectedItem = altoXmlOptions.MeasurementUnit;

                  _altoXmlFileNameTextBox.Text = altoXmlOptions.FileName;
                  _altoXmlSoftwareCreatorTextBox.Text = altoXmlOptions.SoftwareCreator;
                  _altoXmlSoftwareNameTextBox.Text = altoXmlOptions.SoftwareName;
                  _altoXmlApplicationDescriptionTextBox.Text = altoXmlOptions.ApplicationDescription;
                  _altoXmlFormattedCheckBox.Checked = altoXmlOptions.Formatted;
                  _altoXmlIndentationTextBox.Text = altoXmlOptions.Indentation;
                  _altoXmlSortCheckBox.Checked = altoXmlOptions.Sort;
                  _altoXmlPlainTextCheckBox.Checked = altoXmlOptions.PlainText;
                  _altoXmlShowGlyphInfoCheckBox.Checked = altoXmlOptions.ShowGlyphInfo;
                  _altoXmlShowGlyphVariantsCheckBox.Checked = altoXmlOptions.ShowGlyphVariants;
               }
               break;

            case DocumentFormat.Ltd:
               {
                  _optionsTabControl.TabPages.Add(_ldOptionsTabPage);
               }
               break;

            case DocumentFormat.Emf:
               {
                  _optionsTabControl.TabPages.Add(_emfOptionsTabPage);
               }
               break;

            default:
               {
                  _optionsTabControl.TabPages.Add(_emptyOptionsTabPage);
                  _emptyOptionsTabPage.Text = string.Format("{0} Options", DocumentWriter.GetFormatFileExtension(_format).ToUpperInvariant());
               }
               break;
         }

         Text = DocumentWriter.GetFormatFriendlyName(_format) + " " + DemosGlobalization.GetResxString(GetType(), "Resx_Options");

         UpdateUIState();
      }

      private void UpdateUIState()
      {
         if(_format == DocumentFormat.Html)
         {
            _htmlBackgroundColorLabel.Enabled = _htmlUseBackgroundColorCheckBox.Checked;
            _htmlBackgroundColorValueLabel.Enabled = _htmlUseBackgroundColorCheckBox.Checked;
            _htmlBackgroundColorButton.Enabled = _htmlUseBackgroundColorCheckBox.Checked;
         }

         _altoXmlIndentationLabel.Enabled = _altoXmlFormattedCheckBox.Checked;
         _altoXmlIndentationTextBox.Enabled = _altoXmlFormattedCheckBox.Checked;
      }

      private void _htmlBackgroundColorButton_Click(object sender, EventArgs e)
      {
         using(ColorDialog dlg = new ColorDialog())
         {
            dlg.Color = _htmlBackgroundColorValueLabel.BackColor;
            if(dlg.ShowDialog(this) == DialogResult.OK)
               _htmlBackgroundColorValueLabel.BackColor = dlg.Color;
         }
      }

      private void _pdfDocumentTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
      {
         _pdfOptions.DocumentType = (PdfDocumentType)_pdfDocumentTypeComboBox.SelectedItem;
         UpdateUIState();
      }

      private void _htmlUseBackgroundColorCheckBox_CheckedChanged(object sender, EventArgs e)
      {
         UpdateUIState();
      }

      private void _pdfAdvanctionOptionsButton_Click(object sender, EventArgs e)
      {
         using (AdvancedPdfDocumentOptionsDialog dlg = new AdvancedPdfDocumentOptionsDialog(_pdfOptions, _totalPages, 0))
         {
            dlg.ShowLinearized = false;
            dlg.ShowDialog(this);
         }
      }

      private void _okButton_Click(object sender, EventArgs e)
      {
         DocumentOptions options = _documentWriter.GetOptions(_format);

         switch(_format)
         {
            case DocumentFormat.Pdf:
               // Update the PDF options
               {
                  PdfDocumentOptions pdfOptions = options as PdfDocumentOptions;
                  pdfOptions.DocumentType = (PdfDocumentType)_pdfDocumentTypeComboBox.SelectedItem;
                  pdfOptions.ImageOverText = _pdfImageOverTextCheckBox.Checked;
                  pdfOptions.Linearized = _pdfLinearizedCheckBox.Checked;
                  pdfOptions.FontEmbedMode = _pdfOptions.FontEmbedMode;
                  pdfOptions.Linearized = _pdfOptions.Linearized;
                  pdfOptions.Title = _pdfOptions.Title;
                  pdfOptions.Subject = _pdfOptions.Subject;
                  pdfOptions.Keywords = _pdfOptions.Keywords;
                  pdfOptions.Author = _pdfOptions.Author;
                  pdfOptions.Creator = _pdfOptions.Creator;
                  pdfOptions.Producer = _pdfOptions.Producer;
                  pdfOptions.PageRestriction = DocumentPageRestriction.Relaxed;

                  pdfOptions.Protected = _pdfOptions.Protected;
                  if (pdfOptions.Protected)
                  {
                     pdfOptions.UserPassword = _pdfOptions.UserPassword;
                     pdfOptions.OwnerPassword = _pdfOptions.OwnerPassword;
                     pdfOptions.EncryptionMode = _pdfOptions.EncryptionMode;
                     pdfOptions.PrintEnabled = _pdfOptions.PrintEnabled;
                     pdfOptions.HighQualityPrintEnabled = _pdfOptions.HighQualityPrintEnabled;
                     pdfOptions.CopyEnabled = _pdfOptions.CopyEnabled;
                     pdfOptions.EditEnabled = _pdfOptions.EditEnabled;
                     pdfOptions.AnnotationsEnabled = _pdfOptions.AnnotationsEnabled;
                     pdfOptions.AssemblyEnabled = _pdfOptions.AssemblyEnabled;
                  }

                  // Compression options
                  pdfOptions.OneBitImageCompression = _pdfOptions.OneBitImageCompression;
                  pdfOptions.ColoredImageCompression = _pdfOptions.ColoredImageCompression;
                  pdfOptions.QualityFactor = _pdfOptions.QualityFactor;
                  pdfOptions.ImageOverTextSize = _pdfOptions.ImageOverTextSize;
                  pdfOptions.ImageOverTextMode = _pdfOptions.ImageOverTextMode;

                  // Linearized
                  pdfOptions.Linearized = _pdfOptions.Linearized;

                  // Initial View Options
                  pdfOptions.PageModeType = _pdfOptions.PageModeType;
                  pdfOptions.PageLayoutType = _pdfOptions.PageLayoutType;
                  pdfOptions.PageFitType = _pdfOptions.PageFitType;
                  pdfOptions.ZoomPercent = _pdfOptions.ZoomPercent;
                  pdfOptions.InitialPageNumber = _pdfOptions.InitialPageNumber;
                  pdfOptions.FitWindow = _pdfOptions.FitWindow;
                  pdfOptions.CenterWindow = _pdfOptions.CenterWindow;
                  pdfOptions.DisplayDocTitle = _pdfOptions.DisplayDocTitle;
                  pdfOptions.HideMenubar = _pdfOptions.HideMenubar;
                  pdfOptions.HideToolbar = _pdfOptions.HideToolbar;
                  pdfOptions.HideWindowUI = _pdfOptions.HideWindowUI;
               }
               break;

            case DocumentFormat.Doc:
               // Update the DOC options
               {
                  DocDocumentOptions docOptions = options as DocDocumentOptions;
                  docOptions.TextMode = (_docFramedCheckBox.Checked) ? DocumentTextMode.Framed : DocumentTextMode.NonFramed;
               }
               break;

            case DocumentFormat.Docx:
               // Update the DOCX options
               {
                  DocxDocumentOptions docxOptions = options as DocxDocumentOptions;
                  docxOptions.TextMode = (_docxFramedCheckBox.Checked) ? DocumentTextMode.Framed : DocumentTextMode.NonFramed;
               }
               break;

            case DocumentFormat.Rtf:
               // Update the RTF options
               {
                  RtfDocumentOptions rtfOptions = options as RtfDocumentOptions;
                  rtfOptions.TextMode = (_rtfFramedCheckBox.Checked) ? DocumentTextMode.Framed : DocumentTextMode.NonFramed;
               }
               break;

            case DocumentFormat.Html:
               // Update the HTML options
               {
                  HtmlDocumentOptions htmlOptions = options as HtmlDocumentOptions;
                  htmlOptions.FontEmbedMode = (DocumentFontEmbedMode)_htmlEmbedFontModeComboBox.SelectedItem;
                  htmlOptions.UseBackgroundColor = _htmlUseBackgroundColorCheckBox.Checked;
                  htmlOptions.BackgroundColor = Leadtools.Demos.Converters.FromGdiPlusColor(_htmlBackgroundColorValueLabel.BackColor);
               }
               break;

            case DocumentFormat.Text:
               // Update the TEXT options
               {
                  TextDocumentOptions textOptions = options as TextDocumentOptions;
                  textOptions.DocumentType = (TextDocumentType)_textDocumentTypeComboBox.SelectedItem;
                  textOptions.AddPageNumber = _textAddPageNumberCheckBox.Checked;
                  textOptions.AddPageBreak = _textAddPageBreakCheckBox.Checked;
                  textOptions.Formatted = _textFormattedCheckBox.Checked;
               }
               break;

            case DocumentFormat.AltoXml:
               // Update the ALTOXML options
               {
                  AltoXmlDocumentOptions altoXmlOptions = options as AltoXmlDocumentOptions;
                  altoXmlOptions.MeasurementUnit = (AltoXmlMeasurementUnit)_altoXmlMeasurementUnitComboBox.SelectedItem;
                  altoXmlOptions.FileName = _altoXmlFileNameTextBox.Text;
                  altoXmlOptions.SoftwareCreator = _altoXmlSoftwareCreatorTextBox.Text;
                  altoXmlOptions.SoftwareName = _altoXmlSoftwareNameTextBox.Text;
                  altoXmlOptions.ApplicationDescription = _altoXmlApplicationDescriptionTextBox.Text;
                  altoXmlOptions.Formatted = _altoXmlFormattedCheckBox.Checked;
                  altoXmlOptions.Indentation = _altoXmlIndentationTextBox.Text;
                  altoXmlOptions.Sort = _altoXmlSortCheckBox.Checked;
                  altoXmlOptions.PlainText = _altoXmlPlainTextCheckBox.Checked;
                  altoXmlOptions.ShowGlyphInfo = _altoXmlShowGlyphInfoCheckBox.Checked;
                  altoXmlOptions.ShowGlyphVariants = _altoXmlShowGlyphVariantsCheckBox.Checked;
               }
               break;

            case DocumentFormat.Ltd:
            case DocumentFormat.Emf:
            default:
               // These formats have no options
               break;
         }

         if(options != null)
            _documentWriter.SetOptions(_format, options);
      }

      private void _pdfImageOverTextCheckBox_CheckedChanged(object sender, EventArgs e)
      {
         _pdfOptions.ImageOverText = _pdfImageOverTextCheckBox.Checked;
      }

      private void _pdfLinearizedCheckBox_CheckedChanged(object sender, EventArgs e)
      {
         _pdfOptions.Linearized = _pdfLinearizedCheckBox.Checked;
      }

      private void _altoXmlFormattedCheckBox_CheckedChanged(object sender, EventArgs e)
      {
         UpdateUIState();
      }
   }
}
