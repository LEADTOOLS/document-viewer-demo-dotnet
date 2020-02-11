// *************************************************************
// Copyright (c) 1991-2019 LEAD Technologies, Inc.              
// All Rights Reserved.                                         
// *************************************************************
using System;
using System.Windows.Forms;
using System.ComponentModel;

using Leadtools;
using Leadtools.Demos;
using Leadtools.Document.Viewer;
using Leadtools.Controls;
using System.Collections.Generic;

namespace DocumentViewerDemo
{
   // Contains the page menu and toolbar part of the viewer
   public partial class MainForm
   {
      private void BindPageItems()
      {
         // Menu
         _commandsBinder.Items.Add(new CommandBinderItem { ToolStripItem = _pageToolStripMenuItem });
         _commandsBinder.Items.Add(new CommandBinderItem { CommandName = DocumentViewerCommands.PageFirst, ToolStripItem = _firstPageToolStripMenuItem });
         _commandsBinder.Items.Add(new CommandBinderItem { CommandName = DocumentViewerCommands.PagePrevious, ToolStripItem = _previousPageToolStripMenuItem });
         _commandsBinder.Items.Add(new CommandBinderItem { CommandName = DocumentViewerCommands.PageNext, ToolStripItem = _nextPageToolStripMenuItem });
         _commandsBinder.Items.Add(new CommandBinderItem { CommandName = DocumentViewerCommands.PageLast, ToolStripItem = _lastPageToolStripMenuItem });
         _commandsBinder.Items.Add(new CommandBinderItem { CommandName = DocumentViewerCommands.PageGoto, ToolStripItem = _gotoPageToolStripMenuItem, AutoRun = false });

         _commandsBinder.Items.Add(new CommandBinderItem
         {
            CommandName = DocumentViewerCommands.TextGet,
            ToolStripItem = _getCurrentPageTextToolStripMenuItem,
            AutoRun = false,
            GetValue = (() =>
            {
               return _documentViewer.CurrentPageNumber;
            })
         });

         _commandsBinder.Items.Add(new CommandBinderItem
         {
            CommandName = DocumentViewerCommands.TextGet,
            ToolStripItem = _getAllPagesTextToolStripMenuItem,
            AutoRun = false,
            GetValue = (() =>
            {
               return 0;
            })
         });

         _commandsBinder.Items.Add(new CommandBinderItem
         {
            CommandName = DocumentViewerCommands.PageRotateClockwise,
            ToolStripItem = _rotatePageClockwiseToolStripMenuItem,
            AutoRun = true,
            GetValue = (() =>
            {
               return new int[] { _documentViewer.CurrentPageNumber };
            })
         });

         _commandsBinder.Items.Add(new CommandBinderItem
         {
            CommandName = DocumentViewerCommands.PageRotateCounterClockwise,
            ToolStripItem = _rotatePageCounterClockwiseToolStripMenuItem,
            AutoRun = true,
            GetValue = (() =>
            {
               return new int[] { _documentViewer.CurrentPageNumber };
            })
         });

         _commandsBinder.Items.Add(new CommandBinderItem
         {
            CommandName = DocumentViewerCommands.PageDisable,
            ToolStripItem = _enableDisablePageToolStripMenuItem,
            AutoRun = false,
            GetValue = (() =>
            {
               return _documentViewer.CurrentPageNumber;
            })
         });

         _commandsBinder.Items.Add(new CommandBinderItem { CommandName = DocumentViewerCommands.LayoutSingle, ToolStripItem = _singlePageToolStripMenuItem, UpdateChecked = true });
         _commandsBinder.Items.Add(new CommandBinderItem { CommandName = DocumentViewerCommands.LayoutVertical, ToolStripItem = _verticalPageToolStripMenuItem, UpdateChecked = true });
         _commandsBinder.Items.Add(new CommandBinderItem { CommandName = DocumentViewerCommands.LayoutDouble, ToolStripItem = _doublePageToolStripMenuItem, UpdateChecked = true });
         _commandsBinder.Items.Add(new CommandBinderItem { CommandName = DocumentViewerCommands.LayoutHorizontal, ToolStripItem = _horizontalPageToolStripMenuItem, UpdateChecked = true });

         // Toolbar
         _commandsBinder.Items.Add(new CommandBinderItem { ToolStripItem = _mainToolStripSeparator1 });
         _commandsBinder.Items.Add(new CommandBinderItem { CommandName = DocumentViewerCommands.PagePrevious, ToolStripItem = _previousPageToolStripButton });
         _commandsBinder.Items.Add(new CommandBinderItem { CommandName = DocumentViewerCommands.PageNext, ToolStripItem = _nextPageToolStripButton });
         _commandsBinder.Items.Add(new CommandBinderItem { ToolStripItem = _pageNumberToolStripTextBox });
         _commandsBinder.Items.Add(new CommandBinderItem { ToolStripItem = _pageNumberToolStripLabel });

         _commandsBinder.Items.Add(new CommandBinderItem { ToolStripItem = _mainToolStripSeparator3 });
         _commandsBinder.Items.Add(new CommandBinderItem { CommandName = DocumentViewerCommands.LayoutSingle, ToolStripItem = _singlePageToolStripButton, UpdateChecked = true });
         _commandsBinder.Items.Add(new CommandBinderItem { CommandName = DocumentViewerCommands.LayoutVertical, ToolStripItem = _verticalPageToolStripButton, UpdateChecked = true });
         _commandsBinder.Items.Add(new CommandBinderItem { CommandName = DocumentViewerCommands.LayoutDouble, ToolStripItem = _doublePageToolStripButton, UpdateChecked = true });
         _commandsBinder.Items.Add(new CommandBinderItem { CommandName = DocumentViewerCommands.LayoutHorizontal, ToolStripItem = _horizontalPageToolStripButton, UpdateChecked = true });

         BindPageNumber();
      }

      public void UpdateCurrentPageNumber(CurrentPageNumberChangeData data) {
         if (data == null || !_documentViewer.HasDocument)
            return;

         var pageNumber = _documentViewer.CurrentPageNumber;
         var pageCount = _documentViewer.PageCount;

         _pageNumberToolStripTextBox.Text = pageNumber.ToString();
         _pageNumberToolStripLabel.Text = "/ " + pageCount.ToString();
      }

      private void BindPageNumber()
      {
         _pageNumberToolStripTextBox.LostFocus += (sender, e) =>
         {
            if (!_documentViewer.HasDocument)
               return;

            var pageNumber = _documentViewer.CurrentPageNumber;
            _pageNumberToolStripTextBox.Text = pageNumber.ToString();
         };

         _pageNumberToolStripTextBox.KeyPress += (sender, e) =>
         {
            if (e.KeyChar != (char)Keys.Return)
               return;

         // User has pressed enter, go to the new page number
         string text = _pageNumberToolStripTextBox.Text.Trim();

         // Try to parse the integer value
         int newPageNumber;
            if (!int.TryParse(text, out newPageNumber))
               return;

            var pageNumber = _documentViewer.CurrentPageNumber;
            var pageCount = _documentViewer.PageCount;

            if (newPageNumber != pageNumber && newPageNumber >= 1 && newPageNumber <= pageCount)
            {
               try
               {
                  _documentViewer.Commands.Run(DocumentViewerCommands.PageGoto, newPageNumber);
               }
               catch (Exception ex)
               {
                  UI.Helper.ShowError(this, ex);
               }
            }
         };
      }

      private void _gotoPageToolStripMenuItem_Click(object sender, EventArgs e)
      {
         using (var dlg = new UI.InputDialog())
         {
            dlg.Text = "Go To Page";
            dlg.ValueTitle = null;
            var pageCount = _documentViewer.PageCount;
            dlg.ValueDescription1 = string.Format("This document has {0} pages. Select the page number to go to", pageCount);
            dlg.UseIntValues = true;
            dlg.MinIntValue = 1;
            dlg.MaxIntValue = pageCount;
            dlg.IntValue = _documentViewer.View.ImageViewer.GetLargestVisibleItemIndex(ImageViewerItemPart.Item) + 1;
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
               try
               {
                  _documentViewer.Commands.Run(DocumentViewerCommands.PageGoto, dlg.IntValue);
               }
               catch (Exception ex)
               {
                  UI.Helper.ShowError(this, ex);
               }
            }
         }
      }

      private void _getCurrentPageTextToolStripMenuItem_Click(object sender, EventArgs e)
      {
         GetPagesText(_documentViewer.CurrentPageNumber);
      }

      private void _getAllPagesTextToolStripMenuItem_Click(object sender, EventArgs e)
      {
         GetPagesText(0);
      }

      private void _thumbnailsContextMenuStrip_Opening(object sender, CancelEventArgs e)
      {
         // Get current page from the position
         if (!_documentViewer.HasDocument)
         {
            e.Cancel = true;
            return;
         }

         var thumbnails = _documentViewer.Thumbnails;
         if (thumbnails == null)
         {
            e.Cancel = true;
            return;
         }

         var pageNumber = -1;
         var imageViewer = thumbnails.ImageViewer;
         var position = imageViewer.PointToClient(Cursor.Position);
         var item = imageViewer.HitTestItem(LeadPoint.Create(position.X, position.Y));
         var canRunText = false;
         if (item != null)
         {
            pageNumber = imageViewer.Items.IndexOf(item) + 1;
            canRunText = _documentViewer.Commands.CanRun(DocumentViewerCommands.TextGet, pageNumber);
         }

         if (pageNumber != -1)
         {
            _thumbnailsGetThisPageTextToolStripMenuItem.Tag = canRunText ? (object)pageNumber : null;
            _thumbnailsGetThisPageTextToolStripMenuItem.Enabled = canRunText;
            _thumbnailsRotateClockwiseToolStripMenuItem.Tag = pageNumber;
            _thumbnailsRotateClockwiseToolStripMenuItem.Enabled = true;
            _thumbnailsRotateCounterClockwiseToolStripMenuItem.Tag = pageNumber;
            _thumbnailsRotateCounterClockwiseToolStripMenuItem.Enabled = true;
            _thumbnailsEnableDisablePageToolStripMenuItem.Tag = pageNumber;
            _thumbnailsEnableDisablePageToolStripMenuItem.Enabled = true;
            _thumbnailsEnableDisablePageToolStripMenuItem.Checked = _documentViewer.Document.Pages[pageNumber - 1].IsDeleted;
         }
         else
         {
            _thumbnailsGetThisPageTextToolStripMenuItem.Tag = null;
            _thumbnailsGetThisPageTextToolStripMenuItem.Enabled = false;
            _thumbnailsRotateClockwiseToolStripMenuItem.Tag = null;
            _thumbnailsRotateClockwiseToolStripMenuItem.Enabled = true;
            _thumbnailsRotateCounterClockwiseToolStripMenuItem.Tag = null;
            _thumbnailsRotateCounterClockwiseToolStripMenuItem.Enabled = true;
            _thumbnailsEnableDisablePageToolStripMenuItem.Tag = null;
            _thumbnailsEnableDisablePageToolStripMenuItem.Enabled = false;
         }

         _thumbnailsGetAllPagesTextToolStripMenuItem.Enabled = _documentViewer.Commands.CanRun(DocumentViewerCommands.TextGet, 0);
      }

      private void _thumbnailsGetThisPageTextToolStripMenuItem_Click(object sender, EventArgs e)
      {
         if (_thumbnailsGetThisPageTextToolStripMenuItem.Tag == null)
            return;

         var pageNumber = (int)_thumbnailsGetThisPageTextToolStripMenuItem.Tag;
         GetPagesText(pageNumber);
      }

      private void _thumbnailsGetAllPagesTextToolStripMenuItem_Click(object sender, EventArgs e)
      {
         GetPagesText(0);
      }

      private void GetPagesText(int pageNumber)
      {
         // This could take some time, so run it as a busy operation
         this.BeginBusyOperation();

         var thisOperation = new DocumentViewerAsyncOperation
         {
            Error = (DocumentViewerAsyncOperation operation, Exception error) =>
            {
               UI.Helper.ShowError(this, error);
            },
            Always = (DocumentViewerAsyncOperation operation) =>
            {
               this.EndBusyOperation();
            }
         };

         _documentViewer.Commands.RunAsync(thisOperation, DocumentViewerCommands.TextGet, pageNumber);
      }

      private void _thumbnailsRotateClockwiseToolStripMenuItem_Click(object sender, EventArgs e)
      {
         if (_thumbnailsRotateClockwiseToolStripMenuItem.Tag == null)
            return;

         var pageNumber = (int)_thumbnailsRotateClockwiseToolStripMenuItem.Tag;
         RotatePage(pageNumber, DocumentViewerCommands.PageRotateClockwise);
      }

      private void _thumbnailsRotateCounterClockwiseToolStripMenuItem_Click(object sender, EventArgs e)
      {
         if (_thumbnailsRotateCounterClockwiseToolStripMenuItem.Tag == null)
            return;

         var pageNumber = (int)_thumbnailsRotateCounterClockwiseToolStripMenuItem.Tag;
         RotatePage(pageNumber, DocumentViewerCommands.PageRotateCounterClockwise);
      }

      private void _rotatePagesToolStripMenuItem_Click(object sender, EventArgs e)
      {
         using (var dlg = new UI.RotatePagesDialog())
         {
            dlg.PageCount = _documentViewer.PageCount;
            dlg.FirstPageNumber = 1;
            dlg.LastPageNumber = dlg.PageCount;
            dlg.SelectedPageNumber = _documentViewer.CurrentPageNumber;
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
               int rotationAngle;
               switch (dlg.Direction)
               {
                  case UI.RotatePagesDialog.DirectionMode.Direction90CounterClockwise:
                     rotationAngle = -90;
                     break;

                  case UI.RotatePagesDialog.DirectionMode.Direction180:
                     rotationAngle = 180;
                     break;

                  case UI.RotatePagesDialog.DirectionMode.Direction90Clockwise:
                  default:
                     rotationAngle = 90;
                     break;
               }

               // Get the page numbers to rotate
               var pageNumbers = new List<int>();
               var firstPageNumber = dlg.FirstPageNumber;
               var lastPageNumber = dlg.LastPageNumber;
               var evenOdd = dlg.EventOdd;
               var orientation = dlg.Orientation;

               for (var pageNumber = firstPageNumber; pageNumber <= lastPageNumber; pageNumber++)
               {
                  bool add = false;

                  switch (evenOdd)
                  {
                     case UI.RotatePagesDialog.EvenOddMode.OnlyEven:
                        add = (pageNumber % 2) == 0;
                        break;

                     case UI.RotatePagesDialog.EvenOddMode.OnlyOdd:
                        add = (pageNumber % 2) != 0;
                        break;

                     case UI.RotatePagesDialog.EvenOddMode.All:
                        add = true;
                        break;
                  }

                  if (add)
                  {
                     var page = _documentViewer.Document.Pages[pageNumber - 1];
                     switch (orientation)
                     {
                        case UI.RotatePagesDialog.OrientationMode.LandscapeOnly:
                           add = page.ViewPerspectiveSize.Width > page.ViewPerspectiveSize.Height;
                           break;

                        case UI.RotatePagesDialog.OrientationMode.PortraitOnly:
                           add = page.ViewPerspectiveSize.Height > page.ViewPerspectiveSize.Width;
                           break;

                        case UI.RotatePagesDialog.OrientationMode.All:
                        default:
                           add = true;
                           break;
                     }
                  }

                  if (add)
                     pageNumbers.Add(pageNumber);
               }

               if (pageNumbers.Count > 0)
                  _documentViewer.RotatePages(pageNumbers, rotationAngle);
            }
         }
      }

      private void RotatePage(int pageNumber, string commandName)
      {
         _documentViewer.Commands.Run(commandName, new int[] { pageNumber });
      }


      private void _thumbnailsEnableDisablePageToolStripMenuItem_Click(object sender, EventArgs e)
      {
         if (_thumbnailsEnableDisablePageToolStripMenuItem.Tag == null)
            return;

         var pageNumber = (int)_thumbnailsEnableDisablePageToolStripMenuItem.Tag;
         EnableDisablePage(pageNumber);
      }

      private void _pageToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
      {
         if (!_documentViewer.HasDocument)
         {
            return;
         }

         int pageNumber = _documentViewer.CurrentPageNumber;
         if (pageNumber == 0)
            return;

         _enableDisablePageToolStripMenuItem.Checked = _documentViewer.Document.Pages[pageNumber - 1].IsDeleted;
      }

      private void _enableDisablePageToolStripMenuItem_Click(object sender, EventArgs e)
      {
         var pageNumber = _documentViewer.CurrentPageNumber;
         EnableDisablePage(pageNumber);
      }

      private void EnableDisablePage(int pageNumber)
      {
         var page = _documentViewer.Document.Pages[pageNumber - 1];
         string command;
         if (page.IsDeleted)
            command = DocumentViewerCommands.PageEnable;
         else
            command = DocumentViewerCommands.PageDisable;

         _documentViewer.Commands.Run(command, new int[] { pageNumber });
      }
   }
}
