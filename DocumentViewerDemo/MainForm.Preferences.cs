// *************************************************************
// Copyright (c) 1991-2019 LEAD Technologies, Inc.              
// All Rights Reserved.                                         
// *************************************************************
using System;
using System.Windows.Forms;

using Leadtools.Demos;
using Leadtools.Document.Viewer;

namespace DocumentViewerDemo
{
   // Contains the preferences menu and toolbar part of the viewer
   public partial class MainForm
   {
      private void _preferencesToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
      {
         _autoGetTextToolStripMenuItem.Checked = _preferences.AutoGetText;
         _showOperationsToolStripMenuItem.Checked = _preferences.ShowOperations;
         _showTextIndicatorsToolStripMenuItem.Checked = _preferences.ShowTextIndicators;
      }

      private void _userNameToolStripMenuItem_Click(object sender, EventArgs e)
      {
         using (var dlg = new UI.InputDialog())
         {
            dlg.Text = "User Name";
            dlg.ValueTitle = null;
            dlg.ValueDescription1 = "Enter user name for modifying annotations in the document";
            dlg.Value = _documentViewer.UserName;
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
               _documentViewer.UserName = dlg.Value;
            }
         }
      }

      private void _cacheDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
      {
         using (var dlg = new FolderBrowserDialog())
         {
            dlg.RootFolder = Environment.SpecialFolder.Desktop; // so we can set the initial folder
            dlg.SelectedPath = _preferences.CacheDir;
            dlg.ShowNewFolderButton = true;
            dlg.Description = "Select the directory to use for caching the documents data";
            if(dlg.ShowDialog(this) == DialogResult.OK)
            {
               _preferences.CacheDir = dlg.SelectedPath;
               UI.Helper.ShowInformation(this, "Cache directory has been updated. You need to re-start this demo to use the new value");
            }
         }
      }

      private void _autoGetTextToolStripMenuItem_Click(object sender, EventArgs e)
      {
         _preferences.AutoGetText = !_preferences.AutoGetText;
         if (_documentViewer != null)
            _documentViewer.Text.AutoGetText = _preferences.AutoGetText;
      }

      private void _documentTextOptionsToolStripMenuItem_Click(object sender, EventArgs e)
      {
         using (var dlg = new UI.DocumentTextOptionsDialog())
         {
            dlg.ImagesRecognitionMode = _imagesRecognitionMode;
            dlg.TextExtractionMode = _textExtractionMode;
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
               _imagesRecognitionMode = dlg.ImagesRecognitionMode;
               _textExtractionMode = dlg.TextExtractionMode;

               if (_documentViewer != null && _documentViewer.Document != null)
               {
                  _documentViewer.Document.Text.ImagesRecognitionMode = _imagesRecognitionMode;
                  _documentViewer.Document.Text.TextExtractionMode = _textExtractionMode;
               }
            }
         }
      }

      private void _showTextIndicatorsToolStripMenuItem_Click(object sender, EventArgs e)
      {
         _preferences.ShowTextIndicators = !_preferences.ShowTextIndicators;
         UpdateShowTextIndicators();
      }

      private void _showOperationsToolStripMenuItem_Click(object sender, EventArgs e)
      {
         _preferences.ShowOperations = !_preferences.ShowOperations;
         UpdateShowOperation();
      }

      private void _diagnosticsToolStripMenuItem_Click(object sender, EventArgs e)
      {
         using (var dlg = new UI.ObjectPropertiesDialog())
         {
            dlg.Text = "Diagnostics";
            dlg.PropertyGrid.ToolbarVisible = false;
            dlg.PropertyGrid.PropertySort = PropertySort.Alphabetical;
            dlg.PropertyGrid.SelectedObject = _documentViewer.Diagnostics;
            dlg.ShowDialog(this);
         }
      }

      private void _documentViewerOptionsToolStripMenuItem_Click(object sender, EventArgs e)
      {
         using (var dlg = new UI.DocumentViewerOptionsDialog())
         {
            dlg.LoadDocumentTimeoutMilliseconds = _loadDocumentTimeoutMilliseconds;
            dlg.MaximumImagesPixelSize = _maximumImagePixelSize;
            dlg.DocumentViewer = _documentViewer;
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
               _loadDocumentTimeoutMilliseconds = dlg.LoadDocumentTimeoutMilliseconds;
               _maximumImagePixelSize = dlg.MaximumImagesPixelSize;
            }
         }
      }
   }
}
