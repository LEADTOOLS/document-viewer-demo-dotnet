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

namespace DocumentViewerDemo.UI
{
   // General busy dialog
   public partial class BusyDialog : Form
   {
      public BusyDialog()
      {
         InitializeComponent();
      }

      public bool EnableCancellation { get; set; }
      public bool IsCancelled { get; set; }

      protected override void OnLoad(EventArgs e)
      {
         if (!DesignMode)
         {
            _isWorking = true;

            this.IsCancelled = false;
            _cancellingLabel.Visible = false;
            this._cancelButton.Enabled = this.EnableCancellation;
            this._cancelButton.Visible = this.EnableCancellation;
         }

         base.OnLoad(e);
      }

      public void UpdateDescription(string description)
      {
         if (this.InvokeRequired)
         {
            BeginInvoke((Action)delegate ()
            {
               _descriptionLabel.Text = description;
               Application.DoEvents();
            });

            return;
         }

         _descriptionLabel.Text = description;
         Application.DoEvents();
      }

      private bool _isWorking;

      public bool IsWorking
      {
         get { return _isWorking; }
         set
         {
            _isWorking = value;
            if (!_isWorking)
            {
               // Close us
               DialogResult = DialogResult.OK;
               Close();
            }
         }
      }

      protected override void OnFormClosing(FormClosingEventArgs e)
      {
         e.Cancel = _isWorking;
         base.OnFormClosing(e);
      }

      private void _cancelButton_Click(object sender, EventArgs e)
      {
         if (this.EnableCancellation && !this.IsCancelled)
         {
            this.IsCancelled = true;
            _cancelButton.Enabled = false;
            _cancellingLabel.Visible = true;
            Application.DoEvents();
         }

         DialogResult = DialogResult.None;
      }

      protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
      {
         if (keyData == Keys.Return || keyData == Keys.Enter)
         {
            return true;
         }

         return base.ProcessCmdKey(ref msg, keyData);
      }
   }
}
