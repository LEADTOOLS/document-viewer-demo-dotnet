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
using System.IO;

using Leadtools.Demos;

namespace DocumentViewerDemo.UI
{
   public partial class ExportTextDialog : Form
   {
      public ExportTextDialog(string text)
      {
         InitializeComponent();

         // Convert to Window style
         if (!string.IsNullOrEmpty(text))
            _textBox.Text = text.Replace("\n", Environment.NewLine);
         else
            _textBox.Text = text;
      }

      private void _saveButton_Click(object sender, EventArgs e)
      {
         using (var dlg = new SaveFileDialog())
         {
            dlg.Filter = "Text files|*.txt|All files|*.*";
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
               try
               {
                  File.WriteAllText(dlg.FileName, _textBox.Text);
               }
               catch (Exception ex)
               {
                  Helper.ShowError(this, ex);
               }
            }
         }
      }
   }
}
