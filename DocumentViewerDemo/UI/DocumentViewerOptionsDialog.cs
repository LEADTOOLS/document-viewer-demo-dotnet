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

using Leadtools.Document.Viewer;

namespace DocumentViewerDemo.UI
{
   public partial class DocumentViewerOptionsDialog : Form
   {
      public DocumentViewerOptionsDialog()
      {
         InitializeComponent();
      }

      private DocumentViewer _documentViewer;
      public DocumentViewer DocumentViewer
      {
         get { return _documentViewer; }
         set { _documentViewer = value; }
      }

      private int _loadDocumentTimeoutMilliseconds;
      public int LoadDocumentTimeoutMilliseconds
      {
         get { return _loadDocumentTimeoutMilliseconds; }
         set { _loadDocumentTimeoutMilliseconds = value; }
      }

      private int _maximumImagesPixelSize;
      public int MaximumImagesPixelSize
      {
         get { return _maximumImagesPixelSize; }
         set { _maximumImagesPixelSize = value; }
      }

      protected override void OnLoad(EventArgs e)
      {
         if (!DesignMode)
         {
            var hasThumbnails = (_documentViewer.Thumbnails != null);
            _thumbnailsOptionsGroupBox.Enabled = hasThumbnails;
            _thumbnailsUseGridsCheckBox.Checked = hasThumbnails && _documentViewer.Thumbnails.UseGrids;
            if (hasThumbnails)
               _thumbnailsGridPixelSizeTextBox.Text = _documentViewer.Thumbnails.GridPixelSize.ToString();
            else
               _thumbnailsGridPixelSizeTextBox.Text = String.Empty;

            _thumbnailsUseGridsCheckBox_CheckedChanged(null, null);

            _loadDocumentTimeoutTextBox.Text = _loadDocumentTimeoutMilliseconds.ToString();
            _maximumImagesPixelSizeTextBox.Text = _maximumImagesPixelSize.ToString();
         }

         base.OnLoad(e);
      }

      private void _thumbnailsUseGridsCheckBox_CheckedChanged(object sender, EventArgs e)
      {
         if (_documentViewer.Thumbnails == null)
            return;

         _thumbnailsGridPixelSizeLabel.Enabled = _thumbnailsUseGridsCheckBox.Checked;
         _thumbnailsGridPixelSizeTextBox.Enabled = _thumbnailsUseGridsCheckBox.Checked;
      }

      private void _okButton_Click(object sender, EventArgs e)
      {
         int loadDocumentTimeout;
         if (!int.TryParse(_loadDocumentTimeoutTextBox.Text, out loadDocumentTimeout) ||
            loadDocumentTimeout < 0)
         {
            MessageBox.Show(this, "Must be a value greater or equal to 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            _loadDocumentTimeoutTextBox.SelectAll();
            _loadDocumentTimeoutTextBox.Focus();
            DialogResult = DialogResult.None;
            return;
         }

         int maximumImagesPixelSize;
         if (!int.TryParse(_maximumImagesPixelSizeTextBox.Text, out maximumImagesPixelSize) ||
            maximumImagesPixelSize < 0)
         {
            MessageBox.Show(this, "Must be a value greater or equal to 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            _maximumImagesPixelSizeTextBox.SelectAll();
            _maximumImagesPixelSizeTextBox.Focus();
            DialogResult = DialogResult.None;
            return;
         }

         var hasThumbnails = (_documentViewer.Thumbnails != null);
         if (hasThumbnails)
         {
            bool useGrid = _thumbnailsUseGridsCheckBox.Checked;
            if (useGrid)
            {
               int gridPixelSize;
               if (!int.TryParse(_thumbnailsGridPixelSizeTextBox.Text, out gridPixelSize) ||
                  gridPixelSize < 1 ||
                  gridPixelSize > 4000)
               {
                  MessageBox.Show(this, "Must be a value greater than 0 and less than or equal to 4000", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                  _thumbnailsGridPixelSizeTextBox.SelectAll();
                  _thumbnailsGridPixelSizeTextBox.Focus();
                  DialogResult = DialogResult.None;
                  return;
               }

               _documentViewer.Thumbnails.GridPixelSize = gridPixelSize;
            }

            _documentViewer.Thumbnails.UseGrids = useGrid;
         }

         this.LoadDocumentTimeoutMilliseconds = loadDocumentTimeout;
         this.MaximumImagesPixelSize = maximumImagesPixelSize;
      }
   }
}
