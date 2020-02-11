// *************************************************************
// Copyright (c) 1991-2019 LEAD Technologies, Inc.              
// All Rights Reserved.                                         
// *************************************************************
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Leadtools;
using Leadtools.Document.Viewer;

namespace DocumentViewerDemo.UI
{
   class ViewContextMenu : ContextMenuStrip
   {
      public ViewContextMenu(DocumentViewer documentViewer, Action selectAllTextAction)
      {
         _commandsBinder = new CommandsBinder(documentViewer);

         _commandsBinder.Items.Add(new CommandBinderItem
         {
            CommandNames = new string[] { DocumentViewerCommands.TextCopy, DocumentViewerCommands.AnnotationsCopy },
            ToolStripItem = this.Items.Add("Copy")
         });

         _commandsBinder.Items.Add(new CommandBinderItem
         {
            CommandName = DocumentViewerCommands.AnnotationsPaste,
            ToolStripItem = this.Items.Add("Paste"),
            GetValue = (() =>
            {
               // The paste position, in viewer coordinates
               var position = documentViewer.View.ImageViewer.PointToClient(_openingPosition);
               return LeadPoint.Create(position.X, position.Y);
            })
         });

         
         _commandsBinder.Items.Add(new CommandBinderItem
         {
            CommandName = DocumentViewerCommands.AnnotationsDelete,
            ToolStripItem = this.Items.Add("Delete")
         });

         this.Items.Add(new ToolStripSeparator());

         _commandsBinder.Items.Add(new CommandBinderItem
         {
            CommandName = DocumentViewerCommands.TextSelectAll,
            ToolStripItem = this.Items.Add("Select all", null, new EventHandler(delegate { selectAllTextAction(); })),
            AutoRun = false
         });

         _commandsBinder.Items.Add(new CommandBinderItem
         {
            CommandName = DocumentViewerCommands.AnnotationsSelectAll,
            ToolStripItem = this.Items.Add("Select all annotations")
         });

         _commandsBinder.Items.Add(new CommandBinderItem
         {
            CommandNames = new string[] { DocumentViewerCommands.TextClearSelection, DocumentViewerCommands.AnnotationsClearSelection },
            ToolStripItem = this.Items.Add("Clear selection")
         });

         _commandsBinder.BindActions(true);
         _commandsBinder.Run();
      }

      private Point _openingPosition;

      protected override void OnOpening(CancelEventArgs e)
      {
         // Save the current mouse position
         _openingPosition = Cursor.Position;
         if (_commandsBinder != null)
            _commandsBinder.Run();

         base.OnOpening(e);
      }

      private CommandsBinder _commandsBinder;

      protected override void Dispose(bool disposing)
      {
         if (disposing)
         {
            if (_commandsBinder != null)
            {
               _commandsBinder.BindActions(false);
               _commandsBinder.Items.Clear();
               _commandsBinder = null;
            }
         }

         base.Dispose(disposing);
      }
   }
}
