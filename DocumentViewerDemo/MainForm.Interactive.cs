// *************************************************************
// Copyright (c) 1991-2019 LEAD Technologies, Inc.              
// All Rights Reserved.                                         
// *************************************************************
using System;
using System.Windows.Forms;

using Leadtools;
using Leadtools.Demos;
using Leadtools.Document.Viewer;
using Leadtools.Controls;

namespace DocumentViewerDemo
{
   // Contains the interactive menu and toolbar part of the viewer
   public partial class MainForm
   {
      private void BindInteractiveItems()
      {
         // Menu
         _commandsBinder.Items.Add(new CommandBinderItem { ToolStripItem = _interactiveToolStripMenuItem });
         _commandsBinder.Items.Add(new CommandBinderItem { CommandName = DocumentViewerCommands.InteractiveSelectText, ToolStripItem = _selectTextToolStripMenuItem, UpdateChecked = true });
         _commandsBinder.Items.Add(new CommandBinderItem { CommandName = DocumentViewerCommands.InteractivePanZoom, ToolStripItem = _panZoomToolStripMenuItem, UpdateChecked = true });
         _commandsBinder.Items.Add(new CommandBinderItem { CommandName = DocumentViewerCommands.InteractivePan, ToolStripItem = _panToolStripMenuItem, UpdateChecked = true });
         _commandsBinder.Items.Add(new CommandBinderItem { CommandName = DocumentViewerCommands.InteractiveZoom, ToolStripItem = _zoomToolStripMenuItem, UpdateChecked = true });
         _commandsBinder.Items.Add(new CommandBinderItem { CommandName = DocumentViewerCommands.InteractiveZoomTo, ToolStripItem = _zoomToToolStripMenuItem, UpdateChecked = true });
         _commandsBinder.Items.Add(new CommandBinderItem { CommandName = DocumentViewerCommands.InteractiveMagnifyGlass, ToolStripItem = _magnifyGlassToolStripMenuItem, UpdateChecked = true });
         _commandsBinder.Items.Add(new CommandBinderItem { CommandName = DocumentViewerCommands.InteractiveAutoPan, ToolStripItem = _autoPanToolStripMenuItem });
         _commandsBinder.Items.Add(new CommandBinderItem { ToolStripItem = _inertiaScrollToolStripMenuItem });

         // Toolbar
         _commandsBinder.Items.Add(new CommandBinderItem { CommandName = DocumentViewerCommands.InteractiveSelectText, ToolStripItem = _selectTextToolStripButton, UpdateChecked = true });
         _commandsBinder.Items.Add(new CommandBinderItem { CommandName = DocumentViewerCommands.InteractivePanZoom, ToolStripItem = _panZoomToolStripButton, UpdateChecked = true });
         _commandsBinder.Items.Add(new CommandBinderItem { CommandName = DocumentViewerCommands.InteractivePan, ToolStripItem = _panToolStripButton, UpdateChecked = true });
         _commandsBinder.Items.Add(new CommandBinderItem { CommandName = DocumentViewerCommands.InteractiveZoom, ToolStripItem = _zoomToolStripButton, UpdateChecked = true });
         _commandsBinder.Items.Add(new CommandBinderItem { CommandName = DocumentViewerCommands.InteractiveZoomTo, ToolStripItem = _zoomToToolStripButton, UpdateChecked = true });
         _commandsBinder.Items.Add(new CommandBinderItem { CommandName = DocumentViewerCommands.InteractiveMagnifyGlass, ToolStripItem = _magnifyGlassToolStripButton, UpdateChecked = true });
      }


      private void _interactiveToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
      {
         _inertiaScrollToolStripMenuItem.Checked = _preferences.EnableInertiaScroll;
      }

      private void _inertiaScrollToolStripMenuItem_Click(object sender, EventArgs e)
      {
         ToggleInertiaScroll(false);
      }
   }
}
