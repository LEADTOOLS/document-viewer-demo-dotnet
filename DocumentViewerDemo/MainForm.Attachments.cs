// *************************************************************
// Copyright (c) 1991-2020 LEAD Technologies, Inc.              
// All Rights Reserved.                                         
// *************************************************************
using Leadtools;
using Leadtools.Caching;
using Leadtools.Controls;
using Leadtools.Demos;
using Leadtools.Document;
using Leadtools.Document.Viewer;
using Leadtools.Drawing;
using Leadtools.ImageProcessing;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DocumentViewerDemo
{
   // Contains the attachments part of the viewer
   public partial class MainForm
   {
      private void BindAttachmentItems()
      {
         // Menu
         _commandsBinder.Items.Add(new CommandBinderItem
         {
            ToolStripItem = _attachmentsToolStripMenuItem,
            UpdateVisible = true,
            CanRun = (DocumentViewer documentViewer, object value) =>
            {
               return documentViewer.HasDocument && documentViewer.Document.Attachments.Count > 0;
            }
         });

         _commandsBinder.Items.Add(new CommandBinderItem
         {
            ToolStripItem = _openAttachmentToolStripMenuItem,
            CanRun = (DocumentViewer documentViewer, object value) =>
            {
               return _selectedAttachmentIndex != -1;
            }
         });

         _commandsBinder.Items.Add(new CommandBinderItem
         {
            ToolStripItem = _saveAttachmentToolStripMenuItem,
            CanRun = (DocumentViewer documentViewer, object value) =>
            {
               return _selectedAttachmentIndex != -1;
            }
         });

         _commandsBinder.Items.Add(new CommandBinderItem
         {
            ToolStripItem = _attachmentPropertyToolStripMenuItem,
            CanRun = (DocumentViewer documentViewer, object value) =>
            {
               return _selectedAttachmentIndex != -1;
            }
         });

         _attachmentsContextMenu.Opening += (sender, e) =>
         {
            if (_selectedAttachmentIndex == -1)
               e.Cancel = true;
         };

         CreateAttachmentImageViewer();
      }

      private void AttachmentsCleanup()
      {
         if (_attachmentsImageViewer != null)
         {
            var selectionMode = _attachmentsImageViewer.InteractiveModes.FindById(ImageViewerInteractiveMode.SelectItemsModeId) as ImageViewerSelectItemsInteractiveMode;
            if (selectionMode != null)
               selectionMode.ItemActivate -= AttachmentImageViewerItemActivate;

            _attachmentsImageViewer.SelectedItemsChanged -= AttachmentImageViewerSelectedItemChanged;
            _attachmentsImageViewer.Dispose();
            _attachmentsImageViewer = null;
         }

         if (_attachmentImage != null)
         {
            _attachmentImage.Dispose();
            _attachmentImage = null;
         }
      }

      private ImageViewer _attachmentsImageViewer;
      private RasterImage _attachmentImage;
      private int _selectedAttachmentIndex = -1;

      private void CreateAttachmentImageViewer()
      {
         // Create an image viewer to be used to show the attachments of a LEADDocument
         ImageViewerVerticalViewLayout layout = new ImageViewerVerticalViewLayout();
         layout.Columns = 0;
         var imageViewer = new ImageViewer(layout);
         imageViewer.Dock = DockStyle.Fill;
         
         imageViewer.ItemHorizontalAlignment = ControlAlignment.Center;
         imageViewer.ItemVerticalAlignment = ControlAlignment.Center;

         imageViewer.ViewPadding = new Padding(8, 8, 8, 8);
         imageViewer.ItemPadding = new Padding(10, 10, 10, 50);
         imageViewer.ImageBorderThickness = 1;
         imageViewer.SelectedItemBackgroundColor = Color.LightBlue;

         imageViewer.AutoDisposeImages = false;

         _attachmentsTabPage.Controls.Add(imageViewer);
         imageViewer.BringToFront();

         // Create a select interactive mode
         ImageViewerSelectItemsInteractiveMode selectItemsMode = new ImageViewerSelectItemsInteractiveMode();
         selectItemsMode.SelectionMode = ImageViewerSelectionMode.Single;
         selectItemsMode.MouseButtons = MouseButtons.Left | MouseButtons.Right;
         selectItemsMode.ItemActivate += AttachmentImageViewerItemActivate;

         // Create a pan interactive mode for the area outside the selection
         ImageViewerPanZoomInteractiveMode panMode = new ImageViewerPanZoomInteractiveMode();
         panMode.EnableZoom = false;
         panMode.DoubleTapSizeMode = ControlSizeMode.None;

         imageViewer.BeginUpdate();
         imageViewer.InteractiveModes.Add(selectItemsMode);
         imageViewer.InteractiveModes.Add(panMode);
         imageViewer.EndUpdate();

         _attachmentImage = CreateAttachmentImage(imageViewer);

         imageViewer.SelectedItemsChanged += AttachmentImageViewerSelectedItemChanged;
         imageViewer.ContextMenuStrip = _attachmentsContextMenu;
         _attachmentsImageViewer = imageViewer;
      }

      private RasterImage CreateAttachmentImage(ImageViewer imageViewer)
      {
         // Get the attachment image from the resource
         Bitmap icon = Properties.Resources.Attachment;
         using (RasterImage image = RasterImageConverter.ConvertFromImage(icon, ConvertFromImageOptions.None))
         {
            // Resize the image to be the same as width as image viewer thumbnails with original height
            int desiredWidth;
            if (_documentViewer.Thumbnails != null)
               desiredWidth = _documentViewer.Thumbnails.MaximumSize.Width;
            else
               desiredWidth = image.ImageWidth;

            var destRect = new LeadRect(0, 0, desiredWidth, image.ImageHeight);
            RasterImage attachmentImage = RasterImage.Create(destRect.Width, destRect.Height, 32, 96, RasterColor.Black);
            new SetAlphaValuesCommand(0x00).Run(attachmentImage);

            LeadRect imageRect = RasterImage.CalculatePaintModeRectangle(
               image.ImageWidth,
               image.ImageHeight,
               destRect,
               RasterPaintSizeMode.Fit,
               RasterPaintAlignMode.Center,
               RasterPaintAlignMode.Center);

            new CombineFastCommand(attachmentImage, imageRect, LeadPoint.Empty, Leadtools.ImageProcessing.CombineFastCommandFlags.SourceCopy).Run(image);
            return attachmentImage;
         }
      }

      private void AttachmentImageViewerSelectedItemChanged(object sender, EventArgs e)
      {
         ImageViewerItem[] selectedItems = _attachmentsImageViewer.Items.GetSelected();
         if (selectedItems != null && selectedItems.Length == 1)
            _selectedAttachmentIndex = _attachmentsImageViewer.Items.IndexOf(selectedItems[0]);
         else
            _selectedAttachmentIndex = -1;
         this.UpdateUIState();
      }

      private void AttachmentImageViewerItemActivate(object sender, ImageViewerItemActivateEventArgs e)
      {
         OpenAttachment();
      }

      private void _openAttachmentToolStripMenuItem_Click(object sender, EventArgs e)
      {
         OpenAttachment();
      }

      private void _attachmentsOpenAttachmentToolStripMenuItem_Click(object sender, EventArgs e)
      {
         OpenAttachment();
      }

      private void _saveAttachmentToolStripMenuItem_Click(object sender, EventArgs e)
      {
         SaveAttachment();
      }

      private void _attachmentsSaveAttachmentToolStripMenuItem_Click(object sender, EventArgs e)
      {
         SaveAttachment();
      }

      private void _attachmentPropertyToolStripMenuItem_Click(object sender, EventArgs e)
      {
         ShowAttachmentProperties();
      }

      private void _attachmentsAattachmentPropertyToolStripMenuItem_Click(object sender, EventArgs e)
      {
         ShowAttachmentProperties();
      }

      private void PopulateAttachments()
      {
         // Remove any previous attachments
         RemoveAllAttachments();

         LEADDocument document = _documentViewer.Document;

         if (document == null || document.Attachments.Count == 0)
         {
            return;
         }

         // Add new ones
         int selectedIndex = GetAttachmentSelectedIndexForDocument(document);
         _attachmentsImageViewer.BeginUpdate();
         for (int i = 0; i < document.Attachments.Count; i++)
         {
            DocumentAttachment attachment = document.Attachments[i];
            var item = new ImageViewerItem();
            item.Text = attachment.DisplayName;
            item.Image = _attachmentImage;
            item.Tag = attachment;
            if (selectedIndex == i)
               item.IsSelected = true;
            _attachmentsImageViewer.Items.Add(item);
         }
         _attachmentsImageViewer.EndUpdate();

         if (selectedIndex != -1)
            _attachmentsImageViewer.EnsureItemVisibleByIndex(selectedIndex);
      }

      private void RemoveAllAttachments()
      {
         // Remove any attachments we might have added
         _attachmentsImageViewer.BeginUpdate();
         _attachmentsImageViewer.Items.Clear();
         _attachmentsImageViewer.EndUpdate();

         _selectedAttachmentIndex = -1;
      }

      private int GetSelectedAttachmentIndex()
      {
         return _selectedAttachmentIndex;
      }

      private void OpenAttachment()
      {
         if (_selectedAttachmentIndex == -1)
            return;

         LEADDocument currentDocument = _documentViewer.Document;

         // The attachment has a document ID if it is already saved into the cache, if so, just load it
         int attachmentIndex = _selectedAttachmentIndex;
         DocumentAttachment attachment = currentDocument.Attachments[attachmentIndex];
         if (!string.IsNullOrEmpty(attachment.DocumentId))
         {
            LoadDocumentFromCache(attachment.DocumentId);
         }
         else
         {
            // If our document is cached, then save the attachment to cache and open it from there
            // Otherwise, load it into a stream as a brand new document

            if (IsDocumentInCache(currentDocument))
            {
               CreateAttachmentDocumentFromCache(currentDocument, attachment);
            }
            else
            {
               CreateAttachmentDocument(currentDocument, attachment);
            }
         }
      }

      private void CreateAttachmentDocumentFromCache(LEADDocument currentDocument, DocumentAttachment attachment)
      {
         try
         {
            // Save it int the cache
            var options = new SaveAttachmentToCacheOptions();
            options.AttachmentNumber = attachment.AttachmentNumber;
            options.UploadDocumentOptions.Cache = this._cache;
            // This will update DocumentAttachment.DocumentId
            currentDocument.SaveAttachmentToCache(options);

            string attachmentDocumentId = attachment.DocumentId;
            this.LoadDocumentFromCache(attachmentDocumentId);
         }
         catch (Exception ex)
         {
            UI.Helper.ShowError(this, ex);
         }
      }

      private void CreateAttachmentDocument(LEADDocument currentDocument, DocumentAttachment attachment)
      {
         try
         {
            // Load it as a document
            var loadAttachmentOptions = new LoadAttachmentOptions();
            loadAttachmentOptions.AttachmentNumber = attachment.AttachmentNumber;
            loadAttachmentOptions.UpdateAttachmentDocumentId = false;
            loadAttachmentOptions.LoadDocumentOptions.RenderAnnotations = _preferences.LastRenderAnnotations;
            loadAttachmentOptions.LoadDocumentOptions.LoadAttachmentsMode = _preferences.LastLoadAttachmentsMode;
            loadAttachmentOptions.LoadDocumentOptions.LoadEmbeddedAnnotations = _preferences.LastFileLoadEmbeddedAnnotations;
            loadAttachmentOptions.LoadDocumentOptions.Cache = _cache;
            loadAttachmentOptions.LoadDocumentOptions.Name = attachment.DisplayName;
            this.LoadDocumentFromAttachment(currentDocument, loadAttachmentOptions);
         }
         catch (Exception ex)
         {
            UI.Helper.ShowError(this, ex);
         }
      }

      private void SaveAttachment()
      {
         if (_selectedAttachmentIndex == -1)
            return;

         int attachmentIndex = _selectedAttachmentIndex;
         LEADDocument currentDocument = this._documentViewer.Document;
         DocumentAttachment attachment = currentDocument.Attachments[attachmentIndex];

         if (attachment == null)
            return;

         string extension = "bin";
         if (!string.IsNullOrEmpty(attachment.FileName))
         {
            try
            {
               extension = Path.GetExtension(attachment.FileName);
               if (extension != null)
                  extension = extension.Substring(1);
            }
            catch { }
         }

         string outputFile = null;
         using (var dlg = new SaveFileDialog())
         {
            dlg.FileName = attachment.FileName;
            dlg.Filter = string.Format("{0} files|*.{0}|All files|*.*", extension);
            dlg.DefaultExt = extension;
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
               outputFile = dlg.FileName;
            }
         }

         if (outputFile == null)
            return;

         ObjectCache cache = currentDocument.HasCache ? currentDocument.GetCache() : null;

         try
         {
            using (var wait = new WaitCursor())
            {
               using (Stream stream = File.Create(outputFile))
               {
                  SaveAttachmentToStream(currentDocument, attachment, stream);
               }
            }

            Process.Start(outputFile);
         }
         catch (Exception ex)
         {
            UI.Helper.ShowError(this, ex);
         }
      }

      private static void SaveAttachmentToStream(LEADDocument document, DocumentAttachment attachment, Stream stream)
      {
         using (var inputStream = document.Attachments.CreateAttachmentStream(attachment.AttachmentNumber, null))
         {
            inputStream.CopyTo(stream);
         }
      }

      private void ShowAttachmentProperties()
      {
         if (_selectedAttachmentIndex == -1)
            return;

         int attachmentIndex = _selectedAttachmentIndex;

         LEADDocument currentDocument = this._documentViewer.Document;
         DocumentAttachment attachment = currentDocument.Attachments[attachmentIndex];

         using (var dlg = new UI.AttachmentPropertiesDialog())
         {
            dlg.Attachment = attachment;
            dlg.ShowDialog(this);
         }
      }
   }
}
