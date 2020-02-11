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
using System.Diagnostics;
using System.Drawing.Printing;

using Leadtools.Demos;
using Leadtools;
using Leadtools.Codecs;
using Leadtools.Caching;
using Leadtools.Document;
using Leadtools.Document.Viewer;
using Leadtools.Controls;
using Leadtools.Ocr;
using Leadtools.Document.Writer;
using Leadtools.Drawing;
using Leadtools.Annotations.Engine;
using Leadtools.Annotations.Rendering;
using System.Text.RegularExpressions;
using System.Drawing.Drawing2D;

namespace DocumentViewerDemo
{
   public partial class MainForm : Form
   {
      // This app preferences
      private Preferences _preferences;

      // Cache to use in this demo
      private ObjectCache _cache;

      // Preferences used when converting this document (Save)
      private DocumentConverterPreferences _converterPreferences;

      // This is the optional OCR engine used by this demo
      private IOcrEngine _ocrEngine;

      // The document viewer
      private DocumentViewer _documentViewer;

      // UI Command binder
      private CommandsBinder _commandsBinder;

      // View context menu
      private UI.ViewContextMenu _viewContextMenu = null;

      // Print page settings
      private PageSettings _pageSettings;

      // Add a logging line whenever a page renders
      private bool _countPageRenders = false;
      private SortedDictionary<int, int> _viewPageRendersByIndex;
      private SortedDictionary<int, int> _thumbnailsPageRendersByIndex;

      private DocumentTextImagesRecognitionMode _imagesRecognitionMode = DocumentTextImagesRecognitionMode.Auto;
      private DocumentTextExtractionMode _textExtractionMode = DocumentTextExtractionMode.Auto;

      private int _loadDocumentTimeoutMilliseconds = 0;
      private int _maximumImagePixelSize = 12288;

      public MainForm()
      {
         InitializeComponent();
      }

      protected override void OnLoad(EventArgs e)
      {
         if (!DesignMode)
         {
            try
            {
               InitDemo();
            }
            catch (Exception ex)
            {
               Messager.ShowError(this, ex);
               return;
            }
         }

         base.OnLoad(e);
      }

      protected override void OnFormClosed(FormClosedEventArgs e)
      {
         if (_documentViewer != null)
         {
            if (_documentViewer.Annotations != null)
               _preferences.EnableTooltips = _documentViewer.Annotations.AutomationManager.EnableToolTip;
         }

         _preferences.Save();
         _converterPreferences.Save();

         if (_documentViewer != null)
         {
            _documentViewer.Operation -= _documentViewer_Operation;

            _documentViewer.View.ImageViewer.PostRenderItem -= imageViewer_PostRenderItem;
            if (_documentViewer.Thumbnails != null)
               _documentViewer.Thumbnails.ImageViewer.PostRenderItem -= imageViewer_PostRenderItem;

            if (_preferences.ShowTextIndicators)
               _preferences.ShowTextIndicators = false;

            _documentViewer.Dispose();
         }

         if (_ocrEngine != null)
         {
            _ocrEngine.Dispose();
            _ocrEngine = null;
         }

         base.OnFormClosed(e);
      }

      private void InitDemo()
      {
         // Load the preferences
         _preferences = Preferences.Load();

         Messager.Caption = "C# Document Viewer Demo";
         Text = Messager.Caption;

         // Init the optional OCR engine used by this app
         InitOcrEngine();

         // Init the documents cache to use by this app
         InitCache();

         // Init the preferences used with the document converter (used on the save menu)
         InitDocumentsConverter();

         // Init the document viewer...
         InitDocumentViewer();
         InitAutomation();

         _commandsBinder = new CommandsBinder(_documentViewer);

         BindFileItems();
         BindEditItems();
         BindViewItems();
         BindPageItems();
         BindInteractiveItems();
         BindAnnotationsItems();

         _commandsBinder.BindActions(true);

         UpdateShowOperation();

         // Init the UI
         UpdateDocumentSetUIState();

         // Load the default document
         var defaultAnnotationsFileName = _preferences.LastAnnotationsFileName;
         var defaultDocumentFileName = _preferences.LastDocumentFileName;
         var defaultFirstPageNumber = _preferences.LastDocumentFirstPageNumber;
         var defaultLastPageNumber = _preferences.LastDocumentLastPageNumber;
         if (string.IsNullOrEmpty(defaultDocumentFileName) || !File.Exists(defaultDocumentFileName))
         {
            // Try our default image
#if LT_CLICKONCE
            defaultDocumentFileName = Path.Combine(Application.StartupPath, @"Documents\Leadtools.pdf");
#else
            defaultDocumentFileName = Path.Combine(DemosGlobal.ImagesFolder, @"Leadtools.pdf");
#endif // #if LT_CLICKONCE
            defaultAnnotationsFileName = null;
         }

         if (!string.IsNullOrEmpty(defaultAnnotationsFileName) && !File.Exists(defaultAnnotationsFileName))
            defaultAnnotationsFileName = null;

         if (!string.IsNullOrEmpty(defaultDocumentFileName) && File.Exists(defaultDocumentFileName))
         {
            BeginInvoke((MethodInvoker)delegate
            {
              var message = string.Format("Do you want to re-load the last document?{0}{0}{1}", Environment.NewLine, defaultDocumentFileName);
              if (Messager.ShowQuestion(this, message, MessageBoxButtons.YesNo) == DialogResult.Yes)
                 LoadDocumentFromFile(defaultDocumentFileName, defaultFirstPageNumber, defaultLastPageNumber, defaultAnnotationsFileName, _preferences.LastFileLoadEmbeddedAnnotations);
            });
         }

         // Init printing
         if (PrinterSettings.InstalledPrinters != null && PrinterSettings.InstalledPrinters.Count > 0)
            _pageSettings = new PageSettings();
      }

      private void CleanUp()
      {
         if (_automationManagerHelper != null)
            _automationManagerHelper.Dispose();
      }

      private void InitOcrEngine()
      {
         try
         {
            _ocrEngine = OcrEngineManager.CreateEngine(OcrEngineType.LEAD, false);

            // A child directory?
            var enginePath = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), @"LEADTOOLS\OcrLEADRuntime");
            if (!Directory.Exists(enginePath))
            {
               // No, perhaps in the registry then
               enginePath = null;
            }

#if LT_CLICKONCE
            _ocrEngine.Startup( null, null, null, Application.StartupPath + @"\OCR Engine" );
#else
            _ocrEngine.Startup(null, null, null, enginePath);
#endif // #if LT_CLICKONCE

         }
         catch (Exception ex)
         {
            UI.Helper.ShowWarning(this, string.Format("Failed to start the LEAD OCR engine. The demo will continue running without OCR functionality and you will not be able to parse text from non-document files such as TIFF or Raster PDF.\n\nError message:\n{0}", ex.Message));
         }
      }

      // Init the documents cache
      private void InitCache()
      {
         // This demo does not require cache, however, using cache will speed up loading of resources from a document with a large number of pages
         // Setup the cache directory
         var cacheDir = _preferences.CacheDir;
         if (!Directory.Exists(cacheDir))
            Directory.CreateDirectory(cacheDir);

         // Now setup a new LEADTOOLS file cache object and set it as the cache object to use from now on
         var cache = new FileCache();
         cache.CacheDirectory = cacheDir;
         _cache = cache;
      }

      private void InitDocumentsConverter()
      {
         // Load the converters preferences file
         DocumentConverterPreferences.DemoName = "Document Viewer Demo";
         DocumentConverterPreferences.XmlFileName = "DocumentViewerDemo_Converters";
         _converterPreferences = DocumentConverterPreferences.Load();

         // Create the rendering engine
         try
         {
            if (_converterPreferences.AnnRenderingEngine == null)
            {
               _converterPreferences.AnnRenderingEngine = new AnnWinFormsRenderingEngine();
               _converterPreferences.AnnRenderingEngine.Resources = Leadtools.Annotations.WinForms.Tools.LoadResources();
            }
         }
         catch { }

         // Initialize OCR engine
         _converterPreferences.OcrEngineInstance = this._ocrEngine;

         // Initialize the RasterCodecs instance
         _converterPreferences.RasterCodecsInstance = DocumentFactory.RasterCodecsTemplate;

         // Initialize the DocumentWriter instance
         _converterPreferences.DocumentWriterInstance = new DocumentWriter();
      }

      // Create the document viewer
      private void InitDocumentViewer()
      {
         var createOptions = new DocumentViewerCreateOptions();

         // Set the UI part where the main view is displayed
         createOptions.ViewContainer = _centerPanel;
         // Set the UI part where the thumbnails are displayed
         createOptions.ThumbnailsContainer = _thumbnailsTabPage;
         // Set the UI part where the bookmarks are displayed
         createOptions.BookmarksContainer = _bookmarksTabPage;
         createOptions.UseAnnotations = true;

         // Now create the viewer
         _documentViewer = DocumentViewerFactory.CreateDocumentViewer(createOptions);
         // Set the user name
         _documentViewer.UserName = Environment.UserName;
         // We prefer SVG viewing (if supported)
         _documentViewer.View.PreferredItemType = DocumentViewerItemType.Svg;

         var imageViewer = _documentViewer.View.ImageViewer;
         imageViewer.BackColor = SystemColors.AppWorkspace;

         // Helps with debugging of there was a rendering error
         imageViewer.RenderError += (sender, e) =>
         {
            var message = string.Format("Error during render item {0} part {1}: {2}",
               e.Item != null ? imageViewer.Items.IndexOf(e.Item) : -1,
               e.Part,
               e.Error.Message);
            _outputWindow.AddTextLine(message, UI.OutputWindow.LineStyle.Error);
         };

         _documentViewer.Text.AutoGetText = _preferences.AutoGetText;
         _documentViewer.Commands.Run(DocumentViewerCommands.InteractiveAutoPan);
         // Comment this to use the default SelectText interactive mode
         _documentViewer.Commands.Run(DocumentViewerCommands.InteractivePanZoom);

         // Set enable tooltip default value
         if (_documentViewer.Annotations != null)
            _documentViewer.Annotations.AutomationManager.EnableToolTip = _preferences.EnableTooltips;

         // See if we need to enable inertia scroll
         if (_preferences.EnableInertiaScroll)
            ToggleInertiaScroll(true);

         _documentViewer.Operation += _documentViewer_Operation;

         _documentViewer.View.ImageViewer.PostRenderItem += imageViewer_PostRenderItem;
         if (_documentViewer.Thumbnails != null)
            _documentViewer.Thumbnails.ImageViewer.PostRenderItem += imageViewer_PostRenderItem;
      }

      // Update the UI state of the app
      private void UpdateDocumentSetUIState()
      {
         var hasDocument = _documentViewer.HasDocument;

         if (hasDocument)
         {
            if (!_leftPanel.Visible)
               _leftPanel.Visible = true;

            if (!_centerPanel.Visible)
               _centerPanel.Visible = true;

            if (_documentViewer.Document.IsStructureSupported)
            {
               if (!_leftTabControl.TabPages.Contains(_bookmarksTabPage))
                  _leftTabControl.TabPages.Add(_bookmarksTabPage);
            }
            else
            {
               if (_leftTabControl.TabPages.Contains(_bookmarksTabPage))
                  _leftTabControl.TabPages.Remove(_bookmarksTabPage);
            }

            if (!_documentViewer.Document.IsReadOnly)
               _loadingThumbnailsProgressBar.Visible = false;

            UpdateAnnotationsControlsVisiblity();
         }
         else
         {
            _leftPanel.Visible = false;
            _rightPanel.Visible = false;
            _centerPanel.Visible = false;
         }

         UpdateUIState();
      }

      private void UpdateUIState()
      {
         _commandsBinder.Run();
      }

      private void LoadDocumentFromFile(string documentFileName, int firstPageNumber, int lastPageNumber, string annotationsFileName, bool loadEmbeddedAnnotations)
      {
         // This could take some time, so run it as a busy operation

         new BusyOperation<LEADDocument>("Load document from file")
         {
            Begin = () =>
            {
               this.BeginBusyOperation();

               string pagesMessage;
               if ((firstPageNumber == 0 && lastPageNumber == 0) || (firstPageNumber == 1 && lastPageNumber == -1))
               {
                  pagesMessage = string.Empty;
               }
               else
               {
                  if (lastPageNumber == 0 || lastPageNumber == -1)
                     pagesMessage = string.Format("{0}From page {1} to last page", Environment.NewLine, firstPageNumber);
                  else
                     pagesMessage = string.Format("{0}From page {1} to {2}", Environment.NewLine, firstPageNumber, lastPageNumber);
               }

               string annotationsMessage;
               if (annotationsFileName != null)
                  annotationsMessage = string.Format("{0}With annotations from {1}", Environment.NewLine, annotationsFileName);
               else if (loadEmbeddedAnnotations)
                  annotationsMessage = string.Format("{0}With embedded annotations if exist", Environment.NewLine);
               else
                  annotationsMessage = string.Format("{0}With no annotations", Environment.NewLine);

               string message = string.Format("Loading document from {0}{1}{2}", documentFileName, pagesMessage, annotationsMessage);
               ShowBusyDialog(false, message);
            },

            InThread = () =>
            {
               // Setup the document load options
               var options = new LoadDocumentOptions();
               options.Cache = _cache;
               options.UseCache = _cache != null;
               options.TimeoutMilliseconds = _loadDocumentTimeoutMilliseconds;
               options.MaximumImagePixelSize = _maximumImagePixelSize;

               if (annotationsFileName != null)
                  options.AnnotationsUri = new Uri(annotationsFileName);
               else
                  options.AnnotationsUri = null;

               options.LoadEmbeddedAnnotations = loadEmbeddedAnnotations;
               options.FirstPageNumber = firstPageNumber;
               options.LastPageNumber = lastPageNumber;
               return DocumentFactory.LoadFromFile(documentFileName, options);
            },

            End = this.EndBusyOperation,

            ThenInvoke = (LEADDocument document) =>
            {
               try
               {
                  if (document != null)
                  {
                     // Auto-delete from cache when its disposed
                     document.AutoDeleteFromCache = true;
                     SetDocument(document);
                     // On success, set it as the last document file we opened
                     _preferences.LastDocumentFileName = documentFileName;
                     _preferences.LastDocumentFirstPageNumber = firstPageNumber;
                     _preferences.LastDocumentLastPageNumber = lastPageNumber;
                     _preferences.LastAnnotationsFileName = annotationsFileName;
                     _preferences.LastFileLoadEmbeddedAnnotations = loadEmbeddedAnnotations;
                  }
                  else
                  {
                     UI.Helper.ShowError(this, "Loading document timed-out");
                  }
               }
               catch (Exception ex)
               {
                  UI.Helper.ShowError(this, ex);
               }
            },

            Error = (Exception ex) =>
            {
               UI.Helper.ShowError(this, ex);
            }
         }
         .Run(this);
      }

      public bool LoadDocumentFromUri(UI.OpenDocumentUrlDialog dialog, Uri documentUri, int firstPageNumber, int lastPageNumber, Uri annotationsUri, bool loadEmbeddedAnnotations)
      {
         try
         {
            var options = new LoadDocumentAsyncOptions();

            // Setup the progress and completed event
            EventHandler<LoadAsyncProgressEventArgs> progress = null;
            EventHandler<LoadAsyncCompletedEventArgs> completed = null;

            progress = (sender, e) =>
            {
               dialog.SetProgress(e.ProgressPercentage);
               if (dialog.IsCancelPending)
                  e.IsCancelPending = true;
            };

            completed = (sender, e) =>
            {
               // Remove our events
               var thisOptions = sender as LoadDocumentAsyncOptions;
               thisOptions.Progress -= progress;
               thisOptions.Completed -= completed;

               if (e.Cancelled || e.Error != null)
               {
                  if (!e.Cancelled)
                     UI.Helper.ShowError(this, e.Error);

                  dialog.Finish(false);
                  return;
               }

               dialog.Finish(true);

               LEADDocument document = e.Document;
               if (document != null)
               {
                  // We have a document, set it
                  // Auto-delete from cache when its disposed
                  document.AutoDeleteFromCache = true;
                  SetDocument(document);
               }
               else
               {
                  UI.Helper.ShowError(this, "Loading document timed-out");
               }
            };

            options.Progress += progress;
            options.Completed += completed;

            options.FirstPageNumber = firstPageNumber;
            options.LastPageNumber = lastPageNumber;
            options.LoadEmbeddedAnnotations = loadEmbeddedAnnotations;
            options.AnnotationsUri = annotationsUri;
            options.Cache = _cache;
            options.UseCache = _cache != null;
            options.TimeoutMilliseconds = _loadDocumentTimeoutMilliseconds;
            options.MaximumImagePixelSize = _maximumImagePixelSize;
            DocumentFactory.LoadFromUriAsync(documentUri, options);
            _preferences.LastDocumentUri = documentUri.ToString();
            _preferences.LastDocumentUriFirstPageNumber = firstPageNumber;
            _preferences.LastDocumentUriLastPageNumber = lastPageNumber;
            _preferences.LastAnnotationsUri = annotationsUri != null ? annotationsUri.ToString() : null;
            _preferences.LastUriLoadEmbeddedAnnotations = loadEmbeddedAnnotations;

            return true;
         }
         catch (Exception ex)
         {
            UI.Helper.ShowError(this, ex);
            return false;
         }
      }

      private void LoadDocumentFromCache(string documentId)
      {
         // This could take some time, so run it as a busy operation

         new BusyOperation<LEADDocument>("Load document from cache")
         {
            Begin = () =>
            {
               this.BeginBusyOperation();

               string message = string.Format("Loading document {0} from the cache", documentId);

               ShowBusyDialog(false, message);
            },

            InThread = () =>
            {
               var loadFromCacheOptions = new LoadFromCacheOptions();
               loadFromCacheOptions.Cache = _cache;
               loadFromCacheOptions.DocumentId = documentId;
               loadFromCacheOptions.UserToken = null;
               return DocumentFactory.LoadFromCache(loadFromCacheOptions);
            },

            End = this.EndBusyOperation,

            ThenInvoke = (LEADDocument document) =>
            {
               if (document == null)
               {
                  UI.Helper.ShowError(this, string.Format("Document with ID '{0}' was not found in the cache or has been expired", documentId));
                  return;
               }

               try
               {
                  SetDocument(document);
               }
               catch (Exception ex)
               {
                  UI.Helper.ShowError(this, ex);
               }
            },

            Error = (Exception ex) =>
            {
               UI.Helper.ShowError(this, ex);
            }
         }
         .Run(this);
      }

      private void SaveDocumentToCache()
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
                     SaveDocumentToCache(_documentViewer.Document, true);
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
               SaveDocumentToCache(_documentViewer.Document, true);
            }
         }
         catch (Exception ex)
         {
            UI.Helper.ShowError(this, ex);
         }
      }

      private void SaveDocumentToCache(LEADDocument document, bool showInfoDialog)
      {
         document.SaveToCache();

         if (showInfoDialog)
         {
            using (var dlg = new UI.InputDialog())
            {
               dlg.IsReadOnly = true;
               dlg.Value = document.DocumentId;
               dlg.ValueDescription1 = "The document with the following ID has been successfully saved to the cache";
               dlg.ShowDialog(this);
            }
         }
      }

      private void SetDocument(LEADDocument document)
      {
         if (document.IsEncrypted && !document.IsDecrypted)
         {
            // This document requires a password
            DecryptDocument(document);

            // If still, then dispose it and dont set it
            if (document.IsEncrypted && !document.IsDecrypted)
            {
               document.Dispose();
               return;
            }
         }

         FinishSetDocument(document);
      }

      private void FinishSetDocument(LEADDocument document)
      {
         // If we have an OCR engine, use it
         document.Text.OcrEngine = _ocrEngine;
         document.Text.ImagesRecognitionMode = _imagesRecognitionMode;
         document.Text.TextExtractionMode = _textExtractionMode;

         // Set it in the document viewer
         _documentViewer.SetDocument(document);

         // Show the document name in the caption
         this.Text = string.Format("{0} - {1}", GetDocumentPath(_documentViewer.Document), Messager.Caption);

         // Update the UI
         UpdateDocumentSetUIState();
      }

      private static string GetDocumentPath(LEADDocument document)
      {
         string documentPath;

         var documentUri = document.Uri;
         if (documentUri != null)
         {
            if (documentUri.IsFile)
               documentPath = documentUri.LocalPath;
            else
               documentPath = documentUri.ToString();
         }
         else
         {
            documentPath = "[[Virtual]]";
         }

         return documentPath;
      }

      private void CloseDocument()
      {
         if (_documentViewer.Document == null)
            return;

         _documentViewer.SetDocument(null);

         this.Text = Messager.Caption;

         UpdateDocumentSetUIState();
      }

      private void DecryptDocument(LEADDocument document)
      {
         bool done = false;

         while (!done)
         {
            using (var dlg = new UI.InputDialog())
            {
               dlg.Text = "Enter Password";
               dlg.ValueTitle = null;
               dlg.ValueDescription1 = "This document is encrypted. Enter the password to decrypt it";
               dlg.IsPassword = true;
               if (dlg.ShowDialog(this) == DialogResult.OK)
               {
                  try
                  {
                     // Try the password
                     if (document.Decrypt(dlg.Value))
                     {
                        done = true;
                     }
                     else
                     {
                        UI.Helper.ShowError(this, "Invalid password");
                     }
                  }
                  catch (Exception ex)
                  {
                     UI.Helper.ShowError(this, ex);
                     done = true;
                  }
               }
               else
               {
                  // Use canceled, so they dont want to load it, return
                  done = true;
               }
            }
         }
      }

      private void _documentViewer_Operation(object sender, DocumentViewerOperationEventArgs e)
      {
         Action<DocumentViewerOperationEventArgs> updater = delegate (DocumentViewerOperationEventArgs args)
         {
            // If we have an error, show it
            if (args.Error != null)
            {
               var message = string.Format("Error in {0}{1} operation. {2}", args.IsPostOperation ? "Post-" : "Pre-", args.Operation, args.Error.Message);
               _outputWindow.AddTextLine(message, UI.OutputWindow.LineStyle.Error);
            }

            /* 
             * Updating the UI state is expensive - we check UI elements for their ability
             * to run commands based on the state of the DocumentViewer.
             * So we must approve each operation that we want to update the UI for.
             */
            bool updateUIState = false;
            /* 
             * Some operations don't need to be logged, either
             */
            bool logOperationsInfo = false;

            switch (args.Operation)
            {
               case DocumentViewerOperation.GetPage:
               case DocumentViewerOperation.GotoPage:
               case DocumentViewerOperation.GetAnnotations:
               case DocumentViewerOperation.RenderItemPlaceholder:
               case DocumentViewerOperation.AutomationStateChanged:
                  updateUIState = true;
                  break;
               case DocumentViewerOperation.RenderSelectedText:
                  if (args.IsPostOperation)
                     updateUIState = true;
                  break;
               default:
                  break;
            }

            var sb = new StringBuilder();
            var documentViewer = sender as DocumentViewer;
            var document = (documentViewer != null) ? documentViewer.Document : null;

            if (_preferences.ShowOperations)
               sb.AppendFormat("{0}{1} operation", args.IsPostOperation ? "Post-" : "Pre-", args.Operation);

            switch (args.Operation)
            {
               case DocumentViewerOperation.RunCommand:
                  updateUIState = true;
                  logOperationsInfo = true;
                  if (_preferences.ShowOperations)
                  {
                     var command = args.Data1 as DocumentViewerCommand;
                     sb.AppendFormat(" Command:{0}", command.Name);

                     if (args.IsPostOperation && command.Name == DocumentViewerCommands.InteractiveSelectText)
                     {
                        // Check if we have any text
                        CanPerformTextOperation("Cannot select text", true);
                     }
                  }
                  break;

               case DocumentViewerOperation.AttachToDocument:
                  if (!args.IsPostOperation)
                  {
                     _viewPageRendersByIndex = new SortedDictionary<int, int>();
                     _thumbnailsPageRendersByIndex = new SortedDictionary<int, int>();
                  }
                  break;

               case DocumentViewerOperation.LoadingThumbnails:
                  updateUIState = true;
                  logOperationsInfo = true;
                  if (!document.IsReadOnly)
                     _loadingThumbnailsProgressBar.Visible = !_documentViewer.Thumbnails.LazyLoad && !args.IsPostOperation;
                  break;

               case DocumentViewerOperation.LoadingAnnotations:
                  updateUIState = true;
                  logOperationsInfo = true;
                  _loadingAnnotationsProgressBar.Visible = !args.IsPostOperation;
                  break;

               case DocumentViewerOperation.PagesAdded:
               case DocumentViewerOperation.PagesRemoved:
                  updateUIState = true;
                  logOperationsInfo = true;
                  if (e.IsPostOperation)
                  {
                     if (_documentViewer.Annotations != null)
                        HandleContainersAddedOrRemoved();
                     UpdateDocumentSetUIState();
                  }
                  break;

               case DocumentViewerOperation.RenderViewPage:
               case DocumentViewerOperation.RenderThumbnailPage:
                  if (_countPageRenders && args.IsPostOperation)
                  {
                     var isView = args.Operation == DocumentViewerOperation.RenderViewPage;
                     var renders = isView ? _viewPageRendersByIndex : _thumbnailsPageRendersByIndex;
                     var index = args.PageNumber - 1;

                     if (renders.ContainsKey(index))
                     {
                        renders[index]++;
                     }
                     else
                     {
                        logOperationsInfo = true;
                        renders[index] = 1;
                        sb.AppendFormat(" First {0} Render for page {1}", isView ? "View" : "Thumbnails", args.PageNumber);
                     }
                  }
                  break;

               case DocumentViewerOperation.LoadingBookmarks:
                  updateUIState = true;
                  logOperationsInfo = true;
                  _loadingBookmarksProgressBar.Visible = !args.IsPostOperation;
                  break;

               case DocumentViewerOperation.GetText:
                  {
                     // Have to wait for it to finish. So show the busy dialog
                     if (!args.IsPostOperation)
                     {
                        if (_isInsideBusyOperation)
                        {
                           ShowBusyDialog(true, string.Format("Getting text for page {0}", args.PageNumber));
                        }
                        else
                        {
                           // This was not requested by us, cancel it and start to get the text ourselves
                           args.Abort = true;
                           this.BeginInvoke((MethodInvoker)delegate
                           {
                              GetPagesText(args.PageNumber);
                           });
                        }
                     }
                     else
                     {
                        updateUIState = true;
                        logOperationsInfo = true;

                        // When we are done, invalidate the items
                        if (args.PageNumber != 0)
                           _documentViewer.View.ImageViewer.InvalidateItemByIndex(args.PageNumber - 1);
                        else
                           _documentViewer.View.ImageViewer.Invalidate();

                        if (_documentViewer.Thumbnails != null)
                        {
                           if (args.PageNumber != 0)
                              _documentViewer.Thumbnails.ImageViewer.InvalidateItemByIndex(args.PageNumber - 1);
                           else
                              _documentViewer.Thumbnails.ImageViewer.Invalidate();
                        }
                     }
                  }
                  break;

               case DocumentViewerOperation.CreateAutomation:
                  // After the document viewer creates the automation object, we need to hook to some events
                  if (args.IsPostOperation)
                     HandleCreateAutomation();
                  break;

               case DocumentViewerOperation.DestroyAutomation:
                  // Before the document viewer destroys the automation object, we need to unhook from the events
                  if (!args.IsPostOperation)
                     HandleDestroyAutomation();
                  break;

               case DocumentViewerOperation.RunLink:
                  updateUIState = true;
                  logOperationsInfo = true;
                  if (args.IsPostOperation && args.Error == null)
                  {
                     // Get the link and check if its an external one
                     var link = (DocumentLink)args.Data1;
                     if (link.LinkType == DocumentLinkType.Value && !string.IsNullOrEmpty(link.Value))
                     {
                        sb.AppendFormat(" Running link value:" + link.Value);
                        RunValueLink(link.Value);
                     }
                  }
                  break;

               case DocumentViewerOperation.HoverLink:
                  updateUIState = true;
                  logOperationsInfo = true;
                  if (args.IsPostOperation)
                  {
                     if (args.Data1 != null)
                     {
                        // We are hovered over a new link, can show a tooltip for example
                        // This demo will just dump the link info

                        var link = (DocumentLink)args.Data1;

                        if (link.LinkType == DocumentLinkType.TargetPage)
                           sb.AppendFormat(" Link with target page {0}", link.Target.PageNumber);
                        else
                           sb.AppendFormat(" Link with value {0}", link.Value);
                     }
                     else
                     {
                        // We are not hovering over any links any more, can hide the tooltip for example
                        sb.Append(" No link");
                     }
                  }
                  break;

               case DocumentViewerOperation.PagesDisabledEnabled:
                  updateUIState = true;
                  logOperationsInfo = true;
                  if (args.IsPostOperation)
                  {
                     HandleAnnotationsPagesDisabledEnabled();
                  }
                  break;

               case DocumentViewerOperation.CurrentPageNumberChanged:
                  if (args.IsPostOperation)
                  {
                     updateUIState = true;
                     // Change to `true` to log page change info
                     //logOperationsInfo = true;
                     CurrentPageNumberChangeData currentPageData = args.Data1 as CurrentPageNumberChangeData;
                     if (logOperationsInfo && currentPageData != null)
                        sb.AppendFormat(" from {0} to {1} because of {2}", currentPageData.OldCurrentPageNumber, currentPageData.NewCurrentPageNumber, currentPageData.Cause.ToString());
                     UpdateCurrentPageNumber(currentPageData);
                  }
                  break;

               default:
                  break;
            }

            if (_preferences.ShowOperations && logOperationsInfo)
               _outputWindow.AddTextLine(sb.ToString());

            if (args.IsPostOperation && updateUIState)
               UpdateUIState();
         };

         // Try to abort before doing anything
         if (_isInsideBusyOperation)
         {
            if (IsBusyDialogCancelled)
               e.Abort = true;
         }

         if (this.InvokeRequired)
            this.BeginInvoke((Action<DocumentViewerOperationEventArgs>)updater, new object[] { e });
         else
            updater(e);
      }

      private UI.BusyDialog _busyDialog;
      private bool _isInsideBusyOperation;
      private Form _busyDialogActiveForm;

      public void BeginBusyOperation()
      {
         // Get ready ...
         _isInsideBusyOperation = true;
         this.Enabled = false;
      }

      public void EndBusyOperation()
      {
         if (this.InvokeRequired)
         {
            BeginInvoke(new MethodInvoker(EndBusyOperation));
            return;
         }

         if (_isInsideBusyOperation)
         {
            _isInsideBusyOperation = false;

            this.Enabled = true;

            HideBusyDialog();
         }
      }

      private void ShowBusyDialog(bool enableCancellation, string description)
      {
         if (_busyDialog == null)
         {
            _busyDialog = new UI.BusyDialog();
            _busyDialog.Text = Messager.Caption;
            _busyDialog.EnableCancellation = enableCancellation;

            _busyDialogActiveForm = Form.ActiveForm;

            if (_busyDialogActiveForm == null)
               _busyDialog.Show(this);
            else
               _busyDialog.Show(_busyDialogActiveForm);
         }

         _busyDialog.UpdateDescription(description);
      }

      private void HideBusyDialog()
      {
         if (_busyDialog == null)
            return;

         _busyDialog.IsWorking = false;
         _busyDialog.Dispose();
         _busyDialog = null;

         if (_busyDialogActiveForm != null)
         {
            _busyDialogActiveForm.Activate();
            _busyDialogActiveForm = null;
         }
      }

      private bool IsBusyDialogCancelled
      {
         get { return _busyDialog != null && _busyDialog.IsCancelled; }
      }

      private void ShowDocumentProperties()
      {
         using (var dlg = new UI.DocumentPropertiesDialog())
         {
            dlg.Document = _documentViewer.Document;
            dlg.ShowDialog(this);
         }
      }

      private void ToggleInertiaScroll(bool turnOn)
      {
         // These commands have ImageViewerPanZoomInteractiveMode in the tag, update the value
         string[] commandNames = { DocumentViewerCommands.InteractivePanZoom, DocumentViewerCommands.InteractivePan };
         foreach (var commandName in commandNames)
         {
            var mode = _documentViewer.Commands.GetCommand(commandName).Tag as ImageViewerPanZoomInteractiveMode;
            if (mode != null)
            {
               var options = mode.InertiaScrollOptions;
               options.IsEnabled = turnOn ? true : !options.IsEnabled;
               mode.InertiaScrollOptions = options;
               _preferences.EnableInertiaScroll = options.IsEnabled;
            }
         }
      }

      private void UpdateShowOperation()
      {
         if (_preferences.ShowOperations)
         {
            _bottomPanel.Visible = true;
         }
         else
         {
            _bottomPanel.Visible = false;
         }
      }

      public bool CanPerformTextOperation(string operation, bool noPages)
      {
         if (!_documentViewer.Text.AutoGetText && !_documentViewer.Text.HasAnyDocumentPageText())
         {
            // This means auto-get text is off and we never got any text, warn the user
            var message = UI.Helper.AddTextNote(operation, noPages);
            UI.Helper.ShowInformation(this, message);
            return false;
         }

         return true;
      }

      private void UpdateShowTextIndicators()
      {
         _documentViewer.View.Invalidate();
         if (_documentViewer.Thumbnails != null)
            _documentViewer.Thumbnails.Invalidate();
      }

      private static Brush _alphaBrush = new SolidBrush(Color.FromArgb(128, Color.White));
      private static Font _hasTextFont = new Font("Arial", 12, FontStyle.Bold);
      private static Font _noTextFont = new Font("Arial", 12, FontStyle.Regular);

      private void imageViewer_PostRenderItem(object sender, ImageViewerRenderEventArgs e)
      {
         LEADDocument document = _documentViewer.Document;
         if (document == null)
            return;

         ImageViewer imageViewer = sender as ImageViewer;
         bool isView = imageViewer == _documentViewer.View.ImageViewer;

         bool showTextIndicators = _preferences.ShowTextIndicators;
         var pageNumber = imageViewer.Items.IndexOf(e.Item) + 1;
         DocumentPage page = document.Pages[pageNumber - 1];

         var isDisabled = page.IsDeleted;

         if (!showTextIndicators && !isDisabled)
            return;

         var graphics = e.PaintEventArgs.Graphics;
         var transform = imageViewer.GetItemImageTransform(e.Item);
         var imageSize = e.Item.ImageSize;
         var bounds = LeadRectD.Create(0, 0, imageSize.Width, imageSize.Height);
         LeadPointD[] corners =
         {
            LeadPointD.Create(bounds.Left, bounds.Top),
            LeadPointD.Create(bounds.Right, bounds.Top),
            LeadPointD.Create(bounds.Right, bounds.Bottom),
            LeadPointD.Create(bounds.Left, bounds.Bottom),
         };

         transform.TransformPoints(corners);

         if (showTextIndicators)
         {
            // render a small T at the top-right corner
            var hasText = _documentViewer.Text.HasDocumentPageText(pageNumber);

            // Get the top-right point
            LeadPointD topRight = corners[0];
            for (var i = 1; i < corners.Length; i++)
            {
               if (corners[i].X > topRight.X)
                  topRight.X = corners[i].X;
               if (corners[i].Y < topRight.Y)
                  topRight.Y = corners[i].Y;
            }

            var text = "T";
            var font = hasText ? _hasTextFont : _noTextFont;
            var textSize = graphics.MeasureString(text, font);
            var rect = new Rectangle((int)((float)topRight.X - textSize.Width + 0.5), (int)((float)topRight.Y + 0.5), (int)(textSize.Width + 0.5f), (int)(textSize.Height + 0.5f));

            graphics.FillRectangle(_alphaBrush, rect);

            var textColor = hasText ? Color.Blue : Color.Gray;
            TextRenderer.DrawText(graphics, text, font, rect, textColor, Color.Transparent);
         }

         if (isDisabled)
         {
            double size = isView ? 30 : 20;
            LeadRectD transformedBounds = GeometryTools.GetBoundingRect(corners);
            if (isView)
            {
               // Keep the size reasonable when the page scales
               size = GetScaledRender(bounds, .2, size);
            }

            // Get the top-right point
            LeadPointD topLeft = corners[0];
            for (var i = 1; i < corners.Length; i++)
            {
               if (corners[i].X < topLeft.X)
                  topLeft.X = corners[i].X;
               if (corners[i].Y < topLeft.Y)
                  topLeft.Y = corners[i].Y;
            }

            var triangleLength = (size * 1.8);
            using (var path = new GraphicsPath())
            {
               path.AddLine((float)topLeft.X, (float)topLeft.Y, (float)(topLeft.X + triangleLength), (float)topLeft.Y);
               path.AddLine((float)(topLeft.X + triangleLength), (float)topLeft.Y, (float)topLeft.X, (float)(topLeft.Y + triangleLength));
               path.CloseFigure();

               graphics.FillPath(Brushes.DarkRed, path);
            }

            Bitmap disabledPageBitmap = Properties.Resources.DisabledPage;
            graphics.DrawImage(disabledPageBitmap, (float)topLeft.X, (float)topLeft.Y, (float)triangleLength / 2.0f, (float)triangleLength / 2.0f);
            graphics.FillRectangle(_alphaBrush, (float)transformedBounds.X, (float)transformedBounds.Y, (float)transformedBounds.Width, (float)transformedBounds.Height);
         }
      }

      private static double GetScaledRender(LeadRectD bounds, double maxSizeRatio, double original)
      {
         var shortSide = Math.Min(bounds.Width, bounds.Height);
         var sizeRatio = Math.Min(maxSizeRatio, original / shortSide);
         original = sizeRatio * shortSide;
         return original;
      }

      private void SaveDocument()
      {
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
                  SaveDocument(_documentViewer.Document);
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
            SaveDocument(_documentViewer.Document);
         }
      }

      private void SaveDocument(LEADDocument document)
      {
         var run = false;

         // Collect the options
         using (var dlg = new DocumentConverterDialog())
         {
            dlg.Preferences = _converterPreferences.Clone();
            dlg.InputDocument = document;
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
               run = true;
               _converterPreferences = dlg.Preferences.Clone();
            }
         }

         // Run it
         if (run)
         {
            using (var dlg = new UI.DocumentConverterRunner())
            {
               dlg.Preferences = _converterPreferences;
               dlg.InputDocument = document;
               dlg.Cache = _cache;
               dlg.ShowDialog(this);
            }
         }
      }

      private static readonly Regex _emailRegex = new Regex(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?");

      private void RunValueLink(string linkValue)
      {
         // Check if this is an email address
         if (!linkValue.ToLower().StartsWith("mailto:") && _emailRegex.IsMatch(linkValue))
         {
            // Yes,
            linkValue = "mailto:" + linkValue;
         }

         var hasRun = false;

         try
         {
            // Try default
            Process.Start(linkValue);
            hasRun = true;
         }
         catch
         {
         }

         if (!hasRun)
         {
            // Error, ask use what to do with this, application
            using (var dlg = new UI.LinkValueDialog())
            {
               dlg.LinkValue = linkValue;
               dlg.ShowDialog(this);
            }
         }
      }

      private bool CheckPrinters()
      {
         if (_pageSettings == null)
         {
            UI.Helper.ShowError(this, "No printers were found on this machine. Install a printer then try again");
            return false;
         }

         return true;
      }

      private void PrintSetup()
      {
         if (!CheckPrinters())
            return;

         using (var dlg = new PageSetupDialog())
         {
            dlg.PageSettings = _pageSettings;
            dlg.ShowDialog();
         }
      }

      private void PrintDocument()
      {
         if (!CheckPrinters())
            return;

         var pageCount = _documentViewer.PageCount;
         if (pageCount == 0)
            return;

         using (var printDocument = new PrintDocument())
         {
            printDocument.PrinterSettings.MinimumPage = 1;
            printDocument.PrinterSettings.MaximumPage = pageCount;
            printDocument.PrinterSettings.FromPage = 1;
            printDocument.PrinterSettings.ToPage = pageCount;
            printDocument.DefaultPageSettings = _pageSettings;

            using (var dlg = new PrintDialog())
            {
               dlg.Document = printDocument;
               dlg.PrinterSettings = printDocument.PrinterSettings;
               dlg.AllowCurrentPage = true;
               dlg.AllowSomePages = true;
               if (dlg.ShowDialog(this) != DialogResult.OK)
               {
                  return;
               }
            }

            var document = _documentViewer.Document;
            AnnRenderingEngine annRenderingEngine = null;
            if (_documentViewer.Annotations != null && _documentViewer.Annotations.AutomationManager != null)
               annRenderingEngine = _documentViewer.Annotations.AutomationManager.RenderingEngine;

            var pageNumber = printDocument.PrinterSettings.FromPage;

            PrintPageEventHandler printPageHandler = (sender, e) =>
            {
               // Print next undeleted page
               DocumentPage page = null;
               do
               {
                  page = document.Pages[pageNumber - 1];
                  if (page.IsDeleted)
                  {
                     page = null;
                     pageNumber++;
                  }
               }
               while (page == null && pageNumber <= printDocument.PrinterSettings.ToPage);

               if (page != null)
               {
                  PrintPage(document, pageNumber, annRenderingEngine, printDocument, e);
                  pageNumber++;
               }

               e.HasMorePages = (pageNumber <= printDocument.PrinterSettings.ToPage);
               if (!e.HasMorePages)
                  pageNumber = 1;
            };

            printDocument.PrintPage += printPageHandler;

            try
            {

               using (var dlg = new PrintPreviewDialog())
               {
                  dlg.Document = printDocument;
                  dlg.ShowDialog(this);
               }
            }
            catch (Exception ex)
            {
               UI.Helper.ShowError(this, ex);
            }
            finally
            {
               printDocument.PrintPage -= printPageHandler;
            }
         }
      }

      private void PrintPage(LEADDocument document, int pageNumber, AnnRenderingEngine annRenderingEngine, PrintDocument printDocument, PrintPageEventArgs e)
      {
         var page = document.Pages[pageNumber - 1];

         // Get page size in pixels
         var pixelSize = document.SizeToPixels(page.Size);
         // Convert to DPI
         var size = LeadSizeD.Create(pixelSize.Width * 96.0 / page.Resolution, pixelSize.Height * 96.0 / page.Resolution).ToLeadSize();
         // Fit in the margin bounds
         var destRect = LeadRect.Create(e.MarginBounds.X, e.MarginBounds.Y, e.MarginBounds.Width, e.MarginBounds.Height);
         destRect = RasterImage.CalculatePaintModeRectangle(
            size.Width,
            size.Height,
            destRect,
            RasterPaintSizeMode.Fit,
            RasterPaintAlignMode.Center,
            RasterPaintAlignMode.Center);

         // Get the page image
         using (var rasterImage = page.GetImage())
         {
            // Render annotations
            if (annRenderingEngine != null)
            {
               var annContainer = page.GetAnnotations(false);
               if (annContainer != null)
                  annRenderingEngine.RenderOnImage(annContainer, rasterImage);
            }

            // Convert to GDI+ bitmap and print it
            using (var bitmap = RasterImageConverter.ConvertToImage(rasterImage, ConvertToImageOptions.None))
            {
               e.Graphics.DrawImage(bitmap, destRect.X, destRect.Y, destRect.Width, destRect.Height);
            }
         }
      }
   }
}
