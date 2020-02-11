// *************************************************************
// Copyright (c) 1991-2019 LEAD Technologies, Inc.              
// All Rights Reserved.                                         
// *************************************************************
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace DocumentViewerDemo.UI
{
   public class OutputWindow : RichTextBox
   {
      public enum LineStyle
      {
         Normal,
         Bold,
         Error,
         Success
      }

      [DefaultValue(false)]
      public bool AddTime { get; set; }

      public OutputWindow()
      {
         this.Font = new Font("Consolas", 8);
         this.ReadOnly = true;

         var contextMenu = new ContextMenuStrip();
         var item = new ToolStripMenuItem("Clear");
         item.Click += (sender, e) => { this.Clear(); };
         contextMenu.Items.Add(item);
         this.ContextMenuStrip = contextMenu;
      }

      public void AddTextLine(Exception ex)
      {
         if (!Enabled) return;

         AddTextLine(string.Format("Exception: {0}{1}{2}", ex.GetType().Name, Environment.NewLine, ex.Message), LineStyle.Error);
      }

      private string AddCurrentTime(string text)
      {
         if (!AddTime)
            return text;

         var now = DateTime.Now;

         var nowString = string.Format("{0}:{1}:{2}", now.Hour.ToString("00"), now.Minute.ToString("00"), now.Second.ToString("00"));
         if (text != null)
            text = nowString + "-" + text;
         else
            text = nowString;

         return text;
      }

      public void AddText(string text)
      {
         if (!Enabled) return;

         text = AddCurrentTime(text);
         AppendText(text);

         ScrollToCaret();
      }

      public void AddTextLine(string text)
      {
         if (!Enabled) return;

         text = AddCurrentTime(text);

         if (text != null)
            AppendText(text + Environment.NewLine);
         else
            AppendText(Environment.NewLine);

         ScrollToCaret();
      }

      public void AddTextLine(string text, LineStyle lineStyle)
      {
         if (!Enabled) return;

         text = AddCurrentTime(text);

         if (lineStyle == LineStyle.Normal)
         {
            AddTextLine(text);
            return;
         }

         var oldSelectionStart = SelectionStart;

         if (text != null)
            AppendText(text + Environment.NewLine);
         else
            AppendText(Environment.NewLine);

         var newSelectionStart = SelectionStart;
         this.SelectionStart = oldSelectionStart;
         this.SelectionLength = newSelectionStart - oldSelectionStart;

         Color color;

         switch (lineStyle)
         {
            case LineStyle.Error:
               color = Color.Red;
               break;

            case LineStyle.Success:
               color = Color.Blue;
               break;

            default:
               color = Color.Black;
               break;
         }

         this.SelectionColor = color;
         using (var font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold))
            SelectionFont = font;

         this.SelectionStart = newSelectionStart;

         this.ScrollToCaret();
      }
   }

   // A trace listener implementation for the output window
   public class OutputWindowTraceListener : TraceListener
   {
      private OutputWindowTraceListener()
      {
      }

      public OutputWindowTraceListener(OutputWindow outputWindow)
      {
         _outputWindow = outputWindow;
      }

      private OutputWindow _outputWindow;

      public override void Write(string message)
      {
         _outputWindow.BeginInvoke((MethodInvoker)delegate
         {
            _outputWindow.AddText(message);
         });
      }

      public override void WriteLine(string message)
      {
         _outputWindow.BeginInvoke((MethodInvoker)delegate
         {
            _outputWindow.AddTextLine(message);
         });
      }
   }
}
