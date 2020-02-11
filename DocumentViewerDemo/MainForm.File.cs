// *************************************************************
// Copyright (c) 1991-2019 LEAD Technologies, Inc.              
// All Rights Reserved.                                         
// *************************************************************
using System;
using System.Windows.Forms;

using Leadtools;
using Leadtools.Demos;
using Leadtools.Document;
using Leadtools.Document.Viewer;
using Leadtools.Controls;
using Leadtools.Demos.Dialogs;

namespace DocumentViewerDemo
{
   // Contains the file menu and toolbar part of the viewer
   public partial class MainForm
   {
      private void BindFileItems()
      {
         // Menu
         _commandsBinder.Items.Add(new CommandBinderItem { ToolStripItem = _saveToolStripMenuItem, HasDocumentEmptyEnabled = false });
         _commandsBinder.Items.Add(new CommandBinderItem { ToolStripItem = _closeToolStripMenuItem });
         _commandsBinder.Items.Add(new CommandBinderItem { ToolStripItem = _saveToCacheToolStripMenuItem, HasDocumentEmptyEnabled = false });
         _commandsBinder.Items.Add(new CommandBinderItem { ToolStripItem = _saveCurrentViewToolStripMenuItem, HasDocumentEmptyEnabled = false });
         _commandsBinder.Items.Add(new CommandBinderItem { ToolStripItem = _fileSep3ToolStripMenuItem });
         _commandsBinder.Items.Add(new CommandBinderItem { ToolStripItem = _exportTextToolStripMenuItem });
         _commandsBinder.Items.Add(new CommandBinderItem { ToolStripItem = _propertiesToolStripMenuItem });
         _commandsBinder.Items.Add(new CommandBinderItem { ToolStripItem = _fileSep4ToolStripMenuItem });
         _commandsBinder.Items.Add(new CommandBinderItem { ToolStripItem = _printToolStripMenuItem, HasDocumentEmptyEnabled = false });
         _commandsBinder.Items.Add(new CommandBinderItem { ToolStripItem = _printSetupToolStripMenuItem });         
      }

      private void _openDocumentFromFileToolStripMenuItem_Click(object sender, EventArgs e)
      {
         using (var dlg = new UI.OpenDocumentFileDialog())
         {
            dlg.DocumentFileName = _preferences.LastDocumentFileName;
            dlg.FirstPageNumber = _preferences.LastDocumentFirstPageNumber;
            dlg.LastPageNumber = _preferences.LastDocumentLastPageNumber;
            dlg.AnnotationsFileName = _preferences.LastAnnotationsFileName;
            dlg.LoadEmbeddedAnnotations = _preferences.LastFileLoadEmbeddedAnnotations;
            if (dlg.ShowDialog(this) == DialogResult.OK)
               LoadDocumentFromFile(dlg.DocumentFileName, dlg.FirstPageNumber, dlg.LastPageNumber, dlg.AnnotationsFileName, dlg.LoadEmbeddedAnnotations);
         }
      }

      private void _openDocumentFromUrltoolStripMenuItem_Click(object sender, EventArgs e)
      {
         using (var dlg = new UI.OpenDocumentUrlDialog())
         {
            if (string.IsNullOrEmpty(_preferences.LastDocumentUri))
            {
               dlg.DocumentUrl = @"http://demo.leadtools.com/images/pdf/leadtools.pdf";
               dlg.AnnotationsUrl = null;
            }
            else
            {
               dlg.DocumentUrl = _preferences.LastDocumentUri;
               dlg.AnnotationsUrl = _preferences.LastAnnotationsUri;
            }

            dlg.FirstPageNumber = _preferences.LastDocumentUriFirstPageNumber;
            dlg.LastPageNumber = _preferences.LastDocumentUriLastPageNumber;

            dlg.LoadEmbeddedAnnotations = _preferences.LastUriLoadEmbeddedAnnotations;
            dlg.ShowDialog(this);
         }
      }      


      private void _saveToolStripMenuItem_Click(object sender, EventArgs e)
      {
         SaveDocument();
      }

      private void _closeToolStripMenuItem_Click(object sender, EventArgs e)
      {
         CloseDocument();
      }

      private void _exitToolStripMenuItem_Click(object sender, EventArgs e)
      {
         Close();
      }

      private void _openFromCacheToolStripMenuItem_Click(object sender, EventArgs e)
      {
         if (_cache == null)
         {
            UI.Helper.ShowInformation(this, "This feature is only available when a Document Cache is used");
            return;
         }

         using (var dlg = new UI.InputDialog())
         {
            dlg.Text = "Document ID";
            dlg.ValueTitle = "Enter the ID of a document previously saved into the cache";

            // If the document is already in the cache, show its ID for easy re-loading
            LEADDocument document = _documentViewer.Document;
            if (document != null && DocumentFactory.GetDocumentCacheInfo(_cache, document.DocumentId) != null)
            {
               dlg.ValueDescription1 = "The current document ID is:";
               dlg.Value = document.DocumentId;
            }
            else
            {
               dlg.Value = string.Empty;
            }
            dlg.AllowEmptyValue = false;
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
               LoadDocumentFromCache(dlg.Value);
            }
         }
      }

      private void _saveToCacheToolStripMenuItem_Click(object sender, EventArgs e)
      {
         if (_cache == null)
         {
            UI.Helper.ShowInformation(this, "This feature is only available when a Document Cache is used");
            return;
         }

         SaveDocumentToCache();
      }

      private void _saveCurrentViewStripMenuItem_Click(object sender, EventArgs e)
      {
         if (_cache == null)
         {
            UI.Helper.ShowInformation(this, "This feature is only available when a Document Cache is used");
            return;
         }

         var viewOptions = _documentViewer.GetCurrentViewOptions();
         _documentViewer.Document.ViewOptions = viewOptions;

         SaveDocumentToCache();
      }

      private void _aboutToolStripMenuItem_Click(object sender, EventArgs e)
      {
         using (AboutDialog aboutDialog = new AboutDialog("Document Viewer", ProgrammingInterface.CS))
            aboutDialog.ShowDialog(this);
      }

      private void _openDocumentFromFileToolStripButton_Click(object sender, EventArgs e)
      {
         _openDocumentFromFileToolStripMenuItem.PerformClick();
      }

      private void _openDocumentFromUrlToolStripButton_Click(object sender, EventArgs e)
      {
         _openDocumentFromUrltoolStripMenuItem.PerformClick();
      }

      private void _propertiesToolStripMenuItem_Click(object sender, EventArgs e)
      {
         ShowDocumentProperties();
      }

      private void _exportTextToolStripMenuItem_Click(object sender, EventArgs e)
      {
         // Check if we have any text or can get it automatically
         if (!CanPerformTextOperation("No text to export", true))
            return;

         int pageNumber = 1;
         int pageCount = _documentViewer.PageCount;
         if (pageNumber > pageCount)
            pageNumber = pageCount;

         if (pageCount > 1)
         {
            using (var dlg = new UI.PagesDialog())
            {
               dlg.Operation = "Export Text";
               dlg.PageCount = _documentViewer.PageCount;
               dlg.FirstPageNumber = _documentViewer.CurrentPageNumber;
               dlg.SinglePageMode = true;
               if (dlg.ShowDialog(this) != DialogResult.OK)
                  return;

               // Single page mode, either .FirstPageNumber == .LastPageNumber meaning all pages or get it from .FirstPageNumber
               if (dlg.FirstPageNumber == 1 && dlg.LastPageNumber == _documentViewer.PageCount)
                  pageNumber = 0; // 0 means all pages
               else
                  pageNumber = dlg.FirstPageNumber;
            }
         }

         var isSlow = _documentViewer.Commands.IsSlow(DocumentViewerCommands.TextExport, pageNumber);

         if (isSlow)
            this.BeginBusyOperation();

         var thisOperation = new DocumentViewerAsyncOperation<object>
         {
            Done = (DocumentViewerAsyncOperation<object> operation) =>
            {
               this.BeginInvoke((MethodInvoker)delegate
               {
                  var text = operation.Result as string;
                  if (text != null)
                  {
                     using (var dlg = new UI.ExportTextDialog(text))
                     {
                        dlg.ShowDialog(this);
                     }
                  }
                  else
                  {
                     UI.Helper.ShowInformation(this, "This document does not contain any text");
                  }
               });
            },
            Error = (DocumentViewerAsyncOperation<object> operation, Exception error) =>
            {
               UI.Helper.ShowError(this, error);
            },
            Always = (DocumentViewerAsyncOperation<object> operation) =>
            {
               if (isSlow)
                  this.EndBusyOperation();
            }
         };

         _documentViewer.Commands.RunAsync(thisOperation, DocumentViewerCommands.TextExport, pageNumber);
      }

      private void _printSetupToolStripMenuItem_Click(object sender, EventArgs e)
      {
         PrintSetup();
      }

      private void _printToolStripMenuItem_Click(object sender, EventArgs e)
      {
         PrintDocument();
      }
   }
}
