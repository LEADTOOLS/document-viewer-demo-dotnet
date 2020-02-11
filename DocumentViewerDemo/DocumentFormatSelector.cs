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

using Leadtools.Ocr;
using Leadtools.Document.Writer;

namespace Leadtools.Demos
{
   [DefaultEvent("SelectedFormatChanged")]
   public partial class DocumentFormatSelector : UserControl
   {
      private OcrEngineType _ocrEngineType;
      private DocumentWriter _documentWriter;
      private bool _formatHasOptions = true;
      private int _totalPages;

      public DocumentFormatSelector()
      {
         InitializeComponent();

         DoResize();
      }

      protected override void OnResize(EventArgs e)
      {
         DoResize();

         base.OnResize(e);
      }

      private void DoResize()
      {
         SuspendLayout();

         int maxHeight = Math.Max(_formatComboBox.Height, _formatOptionsButton.Height);
         const int dx = 2;

         Height = maxHeight;
         _formatComboBox.Location = new Point(
            0,
            (ClientSize.Height - _formatComboBox.Height) / 2);
         _formatComboBox.Width = ClientSize.Width - _formatOptionsButton.Width - dx * 2;

         _formatOptionsButton.Location = new Point(
            ClientSize.Width - _formatOptionsButton.Width - dx,
            (ClientSize.Height - _formatOptionsButton.Height) / 2);

         ResumeLayout();
      }

      private struct DocumentFormatItem
      {
         public DocumentFormat Format;
         private string _name;

         public DocumentFormatItem(DocumentFormat f, string n)
         {
            Format = f;
            _name = n;
         }

         public override string ToString()
         {
            return _name;
         }
      }

      public void SetDocumentWriter(DocumentWriter docWriter, bool showLtdFormat)
      {
         _documentWriter = docWriter;

         // This is the order of importance, show these first then the rest as they come along
         DocumentFormat[] importantFormats =
         {
            DocumentFormat.Pdf,
            DocumentFormat.Docx,
            DocumentFormat.Rtf,
            DocumentFormat.Text,
            DocumentFormat.Doc,
            DocumentFormat.Xls,
            DocumentFormat.Html
         };

         List<DocumentFormat> formatsToAdd = new List<DocumentFormat>();

         Array a = Enum.GetValues(typeof(DocumentFormat));
         List<DocumentFormat> allFormats = new List<DocumentFormat>();
         foreach (DocumentFormat format in a)
            allFormats.Add(format);

         // Add important once first:
         foreach (DocumentFormat format in importantFormats)
         {
            formatsToAdd.Add(format);
            allFormats.Remove(format);
         }

         // Add rest
         formatsToAdd.AddRange(allFormats);

         // Add rest
         foreach (DocumentFormat format in formatsToAdd)
         {
            bool addItem = true;

            if (format == DocumentFormat.User)
               addItem = false;
            else if (format == DocumentFormat.Ltd && !showLtdFormat)
               addItem = false;

            if(addItem)
            {
               string name = string.Format("{0} ({1})", DocumentWriter.GetFormatFriendlyName(format), DocumentWriter.GetFormatFileExtension(format).ToUpperInvariant());
               DocumentFormatItem item = new DocumentFormatItem(format, name);
               _formatComboBox.Items.Add(item);

               if(format == DocumentFormat.Pdf)
                  _formatComboBox.SelectedItem = item;
            }
         }

         if(_formatComboBox.SelectedIndex == -1 && _formatComboBox.Items.Count > 0)
            _formatComboBox.SelectedIndex = 0;

         PdfDocumentOptions pdfOptions = _documentWriter.GetOptions(DocumentFormat.Pdf) as PdfDocumentOptions;
         if (string.IsNullOrEmpty(pdfOptions.Creator))
            pdfOptions.Creator = "LEADTOOLS PDFWriter";
         if (string.IsNullOrEmpty(pdfOptions.Producer))
            pdfOptions.Producer = "LEAD Technologies, Inc.";
         _documentWriter.SetOptions(DocumentFormat.Pdf, pdfOptions);
      }

      public void SetOcrEngineType(OcrEngineType ocrEngineType)
      {
         _ocrEngineType = ocrEngineType;
      }

      [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
      public DocumentFormat SelectedFormat
      {
         get
         {
            if(_formatComboBox.SelectedIndex != -1)
            {
               DocumentFormatItem item = (DocumentFormatItem)_formatComboBox.SelectedItem;
               return item.Format;
            }
            else
               return DocumentFormat.Pdf;
         }
         set
         {
            foreach(DocumentFormatItem item in _formatComboBox.Items)
            {
               if(item.Format == value)
               {
                  _formatComboBox.SelectedItem = item;
                  return;
               }
            }
         }
      }

      public bool FormatHasOptions
      {
         get
         {
            return _formatHasOptions;
         }
         set
         {
            _formatHasOptions = value;
         }
      }

      public int TotalPages
      {
         get
         {
            return _totalPages;
         }
         set
         {
            _totalPages = value;
         }
      }

      private void _formatOptionsButton_Click(object sender, EventArgs e)
      {
         if(_documentWriter == null || _formatComboBox.SelectedIndex == -1)
            return;

         DocumentFormatItem item = (DocumentFormatItem)_formatComboBox.SelectedItem;

         using (DocumentFormatOptionsDialog dlg = new DocumentFormatOptionsDialog(_ocrEngineType, _documentWriter, item.Format, _totalPages))
            dlg.ShowDialog(this);
      }

      public event EventHandler<EventArgs> SelectedFormatChanged;

      private void _formatComboBox_SelectedIndexChanged(object sender, EventArgs e)
      {
         if(SelectedFormatChanged != null)
            SelectedFormatChanged(this, EventArgs.Empty);

         _formatOptionsButton.Enabled = _formatHasOptions;
      }
   }
}
