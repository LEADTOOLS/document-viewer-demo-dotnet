// *************************************************************
// Copyright (c) 1991-2019 LEAD Technologies, Inc.              
// All Rights Reserved.                                         
// *************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Leadtools.Demos;
using Leadtools.Document;

namespace DocumentViewerDemo.UI
{
   public partial class OpenDocumentFileDialog : Form
   {
      public string DocumentFileName { get; set; }
      public string AnnotationsFileName { get; set; }
      public bool LoadEmbeddedAnnotations { get; set; }
      public int FirstPageNumber { get; set; }
      public int LastPageNumber { get; set; }

      private int _firstPageNumber;
      private int _lastPageNumber;

      public OpenDocumentFileDialog()
      {
         InitializeComponent();
      }

      protected override void OnLoad(EventArgs e)
      {
         if (!DesignMode)
         {
            _documentLocationTextBox.Text = !string.IsNullOrEmpty(this.DocumentFileName) ? this.DocumentFileName.Trim() : string.Empty;
            _annotationsLocationTextBox.Text = !string.IsNullOrEmpty(this.AnnotationsFileName) ? this.AnnotationsFileName.Trim() : string.Empty;

            if (this.AnnotationsFileName != null)
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
         }

         base.OnLoad(e);
      }

      private void _documentLocationBrowseButton_Click(object sender, EventArgs e)
      {
         using (var dlg = new OpenFileDialog())
         {
            dlg.Filter = "All Files|*.*";
            dlg.Title = "Select Document File Name";
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
               _documentLocationTextBox.Text = dlg.FileName;
               _annotationsLocationTextBox.Text = string.Empty;

               // Check if there is a corresponding annotation file
               if (File.Exists(dlg.FileName))
               {
                  var annotationFileName = Path.ChangeExtension(dlg.FileName, "xml");
                  if (File.Exists(annotationFileName))
                  {
                     _annotationsLocationTextBox.Text = annotationFileName;
                     _externalAnnotationsRadioButton.Checked = true;
                  }
               }

               if (_externalAnnotationsRadioButton.Checked && string.IsNullOrEmpty(_annotationsLocationTextBox.Text))
                  _embeddedAnnotationsRadioButton.Checked = true;

               _firstPageNumber = 1;
               _lastPageNumber = -1;

               UpdateUIState();
            }
         }
      }

      private void _annotationsLocationBrowseButton_Click(object sender, EventArgs e)
      {
         using (var dlg = new OpenFileDialog())
         {
            dlg.Filter = "Annotation Files|*.xml|All Files|*.*";
            dlg.Title = "Select Annotations File Name";
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
               _annotationsLocationTextBox.Text = dlg.FileName;
               UpdateUIState();
            }
         }
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
         _annotationsLocationBrowseButton.Enabled = externalAnnotations;

         var enableOk =
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

         _okButton.Enabled = enableOk;
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

      private void _okButton_Click(object sender, EventArgs e)
      {
         this.DocumentFileName = _documentLocationTextBox.Text.Trim();
         this.FirstPageNumber = _firstPageNumber;
         this.LastPageNumber = _lastPageNumber;

         if (_noAnnotationsRadioButton.Checked)
         {
            this.AnnotationsFileName = null;
            this.LoadEmbeddedAnnotations = false;
         }
         else if (_embeddedAnnotationsRadioButton.Checked)
         {
            this.AnnotationsFileName = null;
            this.LoadEmbeddedAnnotations = true;
         }
         else
         {
            this.AnnotationsFileName = _annotationsLocationTextBox.Text.Trim();
            this.LoadEmbeddedAnnotations = false;
         }
      }
   }
}
