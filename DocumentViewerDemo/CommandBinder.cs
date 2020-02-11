// *************************************************************
// Copyright (c) 1991-2019 LEAD Technologies, Inc.              
// All Rights Reserved.                                         
// *************************************************************
using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Leadtools.Document.Viewer;

namespace DocumentViewerDemo
{
   // Binds document viewer command to control
   class CommandBinderItem
   {
      public CommandBinderItem()
      {
         this.UpdateEnabled = true;
         this.HasDocumentVisible = true;
         this.HasDocumentEmptyEnabled = true;
         this.AutoRun = true;
      }

      public string CommandName { get; set; }
      public string[] CommandNames { get; set; }
      public ToolStripItem ToolStripItem { get; set; }
      public bool UpdateEnabled { get; set; }
      public bool UpdateVisible { get; set; }
      public bool UpdateChecked { get; set; }
      public bool HasDocumentVisible { get; set; }
      public bool HasDocumentEmptyEnabled { get; set; }
      public bool AutoRun { get; set; }
      public delegate object GetValueCallback();
      public GetValueCallback GetValue { get; set; }
      public object Tag { get; set; }
      public delegate bool BinderCanRun(DocumentViewer documentViewer, object value);
      public BinderCanRun CanRun { get; set; }
      public object CanRunValue { get; set; }

      public void RunCommand(DocumentViewer documentViewer)
      {
         if (this.CommandName != null)
         {
            documentViewer.Commands.Run(this.CommandName, GetValue != null ? GetValue() : null);
         }
         else if (this.CommandNames != null)
         {
            foreach (var commandName in this.CommandNames)
               documentViewer.Commands.Run(commandName, GetValue != null ? GetValue() : null);
         }
      }

      public bool CanRunCommand(DocumentViewer documentViewer)
      {
         if (this.CommandName != null)
            return documentViewer.Commands.CanRun(this.CommandName, GetValue != null ? GetValue() : null);

         foreach (var commandName in this.CommandNames)
         {
            if (documentViewer.Commands.CanRun(commandName, GetValue != null ? GetValue() : null))
               return true;
         }

         return false;
      }

      public bool HasAnyCommand
      {
         get { return this.CommandName != null || this.CommandNames != null; }
      }
   }

   class CommandsBinder
   {
      public CommandsBinder(DocumentViewer documentViewer)
      {
         _documentViewer = documentViewer;
      }

      private DocumentViewer _documentViewer;

      private List<CommandBinderItem> _items = new List<CommandBinderItem>();
      public IList<CommandBinderItem> Items
      {
         get { return _items; }
      }

      private List<Action> _postRuns = new List<Action>();
      public List<Action> PostRuns
      {
         get { return _postRuns; }
      }

      public void BindActions(bool bind)
      {
         foreach (var item in _items)
         {
            if (bind)
            {
               if (item.AutoRun && item.HasAnyCommand)
               {
                  item.ToolStripItem.Tag = item;
                  item.ToolStripItem.Click += ItemClick;
               }
               else
               {
                  item.ToolStripItem.Tag = null;
                  item.ToolStripItem.Click -= ItemClick;
               }
            }
         }
      }

      private void ItemClick(object sender, EventArgs e)
      {
         var toolStripItem = sender as ToolStripItem;
         var item = toolStripItem.Tag as CommandBinderItem;
         item.RunCommand(_documentViewer);
      }

      public void Run()
      {
         var hasDocument = _documentViewer.HasDocument;
         var isDocumentEmpty = _documentViewer.PageCount == 0;

         foreach (var item in _items)
         {
            var toolStripItem = item.ToolStripItem;

            var canRun = false;

            if (item.CanRun != null)
            {
               canRun = item.CanRun(_documentViewer, item.CanRunValue);
            }
            else if (item.HasDocumentVisible)
            {
               canRun = hasDocument;
               if (toolStripItem.Available != canRun)
                  toolStripItem.Available = canRun;
            }

            if (canRun && item.HasAnyCommand)
               canRun = item.CanRunCommand(_documentViewer);

            var updateCheckedState = item.UpdateChecked;
            DocumentViewerCommand command = null;
            if (item.CommandName != null)
            {
               // This might be a state command, check
               command = _documentViewer.Commands.GetCommand(item.CommandName);
            }

            if (!updateCheckedState)
               updateCheckedState = command != null && command.HasState;

            if (!updateCheckedState)
            {
               if (canRun && !item.HasDocumentEmptyEnabled && isDocumentEmpty)
                  canRun = false;

               if (item.UpdateEnabled && toolStripItem.Enabled != canRun)
                  toolStripItem.Enabled = canRun;
            }
            else
            {
               var checkedState = false;
               if (command != null && command.HasState)
                  checkedState = command.State;
               else
                  checkedState = !canRun;

               UpdateProperty(toolStripItem, "Checked", checkedState);
            }

            if (item.UpdateVisible && toolStripItem.Available != canRun)
               toolStripItem.Available = canRun;
         }

         foreach (var postRun in _postRuns)
            postRun();
      }

      private static void UpdateProperty(object target, string propertyName, bool value)
      {
         var prop = target.GetType().GetProperty(propertyName);
         if (value != (bool)prop.GetValue(target, null))
            prop.SetValue(target, value, null);
      }
   }
}
