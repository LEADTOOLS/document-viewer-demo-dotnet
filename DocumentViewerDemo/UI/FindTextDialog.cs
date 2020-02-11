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
using Leadtools.Document.Viewer;

namespace DocumentViewerDemo.UI
{
   public partial class FindTextDialog : Form
   {
      public FindTextDialog(DocumentViewer documentViewer)
      {
         InitializeComponent();

         _documentViewer = documentViewer;
      }

      private DocumentViewer _documentViewer;

      protected override void OnLoad(EventArgs e)
      {
         if (!DesignMode)
         {
            // Check if have a previous operation
            var findText = _documentViewer.Text.LastFindText;
            if (findText == null)
               findText = new DocumentViewerFindText();

            _matchCaseCheckBox.Checked = findText.MatchCase;
            _wholeWordsOnlyCheckBox.Checked = findText.WholeWordsOnly;

            _findTextBox.Text = findText.Text;
         }

         base.OnLoad(e);
      }

      private void _nextButton_Click(object sender, EventArgs e)
      {
         FindText(true);
      }

      private void _previousButton_Click(object sender, EventArgs e)
      {
         FindText(false);
      }

      private void FindText(bool findNext)
      {
         var text = _findTextBox.Text;
         if (string.IsNullOrEmpty(text))
            return;

         var findTextOptions = _documentViewer.Text.LastFindText;
         if (findTextOptions == null)
            findTextOptions = new DocumentViewerFindText();

         findTextOptions.Text = text;
         findTextOptions.SelectFirstResult = true;

         // Set both to true to highlight all results
         findTextOptions.FindAll = false;
         findTextOptions.RenderResults = false;

         findTextOptions.MatchCase = _matchCaseCheckBox.Checked;
         findTextOptions.WholeWordsOnly = _wholeWordsOnlyCheckBox.Checked;
         findTextOptions.Loop = true;

         // We search the whole document, or just one page (more combinations are possible)
         DocumentViewerTextPosition searchBoundsBegin = null;
         DocumentViewerTextPosition searchBoundsEnd = null;
         bool currentPageOnly = _currentPageOnlyCheckBox.Checked;
         int currentPage = _documentViewer.CurrentPageNumber;
         var firstPosition = DocumentViewerTextPosition.CreateBeginOfPage(currentPageOnly ? currentPage : 1);
         var lastPosition = DocumentViewerTextPosition.CreateEndOfPage(currentPageOnly ? currentPage : _documentViewer.PageCount);
         if (findNext)
         {
            searchBoundsBegin = firstPosition;
            searchBoundsEnd = lastPosition;
         }
         else
         {
            searchBoundsBegin = lastPosition;
            searchBoundsEnd = firstPosition;
         }
         findTextOptions.BeginPosition = searchBoundsBegin;
         findTextOptions.EndPosition = searchBoundsEnd;

         if (_documentViewer.Text.HasAnySelectedText)
         {
            // If we have a selection, we can start our search with the character after it (in direction of search,
            // as specified by beginPosition/endPosition)
            // If no selected text actually exists, search will default to beginPosition
            findTextOptions.Start = DocumentViewerFindTextStart.AfterSelection;
         }

         // Find out if this might take some time, if so, run it as a busy operation
         // Condition is we have a previous find, and we either have all text cached
         // or we have text for current page and the operation is in current page only
         var mightTakeTime = !_documentViewer.Text.HasDocumentPageText(0);
         if (mightTakeTime)
         {
            // is it same page and we have text for it?
            if (currentPageOnly && _documentViewer.Text.HasDocumentPageText(currentPage))
               mightTakeTime = false;
         }

         MainForm mainForm = this.Owner as MainForm;

         new BusyOperation<bool>("Find Text")
         {
            Begin = () =>
            {
               if (mightTakeTime)
               {
                  mainForm.BeginBusyOperation();
                  this.Enabled = false;
               }
            },

            InThread = () =>
            {
               _documentViewer.Text.ClearRenderedFoundText();
               var found = _documentViewer.Text.Find(findTextOptions) != null;
               return found;
            },

            End = () =>
            {
               if (mightTakeTime)
               {
                  mainForm.EndBusyOperation();

                  if (this.InvokeRequired)
                  {
                     BeginInvoke((MethodInvoker)delegate
                     {
                        this.Enabled = true;
                     });
                  }
                  else
                  {
                     this.Enabled = true;
                  }
               }
            },

            ThenInvoke = (bool textFound) =>
            {
               if (!textFound)
               {
                  // Check if we have all the text, if not, let the user know
                  var message = "Finished searching. No more results found";
                  if (!_documentViewer.Text.AutoGetText && !_documentViewer.Text.HasDocumentPageText(0))
                     message = Helper.AddTextNote(message, false);

                  Helper.ShowInformation(this, message);
               }
            },

            Error = (Exception ex) =>
            {
               Helper.ShowError(this, ex);
            }
         }
         .Run(this);
      }

      protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
      {
         if (keyData == Keys.Escape)
         {
            this.Close();
            return true;
         }

         return base.ProcessCmdKey(ref msg, keyData);
      }
   }
}
