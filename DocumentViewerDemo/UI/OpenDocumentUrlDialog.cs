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
using Leadtools.Document;

namespace DocumentViewerDemo.UI
{
   public partial class OpenDocumentUrlDialog : Form
   {
      public OpenDocumentUrlDialog()
      {
         InitializeComponent();
      }

      public string DocumentUrl { get; set; }
      public string AnnotationsUrl { get; set; }
      public bool LoadEmbeddedAnnotations { get; set; }
      public int FirstPageNumber { get; set; }
      public int LastPageNumber { get; set; }

      private int _firstPageNumber;
      private int _lastPageNumber;

      protected override void OnLoad(EventArgs e)
      {
         if (!DesignMode)
         {
            _documentLocationTextBox.Text = !string.IsNullOrEmpty(this.DocumentUrl) ? this.DocumentUrl.Trim() : string.Empty;
            _annotationsLocationTextBox.Text = !string.IsNullOrEmpty(this.AnnotationsUrl) ? this.AnnotationsUrl.Trim() : string.Empty;

            if (this.AnnotationsUrl != null)
               _externalAnnotationsRadioButton.Checked = true;
            else if (this.LoadEmbeddedAnnotations)
               _embeddedAnnotationsRadioButton.Checked = true;
            else
               _noAnnotationsRadioButton.Checked = true;

            _firstPageNumber = this.FirstPageNumber;
            _lastPageNumber = this.LastPageNumber;
            if (_firstPageNumber == 0)
               _firstPageNumber = 1;
            if (_lastPageNumber == 0)
               _lastPageNumber = -1;

            UpdateUIState();
            _progressBar.Visible = false;
         }

         base.OnLoad(e);
      }

      protected override void OnFormClosing(FormClosingEventArgs e)
      {
         e.Cancel = _isLoading;
         base.OnFormClosing(e);
      }

      private void _locationTextBox_TextChanged(object sender, EventArgs e)
      {
         UpdateUIState();
      }

      private void _annotationsRadioButton_CheckedChanged(object sender, EventArgs e)
      {
         UpdateUIState();
      }

      private void UpdateUIState()
      {
         var externalAnnotations = _externalAnnotationsRadioButton.Checked;

         _externalAnnotationsLocationLabel.Enabled = externalAnnotations;
         _annotationsLocationTextBox.Enabled = externalAnnotations;

         var enableLoad =
            !string.IsNullOrEmpty(_documentLocationTextBox.Text) &&
            (!externalAnnotations || !string.IsNullOrEmpty(_annotationsLocationTextBox.Text));

         string pagesText;

         if (_firstPageNumber == 1 && _lastPageNumber == -1)
         {
            pagesText = "All pages";
         }
         else
         {
            if (_lastPageNumber == -1)
               pagesText = string.Format("From {0} to last page", _firstPageNumber);
            else
               pagesText = string.Format("From {0} to {1}", _firstPageNumber, _lastPageNumber);
         }

         _pagesLabel.Text = pagesText;

         _loadButton.Enabled = enableLoad;
      }

      private void _pagesButton_Click(object sender, EventArgs e)
      {
         using (var dlg = new PagesDialog())
         {
            dlg.SinglePageMode = false;
            dlg.ShowCurrentPageNumber = false;
            dlg.Operation = "load document";
            dlg.PageCount = -1;
            dlg.FirstPageNumber = _firstPageNumber;
            dlg.LastPageNumber = _lastPageNumber;
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
               _firstPageNumber = dlg.FirstPageNumber;
               _lastPageNumber = dlg.LastPageNumber;
               UpdateUIState();
            }
         }
      }

      private bool _isLoading;

      private void _loadButton_Click(object sender, EventArgs e)
      {
         Uri documentUri;
         Uri annotationsUri;
         bool loadEmbeddedAnnotations;

         // Get the URI
         try
         {
            documentUri = new Uri(_documentLocationTextBox.Text.Trim());

            if (_noAnnotationsRadioButton.Checked)
            {
               annotationsUri = null;
               loadEmbeddedAnnotations = false;
            }
            else if (_embeddedAnnotationsRadioButton.Checked)
            {
               annotationsUri = null;
               loadEmbeddedAnnotations = true;
            }
            else
            {
               annotationsUri = new Uri(_annotationsLocationTextBox.Text.Trim());
               loadEmbeddedAnnotations = false;
            }
         }
         catch (Exception ex)
         {
            Helper.ShowError(this, ex);
            return;
         }

         this.FirstPageNumber = _firstPageNumber;
         this.LastPageNumber = _lastPageNumber;

         _isCancelPending = false;
         _isLoading = false;
         var mainForm = this.Owner as MainForm;
         if (mainForm.LoadDocumentFromUri(this, documentUri, this.FirstPageNumber, this.LastPageNumber, annotationsUri, loadEmbeddedAnnotations))
         {
            // Means the main form has started loading the document
            _isLoading = true;
            _documentLocationGroupBox.Enabled = false;
            _annotationsGroupBox.Enabled = false;
            _progressBar.Visible = true;
         }
      }

      public void SetProgress(int percentage)
      {
         _progressBar.Value = percentage;
      }

      public void Finish(bool closeDialog)
      {
         _isLoading = false;

         if (closeDialog)
         {
            DialogResult = DialogResult.OK;
            Close();
         }
         else
         {
            _documentLocationGroupBox.Enabled = true;
            _annotationsGroupBox.Enabled = true;
            _progressBar.Visible = false;
         }
      }

      private bool _isCancelPending;
      public bool IsCancelPending
      {
         get { return _isCancelPending; }
      }

      private void _cancelButton_Click(object sender, EventArgs e)
      {
         if (_isLoading)
         {
            // Means we are loading, stop this dialog from closing and let main form knows
            DialogResult = DialogResult.None;
            _isCancelPending = true;
         }
      }
   }
}
