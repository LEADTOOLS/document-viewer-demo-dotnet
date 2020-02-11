namespace DocumentViewerDemo
{
   partial class MainForm
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            CleanUp();
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.components = new System.ComponentModel.Container();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
         this._mainMenuStrip = new System.Windows.Forms.MenuStrip();
         this._fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._openDocumentFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._openDocumentFromUrltoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._fileSep1ToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
         this._openFromCacheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._saveToCacheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._saveCurrentViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._fileSep2ToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
         this._exportTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._fileSep3ToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
         this._printSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._fileSep4ToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
         this._exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._editSep1ToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
         this._cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._editSep2ToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
         this._selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._selectAllAnnotationsToolStripMenuItemtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._clearSelectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._editSep3ToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
         this._findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._findNextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._findPreviousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._rotateVieweToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._clockwiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._counterClockwiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._viewSep1ToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
         this._zoomOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._zoomInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._viewSep2ToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
         this._actualSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._fitPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._fitWidthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._viewSep3ToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
         this._asSvgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._asImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._viewSep4ToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
         this._thumbnailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._bookmarksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._pageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._firstPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._previousPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._nextPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._lastPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._gotoPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._pageSep1ToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
         this._getCurrentPageTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._getAllPagesTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._pageSep2ToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
         this._rotatePageClockwiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._rotatePageCounterClockwiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._rotatePagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._pageSep3ToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
         this._enableDisablePageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._pageSep4ToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
         this._displayPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._singlePageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._verticalPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._doublePageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._horizontalPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._interactiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._selectTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._panZoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._panToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._zoomToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._magnifyGlassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._interactiveSep1ToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
         this._autoPanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._inertiaScrollToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._annotationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._userModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._userModeDesignToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._userModeRunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._userModeRenderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._userModeSep1ToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
         this._customizeRenderModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._annotationsSep1ToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
         this._currentObjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._annotationsSep2ToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
         this._alignToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._alignBringToFrontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._alignSendToBackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._alignBringToFirstToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._alignSendToLastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._flipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._flipVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._flipHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._groupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._groupSelectedObjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._groupUngroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._securityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._securityLockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._securityUnlockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._resetRotatePointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._antiAliasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._annotationsPropertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._annotationsSep3ToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
         this._behaviorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._behaviorUseRotateThumbsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._behaviorEnableToolTipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._behaviorRenderOnThumbnailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._behaviorDeselectOnDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._behaviorRestrictDesignersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._behaviorRubberbandSelectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._userNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._cacheDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._autoGetTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._documentTextOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._showTextIndicatorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._showOperationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._diagnosticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._documentViewerOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._mainToolStrip = new System.Windows.Forms.ToolStrip();
         this._openDocumentFromFileToolStripButton = new System.Windows.Forms.ToolStripButton();
         this._openDocumentFromUrlToolStripButton = new System.Windows.Forms.ToolStripButton();
         this._mainToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
         this._previousPageToolStripButton = new System.Windows.Forms.ToolStripButton();
         this._nextPageToolStripButton = new System.Windows.Forms.ToolStripButton();
         this._pageNumberToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
         this._pageNumberToolStripLabel = new System.Windows.Forms.ToolStripLabel();
         this._mainToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
         this._zoomInToolStripButton = new System.Windows.Forms.ToolStripButton();
         this._zoomOutToolStripButton = new System.Windows.Forms.ToolStripButton();
         this._zoomToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
         this._actualSizeToolStripButton = new System.Windows.Forms.ToolStripButton();
         this._fitPageToolStripButton = new System.Windows.Forms.ToolStripButton();
         this._fitWidthToolStripButton = new System.Windows.Forms.ToolStripButton();
         this._mainToolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
         this._singlePageToolStripButton = new System.Windows.Forms.ToolStripButton();
         this._verticalPageToolStripButton = new System.Windows.Forms.ToolStripButton();
         this._doublePageToolStripButton = new System.Windows.Forms.ToolStripButton();
         this._horizontalPageToolStripButton = new System.Windows.Forms.ToolStripButton();
         this._mainToolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
         this._selectTextToolStripButton = new System.Windows.Forms.ToolStripButton();
         this._panZoomToolStripButton = new System.Windows.Forms.ToolStripButton();
         this._panToolStripButton = new System.Windows.Forms.ToolStripButton();
         this._zoomToolStripButton = new System.Windows.Forms.ToolStripButton();
         this._zoomToToolStripButton = new System.Windows.Forms.ToolStripButton();
         this._magnifyGlassToolStripButton = new System.Windows.Forms.ToolStripButton();
         this._leftPanel = new System.Windows.Forms.Panel();
         this._leftTabControl = new System.Windows.Forms.TabControl();
         this._thumbnailsTabPage = new System.Windows.Forms.TabPage();
         this._thumbnailsContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
         this._thumbnailsGetThisPageTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._thumbnailsGetAllPagesTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._thumbnailsSep1ToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
         this._thumbnailsRotateClockwiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._thumbnailsRotateCounterClockwiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._thumbnailsSep2ToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
         this._thumbnailsEnableDisablePageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._loadingThumbnailsProgressBar = new System.Windows.Forms.ProgressBar();
         this._bookmarksTabPage = new System.Windows.Forms.TabPage();
         this._loadingBookmarksProgressBar = new System.Windows.Forms.ProgressBar();
         this._rightPanel = new System.Windows.Forms.Panel();
         this._loadingAnnotationsProgressBar = new System.Windows.Forms.ProgressBar();
         this._annotationsControlPanel = new System.Windows.Forms.Panel();
         this._annotationsObjectsPanel = new System.Windows.Forms.Panel();
         this._annotationsObjectsLabel = new System.Windows.Forms.Label();
         this._annotationsControlSplitter = new System.Windows.Forms.Splitter();
         this._annotationsToolBarPanel = new System.Windows.Forms.Panel();
         this._annotationsShapeLabel = new System.Windows.Forms.Label();
         this._leftSplitter = new System.Windows.Forms.Splitter();
         this._rightSplitter = new System.Windows.Forms.Splitter();
         this._centerPanel = new System.Windows.Forms.Panel();
         this._bottomPanel = new System.Windows.Forms.Panel();
         this._outputWindow = new DocumentViewerDemo.UI.OutputWindow();
         this._annotationsSep4ToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
         this._redactionOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._mainMenuStrip.SuspendLayout();
         this._mainToolStrip.SuspendLayout();
         this._leftPanel.SuspendLayout();
         this._leftTabControl.SuspendLayout();
         this._thumbnailsTabPage.SuspendLayout();
         this._thumbnailsContextMenuStrip.SuspendLayout();
         this._bookmarksTabPage.SuspendLayout();
         this._rightPanel.SuspendLayout();
         this._annotationsControlPanel.SuspendLayout();
         this._annotationsObjectsPanel.SuspendLayout();
         this._annotationsToolBarPanel.SuspendLayout();
         this._bottomPanel.SuspendLayout();
         this.SuspendLayout();
         // 
         // _mainMenuStrip
         // 
         this._mainMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
         this._mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._fileToolStripMenuItem,
            this._editToolStripMenuItem,
            this._viewToolStripMenuItem,
            this._pageToolStripMenuItem,
            this._interactiveToolStripMenuItem,
            this._annotationsToolStripMenuItem,
            this._preferencesToolStripMenuItem,
            this._helpToolStripMenuItem});
         this._mainMenuStrip.Location = new System.Drawing.Point(0, 0);
         this._mainMenuStrip.Name = "_mainMenuStrip";
         this._mainMenuStrip.Size = new System.Drawing.Size(1154, 24);
         this._mainMenuStrip.TabIndex = 0;
         // 
         // _fileToolStripMenuItem
         // 
         this._fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._openDocumentFromFileToolStripMenuItem,
            this._openDocumentFromUrltoolStripMenuItem,
            this._saveToolStripMenuItem,
            this._closeToolStripMenuItem,
            this._fileSep1ToolStripMenuItem,
            this._openFromCacheToolStripMenuItem,
            this._saveToCacheToolStripMenuItem,
            this._saveCurrentViewToolStripMenuItem,
            this._fileSep2ToolStripMenuItem,
            this._exportTextToolStripMenuItem,
            this._propertiesToolStripMenuItem,
            this._fileSep3ToolStripMenuItem,
            this._printSetupToolStripMenuItem,
            this._printToolStripMenuItem,
            this._fileSep4ToolStripMenuItem,
            this._exitToolStripMenuItem});
         this._fileToolStripMenuItem.Name = "_fileToolStripMenuItem";
         this._fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
         this._fileToolStripMenuItem.Text = "&File";
         // 
         // _openDocumentFromFileToolStripMenuItem
         // 
         this._openDocumentFromFileToolStripMenuItem.Image = global::DocumentViewerDemo.Properties.Resources.Open;
         this._openDocumentFromFileToolStripMenuItem.Name = "_openDocumentFromFileToolStripMenuItem";
         this._openDocumentFromFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
         this._openDocumentFromFileToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
         this._openDocumentFromFileToolStripMenuItem.Text = "&Open...";
         this._openDocumentFromFileToolStripMenuItem.Click += new System.EventHandler(this._openDocumentFromFileToolStripMenuItem_Click);
         // 
         // _openDocumentFromUrltoolStripMenuItem
         // 
         this._openDocumentFromUrltoolStripMenuItem.Image = global::DocumentViewerDemo.Properties.Resources.OpenUrl;
         this._openDocumentFromUrltoolStripMenuItem.Name = "_openDocumentFromUrltoolStripMenuItem";
         this._openDocumentFromUrltoolStripMenuItem.Size = new System.Drawing.Size(175, 22);
         this._openDocumentFromUrltoolStripMenuItem.Text = "Open &URL...";
         this._openDocumentFromUrltoolStripMenuItem.Click += new System.EventHandler(this._openDocumentFromUrltoolStripMenuItem_Click);
         // 
         // _saveToolStripMenuItem
         // 
         this._saveToolStripMenuItem.Name = "_saveToolStripMenuItem";
         this._saveToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
         this._saveToolStripMenuItem.Text = "&Save...";
         this._saveToolStripMenuItem.ToolTipText = "Export this document";
         this._saveToolStripMenuItem.Click += new System.EventHandler(this._saveToolStripMenuItem_Click);
         // 
         // _closeToolStripMenuItem
         // 
         this._closeToolStripMenuItem.Name = "_closeToolStripMenuItem";
         this._closeToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
         this._closeToolStripMenuItem.Text = "C&lose";
         this._closeToolStripMenuItem.Click += new System.EventHandler(this._closeToolStripMenuItem_Click);
         // 
         // _fileSep1ToolStripMenuItem
         // 
         this._fileSep1ToolStripMenuItem.Name = "_fileSep1ToolStripMenuItem";
         this._fileSep1ToolStripMenuItem.Size = new System.Drawing.Size(172, 6);
         // 
         // _openFromCacheToolStripMenuItem
         // 
         this._openFromCacheToolStripMenuItem.Name = "_openFromCacheToolStripMenuItem";
         this._openFromCacheToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
         this._openFromCacheToolStripMenuItem.Text = "Open from &cache...";
         this._openFromCacheToolStripMenuItem.ToolTipText = "Open a document from the cache";
         this._openFromCacheToolStripMenuItem.Click += new System.EventHandler(this._openFromCacheToolStripMenuItem_Click);
         // 
         // _saveToCacheToolStripMenuItem
         // 
         this._saveToCacheToolStripMenuItem.Name = "_saveToCacheToolStripMenuItem";
         this._saveToCacheToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
         this._saveToCacheToolStripMenuItem.Text = "Save to cache";
         this._saveToCacheToolStripMenuItem.ToolTipText = "Save the document to the cache";
         this._saveToCacheToolStripMenuItem.Click += new System.EventHandler(this._saveToCacheToolStripMenuItem_Click);
         // 
         // _saveCurrentViewToolStripMenuItem
         // 
         this._saveCurrentViewToolStripMenuItem.Name = "_saveCurrentViewToolStripMenuItem";
         this._saveCurrentViewToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
         this._saveCurrentViewToolStripMenuItem.Text = "Save current view";
         this._saveCurrentViewToolStripMenuItem.Click += new System.EventHandler(this._saveCurrentViewStripMenuItem_Click);
         // 
         // _fileSep2ToolStripMenuItem
         // 
         this._fileSep2ToolStripMenuItem.Name = "_fileSep2ToolStripMenuItem";
         this._fileSep2ToolStripMenuItem.Size = new System.Drawing.Size(172, 6);
         // 
         // _exportTextToolStripMenuItem
         // 
         this._exportTextToolStripMenuItem.Name = "_exportTextToolStripMenuItem";
         this._exportTextToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
         this._exportTextToolStripMenuItem.Text = "Export &text...";
         this._exportTextToolStripMenuItem.Click += new System.EventHandler(this._exportTextToolStripMenuItem_Click);
         // 
         // _propertiesToolStripMenuItem
         // 
         this._propertiesToolStripMenuItem.Image = global::DocumentViewerDemo.Properties.Resources.Properties;
         this._propertiesToolStripMenuItem.Name = "_propertiesToolStripMenuItem";
         this._propertiesToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
         this._propertiesToolStripMenuItem.Text = "P&roperties...";
         this._propertiesToolStripMenuItem.Click += new System.EventHandler(this._propertiesToolStripMenuItem_Click);
         // 
         // _fileSep3ToolStripMenuItem
         // 
         this._fileSep3ToolStripMenuItem.Name = "_fileSep3ToolStripMenuItem";
         this._fileSep3ToolStripMenuItem.Size = new System.Drawing.Size(172, 6);
         // 
         // _printSetupToolStripMenuItem
         // 
         this._printSetupToolStripMenuItem.Name = "_printSetupToolStripMenuItem";
         this._printSetupToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
         this._printSetupToolStripMenuItem.Text = "Print set&up...";
         this._printSetupToolStripMenuItem.Click += new System.EventHandler(this._printSetupToolStripMenuItem_Click);
         // 
         // _printToolStripMenuItem
         // 
         this._printToolStripMenuItem.Name = "_printToolStripMenuItem";
         this._printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
         this._printToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
         this._printToolStripMenuItem.Text = "&Print...";
         this._printToolStripMenuItem.Click += new System.EventHandler(this._printToolStripMenuItem_Click);
         // 
         // _fileSep4ToolStripMenuItem
         // 
         this._fileSep4ToolStripMenuItem.Name = "_fileSep4ToolStripMenuItem";
         this._fileSep4ToolStripMenuItem.Size = new System.Drawing.Size(172, 6);
         // 
         // _exitToolStripMenuItem
         // 
         this._exitToolStripMenuItem.Name = "_exitToolStripMenuItem";
         this._exitToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
         this._exitToolStripMenuItem.Text = "E&xit";
         this._exitToolStripMenuItem.Click += new System.EventHandler(this._exitToolStripMenuItem_Click);
         // 
         // _editToolStripMenuItem
         // 
         this._editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._undoToolStripMenuItem,
            this._redoToolStripMenuItem,
            this._editSep1ToolStripMenuItem,
            this._cutToolStripMenuItem,
            this._copyToolStripMenuItem,
            this._pasteToolStripMenuItem,
            this._deleteToolStripMenuItem,
            this._editSep2ToolStripMenuItem,
            this._selectAllToolStripMenuItem,
            this._selectAllAnnotationsToolStripMenuItemtoolStripMenuItem,
            this._clearSelectionToolStripMenuItem,
            this._editSep3ToolStripMenuItem,
            this._findToolStripMenuItem,
            this._findNextToolStripMenuItem,
            this._findPreviousToolStripMenuItem});
         this._editToolStripMenuItem.Name = "_editToolStripMenuItem";
         this._editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
         this._editToolStripMenuItem.Text = "E&dit";
         // 
         // _undoToolStripMenuItem
         // 
         this._undoToolStripMenuItem.Name = "_undoToolStripMenuItem";
         this._undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
         this._undoToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
         this._undoToolStripMenuItem.Text = "&Undo";
         // 
         // _redoToolStripMenuItem
         // 
         this._redoToolStripMenuItem.Name = "_redoToolStripMenuItem";
         this._redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
         this._redoToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
         this._redoToolStripMenuItem.Text = "&Redo";
         // 
         // _editSep1ToolStripMenuItem
         // 
         this._editSep1ToolStripMenuItem.Name = "_editSep1ToolStripMenuItem";
         this._editSep1ToolStripMenuItem.Size = new System.Drawing.Size(257, 6);
         // 
         // _cutToolStripMenuItem
         // 
         this._cutToolStripMenuItem.Name = "_cutToolStripMenuItem";
         this._cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
         this._cutToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
         this._cutToolStripMenuItem.Text = "Cu&t";
         // 
         // _copyToolStripMenuItem
         // 
         this._copyToolStripMenuItem.Name = "_copyToolStripMenuItem";
         this._copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
         this._copyToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
         this._copyToolStripMenuItem.Text = "&Copy";
         this._copyToolStripMenuItem.ToolTipText = "Copy selected text to the clipboard";
         // 
         // _pasteToolStripMenuItem
         // 
         this._pasteToolStripMenuItem.Name = "_pasteToolStripMenuItem";
         this._pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
         this._pasteToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
         this._pasteToolStripMenuItem.Text = "&Paste";
         // 
         // _deleteToolStripMenuItem
         // 
         this._deleteToolStripMenuItem.Name = "_deleteToolStripMenuItem";
         this._deleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
         this._deleteToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
         this._deleteToolStripMenuItem.Text = "&Delete";
         // 
         // _editSep2ToolStripMenuItem
         // 
         this._editSep2ToolStripMenuItem.Name = "_editSep2ToolStripMenuItem";
         this._editSep2ToolStripMenuItem.Size = new System.Drawing.Size(257, 6);
         // 
         // _selectAllToolStripMenuItem
         // 
         this._selectAllToolStripMenuItem.Name = "_selectAllToolStripMenuItem";
         this._selectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
         this._selectAllToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
         this._selectAllToolStripMenuItem.Text = "Select &all";
         this._selectAllToolStripMenuItem.ToolTipText = "Select all text in this page";
         this._selectAllToolStripMenuItem.Click += new System.EventHandler(this._selectAllToolStripMenuItem_Click);
         // 
         // _selectAllAnnotationsToolStripMenuItemtoolStripMenuItem
         // 
         this._selectAllAnnotationsToolStripMenuItemtoolStripMenuItem.Name = "_selectAllAnnotationsToolStripMenuItemtoolStripMenuItem";
         this._selectAllAnnotationsToolStripMenuItemtoolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
            | System.Windows.Forms.Keys.A)));
         this._selectAllAnnotationsToolStripMenuItemtoolStripMenuItem.Size = new System.Drawing.Size(260, 22);
         this._selectAllAnnotationsToolStripMenuItemtoolStripMenuItem.Text = "Select all annotation&s";
         // 
         // _clearSelectionToolStripMenuItem
         // 
         this._clearSelectionToolStripMenuItem.Name = "_clearSelectionToolStripMenuItem";
         this._clearSelectionToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
         this._clearSelectionToolStripMenuItem.Text = "C&lear selection";
         // 
         // _editSep3ToolStripMenuItem
         // 
         this._editSep3ToolStripMenuItem.Name = "_editSep3ToolStripMenuItem";
         this._editSep3ToolStripMenuItem.Size = new System.Drawing.Size(257, 6);
         // 
         // _findToolStripMenuItem
         // 
         this._findToolStripMenuItem.Name = "_findToolStripMenuItem";
         this._findToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
         this._findToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
         this._findToolStripMenuItem.Text = "&Find...";
         this._findToolStripMenuItem.ToolTipText = "Find text in the document";
         this._findToolStripMenuItem.Click += new System.EventHandler(this._findToolStripMenuItem_Click);
         // 
         // _findNextToolStripMenuItem
         // 
         this._findNextToolStripMenuItem.Image = global::DocumentViewerDemo.Properties.Resources.FindNext;
         this._findNextToolStripMenuItem.Name = "_findNextToolStripMenuItem";
         this._findNextToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
         this._findNextToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
         this._findNextToolStripMenuItem.Text = "Find &next";
         this._findNextToolStripMenuItem.ToolTipText = "Find next accurace of text in the document";
         this._findNextToolStripMenuItem.Click += new System.EventHandler(this._findNextToolStripMenuItem_Click);
         // 
         // _findPreviousToolStripMenuItem
         // 
         this._findPreviousToolStripMenuItem.Image = global::DocumentViewerDemo.Properties.Resources.FindPrevious;
         this._findPreviousToolStripMenuItem.Name = "_findPreviousToolStripMenuItem";
         this._findPreviousToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F3)));
         this._findPreviousToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
         this._findPreviousToolStripMenuItem.Text = "Find &previous";
         this._findPreviousToolStripMenuItem.ToolTipText = "Find previous text";
         this._findPreviousToolStripMenuItem.Click += new System.EventHandler(this._findPreviousToolStripMenuItem_Click);
         // 
         // _viewToolStripMenuItem
         // 
         this._viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._rotateVieweToolStripMenuItem,
            this._viewSep1ToolStripMenuItem,
            this._zoomOutToolStripMenuItem,
            this._zoomInToolStripMenuItem,
            this._viewSep2ToolStripMenuItem,
            this._actualSizeToolStripMenuItem,
            this._fitPageToolStripMenuItem,
            this._fitWidthToolStripMenuItem,
            this._viewSep3ToolStripMenuItem,
            this._asSvgToolStripMenuItem,
            this._asImageToolStripMenuItem,
            this._viewSep4ToolStripMenuItem,
            this._thumbnailsToolStripMenuItem,
            this._bookmarksToolStripMenuItem});
         this._viewToolStripMenuItem.Name = "_viewToolStripMenuItem";
         this._viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
         this._viewToolStripMenuItem.Text = "&View";
         this._viewToolStripMenuItem.DropDownOpening += new System.EventHandler(this._viewToolStripMenuItem_DropDownOpening);
         // 
         // _rotateVieweToolStripMenuItem
         // 
         this._rotateVieweToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._clockwiseToolStripMenuItem,
            this._counterClockwiseToolStripMenuItem});
         this._rotateVieweToolStripMenuItem.Name = "_rotateVieweToolStripMenuItem";
         this._rotateVieweToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
         this._rotateVieweToolStripMenuItem.Text = "&Rotate view";
         // 
         // _clockwiseToolStripMenuItem
         // 
         this._clockwiseToolStripMenuItem.Image = global::DocumentViewerDemo.Properties.Resources.Clockwise;
         this._clockwiseToolStripMenuItem.Name = "_clockwiseToolStripMenuItem";
         this._clockwiseToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
         this._clockwiseToolStripMenuItem.Text = "&Clockwise";
         // 
         // _counterClockwiseToolStripMenuItem
         // 
         this._counterClockwiseToolStripMenuItem.Image = global::DocumentViewerDemo.Properties.Resources.CounterClockwise;
         this._counterClockwiseToolStripMenuItem.Name = "_counterClockwiseToolStripMenuItem";
         this._counterClockwiseToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
         this._counterClockwiseToolStripMenuItem.Text = "Counter clock&wise";
         // 
         // _viewSep1ToolStripMenuItem
         // 
         this._viewSep1ToolStripMenuItem.Name = "_viewSep1ToolStripMenuItem";
         this._viewSep1ToolStripMenuItem.Size = new System.Drawing.Size(134, 6);
         // 
         // _zoomOutToolStripMenuItem
         // 
         this._zoomOutToolStripMenuItem.Image = global::DocumentViewerDemo.Properties.Resources.ZoomOut;
         this._zoomOutToolStripMenuItem.Name = "_zoomOutToolStripMenuItem";
         this._zoomOutToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
         this._zoomOutToolStripMenuItem.Text = "Zoom &out";
         this._zoomOutToolStripMenuItem.ToolTipText = "Zoom out";
         // 
         // _zoomInToolStripMenuItem
         // 
         this._zoomInToolStripMenuItem.Image = global::DocumentViewerDemo.Properties.Resources.ZoomIn;
         this._zoomInToolStripMenuItem.Name = "_zoomInToolStripMenuItem";
         this._zoomInToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
         this._zoomInToolStripMenuItem.Text = "Zoom &in";
         this._zoomInToolStripMenuItem.ToolTipText = "Zoom in";
         // 
         // _viewSep2ToolStripMenuItem
         // 
         this._viewSep2ToolStripMenuItem.Name = "_viewSep2ToolStripMenuItem";
         this._viewSep2ToolStripMenuItem.Size = new System.Drawing.Size(134, 6);
         // 
         // _actualSizeToolStripMenuItem
         // 
         this._actualSizeToolStripMenuItem.Image = global::DocumentViewerDemo.Properties.Resources.ActualSize;
         this._actualSizeToolStripMenuItem.Name = "_actualSizeToolStripMenuItem";
         this._actualSizeToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
         this._actualSizeToolStripMenuItem.Text = "&Actual size";
         this._actualSizeToolStripMenuItem.ToolTipText = "Fit the image into the window";
         // 
         // _fitPageToolStripMenuItem
         // 
         this._fitPageToolStripMenuItem.Image = global::DocumentViewerDemo.Properties.Resources.FitPage;
         this._fitPageToolStripMenuItem.Name = "_fitPageToolStripMenuItem";
         this._fitPageToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
         this._fitPageToolStripMenuItem.Text = "Fit &page";
         this._fitPageToolStripMenuItem.ToolTipText = "Fit the image into the window";
         // 
         // _fitWidthToolStripMenuItem
         // 
         this._fitWidthToolStripMenuItem.Image = global::DocumentViewerDemo.Properties.Resources.FitWidth;
         this._fitWidthToolStripMenuItem.Name = "_fitWidthToolStripMenuItem";
         this._fitWidthToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
         this._fitWidthToolStripMenuItem.Text = "&Fit width";
         this._fitWidthToolStripMenuItem.ToolTipText = "Fit the image width into the window";
         // 
         // _viewSep3ToolStripMenuItem
         // 
         this._viewSep3ToolStripMenuItem.Name = "_viewSep3ToolStripMenuItem";
         this._viewSep3ToolStripMenuItem.Size = new System.Drawing.Size(134, 6);
         // 
         // _asSvgToolStripMenuItem
         // 
         this._asSvgToolStripMenuItem.Image = global::DocumentViewerDemo.Properties.Resources.ViewAsSvg;
         this._asSvgToolStripMenuItem.Name = "_asSvgToolStripMenuItem";
         this._asSvgToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
         this._asSvgToolStripMenuItem.Text = "As &SVG";
         this._asSvgToolStripMenuItem.Click += new System.EventHandler(this._asSvgToolStripMenuItem_Click);
         // 
         // _asImageToolStripMenuItem
         // 
         this._asImageToolStripMenuItem.Image = global::DocumentViewerDemo.Properties.Resources.ViewAsImage;
         this._asImageToolStripMenuItem.Name = "_asImageToolStripMenuItem";
         this._asImageToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
         this._asImageToolStripMenuItem.Text = "As image";
         this._asImageToolStripMenuItem.Click += new System.EventHandler(this._asImageToolStripMenuItem_Click);
         // 
         // _viewSep4ToolStripMenuItem
         // 
         this._viewSep4ToolStripMenuItem.Name = "_viewSep4ToolStripMenuItem";
         this._viewSep4ToolStripMenuItem.Size = new System.Drawing.Size(134, 6);
         // 
         // _thumbnailsToolStripMenuItem
         // 
         this._thumbnailsToolStripMenuItem.Name = "_thumbnailsToolStripMenuItem";
         this._thumbnailsToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
         this._thumbnailsToolStripMenuItem.Text = "&Thumbnails";
         this._thumbnailsToolStripMenuItem.ToolTipText = "Show pages thumbnails";
         this._thumbnailsToolStripMenuItem.Click += new System.EventHandler(this._thumbnailsToolStripMenuItem_Click);
         // 
         // _bookmarksToolStripMenuItem
         // 
         this._bookmarksToolStripMenuItem.Name = "_bookmarksToolStripMenuItem";
         this._bookmarksToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
         this._bookmarksToolStripMenuItem.Text = "&Bookmarks";
         this._bookmarksToolStripMenuItem.ToolTipText = "Show document bookmarks";
         this._bookmarksToolStripMenuItem.Click += new System.EventHandler(this._bookmarksToolStripMenuItem_Click);
         // 
         // _pageToolStripMenuItem
         // 
         this._pageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._firstPageToolStripMenuItem,
            this._previousPageToolStripMenuItem,
            this._nextPageToolStripMenuItem,
            this._lastPageToolStripMenuItem,
            this._gotoPageToolStripMenuItem,
            this._pageSep1ToolStripSeparator,
            this._getCurrentPageTextToolStripMenuItem,
            this._getAllPagesTextToolStripMenuItem,
            this._pageSep2ToolStripSeparator,
            this._rotatePageClockwiseToolStripMenuItem,
            this._rotatePageCounterClockwiseToolStripMenuItem,
            this._rotatePagesToolStripMenuItem,
            this._pageSep3ToolStripSeparator,
            this._enableDisablePageToolStripMenuItem,
            this._pageSep4ToolStripSeparator,
            this._displayPageToolStripMenuItem});
         this._pageToolStripMenuItem.Name = "_pageToolStripMenuItem";
         this._pageToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
         this._pageToolStripMenuItem.Text = "&Page";
         this._pageToolStripMenuItem.DropDownOpening += new System.EventHandler(this._pageToolStripMenuItem_DropDownOpening);
         // 
         // _firstPageToolStripMenuItem
         // 
         this._firstPageToolStripMenuItem.Image = global::DocumentViewerDemo.Properties.Resources.FirstPage;
         this._firstPageToolStripMenuItem.Name = "_firstPageToolStripMenuItem";
         this._firstPageToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
         this._firstPageToolStripMenuItem.Text = "&First";
         // 
         // _previousPageToolStripMenuItem
         // 
         this._previousPageToolStripMenuItem.Image = global::DocumentViewerDemo.Properties.Resources.PreviousPage;
         this._previousPageToolStripMenuItem.Name = "_previousPageToolStripMenuItem";
         this._previousPageToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
         this._previousPageToolStripMenuItem.Text = "&Previous";
         this._previousPageToolStripMenuItem.ToolTipText = "Go to previous page in the document";
         // 
         // _nextPageToolStripMenuItem
         // 
         this._nextPageToolStripMenuItem.Image = global::DocumentViewerDemo.Properties.Resources.NextPage;
         this._nextPageToolStripMenuItem.Name = "_nextPageToolStripMenuItem";
         this._nextPageToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
         this._nextPageToolStripMenuItem.Text = "&Next";
         this._nextPageToolStripMenuItem.ToolTipText = "Go to next page in the document";
         // 
         // _lastPageToolStripMenuItem
         // 
         this._lastPageToolStripMenuItem.Image = global::DocumentViewerDemo.Properties.Resources.LastPage;
         this._lastPageToolStripMenuItem.Name = "_lastPageToolStripMenuItem";
         this._lastPageToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
         this._lastPageToolStripMenuItem.Text = "&Last ";
         // 
         // _gotoPageToolStripMenuItem
         // 
         this._gotoPageToolStripMenuItem.Name = "_gotoPageToolStripMenuItem";
         this._gotoPageToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
         this._gotoPageToolStripMenuItem.Text = "&Goto page...";
         this._gotoPageToolStripMenuItem.ToolTipText = "Go to a specific page in the document";
         this._gotoPageToolStripMenuItem.Click += new System.EventHandler(this._gotoPageToolStripMenuItem_Click);
         // 
         // _pageSep1ToolStripSeparator
         // 
         this._pageSep1ToolStripSeparator.Name = "_pageSep1ToolStripSeparator";
         this._pageSep1ToolStripSeparator.Size = new System.Drawing.Size(203, 6);
         // 
         // _getCurrentPageTextToolStripMenuItem
         // 
         this._getCurrentPageTextToolStripMenuItem.Name = "_getCurrentPageTextToolStripMenuItem";
         this._getCurrentPageTextToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
         this._getCurrentPageTextToolStripMenuItem.Text = "Get &text for current page";
         this._getCurrentPageTextToolStripMenuItem.Click += new System.EventHandler(this._getCurrentPageTextToolStripMenuItem_Click);
         // 
         // _getAllPagesTextToolStripMenuItem
         // 
         this._getAllPagesTextToolStripMenuItem.Name = "_getAllPagesTextToolStripMenuItem";
         this._getAllPagesTextToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
         this._getAllPagesTextToolStripMenuItem.Text = "Get text for &all pages";
         this._getAllPagesTextToolStripMenuItem.Click += new System.EventHandler(this._getAllPagesTextToolStripMenuItem_Click);
         // 
         // _pageSep2ToolStripSeparator
         // 
         this._pageSep2ToolStripSeparator.Name = "_pageSep2ToolStripSeparator";
         this._pageSep2ToolStripSeparator.Size = new System.Drawing.Size(203, 6);
         // 
         // _rotatePageClockwiseToolStripMenuItem
         // 
         this._rotatePageClockwiseToolStripMenuItem.Name = "_rotatePageClockwiseToolStripMenuItem";
         this._rotatePageClockwiseToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
         this._rotatePageClockwiseToolStripMenuItem.Text = "&Rotate clockwise";
         this._rotatePageClockwiseToolStripMenuItem.ToolTipText = "Rotate the current page by 90 degrees clockwise";
         // 
         // _rotatePageCounterClockwiseToolStripMenuItem
         // 
         this._rotatePageCounterClockwiseToolStripMenuItem.Name = "_rotatePageCounterClockwiseToolStripMenuItem";
         this._rotatePageCounterClockwiseToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
         this._rotatePageCounterClockwiseToolStripMenuItem.Text = "Rotate &counter clockwise";
         this._rotatePageCounterClockwiseToolStripMenuItem.ToolTipText = "Rotate the current page by 90 degrees counter-clockwise";
         // 
         // _rotatePagesToolStripMenuItem
         // 
         this._rotatePagesToolStripMenuItem.Name = "_rotatePagesToolStripMenuItem";
         this._rotatePagesToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
         this._rotatePagesToolStripMenuItem.Text = "R&otate pages...";
         this._rotatePagesToolStripMenuItem.ToolTipText = "Rotate document pages";
         this._rotatePagesToolStripMenuItem.Click += new System.EventHandler(this._rotatePagesToolStripMenuItem_Click);
         // 
         // _pageSep3ToolStripSeparator
         // 
         this._pageSep3ToolStripSeparator.Name = "_pageSep3ToolStripSeparator";
         this._pageSep3ToolStripSeparator.Size = new System.Drawing.Size(203, 6);
         // 
         // _enableDisablePageToolStripMenuItem
         // 
         this._enableDisablePageToolStripMenuItem.Name = "_enableDisablePageToolStripMenuItem";
         this._enableDisablePageToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
         this._enableDisablePageToolStripMenuItem.Text = "Mark page as disabl&ed";
         this._enableDisablePageToolStripMenuItem.ToolTipText = "Mark the current page as disabled in the document";
         this._enableDisablePageToolStripMenuItem.Click += new System.EventHandler(this._enableDisablePageToolStripMenuItem_Click);
         // 
         // _pageSep4ToolStripSeparator
         // 
         this._pageSep4ToolStripSeparator.Name = "_pageSep4ToolStripSeparator";
         this._pageSep4ToolStripSeparator.Size = new System.Drawing.Size(203, 6);
         // 
         // _displayPageToolStripMenuItem
         // 
         this._displayPageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._singlePageToolStripMenuItem,
            this._verticalPageToolStripMenuItem,
            this._doublePageToolStripMenuItem,
            this._horizontalPageToolStripMenuItem});
         this._displayPageToolStripMenuItem.Name = "_displayPageToolStripMenuItem";
         this._displayPageToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
         this._displayPageToolStripMenuItem.Text = "&Display";
         // 
         // _singlePageToolStripMenuItem
         // 
         this._singlePageToolStripMenuItem.Image = global::DocumentViewerDemo.Properties.Resources.SingleLayout;
         this._singlePageToolStripMenuItem.Name = "_singlePageToolStripMenuItem";
         this._singlePageToolStripMenuItem.Size = new System.Drawing.Size(137, 30);
         this._singlePageToolStripMenuItem.Text = "&Single";
         this._singlePageToolStripMenuItem.ToolTipText = "Single page display";
         // 
         // _verticalPageToolStripMenuItem
         // 
         this._verticalPageToolStripMenuItem.Image = global::DocumentViewerDemo.Properties.Resources.VerticalLayout;
         this._verticalPageToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
         this._verticalPageToolStripMenuItem.Name = "_verticalPageToolStripMenuItem";
         this._verticalPageToolStripMenuItem.Size = new System.Drawing.Size(137, 30);
         this._verticalPageToolStripMenuItem.Text = "Vertical";
         this._verticalPageToolStripMenuItem.ToolTipText = "Vertical page display";
         // 
         // _doublePageToolStripMenuItem
         // 
         this._doublePageToolStripMenuItem.Image = global::DocumentViewerDemo.Properties.Resources.DoubleLayout;
         this._doublePageToolStripMenuItem.Name = "_doublePageToolStripMenuItem";
         this._doublePageToolStripMenuItem.Size = new System.Drawing.Size(137, 30);
         this._doublePageToolStripMenuItem.Text = "&Double";
         this._doublePageToolStripMenuItem.ToolTipText = "Double page display";
         // 
         // _horizontalPageToolStripMenuItem
         // 
         this._horizontalPageToolStripMenuItem.Image = global::DocumentViewerDemo.Properties.Resources.HorizontalLayout;
         this._horizontalPageToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
         this._horizontalPageToolStripMenuItem.Name = "_horizontalPageToolStripMenuItem";
         this._horizontalPageToolStripMenuItem.Size = new System.Drawing.Size(137, 30);
         this._horizontalPageToolStripMenuItem.Text = "Horizontal";
         this._horizontalPageToolStripMenuItem.ToolTipText = "Horizontal page display";
         // 
         // _interactiveToolStripMenuItem
         // 
         this._interactiveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._selectTextToolStripMenuItem,
            this._panZoomToolStripMenuItem,
            this._panToolStripMenuItem,
            this._zoomToolStripMenuItem,
            this._zoomToToolStripMenuItem,
            this._magnifyGlassToolStripMenuItem,
            this._interactiveSep1ToolStripSeparator,
            this._autoPanToolStripMenuItem,
            this._inertiaScrollToolStripMenuItem});
         this._interactiveToolStripMenuItem.Name = "_interactiveToolStripMenuItem";
         this._interactiveToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
         this._interactiveToolStripMenuItem.Text = "&Interactive";
         this._interactiveToolStripMenuItem.DropDownOpening += new System.EventHandler(this._interactiveToolStripMenuItem_DropDownOpening);
         // 
         // _selectTextToolStripMenuItem
         // 
         this._selectTextToolStripMenuItem.Image = global::DocumentViewerDemo.Properties.Resources.SelectTextMode;
         this._selectTextToolStripMenuItem.Name = "_selectTextToolStripMenuItem";
         this._selectTextToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
         this._selectTextToolStripMenuItem.Text = "&Select text";
         // 
         // _panZoomToolStripMenuItem
         // 
         this._panZoomToolStripMenuItem.Image = global::DocumentViewerDemo.Properties.Resources.PanZoomMode;
         this._panZoomToolStripMenuItem.Name = "_panZoomToolStripMenuItem";
         this._panZoomToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
         this._panZoomToolStripMenuItem.Text = "P&an zoom";
         // 
         // _panToolStripMenuItem
         // 
         this._panToolStripMenuItem.Image = global::DocumentViewerDemo.Properties.Resources.PanMode;
         this._panToolStripMenuItem.Name = "_panToolStripMenuItem";
         this._panToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
         this._panToolStripMenuItem.Text = "&Pan";
         // 
         // _zoomToolStripMenuItem
         // 
         this._zoomToolStripMenuItem.Image = global::DocumentViewerDemo.Properties.Resources.ZoomMode;
         this._zoomToolStripMenuItem.Name = "_zoomToolStripMenuItem";
         this._zoomToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
         this._zoomToolStripMenuItem.Text = "&Zoom";
         // 
         // _zoomToToolStripMenuItem
         // 
         this._zoomToToolStripMenuItem.Image = global::DocumentViewerDemo.Properties.Resources.ZoomToMode;
         this._zoomToToolStripMenuItem.Name = "_zoomToToolStripMenuItem";
         this._zoomToToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
         this._zoomToToolStripMenuItem.Text = "Zoom &to";
         // 
         // _magnifyGlassToolStripMenuItem
         // 
         this._magnifyGlassToolStripMenuItem.Image = global::DocumentViewerDemo.Properties.Resources.MagnifyGlassMode;
         this._magnifyGlassToolStripMenuItem.Name = "_magnifyGlassToolStripMenuItem";
         this._magnifyGlassToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
         this._magnifyGlassToolStripMenuItem.Text = "&Magnify glass";
         // 
         // _interactiveSep1ToolStripSeparator
         // 
         this._interactiveSep1ToolStripSeparator.Name = "_interactiveSep1ToolStripSeparator";
         this._interactiveSep1ToolStripSeparator.Size = new System.Drawing.Size(144, 6);
         // 
         // _autoPanToolStripMenuItem
         // 
         this._autoPanToolStripMenuItem.Name = "_autoPanToolStripMenuItem";
         this._autoPanToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
         this._autoPanToolStripMenuItem.Text = "A&uto pan";
         // 
         // _inertiaScrollToolStripMenuItem
         // 
         this._inertiaScrollToolStripMenuItem.Name = "_inertiaScrollToolStripMenuItem";
         this._inertiaScrollToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
         this._inertiaScrollToolStripMenuItem.Text = "&Inertia scroll";
         this._inertiaScrollToolStripMenuItem.Click += new System.EventHandler(this._inertiaScrollToolStripMenuItem_Click);
         // 
         // _annotationsToolStripMenuItem
         // 
         this._annotationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._userModeToolStripMenuItem,
            this._annotationsSep1ToolStripSeparator,
            this._currentObjectToolStripMenuItem,
            this._annotationsSep2ToolStripSeparator,
            this._alignToolStripMenuItem,
            this._flipToolStripMenuItem,
            this._groupToolStripMenuItem,
            this._securityToolStripMenuItem,
            this._resetRotatePointsToolStripMenuItem,
            this._antiAliasToolStripMenuItem,
            this._annotationsPropertiesToolStripMenuItem,
            this._annotationsSep3ToolStripSeparator,
            this._behaviorToolStripMenuItem,
            this._annotationsSep4ToolStripSeparator,
            this._redactionOptionsToolStripMenuItem});
         this._annotationsToolStripMenuItem.Name = "_annotationsToolStripMenuItem";
         this._annotationsToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
         this._annotationsToolStripMenuItem.Text = "&Annotations";
         this._annotationsToolStripMenuItem.DropDownOpening += new System.EventHandler(this._annotationsToolStripMenuItem_DropDownOpening);
         // 
         // _userModeToolStripMenuItem
         // 
         this._userModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._userModeDesignToolStripMenuItem,
            this._userModeRunToolStripMenuItem,
            this._userModeRenderToolStripMenuItem,
            this._userModeSep1ToolStripMenuItem,
            this._customizeRenderModeToolStripMenuItem});
         this._userModeToolStripMenuItem.Name = "_userModeToolStripMenuItem";
         this._userModeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
         this._userModeToolStripMenuItem.Text = "&User mode";
         // 
         // _userModeDesignToolStripMenuItem
         // 
         this._userModeDesignToolStripMenuItem.Name = "_userModeDesignToolStripMenuItem";
         this._userModeDesignToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
         this._userModeDesignToolStripMenuItem.Text = "&Design";
         this._userModeDesignToolStripMenuItem.ToolTipText = "Allows editing of the annotations objects";
         // 
         // _userModeRunToolStripMenuItem
         // 
         this._userModeRunToolStripMenuItem.Name = "_userModeRunToolStripMenuItem";
         this._userModeRunToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
         this._userModeRunToolStripMenuItem.Text = "&Run";
         this._userModeRunToolStripMenuItem.ToolTipText = "Allows running the annotations objects and clicking the hyperlinks";
         // 
         // _userModeRenderToolStripMenuItem
         // 
         this._userModeRenderToolStripMenuItem.Name = "_userModeRenderToolStripMenuItem";
         this._userModeRenderToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
         this._userModeRenderToolStripMenuItem.Text = "R&ender";
         this._userModeRenderToolStripMenuItem.ToolTipText = "Render the annotations only. No editing and no running";
         // 
         // _userModeSep1ToolStripMenuItem
         // 
         this._userModeSep1ToolStripMenuItem.Name = "_userModeSep1ToolStripMenuItem";
         this._userModeSep1ToolStripMenuItem.Size = new System.Drawing.Size(207, 6);
         // 
         // _customizeRenderModeToolStripMenuItem
         // 
         this._customizeRenderModeToolStripMenuItem.Name = "_customizeRenderModeToolStripMenuItem";
         this._customizeRenderModeToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
         this._customizeRenderModeToolStripMenuItem.Text = "&Customize render mode...";
         this._customizeRenderModeToolStripMenuItem.Click += new System.EventHandler(this._customizeRenderModeToolStripMenuItem_Click);
         // 
         // _annotationsSep1ToolStripSeparator
         // 
         this._annotationsSep1ToolStripSeparator.Name = "_annotationsSep1ToolStripSeparator";
         this._annotationsSep1ToolStripSeparator.Size = new System.Drawing.Size(177, 6);
         // 
         // _currentObjectToolStripMenuItem
         // 
         this._currentObjectToolStripMenuItem.Name = "_currentObjectToolStripMenuItem";
         this._currentObjectToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
         this._currentObjectToolStripMenuItem.Text = "&Current object...";
         this._currentObjectToolStripMenuItem.Click += new System.EventHandler(this._currentObjectToolStripMenuItem_Click);
         // 
         // _annotationsSep2ToolStripSeparator
         // 
         this._annotationsSep2ToolStripSeparator.Name = "_annotationsSep2ToolStripSeparator";
         this._annotationsSep2ToolStripSeparator.Size = new System.Drawing.Size(177, 6);
         // 
         // _alignToolStripMenuItem
         // 
         this._alignToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._alignBringToFrontToolStripMenuItem,
            this._alignSendToBackToolStripMenuItem,
            this._alignBringToFirstToolStripMenuItem,
            this._alignSendToLastToolStripMenuItem});
         this._alignToolStripMenuItem.Name = "_alignToolStripMenuItem";
         this._alignToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
         this._alignToolStripMenuItem.Text = "&Align";
         // 
         // _alignBringToFrontToolStripMenuItem
         // 
         this._alignBringToFrontToolStripMenuItem.Name = "_alignBringToFrontToolStripMenuItem";
         this._alignBringToFrontToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
         this._alignBringToFrontToolStripMenuItem.Text = "&Bring to front";
         // 
         // _alignSendToBackToolStripMenuItem
         // 
         this._alignSendToBackToolStripMenuItem.Name = "_alignSendToBackToolStripMenuItem";
         this._alignSendToBackToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
         this._alignSendToBackToolStripMenuItem.Text = "Send to &back";
         // 
         // _alignBringToFirstToolStripMenuItem
         // 
         this._alignBringToFirstToolStripMenuItem.Name = "_alignBringToFirstToolStripMenuItem";
         this._alignBringToFirstToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
         this._alignBringToFirstToolStripMenuItem.Text = "Bring to &first";
         // 
         // _alignSendToLastToolStripMenuItem
         // 
         this._alignSendToLastToolStripMenuItem.Name = "_alignSendToLastToolStripMenuItem";
         this._alignSendToLastToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
         this._alignSendToLastToolStripMenuItem.Text = "Send to &last";
         // 
         // _flipToolStripMenuItem
         // 
         this._flipToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._flipVerticalToolStripMenuItem,
            this._flipHorizontalToolStripMenuItem});
         this._flipToolStripMenuItem.Name = "_flipToolStripMenuItem";
         this._flipToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
         this._flipToolStripMenuItem.Text = "&Flip";
         // 
         // _flipVerticalToolStripMenuItem
         // 
         this._flipVerticalToolStripMenuItem.Name = "_flipVerticalToolStripMenuItem";
         this._flipVerticalToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
         this._flipVerticalToolStripMenuItem.Text = "&Vertical";
         // 
         // _flipHorizontalToolStripMenuItem
         // 
         this._flipHorizontalToolStripMenuItem.Name = "_flipHorizontalToolStripMenuItem";
         this._flipHorizontalToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
         this._flipHorizontalToolStripMenuItem.Text = "&Horizontal";
         // 
         // _groupToolStripMenuItem
         // 
         this._groupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._groupSelectedObjectsToolStripMenuItem,
            this._groupUngroupToolStripMenuItem});
         this._groupToolStripMenuItem.Name = "_groupToolStripMenuItem";
         this._groupToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
         this._groupToolStripMenuItem.Text = "&Group";
         // 
         // _groupSelectedObjectsToolStripMenuItem
         // 
         this._groupSelectedObjectsToolStripMenuItem.Name = "_groupSelectedObjectsToolStripMenuItem";
         this._groupSelectedObjectsToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
         this._groupSelectedObjectsToolStripMenuItem.Text = "&Group selected objects";
         // 
         // _groupUngroupToolStripMenuItem
         // 
         this._groupUngroupToolStripMenuItem.Name = "_groupUngroupToolStripMenuItem";
         this._groupUngroupToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
         this._groupUngroupToolStripMenuItem.Text = "&Ungroup";
         // 
         // _securityToolStripMenuItem
         // 
         this._securityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._securityLockToolStripMenuItem,
            this._securityUnlockToolStripMenuItem});
         this._securityToolStripMenuItem.Name = "_securityToolStripMenuItem";
         this._securityToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
         this._securityToolStripMenuItem.Text = "&Security";
         // 
         // _securityLockToolStripMenuItem
         // 
         this._securityLockToolStripMenuItem.Name = "_securityLockToolStripMenuItem";
         this._securityLockToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
         this._securityLockToolStripMenuItem.Text = "&Lock...";
         // 
         // _securityUnlockToolStripMenuItem
         // 
         this._securityUnlockToolStripMenuItem.Name = "_securityUnlockToolStripMenuItem";
         this._securityUnlockToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
         this._securityUnlockToolStripMenuItem.Text = "&Unlock...";
         // 
         // _resetRotatePointsToolStripMenuItem
         // 
         this._resetRotatePointsToolStripMenuItem.Name = "_resetRotatePointsToolStripMenuItem";
         this._resetRotatePointsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
         this._resetRotatePointsToolStripMenuItem.Text = "Reset rotate p&oints";
         // 
         // _antiAliasToolStripMenuItem
         // 
         this._antiAliasToolStripMenuItem.Name = "_antiAliasToolStripMenuItem";
         this._antiAliasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
         this._antiAliasToolStripMenuItem.Text = "A&nti alias";
         // 
         // _annotationsPropertiesToolStripMenuItem
         // 
         this._annotationsPropertiesToolStripMenuItem.Name = "_annotationsPropertiesToolStripMenuItem";
         this._annotationsPropertiesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
         this._annotationsPropertiesToolStripMenuItem.Text = "&Properties...";
         // 
         // _annotationsSep3ToolStripSeparator
         // 
         this._annotationsSep3ToolStripSeparator.Name = "_annotationsSep3ToolStripSeparator";
         this._annotationsSep3ToolStripSeparator.Size = new System.Drawing.Size(177, 6);
         // 
         // _behaviorToolStripMenuItem
         // 
         this._behaviorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._behaviorUseRotateThumbsToolStripMenuItem,
            this._behaviorEnableToolTipToolStripMenuItem,
            this._behaviorRenderOnThumbnailsToolStripMenuItem,
            this._behaviorDeselectOnDownToolStripMenuItem,
            this._behaviorRestrictDesignersToolStripMenuItem,
            this._behaviorRubberbandSelectToolStripMenuItem});
         this._behaviorToolStripMenuItem.Name = "_behaviorToolStripMenuItem";
         this._behaviorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
         this._behaviorToolStripMenuItem.Text = "&Behavior";
         this._behaviorToolStripMenuItem.DropDownOpening += new System.EventHandler(this._behaviorToolStripMenuItem_DropDownOpening);
         // 
         // _behaviorUseRotateThumbsToolStripMenuItem
         // 
         this._behaviorUseRotateThumbsToolStripMenuItem.Name = "_behaviorUseRotateThumbsToolStripMenuItem";
         this._behaviorUseRotateThumbsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
         this._behaviorUseRotateThumbsToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
         this._behaviorUseRotateThumbsToolStripMenuItem.Text = "&Use rotate thumbs";
         // 
         // _behaviorEnableToolTipToolStripMenuItem
         // 
         this._behaviorEnableToolTipToolStripMenuItem.Name = "_behaviorEnableToolTipToolStripMenuItem";
         this._behaviorEnableToolTipToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
         this._behaviorEnableToolTipToolStripMenuItem.Text = "&Enable tool tip";
         // 
         // _behaviorRenderOnThumbnailsToolStripMenuItem
         // 
         this._behaviorRenderOnThumbnailsToolStripMenuItem.Name = "_behaviorRenderOnThumbnailsToolStripMenuItem";
         this._behaviorRenderOnThumbnailsToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
         this._behaviorRenderOnThumbnailsToolStripMenuItem.Text = "&Render on thumbnails";
         // 
         // _behaviorDeselectOnDownToolStripMenuItem
         // 
         this._behaviorDeselectOnDownToolStripMenuItem.Name = "_behaviorDeselectOnDownToolStripMenuItem";
         this._behaviorDeselectOnDownToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
         this._behaviorDeselectOnDownToolStripMenuItem.Text = "&Deselect on down";
         this._behaviorDeselectOnDownToolStripMenuItem.Click += new System.EventHandler(this._behaviorDeselectOnDownToolStripMenuItem_Click);
         // 
         // _behaviorRestrictDesignersToolStripMenuItem
         // 
         this._behaviorRestrictDesignersToolStripMenuItem.Name = "_behaviorRestrictDesignersToolStripMenuItem";
         this._behaviorRestrictDesignersToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
         this._behaviorRestrictDesignersToolStripMenuItem.Text = "Res&trict Designers";
         this._behaviorRestrictDesignersToolStripMenuItem.Click += new System.EventHandler(this._behaviorRestrictDesignersToolStripMenuItem_Click);
         // 
         // _behaviorRubberbandSelectToolStripMenuItem
         // 
         this._behaviorRubberbandSelectToolStripMenuItem.Name = "_behaviorRubberbandSelectToolStripMenuItem";
         this._behaviorRubberbandSelectToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
         this._behaviorRubberbandSelectToolStripMenuItem.Text = "Ru&bberband Select";
         this._behaviorRubberbandSelectToolStripMenuItem.Click += new System.EventHandler(this._behaviorRubberbandSelectToolStripMenuItem_Click);
         // 
         // _preferencesToolStripMenuItem
         // 
         this._preferencesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._userNameToolStripMenuItem,
            this._cacheDirectoryToolStripMenuItem,
            this._autoGetTextToolStripMenuItem,
            this._documentTextOptionsToolStripMenuItem,
            this._showTextIndicatorsToolStripMenuItem,
            this._showOperationsToolStripMenuItem,
            this._diagnosticsToolStripMenuItem,
            this._documentViewerOptionsToolStripMenuItem});
         this._preferencesToolStripMenuItem.Name = "_preferencesToolStripMenuItem";
         this._preferencesToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
         this._preferencesToolStripMenuItem.Text = "P&references";
         this._preferencesToolStripMenuItem.DropDownOpening += new System.EventHandler(this._preferencesToolStripMenuItem_DropDownOpening);
         // 
         // _userNameToolStripMenuItem
         // 
         this._userNameToolStripMenuItem.Name = "_userNameToolStripMenuItem";
         this._userNameToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
         this._userNameToolStripMenuItem.Text = "&User name...";
         this._userNameToolStripMenuItem.ToolTipText = "Change the current user name used with the document";
         this._userNameToolStripMenuItem.Click += new System.EventHandler(this._userNameToolStripMenuItem_Click);
         // 
         // _cacheDirectoryToolStripMenuItem
         // 
         this._cacheDirectoryToolStripMenuItem.Name = "_cacheDirectoryToolStripMenuItem";
         this._cacheDirectoryToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
         this._cacheDirectoryToolStripMenuItem.Text = "&Cache directory...";
         this._cacheDirectoryToolStripMenuItem.ToolTipText = "Change the cache directory used by this application";
         this._cacheDirectoryToolStripMenuItem.Click += new System.EventHandler(this._cacheDirectoryToolStripMenuItem_Click);
         // 
         // _autoGetTextToolStripMenuItem
         // 
         this._autoGetTextToolStripMenuItem.Name = "_autoGetTextToolStripMenuItem";
         this._autoGetTextToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
         this._autoGetTextToolStripMenuItem.Text = "&Auto get text";
         this._autoGetTextToolStripMenuItem.ToolTipText = "Automatically get the text when needed";
         this._autoGetTextToolStripMenuItem.Click += new System.EventHandler(this._autoGetTextToolStripMenuItem_Click);
         // 
         // _documentTextOptionsToolStripMenuItem
         // 
         this._documentTextOptionsToolStripMenuItem.Name = "_documentTextOptionsToolStripMenuItem";
         this._documentTextOptionsToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
         this._documentTextOptionsToolStripMenuItem.Text = "Document text &options...";
         this._documentTextOptionsToolStripMenuItem.ToolTipText = "Show the document text options";
         this._documentTextOptionsToolStripMenuItem.Click += new System.EventHandler(this._documentTextOptionsToolStripMenuItem_Click);
         // 
         // _showTextIndicatorsToolStripMenuItem
         // 
         this._showTextIndicatorsToolStripMenuItem.Name = "_showTextIndicatorsToolStripMenuItem";
         this._showTextIndicatorsToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
         this._showTextIndicatorsToolStripMenuItem.Text = "Show &text indicators";
         this._showTextIndicatorsToolStripMenuItem.ToolTipText = "Show the text indicators on the pages";
         this._showTextIndicatorsToolStripMenuItem.Click += new System.EventHandler(this._showTextIndicatorsToolStripMenuItem_Click);
         // 
         // _showOperationsToolStripMenuItem
         // 
         this._showOperationsToolStripMenuItem.Name = "_showOperationsToolStripMenuItem";
         this._showOperationsToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
         this._showOperationsToolStripMenuItem.Text = "&Show operations";
         this._showOperationsToolStripMenuItem.ToolTipText = "Show the operation pane";
         this._showOperationsToolStripMenuItem.Click += new System.EventHandler(this._showOperationsToolStripMenuItem_Click);
         // 
         // _diagnosticsToolStripMenuItem
         // 
         this._diagnosticsToolStripMenuItem.Name = "_diagnosticsToolStripMenuItem";
         this._diagnosticsToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
         this._diagnosticsToolStripMenuItem.Text = "&Diagnostics...";
         this._diagnosticsToolStripMenuItem.ToolTipText = "Show the diagnostics dialog";
         this._diagnosticsToolStripMenuItem.Click += new System.EventHandler(this._diagnosticsToolStripMenuItem_Click);
         // 
         // _documentViewerOptionsToolStripMenuItem
         // 
         this._documentViewerOptionsToolStripMenuItem.Name = "_documentViewerOptionsToolStripMenuItem";
         this._documentViewerOptionsToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
         this._documentViewerOptionsToolStripMenuItem.Text = "Document &Viewer options...";
         this._documentViewerOptionsToolStripMenuItem.Click += new System.EventHandler(this._documentViewerOptionsToolStripMenuItem_Click);
         // 
         // _helpToolStripMenuItem
         // 
         this._helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._aboutToolStripMenuItem});
         this._helpToolStripMenuItem.Name = "_helpToolStripMenuItem";
         this._helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
         this._helpToolStripMenuItem.Text = "&Help";
         // 
         // _aboutToolStripMenuItem
         // 
         this._aboutToolStripMenuItem.Name = "_aboutToolStripMenuItem";
         this._aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
         this._aboutToolStripMenuItem.Text = "&About...";
         this._aboutToolStripMenuItem.Click += new System.EventHandler(this._aboutToolStripMenuItem_Click);
         // 
         // _mainToolStrip
         // 
         this._mainToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
         this._mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._openDocumentFromFileToolStripButton,
            this._openDocumentFromUrlToolStripButton,
            this._mainToolStripSeparator1,
            this._previousPageToolStripButton,
            this._nextPageToolStripButton,
            this._pageNumberToolStripTextBox,
            this._pageNumberToolStripLabel,
            this._mainToolStripSeparator2,
            this._zoomInToolStripButton,
            this._zoomOutToolStripButton,
            this._zoomToolStripComboBox,
            this._actualSizeToolStripButton,
            this._fitPageToolStripButton,
            this._fitWidthToolStripButton,
            this._mainToolStripSeparator3,
            this._singlePageToolStripButton,
            this._verticalPageToolStripButton,
            this._doublePageToolStripButton,
            this._horizontalPageToolStripButton,
            this._mainToolStripSeparator4,
            this._selectTextToolStripButton,
            this._panZoomToolStripButton,
            this._panToolStripButton,
            this._zoomToolStripButton,
            this._zoomToToolStripButton,
            this._magnifyGlassToolStripButton});
         this._mainToolStrip.Location = new System.Drawing.Point(0, 24);
         this._mainToolStrip.Name = "_mainToolStrip";
         this._mainToolStrip.Size = new System.Drawing.Size(1154, 31);
         this._mainToolStrip.TabIndex = 1;
         // 
         // _openDocumentFromFileToolStripButton
         // 
         this._openDocumentFromFileToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this._openDocumentFromFileToolStripButton.Image = global::DocumentViewerDemo.Properties.Resources.Open;
         this._openDocumentFromFileToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
         this._openDocumentFromFileToolStripButton.Name = "_openDocumentFromFileToolStripButton";
         this._openDocumentFromFileToolStripButton.Size = new System.Drawing.Size(28, 28);
         this._openDocumentFromFileToolStripButton.ToolTipText = "Open document from a disk file";
         this._openDocumentFromFileToolStripButton.Click += new System.EventHandler(this._openDocumentFromFileToolStripButton_Click);
         // 
         // _openDocumentFromUrlToolStripButton
         // 
         this._openDocumentFromUrlToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this._openDocumentFromUrlToolStripButton.Image = global::DocumentViewerDemo.Properties.Resources.OpenUrl;
         this._openDocumentFromUrlToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
         this._openDocumentFromUrlToolStripButton.Name = "_openDocumentFromUrlToolStripButton";
         this._openDocumentFromUrlToolStripButton.Size = new System.Drawing.Size(28, 28);
         this._openDocumentFromUrlToolStripButton.ToolTipText = "Open document from a web address";
         this._openDocumentFromUrlToolStripButton.Click += new System.EventHandler(this._openDocumentFromUrlToolStripButton_Click);
         // 
         // _mainToolStripSeparator1
         // 
         this._mainToolStripSeparator1.Name = "_mainToolStripSeparator1";
         this._mainToolStripSeparator1.Size = new System.Drawing.Size(6, 31);
         // 
         // _previousPageToolStripButton
         // 
         this._previousPageToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this._previousPageToolStripButton.Image = global::DocumentViewerDemo.Properties.Resources.PreviousPage;
         this._previousPageToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
         this._previousPageToolStripButton.Name = "_previousPageToolStripButton";
         this._previousPageToolStripButton.Size = new System.Drawing.Size(28, 28);
         this._previousPageToolStripButton.ToolTipText = "Go to previous page in the document";
         // 
         // _nextPageToolStripButton
         // 
         this._nextPageToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this._nextPageToolStripButton.Image = global::DocumentViewerDemo.Properties.Resources.NextPage;
         this._nextPageToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
         this._nextPageToolStripButton.Name = "_nextPageToolStripButton";
         this._nextPageToolStripButton.Size = new System.Drawing.Size(28, 28);
         this._nextPageToolStripButton.ToolTipText = "Go to next page in the document";
         // 
         // _pageNumberToolStripTextBox
         // 
         this._pageNumberToolStripTextBox.Name = "_pageNumberToolStripTextBox";
         this._pageNumberToolStripTextBox.Size = new System.Drawing.Size(60, 31);
         this._pageNumberToolStripTextBox.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
         this._pageNumberToolStripTextBox.ToolTipText = "Current page number";
         // 
         // _pageNumberToolStripLabel
         // 
         this._pageNumberToolStripLabel.AutoSize = false;
         this._pageNumberToolStripLabel.Name = "_pageNumberToolStripLabel";
         this._pageNumberToolStripLabel.Size = new System.Drawing.Size(60, 22);
         this._pageNumberToolStripLabel.Text = "/##";
         this._pageNumberToolStripLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // _mainToolStripSeparator2
         // 
         this._mainToolStripSeparator2.Name = "_mainToolStripSeparator2";
         this._mainToolStripSeparator2.Size = new System.Drawing.Size(6, 31);
         // 
         // _zoomInToolStripButton
         // 
         this._zoomInToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this._zoomInToolStripButton.Image = global::DocumentViewerDemo.Properties.Resources.ZoomIn;
         this._zoomInToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
         this._zoomInToolStripButton.Name = "_zoomInToolStripButton";
         this._zoomInToolStripButton.Size = new System.Drawing.Size(28, 28);
         this._zoomInToolStripButton.ToolTipText = "Zoom in";
         // 
         // _zoomOutToolStripButton
         // 
         this._zoomOutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this._zoomOutToolStripButton.Image = global::DocumentViewerDemo.Properties.Resources.ZoomOut;
         this._zoomOutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
         this._zoomOutToolStripButton.Name = "_zoomOutToolStripButton";
         this._zoomOutToolStripButton.Size = new System.Drawing.Size(28, 28);
         this._zoomOutToolStripButton.ToolTipText = "Zoom out";
         // 
         // _zoomToolStripComboBox
         // 
         this._zoomToolStripComboBox.Name = "_zoomToolStripComboBox";
         this._zoomToolStripComboBox.Size = new System.Drawing.Size(100, 31);
         // 
         // _actualSizeToolStripButton
         // 
         this._actualSizeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this._actualSizeToolStripButton.Image = global::DocumentViewerDemo.Properties.Resources.ActualSize;
         this._actualSizeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
         this._actualSizeToolStripButton.Name = "_actualSizeToolStripButton";
         this._actualSizeToolStripButton.Size = new System.Drawing.Size(28, 28);
         this._actualSizeToolStripButton.ToolTipText = "Show the actual size of the page";
         // 
         // _fitPageToolStripButton
         // 
         this._fitPageToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this._fitPageToolStripButton.Image = global::DocumentViewerDemo.Properties.Resources.FitPage;
         this._fitPageToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
         this._fitPageToolStripButton.Name = "_fitPageToolStripButton";
         this._fitPageToolStripButton.Size = new System.Drawing.Size(28, 28);
         this._fitPageToolStripButton.ToolTipText = "Fit the image into the window";
         // 
         // _fitWidthToolStripButton
         // 
         this._fitWidthToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this._fitWidthToolStripButton.Image = global::DocumentViewerDemo.Properties.Resources.FitWidth;
         this._fitWidthToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
         this._fitWidthToolStripButton.Name = "_fitWidthToolStripButton";
         this._fitWidthToolStripButton.Size = new System.Drawing.Size(28, 28);
         this._fitWidthToolStripButton.ToolTipText = "Fit the image width into the window";
         // 
         // _mainToolStripSeparator3
         // 
         this._mainToolStripSeparator3.Name = "_mainToolStripSeparator3";
         this._mainToolStripSeparator3.Size = new System.Drawing.Size(6, 31);
         // 
         // _singlePageToolStripButton
         // 
         this._singlePageToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this._singlePageToolStripButton.Image = global::DocumentViewerDemo.Properties.Resources.SingleLayout;
         this._singlePageToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
         this._singlePageToolStripButton.Name = "_singlePageToolStripButton";
         this._singlePageToolStripButton.Size = new System.Drawing.Size(28, 28);
         this._singlePageToolStripButton.ToolTipText = "Single page display";
         // 
         // _verticalPageToolStripButton
         // 
         this._verticalPageToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this._verticalPageToolStripButton.Image = global::DocumentViewerDemo.Properties.Resources.VerticalLayout;
         this._verticalPageToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
         this._verticalPageToolStripButton.Name = "_verticalPageToolStripButton";
         this._verticalPageToolStripButton.Size = new System.Drawing.Size(28, 28);
         this._verticalPageToolStripButton.ToolTipText = "Vertical page display";
         // 
         // _doublePageToolStripButton
         // 
         this._doublePageToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this._doublePageToolStripButton.Image = global::DocumentViewerDemo.Properties.Resources.DoubleLayout;
         this._doublePageToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
         this._doublePageToolStripButton.Name = "_doublePageToolStripButton";
         this._doublePageToolStripButton.Size = new System.Drawing.Size(28, 28);
         this._doublePageToolStripButton.ToolTipText = "Double page display";
         // 
         // _horizontalPageToolStripButton
         // 
         this._horizontalPageToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this._horizontalPageToolStripButton.Image = global::DocumentViewerDemo.Properties.Resources.HorizontalLayout;
         this._horizontalPageToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
         this._horizontalPageToolStripButton.Name = "_horizontalPageToolStripButton";
         this._horizontalPageToolStripButton.Size = new System.Drawing.Size(28, 28);
         this._horizontalPageToolStripButton.ToolTipText = "Horizontal page display";
         // 
         // _mainToolStripSeparator4
         // 
         this._mainToolStripSeparator4.Name = "_mainToolStripSeparator4";
         this._mainToolStripSeparator4.Size = new System.Drawing.Size(6, 31);
         // 
         // _selectTextToolStripButton
         // 
         this._selectTextToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this._selectTextToolStripButton.Image = global::DocumentViewerDemo.Properties.Resources.SelectTextMode;
         this._selectTextToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
         this._selectTextToolStripButton.Name = "_selectTextToolStripButton";
         this._selectTextToolStripButton.Size = new System.Drawing.Size(28, 28);
         this._selectTextToolStripButton.ToolTipText = "Select text";
         // 
         // _panZoomToolStripButton
         // 
         this._panZoomToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this._panZoomToolStripButton.Image = global::DocumentViewerDemo.Properties.Resources.PanZoomMode;
         this._panZoomToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
         this._panZoomToolStripButton.Name = "_panZoomToolStripButton";
         this._panZoomToolStripButton.Size = new System.Drawing.Size(28, 28);
         this._panZoomToolStripButton.ToolTipText = "Pan and zoom";
         // 
         // _panToolStripButton
         // 
         this._panToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this._panToolStripButton.Image = global::DocumentViewerDemo.Properties.Resources.PanMode;
         this._panToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
         this._panToolStripButton.Name = "_panToolStripButton";
         this._panToolStripButton.Size = new System.Drawing.Size(28, 28);
         this._panToolStripButton.ToolTipText = "Pan";
         // 
         // _zoomToolStripButton
         // 
         this._zoomToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this._zoomToolStripButton.Image = global::DocumentViewerDemo.Properties.Resources.ZoomMode;
         this._zoomToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
         this._zoomToolStripButton.Name = "_zoomToolStripButton";
         this._zoomToolStripButton.Size = new System.Drawing.Size(28, 28);
         this._zoomToolStripButton.ToolTipText = "Zoom";
         // 
         // _zoomToToolStripButton
         // 
         this._zoomToToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this._zoomToToolStripButton.Image = global::DocumentViewerDemo.Properties.Resources.ZoomToMode;
         this._zoomToToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
         this._zoomToToolStripButton.Name = "_zoomToToolStripButton";
         this._zoomToToolStripButton.Size = new System.Drawing.Size(28, 28);
         this._zoomToToolStripButton.ToolTipText = "Zoom to";
         // 
         // _magnifyGlassToolStripButton
         // 
         this._magnifyGlassToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this._magnifyGlassToolStripButton.Image = global::DocumentViewerDemo.Properties.Resources.MagnifyGlassMode;
         this._magnifyGlassToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
         this._magnifyGlassToolStripButton.Name = "_magnifyGlassToolStripButton";
         this._magnifyGlassToolStripButton.Size = new System.Drawing.Size(28, 28);
         this._magnifyGlassToolStripButton.ToolTipText = "Magnify Glass";
         // 
         // _leftPanel
         // 
         this._leftPanel.Controls.Add(this._leftTabControl);
         this._leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
         this._leftPanel.Location = new System.Drawing.Point(0, 55);
         this._leftPanel.Name = "_leftPanel";
         this._leftPanel.Size = new System.Drawing.Size(200, 459);
         this._leftPanel.TabIndex = 2;
         // 
         // _leftTabControl
         // 
         this._leftTabControl.Controls.Add(this._thumbnailsTabPage);
         this._leftTabControl.Controls.Add(this._bookmarksTabPage);
         this._leftTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
         this._leftTabControl.Location = new System.Drawing.Point(0, 0);
         this._leftTabControl.Name = "_leftTabControl";
         this._leftTabControl.SelectedIndex = 0;
         this._leftTabControl.Size = new System.Drawing.Size(200, 459);
         this._leftTabControl.TabIndex = 1;
         // 
         // _thumbnailsTabPage
         // 
         this._thumbnailsTabPage.ContextMenuStrip = this._thumbnailsContextMenuStrip;
         this._thumbnailsTabPage.Controls.Add(this._loadingThumbnailsProgressBar);
         this._thumbnailsTabPage.Location = new System.Drawing.Point(4, 22);
         this._thumbnailsTabPage.Name = "_thumbnailsTabPage";
         this._thumbnailsTabPage.Padding = new System.Windows.Forms.Padding(3);
         this._thumbnailsTabPage.Size = new System.Drawing.Size(192, 433);
         this._thumbnailsTabPage.TabIndex = 0;
         this._thumbnailsTabPage.Text = "Pages";
         // 
         // _thumbnailsContextMenuStrip
         // 
         this._thumbnailsContextMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
         this._thumbnailsContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._thumbnailsGetThisPageTextToolStripMenuItem,
            this._thumbnailsGetAllPagesTextToolStripMenuItem,
            this._thumbnailsSep1ToolStripMenuItem,
            this._thumbnailsRotateClockwiseToolStripMenuItem,
            this._thumbnailsRotateCounterClockwiseToolStripMenuItem,
            this._thumbnailsSep2ToolStripMenuItem,
            this._thumbnailsEnableDisablePageToolStripMenuItem});
         this._thumbnailsContextMenuStrip.Name = "_thumbnailsCcontextMenuStrip";
         this._thumbnailsContextMenuStrip.Size = new System.Drawing.Size(207, 126);
         this._thumbnailsContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this._thumbnailsContextMenuStrip_Opening);
         // 
         // _thumbnailsGetThisPageTextToolStripMenuItem
         // 
         this._thumbnailsGetThisPageTextToolStripMenuItem.Name = "_thumbnailsGetThisPageTextToolStripMenuItem";
         this._thumbnailsGetThisPageTextToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
         this._thumbnailsGetThisPageTextToolStripMenuItem.Text = "Get &text for this page";
         this._thumbnailsGetThisPageTextToolStripMenuItem.Click += new System.EventHandler(this._thumbnailsGetThisPageTextToolStripMenuItem_Click);
         // 
         // _thumbnailsGetAllPagesTextToolStripMenuItem
         // 
         this._thumbnailsGetAllPagesTextToolStripMenuItem.Name = "_thumbnailsGetAllPagesTextToolStripMenuItem";
         this._thumbnailsGetAllPagesTextToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
         this._thumbnailsGetAllPagesTextToolStripMenuItem.Text = "Get text for &all pages";
         this._thumbnailsGetAllPagesTextToolStripMenuItem.Click += new System.EventHandler(this._thumbnailsGetAllPagesTextToolStripMenuItem_Click);
         // 
         // _thumbnailsSep1ToolStripMenuItem
         // 
         this._thumbnailsSep1ToolStripMenuItem.Name = "_thumbnailsSep1ToolStripMenuItem";
         this._thumbnailsSep1ToolStripMenuItem.Size = new System.Drawing.Size(203, 6);
         // 
         // _thumbnailsRotateClockwiseToolStripMenuItem
         // 
         this._thumbnailsRotateClockwiseToolStripMenuItem.Name = "_thumbnailsRotateClockwiseToolStripMenuItem";
         this._thumbnailsRotateClockwiseToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
         this._thumbnailsRotateClockwiseToolStripMenuItem.Text = "&Rotate clockwise";
         this._thumbnailsRotateClockwiseToolStripMenuItem.ToolTipText = "Rotate this page by 90 degrees clockwise";
         this._thumbnailsRotateClockwiseToolStripMenuItem.Click += new System.EventHandler(this._thumbnailsRotateClockwiseToolStripMenuItem_Click);
         // 
         // _thumbnailsRotateCounterClockwiseToolStripMenuItem
         // 
         this._thumbnailsRotateCounterClockwiseToolStripMenuItem.Name = "_thumbnailsRotateCounterClockwiseToolStripMenuItem";
         this._thumbnailsRotateCounterClockwiseToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
         this._thumbnailsRotateCounterClockwiseToolStripMenuItem.Text = "Rotate &counter clockwise";
         this._thumbnailsRotateCounterClockwiseToolStripMenuItem.ToolTipText = "Rotate this page by 90 degrees counter-clockwise";
         this._thumbnailsRotateCounterClockwiseToolStripMenuItem.Click += new System.EventHandler(this._thumbnailsRotateCounterClockwiseToolStripMenuItem_Click);
         // 
         // _thumbnailsSep2ToolStripMenuItem
         // 
         this._thumbnailsSep2ToolStripMenuItem.Name = "_thumbnailsSep2ToolStripMenuItem";
         this._thumbnailsSep2ToolStripMenuItem.Size = new System.Drawing.Size(203, 6);
         // 
         // _thumbnailsEnableDisablePageToolStripMenuItem
         // 
         this._thumbnailsEnableDisablePageToolStripMenuItem.Name = "_thumbnailsEnableDisablePageToolStripMenuItem";
         this._thumbnailsEnableDisablePageToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
         this._thumbnailsEnableDisablePageToolStripMenuItem.Text = "Mark page as &disabled";
         this._thumbnailsEnableDisablePageToolStripMenuItem.ToolTipText = "Mark this page as disabled in the document";
         this._thumbnailsEnableDisablePageToolStripMenuItem.Click += new System.EventHandler(this._thumbnailsEnableDisablePageToolStripMenuItem_Click);
         // 
         // _loadingThumbnailsProgressBar
         // 
         this._loadingThumbnailsProgressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
         this._loadingThumbnailsProgressBar.Location = new System.Drawing.Point(3, 420);
         this._loadingThumbnailsProgressBar.MarqueeAnimationSpeed = 50;
         this._loadingThumbnailsProgressBar.Name = "_loadingThumbnailsProgressBar";
         this._loadingThumbnailsProgressBar.Size = new System.Drawing.Size(186, 10);
         this._loadingThumbnailsProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
         this._loadingThumbnailsProgressBar.TabIndex = 1;
         this._loadingThumbnailsProgressBar.Visible = false;
         // 
         // _bookmarksTabPage
         // 
         this._bookmarksTabPage.Controls.Add(this._loadingBookmarksProgressBar);
         this._bookmarksTabPage.Location = new System.Drawing.Point(4, 22);
         this._bookmarksTabPage.Name = "_bookmarksTabPage";
         this._bookmarksTabPage.Padding = new System.Windows.Forms.Padding(3);
         this._bookmarksTabPage.Size = new System.Drawing.Size(192, 433);
         this._bookmarksTabPage.TabIndex = 1;
         this._bookmarksTabPage.Text = "Bookmarks";
         this._bookmarksTabPage.UseVisualStyleBackColor = true;
         // 
         // _loadingBookmarksProgressBar
         // 
         this._loadingBookmarksProgressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
         this._loadingBookmarksProgressBar.Location = new System.Drawing.Point(3, 420);
         this._loadingBookmarksProgressBar.MarqueeAnimationSpeed = 50;
         this._loadingBookmarksProgressBar.Name = "_loadingBookmarksProgressBar";
         this._loadingBookmarksProgressBar.Size = new System.Drawing.Size(186, 10);
         this._loadingBookmarksProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
         this._loadingBookmarksProgressBar.TabIndex = 2;
         this._loadingBookmarksProgressBar.Visible = false;
         // 
         // _rightPanel
         // 
         this._rightPanel.Controls.Add(this._loadingAnnotationsProgressBar);
         this._rightPanel.Controls.Add(this._annotationsControlPanel);
         this._rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
         this._rightPanel.Location = new System.Drawing.Point(954, 55);
         this._rightPanel.Name = "_rightPanel";
         this._rightPanel.Size = new System.Drawing.Size(200, 459);
         this._rightPanel.TabIndex = 3;
         // 
         // _loadingAnnotationsProgressBar
         // 
         this._loadingAnnotationsProgressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
         this._loadingAnnotationsProgressBar.Location = new System.Drawing.Point(0, 449);
         this._loadingAnnotationsProgressBar.MarqueeAnimationSpeed = 50;
         this._loadingAnnotationsProgressBar.Name = "_loadingAnnotationsProgressBar";
         this._loadingAnnotationsProgressBar.Size = new System.Drawing.Size(200, 10);
         this._loadingAnnotationsProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
         this._loadingAnnotationsProgressBar.TabIndex = 4;
         this._loadingAnnotationsProgressBar.Visible = false;
         // 
         // _annotationsControlPanel
         // 
         this._annotationsControlPanel.Controls.Add(this._annotationsObjectsPanel);
         this._annotationsControlPanel.Controls.Add(this._annotationsControlSplitter);
         this._annotationsControlPanel.Controls.Add(this._annotationsToolBarPanel);
         this._annotationsControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
         this._annotationsControlPanel.Location = new System.Drawing.Point(0, 0);
         this._annotationsControlPanel.Name = "_annotationsControlPanel";
         this._annotationsControlPanel.Size = new System.Drawing.Size(200, 459);
         this._annotationsControlPanel.TabIndex = 3;
         // 
         // _annotationsObjectsPanel
         // 
         this._annotationsObjectsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this._annotationsObjectsPanel.Controls.Add(this._annotationsObjectsLabel);
         this._annotationsObjectsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
         this._annotationsObjectsPanel.Location = new System.Drawing.Point(0, 232);
         this._annotationsObjectsPanel.Name = "_annotationsObjectsPanel";
         this._annotationsObjectsPanel.Size = new System.Drawing.Size(200, 227);
         this._annotationsObjectsPanel.TabIndex = 2;
         // 
         // _annotationsObjectsLabel
         // 
         this._annotationsObjectsLabel.Dock = System.Windows.Forms.DockStyle.Top;
         this._annotationsObjectsLabel.Location = new System.Drawing.Point(0, 0);
         this._annotationsObjectsLabel.Name = "_annotationsObjectsLabel";
         this._annotationsObjectsLabel.Size = new System.Drawing.Size(198, 13);
         this._annotationsObjectsLabel.TabIndex = 0;
         this._annotationsObjectsLabel.Text = "Objects";
         this._annotationsObjectsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         // 
         // _annotationsControlSplitter
         // 
         this._annotationsControlSplitter.Dock = System.Windows.Forms.DockStyle.Top;
         this._annotationsControlSplitter.Location = new System.Drawing.Point(0, 228);
         this._annotationsControlSplitter.Name = "_annotationsControlSplitter";
         this._annotationsControlSplitter.Size = new System.Drawing.Size(200, 4);
         this._annotationsControlSplitter.TabIndex = 3;
         this._annotationsControlSplitter.TabStop = false;
         // 
         // _annotationsToolBarPanel
         // 
         this._annotationsToolBarPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this._annotationsToolBarPanel.Controls.Add(this._annotationsShapeLabel);
         this._annotationsToolBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
         this._annotationsToolBarPanel.Location = new System.Drawing.Point(0, 0);
         this._annotationsToolBarPanel.Name = "_annotationsToolBarPanel";
         this._annotationsToolBarPanel.Size = new System.Drawing.Size(200, 228);
         this._annotationsToolBarPanel.TabIndex = 0;
         // 
         // _annotationsShapeLabel
         // 
         this._annotationsShapeLabel.Dock = System.Windows.Forms.DockStyle.Top;
         this._annotationsShapeLabel.Location = new System.Drawing.Point(0, 0);
         this._annotationsShapeLabel.Name = "_annotationsShapeLabel";
         this._annotationsShapeLabel.Size = new System.Drawing.Size(198, 13);
         this._annotationsShapeLabel.TabIndex = 1;
         this._annotationsShapeLabel.Text = "Shapes";
         this._annotationsShapeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         // 
         // _leftSplitter
         // 
         this._leftSplitter.Location = new System.Drawing.Point(200, 55);
         this._leftSplitter.Name = "_leftSplitter";
         this._leftSplitter.Size = new System.Drawing.Size(4, 459);
         this._leftSplitter.TabIndex = 4;
         this._leftSplitter.TabStop = false;
         // 
         // _rightSplitter
         // 
         this._rightSplitter.Dock = System.Windows.Forms.DockStyle.Right;
         this._rightSplitter.Location = new System.Drawing.Point(950, 55);
         this._rightSplitter.Name = "_rightSplitter";
         this._rightSplitter.Size = new System.Drawing.Size(4, 459);
         this._rightSplitter.TabIndex = 5;
         this._rightSplitter.TabStop = false;
         // 
         // _centerPanel
         // 
         this._centerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
         this._centerPanel.Location = new System.Drawing.Point(204, 55);
         this._centerPanel.Name = "_centerPanel";
         this._centerPanel.Size = new System.Drawing.Size(746, 459);
         this._centerPanel.TabIndex = 6;
         // 
         // _bottomPanel
         // 
         this._bottomPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this._bottomPanel.Controls.Add(this._outputWindow);
         this._bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
         this._bottomPanel.Location = new System.Drawing.Point(0, 514);
         this._bottomPanel.Name = "_bottomPanel";
         this._bottomPanel.Size = new System.Drawing.Size(1154, 91);
         this._bottomPanel.TabIndex = 7;
         // 
         // _outputWindow
         // 
         this._outputWindow.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this._outputWindow.Dock = System.Windows.Forms.DockStyle.Fill;
         this._outputWindow.Font = new System.Drawing.Font("Consolas", 8F);
         this._outputWindow.Location = new System.Drawing.Point(0, 0);
         this._outputWindow.Name = "_outputWindow";
         this._outputWindow.ReadOnly = true;
         this._outputWindow.Size = new System.Drawing.Size(1152, 89);
         this._outputWindow.TabIndex = 0;
         this._outputWindow.Text = "";
         // 
         // _annotationsSep4ToolStripSeparator
         // 
         this._annotationsSep4ToolStripSeparator.Name = "_annotationsSep4ToolStripSeparator";
         this._annotationsSep4ToolStripSeparator.Size = new System.Drawing.Size(177, 6);
         // 
         // _redactionOptionsToolStripMenuItem
         // 
         this._redactionOptionsToolStripMenuItem.Name = "_redactionOptionsToolStripMenuItem";
         this._redactionOptionsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
         this._redactionOptionsToolStripMenuItem.Text = "&Redaction Options...";
         this._redactionOptionsToolStripMenuItem.Click += new System.EventHandler(this._redactionOptionsToolStripMenuItem_Click);
         // 
         // MainForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1154, 605);
         this.Controls.Add(this._centerPanel);
         this.Controls.Add(this._rightSplitter);
         this.Controls.Add(this._leftSplitter);
         this.Controls.Add(this._rightPanel);
         this.Controls.Add(this._leftPanel);
         this.Controls.Add(this._mainToolStrip);
         this.Controls.Add(this._mainMenuStrip);
         this.Controls.Add(this._bottomPanel);
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MainMenuStrip = this._mainMenuStrip;
         this.Name = "MainForm";
         this.Text = "MainForm";
         this._mainMenuStrip.ResumeLayout(false);
         this._mainMenuStrip.PerformLayout();
         this._mainToolStrip.ResumeLayout(false);
         this._mainToolStrip.PerformLayout();
         this._leftPanel.ResumeLayout(false);
         this._leftTabControl.ResumeLayout(false);
         this._thumbnailsTabPage.ResumeLayout(false);
         this._thumbnailsContextMenuStrip.ResumeLayout(false);
         this._bookmarksTabPage.ResumeLayout(false);
         this._rightPanel.ResumeLayout(false);
         this._annotationsControlPanel.ResumeLayout(false);
         this._annotationsObjectsPanel.ResumeLayout(false);
         this._annotationsToolBarPanel.ResumeLayout(false);
         this._bottomPanel.ResumeLayout(false);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.MenuStrip _mainMenuStrip;
      private System.Windows.Forms.ToolStripMenuItem _fileToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _exitToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _helpToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _aboutToolStripMenuItem;
      private System.Windows.Forms.ToolStrip _mainToolStrip;
      private System.Windows.Forms.Panel _leftPanel;
      private System.Windows.Forms.Panel _rightPanel;
      private System.Windows.Forms.Splitter _leftSplitter;
      private System.Windows.Forms.Splitter _rightSplitter;
      private System.Windows.Forms.Panel _centerPanel;
      private System.Windows.Forms.ToolStripMenuItem _openDocumentFromFileToolStripMenuItem;
      private System.Windows.Forms.ToolStripSeparator _fileSep2ToolStripMenuItem;
      private System.Windows.Forms.ToolStripButton _openDocumentFromFileToolStripButton;
      private System.Windows.Forms.ToolStripMenuItem _closeToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _openDocumentFromUrltoolStripMenuItem;
      private System.Windows.Forms.ToolStripButton _openDocumentFromUrlToolStripButton;
      private System.Windows.Forms.ToolStripMenuItem _exportTextToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _propertiesToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _editToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _copyToolStripMenuItem;
      private System.Windows.Forms.ToolStripSeparator _editSep2ToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _selectAllToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _clearSelectionToolStripMenuItem;
      private System.Windows.Forms.ToolStripSeparator _editSep3ToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _findToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _findNextToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _findPreviousToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _viewToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _rotateVieweToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _clockwiseToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _counterClockwiseToolStripMenuItem;
      private System.Windows.Forms.ToolStripSeparator _viewSep1ToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _zoomOutToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _zoomInToolStripMenuItem;
      private System.Windows.Forms.ToolStripSeparator _viewSep2ToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _fitWidthToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _fitPageToolStripMenuItem;
      private System.Windows.Forms.ToolStripSeparator _viewSep3ToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _thumbnailsToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _bookmarksToolStripMenuItem;
      private System.Windows.Forms.ToolStripSeparator _viewSep4ToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _pageToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _firstPageToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _previousPageToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _nextPageToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _lastPageToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _gotoPageToolStripMenuItem;
      private System.Windows.Forms.ToolStripSeparator _pageSep1ToolStripSeparator;
      private System.Windows.Forms.ToolStripMenuItem _displayPageToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _singlePageToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _doublePageToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _horizontalPageToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _verticalPageToolStripMenuItem;
      private System.Windows.Forms.Panel _bottomPanel;
      private UI.OutputWindow _outputWindow;
      private System.Windows.Forms.ToolStripMenuItem _preferencesToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _showOperationsToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _actualSizeToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _interactiveToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _panZoomToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _panToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _zoomToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _zoomToToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _magnifyGlassToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _selectTextToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _asSvgToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _asImageToolStripMenuItem;
      private System.Windows.Forms.ToolStripSeparator _mainToolStripSeparator1;
      private System.Windows.Forms.ToolStripButton _previousPageToolStripButton;
      private System.Windows.Forms.ToolStripButton _nextPageToolStripButton;
      private System.Windows.Forms.ToolStripTextBox _pageNumberToolStripTextBox;
      private System.Windows.Forms.ToolStripLabel _pageNumberToolStripLabel;
      private System.Windows.Forms.ToolStripSeparator _mainToolStripSeparator2;
      private System.Windows.Forms.ToolStripButton _zoomInToolStripButton;
      private System.Windows.Forms.ToolStripButton _zoomOutToolStripButton;
      private System.Windows.Forms.ToolStripComboBox _zoomToolStripComboBox;
      private System.Windows.Forms.ToolStripButton _fitPageToolStripButton;
      private System.Windows.Forms.ToolStripButton _fitWidthToolStripButton;
      private System.Windows.Forms.ToolStripButton _actualSizeToolStripButton;
      private System.Windows.Forms.TabControl _leftTabControl;
      private System.Windows.Forms.TabPage _thumbnailsTabPage;
      private System.Windows.Forms.TabPage _bookmarksTabPage;
      private System.Windows.Forms.ProgressBar _loadingThumbnailsProgressBar;
      private System.Windows.Forms.ToolStripMenuItem _diagnosticsToolStripMenuItem;
      private System.Windows.Forms.Panel _annotationsToolBarPanel;
      private System.Windows.Forms.Panel _annotationsObjectsPanel;
      private System.Windows.Forms.ToolStripMenuItem _annotationsToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _userModeToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _userModeRunToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _userModeDesignToolStripMenuItem;
      private System.Windows.Forms.ToolStripSeparator _annotationsSep1ToolStripSeparator;
      private System.Windows.Forms.ToolStripMenuItem _currentObjectToolStripMenuItem;
      private System.Windows.Forms.ToolStripSeparator _annotationsSep2ToolStripSeparator;
      private System.Windows.Forms.ToolStripMenuItem _alignToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _alignBringToFrontToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _alignSendToBackToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _alignBringToFirstToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _alignSendToLastToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _flipToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _flipHorizontalToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _flipVerticalToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _groupToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _groupSelectedObjectsToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _groupUngroupToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _securityToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _securityLockToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _securityUnlockToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _resetRotatePointsToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _antiAliasToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _annotationsPropertiesToolStripMenuItem;
      private System.Windows.Forms.ToolStripSeparator _annotationsSep3ToolStripSeparator;
      private System.Windows.Forms.ToolStripMenuItem _behaviorToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _behaviorUseRotateThumbsToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _behaviorEnableToolTipToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _undoToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _redoToolStripMenuItem;
      private System.Windows.Forms.ToolStripSeparator _editSep1ToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _cutToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _pasteToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _deleteToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _selectAllAnnotationsToolStripMenuItemtoolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _userNameToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _behaviorRenderOnThumbnailsToolStripMenuItem;
      private System.Windows.Forms.ToolStripSeparator _interactiveSep1ToolStripSeparator;
      private System.Windows.Forms.ToolStripMenuItem _autoPanToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _userModeRenderToolStripMenuItem;
      private System.Windows.Forms.Panel _annotationsControlPanel;
      private System.Windows.Forms.Splitter _annotationsControlSplitter;
      private System.Windows.Forms.ProgressBar _loadingAnnotationsProgressBar;
      private System.Windows.Forms.ToolStripMenuItem _getCurrentPageTextToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _getAllPagesTextToolStripMenuItem;
      private System.Windows.Forms.ToolStripSeparator _pageSep4ToolStripSeparator;
      private System.Windows.Forms.ContextMenuStrip _thumbnailsContextMenuStrip;
      private System.Windows.Forms.ToolStripMenuItem _thumbnailsGetThisPageTextToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _thumbnailsGetAllPagesTextToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _showTextIndicatorsToolStripMenuItem;
      private System.Windows.Forms.ToolStripSeparator _userModeSep1ToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _customizeRenderModeToolStripMenuItem;
      private System.Windows.Forms.Label _annotationsObjectsLabel;
      private System.Windows.Forms.Label _annotationsShapeLabel;
      private System.Windows.Forms.ToolStripSeparator _mainToolStripSeparator3;
      private System.Windows.Forms.ToolStripButton _singlePageToolStripButton;
      private System.Windows.Forms.ToolStripButton _verticalPageToolStripButton;
      private System.Windows.Forms.ToolStripButton _doublePageToolStripButton;
      private System.Windows.Forms.ToolStripButton _horizontalPageToolStripButton;
      private System.Windows.Forms.ToolStripMenuItem _saveToolStripMenuItem;
      private System.Windows.Forms.ToolStripSeparator _fileSep3ToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _cacheDirectoryToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _printToolStripMenuItem;
      private System.Windows.Forms.ToolStripSeparator _fileSep4ToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _printSetupToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _autoGetTextToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _documentTextOptionsToolStripMenuItem;
      private System.Windows.Forms.ToolStripSeparator _mainToolStripSeparator4;
      private System.Windows.Forms.ToolStripButton _selectTextToolStripButton;
      private System.Windows.Forms.ToolStripButton _panZoomToolStripButton;
      private System.Windows.Forms.ToolStripButton _panToolStripButton;
      private System.Windows.Forms.ToolStripButton _zoomToolStripButton;
      private System.Windows.Forms.ToolStripButton _zoomToToolStripButton;
      private System.Windows.Forms.ToolStripButton _magnifyGlassToolStripButton;
      private System.Windows.Forms.ToolStripMenuItem _inertiaScrollToolStripMenuItem;
      private System.Windows.Forms.ProgressBar _loadingBookmarksProgressBar;
      private System.Windows.Forms.ToolStripMenuItem _documentViewerOptionsToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _behaviorDeselectOnDownToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _behaviorRestrictDesignersToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _behaviorRubberbandSelectToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _openFromCacheToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _saveToCacheToolStripMenuItem;
      private System.Windows.Forms.ToolStripSeparator _fileSep1ToolStripMenuItem;
      private System.Windows.Forms.ToolStripSeparator _thumbnailsSep1ToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _thumbnailsRotateClockwiseToolStripMenuItem;
      private System.Windows.Forms.ToolStripSeparator _pageSep2ToolStripSeparator;
      private System.Windows.Forms.ToolStripMenuItem _rotatePageClockwiseToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _rotatePageCounterClockwiseToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _thumbnailsRotateCounterClockwiseToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _rotatePagesToolStripMenuItem;
      private System.Windows.Forms.ToolStripSeparator _pageSep3ToolStripSeparator;
      private System.Windows.Forms.ToolStripMenuItem _enableDisablePageToolStripMenuItem;
      private System.Windows.Forms.ToolStripSeparator _thumbnailsSep2ToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _thumbnailsEnableDisablePageToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _saveCurrentViewToolStripMenuItem;
      private System.Windows.Forms.ToolStripSeparator _annotationsSep4ToolStripSeparator;
      private System.Windows.Forms.ToolStripMenuItem _redactionOptionsToolStripMenuItem;
   }
}

