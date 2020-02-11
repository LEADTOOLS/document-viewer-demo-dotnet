// *************************************************************
// Copyright (c) 1991-2019 LEAD Technologies, Inc.              
// All Rights Reserved.                                         
// *************************************************************
using System;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;
using System.Collections.Generic;

using Leadtools;
using Leadtools.Controls;
using Leadtools.Document.Viewer;
using Leadtools.Annotations.Engine;
using Leadtools.Annotations.Designers;
using Leadtools.Annotations.Rendering;
using Leadtools.Annotations.Automation;
using Leadtools.Annotations.WinForms;
using Leadtools.Demos;

namespace DocumentViewerDemo
{
   // Contains the annotations menu and toolbar part of the viewer
   public partial class MainForm
   {
      private void BindAnnotationsItems()
      {
         // Menu
         _commandsBinder.Items.Add(new CommandBinderItem
         {
            ToolStripItem = _annotationsToolStripMenuItem,
            UpdateVisible = true,
            CanRun = (DocumentViewer documentViewer, object value) =>
            {
               return documentViewer != null && documentViewer.HasDocument && documentViewer.Annotations != null;
            }
         });
         _commandsBinder.Items.Add(new CommandBinderItem { CommandName = DocumentViewerCommands.AnnotationsUserModeDesign, ToolStripItem = _userModeDesignToolStripMenuItem, UpdateChecked = true });
         _commandsBinder.Items.Add(new CommandBinderItem { CommandName = DocumentViewerCommands.AnnotationsUserModeRun, ToolStripItem = _userModeRunToolStripMenuItem, UpdateChecked = true });
         _commandsBinder.Items.Add(new CommandBinderItem { CommandName = DocumentViewerCommands.AnnotationsUserModeRender, ToolStripItem = _userModeRenderToolStripMenuItem, UpdateChecked = true });
         _commandsBinder.Items.Add(new CommandBinderItem { CommandName = DocumentViewerCommands.AnnotationsBringToFront, ToolStripItem = _alignBringToFrontToolStripMenuItem });
         _commandsBinder.Items.Add(new CommandBinderItem { CommandName = DocumentViewerCommands.AnnotationsSendToBack, ToolStripItem = _alignSendToBackToolStripMenuItem });
         _commandsBinder.Items.Add(new CommandBinderItem { CommandName = DocumentViewerCommands.AnnotationsBringToFirst, ToolStripItem = _alignBringToFirstToolStripMenuItem });
         _commandsBinder.Items.Add(new CommandBinderItem { CommandName = DocumentViewerCommands.AnnotationsSendToLast, ToolStripItem = _alignSendToLastToolStripMenuItem });
         _commandsBinder.Items.Add(new CommandBinderItem { CommandName = DocumentViewerCommands.AnnotationsFlip, ToolStripItem = _flipVerticalToolStripMenuItem });
         _commandsBinder.Items.Add(new CommandBinderItem { CommandName = DocumentViewerCommands.AnnotationsReverse, ToolStripItem = _flipHorizontalToolStripMenuItem });
         _commandsBinder.Items.Add(new CommandBinderItem { CommandName = DocumentViewerCommands.AnnotationsGroup, ToolStripItem = _groupSelectedObjectsToolStripMenuItem });
         _commandsBinder.Items.Add(new CommandBinderItem { CommandName = DocumentViewerCommands.AnnotationsUngroup, ToolStripItem = _groupUngroupToolStripMenuItem });
         _commandsBinder.Items.Add(new CommandBinderItem { CommandName = DocumentViewerCommands.AnnotationsLock, ToolStripItem = _securityLockToolStripMenuItem });
         _commandsBinder.Items.Add(new CommandBinderItem { CommandName = DocumentViewerCommands.AnnotationsUnlock, ToolStripItem = _securityUnlockToolStripMenuItem });
         _commandsBinder.Items.Add(new CommandBinderItem { CommandName = DocumentViewerCommands.AnnotationsResetRotatePoints, ToolStripItem = _resetRotatePointsToolStripMenuItem });
         _commandsBinder.Items.Add(new CommandBinderItem { CommandName = DocumentViewerCommands.AnnotationsAntiAlias, ToolStripItem = _antiAliasToolStripMenuItem });
         _commandsBinder.Items.Add(new CommandBinderItem { CommandName = DocumentViewerCommands.AnnotationsProperties, ToolStripItem = _annotationsPropertiesToolStripMenuItem });
         _commandsBinder.Items.Add(new CommandBinderItem { CommandName = DocumentViewerCommands.AnnotationsUseRotateThumbs, ToolStripItem = _behaviorUseRotateThumbsToolStripMenuItem });
         _commandsBinder.Items.Add(new CommandBinderItem { CommandName = DocumentViewerCommands.AnnotationsEnableToolTips, ToolStripItem = _behaviorEnableToolTipToolStripMenuItem });
         _commandsBinder.Items.Add(new CommandBinderItem { CommandName = DocumentViewerCommands.AnnotationsRenderOnThumbnails, ToolStripItem = _behaviorRenderOnThumbnailsToolStripMenuItem });

         // Toolbar
      }

      private void _annotationsToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
      {
         if (_automationManagerHelper == null)
            return;

         var designMode = (_automationManagerHelper.AutomationManager.UserMode == AnnUserMode.Design);

         // Only the user mode is available
         foreach (var item in _annotationsToolStripMenuItem.DropDownItems)
         {
            ToolStripMenuItem menuItem = item as ToolStripMenuItem;
            if (menuItem != null)
            {
               if (menuItem != _userModeToolStripMenuItem)
                  menuItem.Available = designMode;
            }
            else
            {
               ToolStripSeparator separator = item as ToolStripSeparator;
               separator.Available = designMode;
            }
         }
      }

      private void _behaviorToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
      {
         if (_automationManagerHelper == null)
            return;

         _behaviorDeselectOnDownToolStripMenuItem.Checked = _automationManagerHelper.AutomationManager.DeselectOnDown;
         _behaviorRestrictDesignersToolStripMenuItem.Checked = _automationManagerHelper.AutomationManager.RestrictDesigners;
         _behaviorRubberbandSelectToolStripMenuItem.Checked = !_automationManagerHelper.AutomationManager.ForceSelectionModifierKey;
      }

      private void _behaviorDeselectOnDownToolStripMenuItem_Click(object sender, EventArgs e)
      {
         if (_automationManagerHelper == null)
            return;

         _automationManagerHelper.AutomationManager.DeselectOnDown = !_automationManagerHelper.AutomationManager.DeselectOnDown;
      }

      private void _behaviorRestrictDesignersToolStripMenuItem_Click(object sender, EventArgs e)
      {
         if (_automationManagerHelper == null)
            return;

         _automationManagerHelper.AutomationManager.RestrictDesigners = !_automationManagerHelper.AutomationManager.RestrictDesigners;
      }

      private void _behaviorRubberbandSelectToolStripMenuItem_Click(object sender, EventArgs e)
      {
         if (_automationManagerHelper == null)
            return;

         _automationManagerHelper.AutomationManager.ForceSelectionModifierKey = !_automationManagerHelper.AutomationManager.ForceSelectionModifierKey;
      }

      private void _currentObjectToolStripMenuItem_Click(object sender, EventArgs e)
      {
         var automationManager = _automationManagerHelper.AutomationManager;
         using (var dlg = new CurrentObjectDialog(automationManager))
         {
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
               automationManager.CurrentObjectId = dlg.ObjectId;
               if (automationManager.CurrentObjectId == AnnObject.RubberStampObjectId)
                  automationManager.CurrentRubberStampType = dlg.RubberStampType;
            }
         }
      }

      // Automation manager helper
      private AutomationManagerHelper _automationManagerHelper;

      // Control to use when the a text object is being edited
      private AutomationTextBox _automationTextBox;

      // The annotations object lisy
      private AutomationObjectsListControl _automationObjectsList;

      // So we can switch the renderers when doing custom rendering more
      private Dictionary<int, IAnnObjectRenderer> _originalRenderers;
      private Dictionary<int, IAnnObjectRenderer> _renderModeRenderers;

      private void InitAutomation()
      {
         if (_documentViewer.Annotations == null)
            return;

         // Get the automation manager from the document viewer
         var automationManager = _documentViewer.Annotations.AutomationManager;
         automationManager.UserModeChanged += (sender, e) =>
         {
            // Hide show the toolbars
            _rightPanel.Visible = (automationManager.UserMode != AnnUserMode.Render);

            if (automationManager.UserMode == AnnUserMode.Render)
            {
               // Setup our custom renderer
               automationManager.RenderingEngine.Renderers = _renderModeRenderers;
            }
            else
            {
               automationManager.RenderingEngine.Renderers = _originalRenderers;
            }
         };

         // Create the manager helper. This sets the rendering engine
         _automationManagerHelper = new AutomationManagerHelper(automationManager);

         // Save the rendering engine
         _originalRenderers = automationManager.RenderingEngine.Renderers;
         // And create the render mode renderers, make a copy of it
         _renderModeRenderers = new Dictionary<int, IAnnObjectRenderer>();
         foreach (var item in _originalRenderers)
            _renderModeRenderers.Add(item.Key, item.Value);

         // Tell the document viewer that automation manager helper is created
         _documentViewer.Annotations.Initialize();

         // Update our automation objects (set transparency, etc)
         _automationManagerHelper.UpdateAutomationObjects();

         // Craete the toolbar
         _automationManagerHelper.ModifyToolBarParentVisiblity = true;
         _automationManagerHelper.CreateToolBar();
         var toolBar = _automationManagerHelper.ToolBar;
         toolBar.Dock = DockStyle.Fill;
         toolBar.AutoSize = true;
         toolBar.BorderStyle = BorderStyle.None;
         toolBar.Appearance = ToolBarAppearance.Flat;
         _annotationsToolBarPanel.Controls.Add(toolBar);
         toolBar.BringToFront();

         // Create the objects list
         _automationObjectsList = new AutomationObjectsListControl();

         if (_automationObjectsList != null)
         {
            _automationObjectsList.Dock = DockStyle.Fill;
            _automationObjectsList.BorderStyle = BorderStyle.None;
            _annotationsObjectsPanel.Controls.Add(_automationObjectsList);
            _automationObjectsList.BringToFront();
         }
      }

      private void UpdateAnnotationsControlsVisiblity()
      {
         if (_documentViewer.Annotations == null)
         {
            _annotationsToolStripMenuItem.Visible = false;
            _rightPanel.Visible = false;
         }
         else
         {
            _annotationsToolStripMenuItem.Visible = true;
            _rightPanel.Visible = (_documentViewer.Annotations.AutomationManager.UserMode != AnnUserMode.Render);

            bool isEnabled = (_documentViewer.Annotations.Automation != null);
            _annotationsToolStripMenuItem.Available = isEnabled;
            _rightPanel.Enabled = isEnabled;
         }
      }

      private void HandleCreateAutomation()
      {
         UpdateAnnotationsControlsVisiblity();

         if (!_documentViewer.HasDocument)
            return;

         // Get the automation object from the document viewer
         var automation = _documentViewer.Annotations.Automation;
         if (automation == null)
            return;

         // Optional: If the document is PDF then switch annotations to use PDF mode
         // This will instruct the document viewer to render automation in a similar manner to Adobe Acrobat where
         if (string.Compare(_documentViewer.Document.MimeType, "application/pdf", true) == 0)
         {
            automation.Manager.UsePDFMode = true;
         }
         else
         {
            automation.Manager.UsePDFMode = false;
         }

         var automationControl = _documentViewer.Annotations.AutomationControl;

         // Hook to the events
         automationControl.AutomationTransformChanged += automation_TransformChanged;
         automation.SetCursor += new EventHandler<AnnCursorEventArgs>(automation_SetCursor);
         automation.RestoreCursor += new EventHandler(automation_RestoreCursor);
         automation.ToolTip += new EventHandler<AnnToolTipEventArgs>(automation_ToolTip);
         automation.OnShowObjectProperties += new EventHandler<AnnAutomationEventArgs>(automation_OnShowObjectProperties);
         automation.OnShowContextMenu += new EventHandler<AnnAutomationEventArgs>(automation_OnShowContextMenu);
         automation.EditText += new EventHandler<AnnEditTextEventArgs>(automation_EditText);
         automation.EditContent += new EventHandler<AnnEditContentEventArgs>(automation_EditContent);
         automation.LockObject += new EventHandler<AnnLockObjectEventArgs>(automation_LockObject);
         automation.UnlockObject += new EventHandler<AnnLockObjectEventArgs>(automation_UnlockObject);
         automation.DeserializeObjectError += new EventHandler<AnnSerializeObjectEventArgs>(automation_DeserializeObjectError);

         var imageViewer = _documentViewer.View.ImageViewer;

         // Give it to the objects list

         if (_automationObjectsList != null)
         {
            _automationObjectsList.Automation = automation;
            _automationObjectsList.ImageViewer = imageViewer;
            _automationObjectsList.Populate();
         }
      }

      private void HandleDestroyAutomation()
      {
         if (!_documentViewer.HasDocument)
            return;

         RemoveAutomationTextBox(true);

         // Get the automation object from the document viewer
         var automation = _documentViewer.Annotations.Automation;
         if (automation == null)
            return;

         // Remove it to the objects list
         if (_automationObjectsList != null)
         {
            _automationObjectsList.Automation = null;
            _automationObjectsList.ImageViewer = null;
         }

         var imageViewer = _documentViewer.View.ImageViewer;

         var automationControl = _documentViewer.Annotations.AutomationControl;

         // Unhook from the events
         automationControl.AutomationTransformChanged -= automation_TransformChanged;
         automation.SetCursor -= new EventHandler<AnnCursorEventArgs>(automation_SetCursor);
         automation.RestoreCursor -= new EventHandler(automation_RestoreCursor);
         automation.ToolTip -= new EventHandler<AnnToolTipEventArgs>(automation_ToolTip);
         automation.OnShowObjectProperties -= new EventHandler<AnnAutomationEventArgs>(automation_OnShowObjectProperties);
         automation.OnShowContextMenu -= new EventHandler<AnnAutomationEventArgs>(automation_OnShowContextMenu);
         automation.EditText -= new EventHandler<AnnEditTextEventArgs>(automation_EditText);
         automation.EditContent -= new EventHandler<AnnEditContentEventArgs>(automation_EditContent);
         automation.LockObject -= new EventHandler<AnnLockObjectEventArgs>(automation_LockObject);
         automation.UnlockObject -= new EventHandler<AnnLockObjectEventArgs>(automation_UnlockObject);
         automation.DeserializeObjectError -= new EventHandler<AnnSerializeObjectEventArgs>(automation_DeserializeObjectError);
      }

      private void HandleContainersAddedOrRemoved()
      {
         if (_automationObjectsList != null)
            _automationObjectsList.Populate();
      }

      private void HandleAnnotationsPagesDisabledEnabled()
      {
         _automationObjectsList.HandleAnnotationsPagesDisabledEnabled();
      }

      private void automation_TransformChanged(object sender, EventArgs e)
      {
         if (_automationTextBox != null)
            RemoveAutomationTextBox(true);
      }

      private void automation_SetCursor(object sender, AnnCursorEventArgs e)
      {
         // If there's an interactive mode working and its not automation, then dont do anything
         var imageViewer = _documentViewer.View.ImageViewer;
         if (imageViewer.WorkingInteractiveMode != null && imageViewer.WorkingInteractiveMode.Id != DocumentViewer.AnnotationsInteractiveModeId)
            return;

         var automation = sender as AnnAutomation;
         Cursor newCursor = null;

         if (automation.ActiveContainer == null || !automation.ActiveContainer.IsEnabled)
         {
            newCursor = Cursors.Default;
         }
         else
         {
            switch (e.DesignerType)
            {
               case AnnDesignerType.Draw:
                  {
                     var allow = true;

                     var drawDesigner = automation.CurrentDesigner as AnnDrawDesigner;
                     if (drawDesigner != null && !drawDesigner.IsTargetObjectAdded && e.PointerEvent != null)
                     {
                        // See if we can draw or not
                        var container = automation.ActiveContainer;

                        allow = false;

                        if (automation.HitTestContainer(e.PointerEvent.Location, false) != null)
                           allow = true;
                     }

                     if (allow)
                     {
                        var annAutomationObject = automation.Manager.FindObjectById(e.Id);
                        if (annAutomationObject != null)
                           newCursor = annAutomationObject.DrawCursor as Cursor;
                     }
                     else
                     {
                        newCursor = Cursors.No;
                     }
                  }
                  break;

               case AnnDesignerType.Edit:
                  if (e.IsRotateCenter)
                     newCursor = AutomationManagerHelper.AutomationCursors[CursorType.RotateCenterControlPoint];
                  else if (e.IsRotateGripper)
                     newCursor = AutomationManagerHelper.AutomationCursors[CursorType.RotateGripperControlPoint];
                  else if (e.ThumbIndex < 0)
                  {
                     if (e.DragDropEvent != null && !e.DragDropEvent.Allowed)
                        newCursor = Cursors.No;
                     else
                        newCursor = AutomationManagerHelper.AutomationCursors[CursorType.SelectedObject];
                  }
                  else
                  {
                     newCursor = AutomationManagerHelper.AutomationCursors[CursorType.ControlPoint];
                  }
                  break;

               case AnnDesignerType.Run:
                  newCursor = AutomationManagerHelper.AutomationCursors[CursorType.Run];
                  break;

               default:
                  newCursor = AutomationManagerHelper.AutomationCursors[CursorType.SelectObject];
                  break;
            }
         }

         if (imageViewer.Cursor != newCursor)
            imageViewer.Cursor = newCursor;
      }

      private void automation_RestoreCursor(object sender, EventArgs e)
      {
         var imageViewer = _documentViewer.View.ImageViewer;
         var cursor = Cursors.Default;
         Cursor interactiveModeCursor = null;

         // See if we have an interactive mode, use its cursor

         // Is any working?
         if (imageViewer.WorkingInteractiveMode != null)
         {
            interactiveModeCursor = imageViewer.WorkingInteractiveMode.WorkingCursor;
         }
         // is any hit-testing?
         else if (imageViewer.HitTestStateInteractiveMode != null)
         {
            interactiveModeCursor = imageViewer.HitTestStateInteractiveMode.HitTestStateCursor;
         }
         // is any idle?
         else if (imageViewer.IdleInteractiveMode != null)
         {
            interactiveModeCursor = imageViewer.IdleInteractiveMode.IdleCursor;
         }

         if (interactiveModeCursor != null)
            cursor = interactiveModeCursor;

         if (imageViewer != null && imageViewer.Cursor != cursor)
         {
            imageViewer.Cursor = cursor;
         }
      }

      private void automation_ToolTip(object sender, AnnToolTipEventArgs e)
      {
         var imageViewer = _documentViewer.View.ImageViewer;
         if (e.AnnotationObject == null)
         {
            _automationManagerHelper.SetToolTip(null, string.Empty);
            return;
         }

         // If text, show the text value
         var textObject = e.AnnotationObject as AnnTextObject;
         if (textObject != null)
         {
            _automationManagerHelper.SetToolTip(imageViewer, textObject.Text);
            return;
         }

         // If ruler, show its length
         var rulerObject = e.AnnotationObject as AnnPolyRulerObject;
         if (rulerObject != null)
         {
            _automationManagerHelper.SetToolTip(imageViewer, rulerObject.GetRulerLengthAsString(1));
            return;
         }

         // If it has content, show that
         if (e.AnnotationObject.Metadata.ContainsKey(AnnObject.ContentMetadataKey))
         {
            var content = e.AnnotationObject.Metadata[AnnObject.ContentMetadataKey];
            _automationManagerHelper.SetToolTip(imageViewer, content);
            return;
         }

         // Optionally show its name ...
         /*
         var automationObject = _automationManagerHelper.AutomationManager.FindObjectById(e.AnnotationObject.Id);
         _automationManagerHelper.SetToolTip(imageViewer, automationObject.Name);
         */
      }

      private void automation_OnShowObjectProperties(object sender, AnnAutomationEventArgs e)
      {
         // Get the automation object from the document viewer
         var automation = _documentViewer.Annotations.Automation;
         if (automation == null)
            return;

         using (var dlg = new AutomationUpdateObjectDialog())
         {
            if (automation.CurrentEditObject != null)
            {
               var isSelectionObject = automation.CurrentEditObject is AnnSelectionObject;
               // If is is a text or selection , hide the content
               if (automation.CurrentEditObject is AnnTextObject || isSelectionObject)
               {
                  // if text object, we cannot do that. Ignore, the EditText will fire
                  dlg.SetPageVisible(AutomationUpdateObjectDialogPage.Content, false);

                  if (isSelectionObject)
                  {
                     dlg.SetPageVisible(AutomationUpdateObjectDialogPage.Reviews, false);
                  }
               }
            }

            dlg.UserName = _documentViewer.UserName;
            dlg.Automation = automation;
            dlg.ShowDialog(this);

            e.Cancel = !dlg.IsModified;
         }
      }

      private void automation_OnShowContextMenu(object sender, AnnAutomationEventArgs e)
      {
         var automation = _documentViewer.Annotations.Automation;
         if (automation == null)
            return;

         var imageViewer = _documentViewer.View.ImageViewer;

         var position = imageViewer.PointToClient(Cursor.Position);
         if (e != null && e.Object != null)
         {
            automation.Invalidate(LeadRectD.Empty);
            var automationObject = e.Object as AnnAutomationObject;
            if (automationObject != null)
            {
               var contextMenu = automationObject.ContextMenu as ObjectContextMenu;
               if (contextMenu != null)
               {
                  contextMenu.Automation = automation;
                  contextMenu.Show(imageViewer, position);
               }
            }
         }
         else
         {
            if (_viewContextMenu == null)
               _viewContextMenu = new UI.ViewContextMenu(_documentViewer, this.DoSelectAllText);

            _viewContextMenu.Show(imageViewer, position);
         }
      }

      private void automation_EditText(object sender, AnnEditTextEventArgs e)
      {
         var automation = _documentViewer.Annotations.Automation;
         if (automation == null)
            return;

         RemoveAutomationTextBox(true);

         if (e.TextObject == null)
            return;

         var imageViewer = _documentViewer.View.ImageViewer;

         _automationTextBox = new AutomationTextBox(imageViewer, automation, e, RemoveAutomationTextBox);

         // we haven't changed yet
         e.Cancel = true;
      }

      private void automation_EditContent(object sender, AnnEditContentEventArgs e)
      {
         var automation = _documentViewer.Annotations.Automation;
         if (automation == null)
            return;

         e.Cancel = true;

         RemoveAutomationTextBox(true);

         AnnObject targetObject = e.TargetObject;

         if (targetObject == null)
            return;

         // if text object, we cannot do that. Ignore, the EditText will fire
         var textObject = targetObject as AnnTextObject;
         if (textObject != null)
            return;

         if (sender is AnnDrawDesigner && targetObject.Id != AnnObject.StickyNoteObjectId)
            return;

         using (var dlg = new AutomationUpdateObjectDialog())
         {
            dlg.SetPageVisible(AutomationUpdateObjectDialogPage.Properties, false);
            dlg.SetPageVisible(AutomationUpdateObjectDialogPage.Reviews, false);
            dlg.TargetObject = targetObject;

            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
               e.Cancel = false;
               automation.InvalidateObject(targetObject);
            }
         }
      }

      private void RemoveAutomationTextBox(bool update)
      {
         if (_automationTextBox == null)
            return;

         _automationTextBox.Remove(update);
         _automationTextBox.Dispose();
         _automationTextBox = null;

         var automation = _documentViewer.Annotations.Automation;
         if (automation.CurrentEditObject != null)
            automation.InvalidateObject(automation.CurrentEditObject);
      }

      private void automation_LockObject(object sender, AnnLockObjectEventArgs e)
      {
         var automation = _documentViewer.Annotations.Automation;
         if (automation == null)
            return;

         using (var dlg = new AutomationPasswordDialog())
         {
            dlg.Lock = true;
            if (dlg.ShowDialog(this) == DialogResult.OK)
               e.Password = dlg.Password;
            else
               e.Cancel = true;
         }
      }

      private void automation_UnlockObject(object sender, AnnLockObjectEventArgs e)
      {
         var automation = _documentViewer.Annotations.Automation;
         if (automation == null)
            return;

         e.Cancel = true;
         using (var dlg = new AutomationPasswordDialog())
         {
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
               e.Object.Unlock(dlg.Password);
               if (e.Object.IsLocked)
                  UI.Helper.ShowWarning(this, "Invalid password");

               automation.Invalidate(LeadRectD.Empty);
            }
         }
      }

      private void automation_DeserializeObjectError(object sender, AnnSerializeObjectEventArgs e)
      {
         // In case you need to skip objects or create them yourself
         Debug.WriteLine("Object could not be de-serialized: {0}", e.TypeName);
         e.SkipObject = true;
      }

      private void _customizeRenderModeToolStripMenuItem_Click(object sender, EventArgs e)
      {
         using (var dlg = new UI.CustomRenderModeDialog())
         {
            dlg.AutomationManager = _automationManagerHelper.AutomationManager;
            dlg.AllRenderers = _originalRenderers;
            dlg.CurrentRenderers = _renderModeRenderers;

            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
               // Get the results
               _renderModeRenderers.Clear();
               foreach (var item in dlg.ResultRenderers)
                  _renderModeRenderers.Add(item.Key, item.Value);

               _documentViewer.View.Invalidate();
               if (_documentViewer.Thumbnails != null)
                  _documentViewer.Thumbnails.Invalidate();
            }
         }
      }

      private void _redactionOptionsToolStripMenuItem_Click(object sender, EventArgs e)
      {
         if (_cache == null)
         {
            UI.Helper.ShowInformation(this, "This feature is only available when a Document Cache is used");
            return;
         }

         using (var dlg = new DocumentRedactionOptionsDialog())
         {
            dlg.Options = _documentViewer.Document.Annotations.RedactionOptions.Clone();
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
               bool saveToCache = !_documentViewer.Document.Annotations.RedactionOptions.ViewOptions.Equals(dlg.Options.ViewOptions);
               _documentViewer.Document.Annotations.RedactionOptions = dlg.Options;
               if (saveToCache)
               {
                  try
                  {
                     var document = _documentViewer.Document;

                     // Since we are saving the document manually to the cache, update these values:
                     document.AutoSaveToCache = false;
                     document.AutoDeleteFromCache = false;

                     // If any of the annotation containers have been modified, save it into the document so the converter gets the latest version
                     var annotations = _documentViewer.Annotations;
                     if (annotations != null && annotations.IsContainerModified(0))
                     {
                        new BusyOperation<bool>("Updating the document annotations")
                        {
                           Begin = () =>
                           {
                              this.BeginBusyOperation();

                              ShowBusyDialog(false, "Updating the document annotations");
                           },

                           InThread = () =>
                           {
                              _documentViewer.PrepareToSave();
                              return true;
                           },

                           End = this.EndBusyOperation,

                           ThenInvoke = (result) =>
                           {
                              SaveDocumentToCache(_documentViewer.Document, false);
                              LoadDocumentFromCache(_documentViewer.Document.DocumentId);
                           },

                           Error = (Exception ex) =>
                           {
                              UI.Helper.ShowError(this, ex);
                           }
                        }
                        .Run(this);
                     }
                     else
                     {
                        // Save it directly
                        SaveDocumentToCache(_documentViewer.Document, false);
                        LoadDocumentFromCache(_documentViewer.Document.DocumentId);
                     }
                  }
                  catch (Exception ex)
                  {
                     UI.Helper.ShowError(this, ex);
                  }
               }
            }
         }
      }
   }
}
