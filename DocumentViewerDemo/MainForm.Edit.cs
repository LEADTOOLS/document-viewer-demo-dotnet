// *************************************************************
// Copyright (c) 1991-2019 LEAD Technologies, Inc.              
// All Rights Reserved.                                         
// *************************************************************
using System;
using System.Windows.Forms;

using Leadtools;
using Leadtools.Demos;
using Leadtools.Document.Viewer;

namespace DocumentViewerDemo
{
   // Contains the edit menu and toolbar part of the viewer
   public partial class MainForm
   {
      private void BindEditItems()
      {
         // Menu
         _commandsBinder.Items.Add(new CommandBinderItem { ToolStripItem = _editToolStripMenuItem });
         _commandsBinder.Items.Add(new CommandBinderItem { CommandName = DocumentViewerCommands.AnnotationsUndo, ToolStripItem = _undoToolStripMenuItem });
         _commandsBinder.Items.Add(new CommandBinderItem { CommandName = DocumentViewerCommands.AnnotationsRedo, ToolStripItem = _redoToolStripMenuItem });
         _commandsBinder.Items.Add(new CommandBinderItem { CommandName = DocumentViewerCommands.AnnotationsCut, ToolStripItem = _cutToolStripMenuItem });
         _commandsBinder.Items.Add(new CommandBinderItem { CommandNames = new string[] { DocumentViewerCommands.TextCopy, DocumentViewerCommands.AnnotationsCopy }, ToolStripItem = _copyToolStripMenuItem });
         _commandsBinder.Items.Add(new CommandBinderItem { CommandName = DocumentViewerCommands.AnnotationsPaste, ToolStripItem = _pasteToolStripMenuItem });
         _commandsBinder.Items.Add(new CommandBinderItem { CommandName = DocumentViewerCommands.AnnotationsDelete, ToolStripItem = _deleteToolStripMenuItem });
         _commandsBinder.Items.Add(new CommandBinderItem { CommandName = DocumentViewerCommands.TextSelectAll, ToolStripItem = _selectAllToolStripMenuItem, AutoRun = false });
         _commandsBinder.Items.Add(new CommandBinderItem { CommandName = DocumentViewerCommands.AnnotationsSelectAll, ToolStripItem = _selectAllAnnotationsToolStripMenuItemtoolStripMenuItem });
         _commandsBinder.Items.Add(new CommandBinderItem { CommandNames = new string[] { DocumentViewerCommands.TextClearSelection, DocumentViewerCommands.AnnotationsClearSelection }, ToolStripItem = _clearSelectionToolStripMenuItem });
         _commandsBinder.Items.Add(new CommandBinderItem { ToolStripItem = _findToolStripMenuItem, HasDocumentEmptyEnabled = false });
         _commandsBinder.Items.Add(new CommandBinderItem { CommandName = DocumentViewerCommands.TextFindNext, ToolStripItem = _findNextToolStripMenuItem, AutoRun = false });
         _commandsBinder.Items.Add(new CommandBinderItem { CommandName = DocumentViewerCommands.TextFindPrevious, ToolStripItem = _findPreviousToolStripMenuItem, AutoRun = false });
      }

      private void _selectAllToolStripMenuItem_Click(object sender, EventArgs e)
      {
         DoSelectAllText();
      }

      private void DoSelectAllText()
      {
         // Check if we have any text or can get it automatically
         if (!CanPerformTextOperation("No text to select", true))
            return;

         //if (!_documentViewer.Text.HasDocumentPageText(0) && !
         //message = Helper.AddTextNote(message);

         var isSlow = _documentViewer.Commands.IsSlow(DocumentViewerCommands.TextSelectAll, 0);

         if (isSlow)
            this.BeginBusyOperation();

         var thisOperation = new DocumentViewerAsyncOperation
         {
            Error = (DocumentViewerAsyncOperation operation, Exception error) =>
            {
               UI.Helper.ShowError(this, error);
            },
            Always = (DocumentViewerAsyncOperation operation) =>
            {
               if (isSlow)
                  this.EndBusyOperation();
            }
         };

         _documentViewer.Commands.RunAsync(thisOperation, DocumentViewerCommands.TextSelectAll, 0);
      }

      private void _findToolStripMenuItem_Click(object sender, EventArgs e)
      {
         // Check if we have any text or can get it automatically
         if (!CanPerformTextOperation("No text to find", true))
            return;

         using (var dlg = new UI.FindTextDialog(_documentViewer))
         {
            dlg.ShowDialog(this);
         }
      }

      private void _findNextToolStripMenuItem_Click(object sender, EventArgs e)
      {
         FindNextPrevious(true);
      }

      private void _findPreviousToolStripMenuItem_Click(object sender, EventArgs e)
      {
         FindNextPrevious(false);
      }

      private void FindNextPrevious(bool findNext)
      {
         var commandName = findNext ? DocumentViewerCommands.TextFindNext : DocumentViewerCommands.TextFindPrevious;
         var isSlow = _documentViewer.Commands.IsSlow(commandName, 0);

         if (isSlow)
            this.BeginBusyOperation();

         var thisOperation = new DocumentViewerAsyncOperation
         {
            Error = (DocumentViewerAsyncOperation operation, Exception error) =>
            {
               UI.Helper.ShowError(this, error);
            },
            Always = (DocumentViewerAsyncOperation operation) =>
            {
               if (isSlow)
                  this.EndBusyOperation();
            }
         };

         _documentViewer.Commands.RunAsync(thisOperation, commandName, null);
      }
   }
}
