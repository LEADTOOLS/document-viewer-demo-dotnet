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
using System.Drawing.Imaging;

using Leadtools.Annotations.Engine;
using Leadtools.Annotations.Automation;

namespace DocumentViewerDemo.UI
{
   public partial class CustomRenderModeDialog : Form
   {
      public AnnAutomationManager AutomationManager { get; set; }

      public Dictionary<int, IAnnObjectRenderer> AllRenderers { get; set; }
      public Dictionary<int, IAnnObjectRenderer> CurrentRenderers { get; set; }
      public Dictionary<int, IAnnObjectRenderer> ResultRenderers { get; set; }

      public CustomRenderModeDialog()
      {
         InitializeComponent();
      }

      private struct MyListBoxItem
      {
         public int ObjectId { get; set; }
         public string Name { get; set; }
         public override string ToString()
         {
            return Name;
         }
      }

      protected override void OnLoad(EventArgs e)
      {
         if (!DesignMode)
         {
            foreach (var iter in this.AllRenderers)
            {
               // Visible means its in RenderMode
               var annObjectId = iter.Key;

               // ignore these types
               switch (annObjectId)
               {
                  case AnnObject.SelectObjectId:
                  case AnnObject.ImageObjectId:
                     break;

                  default:
                     var automationObject = this.AutomationManager.FindObjectById(annObjectId);
                     if (automationObject != null)
                     {
                        var listBoxItem = new MyListBoxItem { ObjectId = annObjectId, Name = automationObject.Name };
                        if (this.CurrentRenderers.ContainsKey(annObjectId))
                           _visibleObjectsListBox.Items.Add(listBoxItem);
                        else
                           _invisibleObjectsListBox.Items.Add(listBoxItem);
                     }
                     break;
               }
            }

            UpdateUIState();
         }

         base.OnLoad(e);
      }

      private void _visibleObjectsListBox_DrawItem(object sender, DrawItemEventArgs e)
      {
         DrawItem(sender as ListBox, e);
      }

      private void _invisibleObjectsListBox_DrawItem(object sender, DrawItemEventArgs e)
      {
         DrawItem(sender as ListBox, e);
      }

      private void DrawItem(ListBox listBox, DrawItemEventArgs e)
      {
         if (e.Index < 0)
            return;

         var graphics = e.Graphics;
         var listBoxItem = (MyListBoxItem)listBox.Items[e.Index];
         var automationObject = this.AutomationManager.FindObjectById(listBoxItem.ObjectId);

         using (var brush = new SolidBrush(e.BackColor))
            graphics.FillRectangle(brush, e.Bounds);

         var rc = e.Bounds;

         if (automationObject != null)
         {
            var bitmap = automationObject.ToolBarImage as Bitmap;
            if (bitmap != null)
            {
               const int dx = 2;
               var factor = 1.0;

               if (bitmap.Height > rc.Height && rc.Height > 0)
               {
                  factor = (double)rc.Height / (double)bitmap.Height;
               }

               var width = (int)(bitmap.Width * factor + 0.5);
               var height = (int)(bitmap.Height * factor + 0.5);

               var bitmapRect = new Rectangle(rc.X + dx, rc.Y + (rc.Height - height) / 2, width, height);

               using (var ia = new ImageAttributes())
               {
                  var color = bitmap.GetPixel(0, 0);
                  ia.SetColorKey(color, color);
                  graphics.DrawImage(bitmap, bitmapRect, 0, 0, bitmap.Width, bitmap.Height, GraphicsUnit.Pixel, ia);
               }

               rc = Rectangle.FromLTRB(rc.X + width + dx * 2, rc.Y, rc.Right, rc.Bottom);
            }

            using (var sf = new StringFormat())
            {
               sf.Alignment = StringAlignment.Near;
               sf.LineAlignment = StringAlignment.Center;

               using (var brush = new SolidBrush(e.ForeColor))
                  graphics.DrawString(automationObject.Name, Font, brush, rc, sf);
            }
         }
      }

      private void _visibleObjectsListBox_SelectedIndexChanged(object sender, EventArgs e)
      {
         UpdateUIState();
      }

      private void _invisibleObjectsListBox_SelectedIndexChanged(object sender, EventArgs e)
      {
         UpdateUIState();
      }

      private void UpdateUIState()
      {
         _moveToInvisibleButton.Enabled = _visibleObjectsListBox.SelectedItems.Count > 0;
         _moveToVisibleButton.Enabled = _invisibleObjectsListBox.SelectedItems.Count > 0;
      }

      private void _moveToInvisibleButton_Click(object sender, EventArgs e)
      {
         MoveObjects(_visibleObjectsListBox, _invisibleObjectsListBox);
      }

      private void _moveToVisibleButton_Click(object sender, EventArgs e)
      {
         MoveObjects(_invisibleObjectsListBox, _visibleObjectsListBox);
      }

      private static void MoveObjects(ListBox sourceListBox, ListBox targetListBox)
      {
         // get the objects
         var count = sourceListBox.SelectedItems.Count;
         if (count == 0)
            return;

         var items = new List<MyListBoxItem>();
         for (var i = 0; i < count; i++)
            items.Add((MyListBoxItem)sourceListBox.SelectedItems[i]);

         sourceListBox.SuspendLayout();
         targetListBox.SuspendLayout();

         foreach (var item in items)
         {
            sourceListBox.Items.Remove(item);
            targetListBox.Items.Add(item);
         }

         sourceListBox.ResumeLayout();
         targetListBox.ResumeLayout();
      }

      private void _okButton_Click(object sender, EventArgs e)
      {
         // Get the items in visible
         var count = _visibleObjectsListBox.Items.Count;
         var items = new List<MyListBoxItem>();
         for (var i = 0; i < count; i++)
            items.Add((MyListBoxItem)_visibleObjectsListBox.Items[i]);

         // Update the result
         this.ResultRenderers = new Dictionary<int,IAnnObjectRenderer>();

         foreach (var iter in this.AllRenderers)
         {
            var annObjectId = iter.Key;
            foreach (var item in items)
            {
               if (item.ObjectId == annObjectId)
               {
                  this.ResultRenderers.Add(annObjectId, iter.Value);
                  break;
               }
            }
         }
      }
   }
}
