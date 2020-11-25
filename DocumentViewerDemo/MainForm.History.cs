// *************************************************************
// Copyright (c) 1991-2020 LEAD Technologies, Inc.              
// All Rights Reserved.                                         
// *************************************************************
using Leadtools.Document;
using Leadtools.Document.Viewer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DocumentViewerDemo
{
   // Contains the history part of the viewer
   public partial class MainForm
   {
      // Contains the data for a document we opened
      private class HistoryItem
      {
         // If it is in the cache, this is the ID.
         // We can load this document using DocumentFactory.LoadFromCache
         public string DocumentId;

         // Or, if the document is not cached, here it is.
         // We will keep this document in the list and dispose it ourselves
         // We set this document directory in the viewer using DocumentViewer.SetDocument
         public LEADDocument Document;

         // Current selected attachment (if we have any)
         public int SelectedAttachmentIndex;
      }

      private void BindHistoryItems()
      {
         bool isHistoryAvailable = HasHistory;

         // Menu
         _commandsBinder.Items.Add(new CommandBinderItem
         {
            ToolStripItem = _previousDocumentToolStripMenuItem,
            CanRun = (DocumentViewer documentViewer, object value) =>
            {
               return CanNavigateHistoryBackward;
            }
         });
         _commandsBinder.Items.Add(new CommandBinderItem
         {
            ToolStripItem = _nextDocumentToolStripMenuItem,
            CanRun = (DocumentViewer documentViewer, object value) =>
            {
               return CanNavigateHistoryForward;
            }
         });

         _historyToolStripMenuItem.Available = isHistoryAvailable;

         // Toolbar
         _commandsBinder.Items.Add(new CommandBinderItem
         {
            ToolStripItem = _previousDocumentToolStripButton,
            CanRun = (DocumentViewer documentViewer, object value) =>
            {
               return CanNavigateHistoryBackward;
            }
         });
         _commandsBinder.Items.Add(new CommandBinderItem
         {
            ToolStripItem = _nextDocumentToolStripButton,
            CanRun = (DocumentViewer documentViewer, object value) =>
            {
               return CanNavigateHistoryForward;
            }
         });

         _mainToolStripSeparator5.Available = isHistoryAvailable;
         _previousDocumentToolStripButton.Available = isHistoryAvailable;
         _nextDocumentToolStripButton.Available = isHistoryAvailable;
      }

      // Maximum number of items in the document history. Minimum is 2.
      // Value of -1 means there is no limit on the number of items.
      // Values of 0 or 1 will disable history in the app.
      private int _historyMaxItems = -1;
      // Document history
      private List<HistoryItem> _history;
      // We are we in the history
      private int _historyIndex;
      // Next item to open (from forward/backward navigation)
      private int _historyNextIndex;
      private ViewerDocumentChangedCallback _documentChangedCallback;

      private void InitHistory()
      {
         // See if the app uses document history
         if (_historyMaxItems == -1 || _historyMaxItems > 1)
         {
            _history = new List<HistoryItem>();
            _historyIndex = 0;
            _historyNextIndex = -1;

            // Initialize the callback used by the app when a new document is set in the viewer
            _documentChangedCallback = new ViewerDocumentChangedCallback();
            _documentChangedCallback.Changing = HistoryDocumentChanging;
            _documentChangedCallback.Changed = HistoryDocumentChanged;
            _documentChangedCallback.Aborted = HistoryDocumentAborted;
         }
      }

      private bool HistoryDocumentChanging(DocumentViewer documentViewer, LEADDocument currentDocument, LEADDocument newDocument)
      {
         // This callback is invoked when a new document is set in the viewer. Gives us a chance to
         // update the history.
         // Return true to dispose the old document in the viewer, otherwise; false.

         // We should not dispose the old document when it is not in the cache

         if (currentDocument == null && newDocument == null)
            return true; // Nothing to do

         // This is the default behavior
         bool autoDisposeDocument = true;

         // Delete everything after current index if a new document is set (clear the history forward).
         if (_historyNextIndex == -1 && newDocument != null)
         {
            int removeCount = _history.Count - (_historyIndex + 1);
            if (removeCount > 0)
               RemoveHistoryItems(_historyIndex + 1, removeCount);
         }

         // Check if the document is cached
         bool isDocumentInCache = IsDocumentInCache(currentDocument);

         // Check if this is a new document being set or is it from backward/forward
         bool isDocumentInHistory = _historyIndex < _history.Count && IsSameHistoryDocument(_historyIndex, currentDocument);
         if (!isDocumentInHistory && currentDocument != null)
         {
            // See if we need to make room because we reached the limit
            if (_historyMaxItems > 1 && _history.Count >= _historyMaxItems)
            {
               RemoveHistoryItems(0, 1);

               if (_historyNextIndex != -1)
                  _historyNextIndex--;
            }

            // Now add the item
            var item = new HistoryItem();
            item.SelectedAttachmentIndex = -1;

            // If the document is in the cache, add its id only, otherwise, keep the whole document.
            if (isDocumentInCache)
            {
               item.DocumentId = currentDocument.DocumentId;
            }
            else
            {
               documentViewer.PrepareToSave();
               item.Document = currentDocument;
            }

            _history.Add(item);
         }

         // Update the indexes
         int saveCurrentIndex = _historyIndex;
         if (_historyNextIndex != -1)
         {
            // From forward/backward, go it and reset
            _historyIndex = _historyNextIndex;
            _historyNextIndex = -1;
         }
         else
         {
            _historyIndex = _history.Count;
         }

         if (newDocument == null)
         {
            // Means we closed the document, get the next one
            _historyIndex = saveCurrentIndex + 1;
         }

         if (currentDocument != null)
         {
            // If the document in the viewer has a cache then tell the viewer not to dispose it, we will take care of it ourselves 
            autoDisposeDocument = isDocumentInCache;

            // Update the selected attachment index if any
            int attachmentIndex = this.GetSelectedAttachmentIndex();
            HistoryItem item = FindHistoryItemForDocument(currentDocument);
            if (item != null)
               item.SelectedAttachmentIndex = attachmentIndex;
         }

         return autoDisposeDocument;
      }

      private void RemoveHistoryItems(int index, int count)
      {
         if (count == -1)
            count = _history.Count;

         if (count < 1)
            return;

         // We have to dispose the documents that we kept
         for (int i = index; i < (index + count); i++)
         {
            HistoryItem item = _history[i];
            if (item.Document != null)
            {
               item.Document.Dispose();
               item.Document = null;
            }
         }

         _history.RemoveRange(index, count);
      }

      private bool IsSameHistoryDocument(int index, LEADDocument document)
      {
         if (document == null || index < 0 || index >= _history.Count)
            return false;

         HistoryItem item = _history[index];
         return document == item.Document || document.DocumentId == item.DocumentId;
      }

      private void HistoryDocumentChanged(DocumentViewer documentViewer, LEADDocument document)
      {
         // Called when a new document has been set successfully in the viewer
         _historyNextIndex = -1;
      }

      private void HistoryDocumentAborted()
      {
         // Called when setting a new document has been aborted
         _historyNextIndex = -1;
      }

      private HistoryItem FindHistoryItemForDocument(LEADDocument document)
      {
         HistoryItem item = _history.Find(_item => _item.Document != null && (_item.Document == document || _item.DocumentId == document.DocumentId));
         return item;
      }

      private void HistoryDocumentSavedToCache(LEADDocument document)
      {
         // Called when the document is saved into the cache.
         // Update the document if it is in our list of items.

         if (!HasHistory)
            return;

         HistoryItem item = FindHistoryItemForDocument(document);
         if (item != null)
         {
            // We no longer need to keep track of the whole document since its saved into cache
            // Just the ID
            item.Document = null;
            item.DocumentId = document.DocumentId;
         }
      }

      private int GetAttachmentSelectedIndexForDocument(LEADDocument document)
      {
         if (!HasHistory)
            return -1;

         HistoryItem item = FindHistoryItemForDocument(document);
         if (item != null)
            return item.SelectedAttachmentIndex;

         return -1;
      }

      private void _previousDocumentToolStripMenuItem_Click(object sender, EventArgs e)
      {
         NavigateHistoryItem(true);
      }

      private void _nextDocumentToolStripMenuItem_Click(object sender, EventArgs e)
      {
         NavigateHistoryItem(false);
      }

      private void _previousDocumentToolStripButton_Click(object sender, EventArgs e)
      {
         NavigateHistoryItem(true);
      }

      private void _nextDocumentToolStripButton_Click(object sender, EventArgs e)
      {
         NavigateHistoryItem(false);
      }

      private bool HasHistory
      {
         get
         {
            return _historyMaxItems != -1 && _historyMaxItems > 1;
         }
      }

      private bool CanNavigateHistoryBackward
      {
         get
         {
            return HasHistory && _historyIndex > 0;
         }
      }

      private bool CanNavigateHistoryForward
      {
         get
         {
            return HasHistory && _historyIndex < (_history.Count - 1);
         }
      }

      private void NavigateHistoryItem(bool backward)
      {
         if ((backward && !CanNavigateHistoryBackward) || (!backward && !CanNavigateHistoryForward))
            return;

         // Get the index of the item and try to re-set this document in the viewer
         if (backward)
            _historyNextIndex = _historyIndex - 1;
         else
            _historyNextIndex = _historyIndex + 1;

         HistoryItem item = _history[_historyNextIndex];
         if (item.Document != null)
            this.FinishSetDocument(item.Document);
         else
            this.LoadDocumentFromCache(item.DocumentId);
      }
   }
}
