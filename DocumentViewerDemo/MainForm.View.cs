// *************************************************************
// Copyright (c) 1991-2019 LEAD Technologies, Inc.              
// All Rights Reserved.                                         
// *************************************************************
using System;
using System.Windows.Forms;

using Leadtools.Controls;
using Leadtools.Document.Viewer;

namespace DocumentViewerDemo
{
   // Contains the view menu and toolbar part of the viewer
   public partial class MainForm
   {
      private void BindViewItems()
      {
         // Menu
         _commandsBinder.Items.Add(new CommandBinderItem { ToolStripItem = _viewToolStripMenuItem });
         _commandsBinder.Items.Add(new CommandBinderItem { CommandName = DocumentViewerCommands.ViewRotateClockwise, ToolStripItem = _clockwiseToolStripMenuItem });
         _commandsBinder.Items.Add(new CommandBinderItem { CommandName = DocumentViewerCommands.ViewRotateCounterClockwise, ToolStripItem = _counterClockwiseToolStripMenuItem });
         _commandsBinder.Items.Add(new CommandBinderItem { CommandName = DocumentViewerCommands.ViewZoomOut, ToolStripItem = _zoomOutToolStripMenuItem });
         _commandsBinder.Items.Add(new CommandBinderItem { CommandName = DocumentViewerCommands.ViewZoomIn, ToolStripItem = _zoomInToolStripMenuItem });
         _commandsBinder.Items.Add(new CommandBinderItem { CommandName = DocumentViewerCommands.ViewActualSize, ToolStripItem = _actualSizeToolStripMenuItem, UpdateChecked = true });
         _commandsBinder.Items.Add(new CommandBinderItem { CommandName = DocumentViewerCommands.ViewFitPage, ToolStripItem = _fitPageToolStripMenuItem, UpdateChecked = true });
         _commandsBinder.Items.Add(new CommandBinderItem { CommandName = DocumentViewerCommands.ViewFitWidth, ToolStripItem = _fitWidthToolStripMenuItem, UpdateChecked = true });

         // Toolbar
         _commandsBinder.Items.Add(new CommandBinderItem { ToolStripItem = _mainToolStripSeparator2 });
         _commandsBinder.Items.Add(new CommandBinderItem { CommandName = DocumentViewerCommands.ViewZoomIn, ToolStripItem = _zoomInToolStripButton });
         _commandsBinder.Items.Add(new CommandBinderItem { CommandName = DocumentViewerCommands.ViewZoomOut, ToolStripItem = _zoomOutToolStripButton });
         _commandsBinder.Items.Add(new CommandBinderItem { ToolStripItem = _zoomToolStripComboBox });
         _commandsBinder.Items.Add(new CommandBinderItem { CommandName = DocumentViewerCommands.ViewFitPage, ToolStripItem = _fitPageToolStripButton, UpdateChecked = true });
         _commandsBinder.Items.Add(new CommandBinderItem { CommandName = DocumentViewerCommands.ViewFitWidth, ToolStripItem = _fitWidthToolStripButton, UpdateChecked = true });
         _commandsBinder.Items.Add(new CommandBinderItem { CommandName = DocumentViewerCommands.ViewActualSize, ToolStripItem = _actualSizeToolStripButton, UpdateChecked = true });

         BindZoom();
      }

      private void _viewToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
      {
         if (_documentViewer.Document.Images.IsSvgViewingPreferred)
         {
            if (!_asSvgToolStripMenuItem.Enabled)
               _asSvgToolStripMenuItem.Enabled = true;

            _asSvgToolStripMenuItem.Checked = !_documentViewer.Commands.CanRun(DocumentViewerCommands.ViewItemType, DocumentViewerItemType.Svg);
            _asImageToolStripMenuItem.Checked = !_documentViewer.Commands.CanRun(DocumentViewerCommands.ViewItemType, DocumentViewerItemType.Image);
         }
         else
         {
            _asSvgToolStripMenuItem.Enabled = false;
            _asSvgToolStripMenuItem.Checked = false;
            _asImageToolStripMenuItem.Checked = true;
         }

         if (_documentViewer.Document.IsStructureSupported)
         {
            if (!_bookmarksToolStripMenuItem.Enabled)
               _bookmarksToolStripMenuItem.Enabled = true;

            _bookmarksToolStripMenuItem.Checked = (_leftTabControl.SelectedTab == _bookmarksTabPage);
         }
         else
         {
            _bookmarksToolStripMenuItem.Enabled = false;
            _bookmarksToolStripMenuItem.Checked = false;
         }

         _thumbnailsToolStripMenuItem.Checked = !_bookmarksToolStripMenuItem.Checked;
      }

      private void _asSvgToolStripMenuItem_Click(object sender, EventArgs e)
      {
         _documentViewer.Commands.Run(DocumentViewerCommands.ViewItemType, DocumentViewerItemType.Svg);
      }

      private void _asImageToolStripMenuItem_Click(object sender, EventArgs e)
      {
         _documentViewer.Commands.Run(DocumentViewerCommands.ViewItemType, DocumentViewerItemType.Image);
      }

      private void BindZoom()
      {
         string[] zoomValues =
         {
            "10%", "25%", "50%", "75%", "100%", "125%", "200%", "400%", "800%",
            "1600%", "2400%", "3200%", "6400%", "Actual Size", "Fit Page", "Fit Width", "Fit Height"
         };

         foreach (var zoomValue in zoomValues)
            _zoomToolStripComboBox.Items.Add(zoomValue);

         _documentViewer.View.ImageViewer.TransformChanged += (sender, e) => UpdateZoomValueFromView();
         _zoomToolStripComboBox.LostFocus += (sender, e) => UpdateZoomValueFromView();

         _zoomToolStripComboBox.SelectedIndexChanged += (sender, e) =>
         {
            if (!_documentViewer.HasDocument)
               return;

            // Parse the new zoom value
            var text = _zoomToolStripComboBox.Text.Trim();
            var imageViewer = _documentViewer.View.ImageViewer;

            switch (text)
            {
               case "Actual Size":
                  imageViewer.Zoom(ControlSizeMode.ActualSize, 1, imageViewer.DefaultZoomOrigin);
                  break;

               case "Fit Page":
                  imageViewer.Zoom(ControlSizeMode.FitAlways, 1, imageViewer.DefaultZoomOrigin);
                  break;

               case "Fit Width":
                  imageViewer.Zoom(ControlSizeMode.FitWidth, 1, imageViewer.DefaultZoomOrigin);
                  break;

               case "Fit Height":
                  imageViewer.Zoom(ControlSizeMode.FitHeight, 1, imageViewer.DefaultZoomOrigin);
                  break;

               default:
                  if (!string.IsNullOrEmpty(text))
                  {
                     var percentage = double.Parse(text.Substring(0, text.Length - 1));
                     imageViewer.Zoom(ControlSizeMode.None, percentage / 100.0, imageViewer.DefaultZoomOrigin);
                     UpdateUIState();
                  }
                  break;
            }
         };

         _zoomToolStripComboBox.KeyPress += (sender, e) =>
         {
            if (e.KeyChar == (char)Keys.Return)
            {
               // User has pressed enter, parse the new zoom value
               string text = _zoomToolStripComboBox.Text.Trim();
               if (string.IsNullOrEmpty(text))
                  return;

               // Remove the % sign if present
               if (text.EndsWith("%"))
               {
                  text = text.Remove(text.Length - 1, 1).Trim();
               }

               // Try to parse the new zoom value
               double percentage;
               if (double.TryParse(text, out percentage))
               {
                  var imageViewer = _documentViewer.View.ImageViewer;
                  imageViewer.Zoom(ControlSizeMode.None, percentage / 100.0, imageViewer.DefaultZoomOrigin);
               }

               UpdateZoomValueFromView();
            }
         };
      }

      private void UpdateZoomValueFromView()
      {
         // We are invoking this instead of changing the properties
         // directly because the Text value of a combo box is not
         // updated till after the lost focus or enter event is exited
         BeginInvoke(new MethodInvoker(delegate()
         {
            if (_documentViewer.HasDocument)
            {
               var percentage = _documentViewer.View.ImageViewer.ScaleFactor * 100.0;
               _zoomToolStripComboBox.Text = percentage.ToString("F1") + "%";
            }
            else
            {
               _zoomToolStripComboBox.Text = string.Empty;
            }
         }));
      }


      private void _thumbnailsToolStripMenuItem_Click(object sender, EventArgs e)
      {
         _leftTabControl.SelectedTab = _thumbnailsTabPage;
      }

      private void _bookmarksToolStripMenuItem_Click(object sender, EventArgs e)
      {
         _leftTabControl.SelectedTab = _bookmarksTabPage;
      }
   }
}
