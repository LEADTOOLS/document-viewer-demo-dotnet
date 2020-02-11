using Leadtools.Document;
using System;
using System.Windows.Forms;

namespace DocumentViewerDemo.UI
{
   public partial class DocumentTextOptionsDialog : Form
   {
      public DocumentTextImagesRecognitionMode ImagesRecognitionMode { get; set; }
      public DocumentTextExtractionMode TextExtractionMode { get; set; }

      struct ComboBoxItem
      {
         public object Value;
         public string FriendlyName;
         public override string ToString()
         {
            return FriendlyName;
         }
      }

      public DocumentTextOptionsDialog()
      {
         InitializeComponent();
      }

      protected override void OnLoad(EventArgs e)
      {
         if (!DesignMode)
         {
            ComboBoxItem[] imagesRecognitionModeItems =
            {
               new ComboBoxItem { Value = DocumentTextImagesRecognitionMode.Auto, FriendlyName = "Auto" },
               new ComboBoxItem { Value = DocumentTextImagesRecognitionMode.Disabled, FriendlyName = "Disabled" },
               new ComboBoxItem { Value = DocumentTextImagesRecognitionMode.Always, FriendlyName = "Always" }
            };

            foreach (var comboBoxItem in imagesRecognitionModeItems)
            {
               _imagesRecognitionModeComboBox.Items.Add(comboBoxItem);
               if (this.ImagesRecognitionMode == (DocumentTextImagesRecognitionMode)comboBoxItem.Value)
                  _imagesRecognitionModeComboBox.SelectedItem = comboBoxItem;
            }

            ComboBoxItem[] textExtractionModeItems =
            {
               new ComboBoxItem { Value = DocumentTextExtractionMode.Auto, FriendlyName = "Auto" },
               new ComboBoxItem { Value = DocumentTextExtractionMode.SvgOnly, FriendlyName = "SVG only" },
               new ComboBoxItem { Value = DocumentTextExtractionMode.OcrOnly, FriendlyName = "OCR only" }
            };

            foreach (var comboBoxItem in textExtractionModeItems)
            {
               _textExtractionModeComboBox.Items.Add(comboBoxItem);
               if (this.TextExtractionMode == (DocumentTextExtractionMode)comboBoxItem.Value)
                  _textExtractionModeComboBox.SelectedItem = comboBoxItem;
            }
         }

         base.OnLoad(e);
      }

      private void _okButton_Click(object sender, EventArgs e)
      {
         this.ImagesRecognitionMode = (DocumentTextImagesRecognitionMode)((ComboBoxItem)_imagesRecognitionModeComboBox.SelectedItem).Value;
         this.TextExtractionMode = (DocumentTextExtractionMode)((ComboBoxItem)_textExtractionModeComboBox.SelectedItem).Value;
      }
   }
}
