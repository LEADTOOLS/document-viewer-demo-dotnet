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

using Leadtools.Demos;

namespace DocumentViewerDemo.UI
{
   public partial class InputDialog : Form
   {
      public InputDialog()
      {
         InitializeComponent();
      }

      public string ValueTitle { get; set; }
      public string ValueDescription1 { get; set; }
      public string ValueDescription2 { get; set; }
      public string Value { get; set; }
      public bool IsPassword { get; set; }
      public bool IsReadOnly { get; set; }
      public bool AllowEmptyValue { get; set; }

      public bool UseIntValues { get; set; }
      public int MinIntValue { get; set; }
      public int MaxIntValue { get; set; }
      public int IntValue { get; set; }

      protected override void OnLoad(EventArgs e)
      {
         AllowEmptyValue = true;

         if (!DesignMode)
         {
            _valueGroupBox.Text = this.ValueTitle;

            if (!string.IsNullOrEmpty(this.ValueDescription1))
               _valueLabel1.Text = this.ValueDescription1;
            else
               _valueLabel1.Visible = false;

            if (!string.IsNullOrEmpty(this.ValueDescription2))
               _valueLabel2.Text = this.ValueDescription2;
            else
               _valueLabel2.Visible = false;

            _valueTextBox.UseSystemPasswordChar = this.IsPassword;

            if (this.UseIntValues)
            {
               _valueTextBox.Text = this.IntValue.ToString();
               _valueTextBox.Width /= 4;
            }
            else
               _valueTextBox.Text = this.Value;

            if (IsReadOnly)
            {
               _cancelButton.Visible = false;
               _valueTextBox.ReadOnly = true;
            }
         }

         base.OnLoad(e);
      }

      private void _okButton_Click(object sender, EventArgs e)
      {
         if (IsReadOnly)
            return;

         if (this.UseIntValues)
         {
            // Intgere value, make sure its valid and in range
            int value;
            if (!int.TryParse(_valueTextBox.Text, out value) || value < this.MinIntValue || value > this.MaxIntValue)
            {
               Helper.ShowError(this, string.Format("Value must be between {0} and {1}", this.MinIntValue, this.MaxIntValue));
               DialogResult = DialogResult.None;
               _valueTextBox.SelectAll();
               _valueTextBox.Focus();
               return;
            }

            this.IntValue = value;
         }
         else
         {
            if (!AllowEmptyValue && string.IsNullOrEmpty(_valueTextBox.Text))
            {
               Helper.ShowError(this, "Value must not be empty");
               DialogResult = DialogResult.None;
               _valueTextBox.SelectAll();
               _valueTextBox.Focus();
               return;
            }
         }

         this.Value = _valueTextBox.Text;
      }
   }
}
