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
   public partial class PagesDialog : Form
   {
      public PagesDialog()
      {
         InitializeComponent();
      }

      public string Operation;
      public int PageCount;
      public int FirstPageNumber;
      public int LastPageNumber;
      public bool ShowCurrentPageNumber = true;
      public bool SinglePageMode = true;

      protected override void OnLoad(EventArgs e)
      {
         if (!DesignMode)
         {
            this.Text = this.Operation;
            _operationLabel.Text = _operationLabel.Text.Replace("###", this.Operation.ToLowerInvariant());
            if (PageCount != -1)
            {
               _pagesLabel.Text = _pagesLabel.Text.Replace("###", this.PageCount.ToString());
               _lastPageCheckBox.Visible = false;
               _firstPageNumberNumericUpDown.Maximum = this.PageCount;

               if (this.SinglePageMode)
               {
                  _firstPageNumberLabel.Text = "&Page number:";
                  _lastPageNumberLabel.Visible = false;
                  _lastPageNumberNumericUpDown.Visible = false;
                  _lastPageNumberNumericUpDown.Enabled = false;
               }
               else
               {
                  _lastPageNumberNumericUpDown.Maximum = this.PageCount;
               }

               this.FirstPageNumber = Math.Max(1, Math.Min(this.PageCount, this.FirstPageNumber));

               if (this.SinglePageMode)
               {
                  this.LastPageNumber = this.FirstPageNumber;
               }
               else
               {
                  this.LastPageNumber = Math.Max(1, Math.Min(this.PageCount, this.LastPageNumber));
                  if (this.LastPageNumber < this.FirstPageNumber)
                     this.LastPageNumber = this.FirstPageNumber;
               }

               if (this.ShowCurrentPageNumber)
                  _currentPageNumberLabel.Text = _currentPageNumberLabel.Text.Replace("###", this.FirstPageNumber.ToString());
               else
                  _currentPageNumberLabel.Visible = false;

               _firstPageNumberNumericUpDown.Value = this.FirstPageNumber;

               if (!this.SinglePageMode)
               {
                  _lastPageNumberNumericUpDown.Value = this.LastPageNumber;
                  _allPagesCheckBox.Checked = (this.FirstPageNumber == 1 && this.LastPageNumber == this.PageCount);
               }
            }
            else
            {
               _pagesLabel.Visible = false;
               _lastPageCheckBox.Visible = true;
               _firstPageNumberNumericUpDown.Maximum = Int32.MaxValue;
               _currentPageNumberLabel.Visible = false;

               _firstPageNumberNumericUpDown.Value = this.FirstPageNumber;

               if (this.LastPageNumber == -1)
                  _lastPageNumberNumericUpDown.Value = this.FirstPageNumber;
               else
                  _lastPageNumberNumericUpDown.Value = this.LastPageNumber;

               _lastPageCheckBox.Checked = (this.LastPageNumber == -1);
               _allPagesCheckBox.Checked = (this.FirstPageNumber == 1 && this.LastPageNumber == -1);
            }
         }

         base.OnLoad(e);
      }

      private void _firstPageNumberNumericUpDown_ValueChanged(object sender, EventArgs e)
      {
         this.FirstPageNumber = (int)_firstPageNumberNumericUpDown.Value;

         if (!this.SinglePageMode && this.PageCount != -1)
         {
            if (this.LastPageNumber < this.FirstPageNumber)
               _lastPageNumberNumericUpDown.Value = this.FirstPageNumber;
         }
      }

      private void _lastPageNumberNumericUpDown_ValueChanged(object sender, EventArgs e)
      {
         this.LastPageNumber = (int)_lastPageNumberNumericUpDown.Value;
         if (this.FirstPageNumber > this.LastPageNumber)
            _firstPageNumberNumericUpDown.Value = this.LastPageNumber;
      }

      private void _allPagesCheckBox_CheckedChanged(object sender, EventArgs e)
      {
         _firstPageNumberNumericUpDown.Enabled = !_allPagesCheckBox.Checked;

         if (!this.SinglePageMode)
            _lastPageNumberNumericUpDown.Enabled = !_allPagesCheckBox.Checked;
         else
            _lastPageNumberNumericUpDown.Enabled = !_lastPageCheckBox.Checked;

         if (_lastPageCheckBox.Visible)
         {
            _lastPageCheckBox.Enabled = !_allPagesCheckBox.Checked;
            _lastPageNumberNumericUpDown.Enabled = !_lastPageCheckBox.Checked && !_allPagesCheckBox.Checked;
         }
      }

      private void _lastPageCheckBox_CheckedChanged(object sender, EventArgs e)
      {
         _lastPageNumberNumericUpDown.Enabled = !_lastPageCheckBox.Checked;
         if (!_lastPageCheckBox.Checked)
            this.LastPageNumber = (int)_lastPageNumberNumericUpDown.Value;
      }

      private void _okButton_Click(object sender, EventArgs e)
      {
         if (this.PageCount != -1)
         {
            if (_allPagesCheckBox.Checked)
            {
               this.FirstPageNumber = 1;
               this.LastPageNumber = this.PageCount;
            }
            else if (this.SinglePageMode)
            {
               this.LastPageNumber = this.FirstPageNumber;
            }
         }
         else
         {
            if (_allPagesCheckBox.Checked)
            {
               this.FirstPageNumber = 1;
               this.LastPageNumber = -1;
            }
            else if (_lastPageCheckBox.Checked)
            {
              this.LastPageNumber = -1;
            }
            else
            {
               if (this.FirstPageNumber > this.LastPageNumber)
               {
                  Helper.ShowWarning(this, "First page number must be less than or equal to last page number");
                  this._firstPageNumberNumericUpDown.Focus();
                  DialogResult = DialogResult.None;
               }
            }
         }
      }
   }
}
