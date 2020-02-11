namespace Leadtools.Demos
{
   partial class DocumentConverterDialog
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocumentConverterDialog));
         this._tabControl = new System.Windows.Forms.TabControl();
         this._documentTabPage = new System.Windows.Forms.TabPage();
         this._documentControl = new Leadtools.Demos.DocumentConverterDocumentControl();
         this._optionsTabPage = new System.Windows.Forms.TabPage();
         this._optionsControl = new Leadtools.Demos.DocumentConverterOptionsControl();
         this._ocrSettingsTabPage = new System.Windows.Forms.TabPage();
         this._ocrEngineSettingsControl = new Leadtools.Demos.OcrEngineSettingsControl();
         this._ocrEnginePanel = new System.Windows.Forms.Panel();
         this._ocrEngineLabel = new System.Windows.Forms.Label();
         this._ocrLanguagesTabPage = new System.Windows.Forms.TabPage();
         this._languagesGroupBox = new System.Windows.Forms.GroupBox();
         this._languagesAdditionalLabel = new System.Windows.Forms.Label();
         this._languagesHintLabel = new System.Windows.Forms.Label();
         this._languagesMoveTopButton = new System.Windows.Forms.Button();
         this._enabledLanguagesListBox = new System.Windows.Forms.ListBox();
         this._enabledLanguagesLabel = new System.Windows.Forms.Label();
         this._languagesMoveLeftButton = new System.Windows.Forms.Button();
         this._languagesMoveRightButton = new System.Windows.Forms.Button();
         this._languagesListBox = new System.Windows.Forms.ListBox();
         this._languagesLabel = new System.Windows.Forms.Label();
         this._okButton = new System.Windows.Forms.Button();
         this._cancelButton = new System.Windows.Forms.Button();
         this._aboutButton = new System.Windows.Forms.Button();
         this._tabControl.SuspendLayout();
         this._documentTabPage.SuspendLayout();
         this._optionsTabPage.SuspendLayout();
         this._ocrSettingsTabPage.SuspendLayout();
         this._ocrEnginePanel.SuspendLayout();
         this._ocrLanguagesTabPage.SuspendLayout();
         this._languagesGroupBox.SuspendLayout();
         this.SuspendLayout();
         // 
         // _tabControl
         // 
         this._tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this._tabControl.Controls.Add(this._documentTabPage);
         this._tabControl.Controls.Add(this._optionsTabPage);
         this._tabControl.Controls.Add(this._ocrSettingsTabPage);
         this._tabControl.Controls.Add(this._ocrLanguagesTabPage);
         this._tabControl.Location = new System.Drawing.Point(12, 12);
         this._tabControl.Name = "_tabControl";
         this._tabControl.SelectedIndex = 0;
         this._tabControl.Size = new System.Drawing.Size(660, 350);
         this._tabControl.TabIndex = 0;
         // 
         // _documentTabPage
         // 
         this._documentTabPage.Controls.Add(this._documentControl);
         this._documentTabPage.Location = new System.Drawing.Point(4, 22);
         this._documentTabPage.Name = "_documentTabPage";
         this._documentTabPage.Padding = new System.Windows.Forms.Padding(3);
         this._documentTabPage.Size = new System.Drawing.Size(652, 324);
         this._documentTabPage.TabIndex = 0;
         this._documentTabPage.Text = "Document";
         this._documentTabPage.UseVisualStyleBackColor = true;
         // 
         // _documentControl
         // 
         this._documentControl.Dock = System.Windows.Forms.DockStyle.Fill;
         this._documentControl.Location = new System.Drawing.Point(3, 3);
         this._documentControl.Name = "_documentControl";
         this._documentControl.Size = new System.Drawing.Size(646, 318);
         this._documentControl.TabIndex = 0;
         // 
         // _optionsTabPage
         // 
         this._optionsTabPage.Controls.Add(this._optionsControl);
         this._optionsTabPage.Location = new System.Drawing.Point(4, 22);
         this._optionsTabPage.Name = "_optionsTabPage";
         this._optionsTabPage.Padding = new System.Windows.Forms.Padding(3);
         this._optionsTabPage.Size = new System.Drawing.Size(652, 324);
         this._optionsTabPage.TabIndex = 1;
         this._optionsTabPage.Text = "Options";
         this._optionsTabPage.UseVisualStyleBackColor = true;
         // 
         // _optionsControl
         // 
         this._optionsControl.Dock = System.Windows.Forms.DockStyle.Fill;
         this._optionsControl.Location = new System.Drawing.Point(3, 3);
         this._optionsControl.Name = "_optionsControl";
         this._optionsControl.Size = new System.Drawing.Size(646, 318);
         this._optionsControl.TabIndex = 0;
         // 
         // _ocrSettingsTabPage
         // 
         this._ocrSettingsTabPage.Controls.Add(this._ocrEngineSettingsControl);
         this._ocrSettingsTabPage.Controls.Add(this._ocrEnginePanel);
         this._ocrSettingsTabPage.Location = new System.Drawing.Point(4, 22);
         this._ocrSettingsTabPage.Name = "_ocrSettingsTabPage";
         this._ocrSettingsTabPage.Size = new System.Drawing.Size(652, 324);
         this._ocrSettingsTabPage.TabIndex = 2;
         this._ocrSettingsTabPage.Text = "OCR Settings";
         this._ocrSettingsTabPage.UseVisualStyleBackColor = true;
         // 
         // _ocrEngineSettingsControl
         // 
         this._ocrEngineSettingsControl.Location = new System.Drawing.Point(3, 32);
         this._ocrEngineSettingsControl.Name = "_ocrEngineSettingsControl";
         this._ocrEngineSettingsControl.Size = new System.Drawing.Size(510, 266);
         this._ocrEngineSettingsControl.TabIndex = 1;
         // 
         // _ocrEnginePanel
         // 
         this._ocrEnginePanel.Controls.Add(this._ocrEngineLabel);
         this._ocrEnginePanel.Dock = System.Windows.Forms.DockStyle.Top;
         this._ocrEnginePanel.Location = new System.Drawing.Point(0, 0);
         this._ocrEnginePanel.Name = "_ocrEnginePanel";
         this._ocrEnginePanel.Size = new System.Drawing.Size(652, 26);
         this._ocrEnginePanel.TabIndex = 0;
         // 
         // _ocrEngineLabel
         // 
         this._ocrEngineLabel.AutoSize = true;
         this._ocrEngineLabel.Location = new System.Drawing.Point(12, 8);
         this._ocrEngineLabel.Name = "_ocrEngineLabel";
         this._ocrEngineLabel.Size = new System.Drawing.Size(90, 13);
         this._ocrEngineLabel.TabIndex = 0;
         this._ocrEngineLabel.Text = "OCR Engine:###";
         // 
         // _ocrLanguagesTabPage
         // 
         this._ocrLanguagesTabPage.Controls.Add(this._languagesGroupBox);
         this._ocrLanguagesTabPage.Location = new System.Drawing.Point(4, 22);
         this._ocrLanguagesTabPage.Name = "_ocrLanguagesTabPage";
         this._ocrLanguagesTabPage.Size = new System.Drawing.Size(652, 324);
         this._ocrLanguagesTabPage.TabIndex = 3;
         this._ocrLanguagesTabPage.Text = "OCR Languages";
         this._ocrLanguagesTabPage.UseVisualStyleBackColor = true;
         // 
         // _languagesGroupBox
         // 
         this._languagesGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this._languagesGroupBox.Controls.Add(this._languagesAdditionalLabel);
         this._languagesGroupBox.Controls.Add(this._languagesHintLabel);
         this._languagesGroupBox.Controls.Add(this._languagesMoveTopButton);
         this._languagesGroupBox.Controls.Add(this._enabledLanguagesListBox);
         this._languagesGroupBox.Controls.Add(this._enabledLanguagesLabel);
         this._languagesGroupBox.Controls.Add(this._languagesMoveLeftButton);
         this._languagesGroupBox.Controls.Add(this._languagesMoveRightButton);
         this._languagesGroupBox.Controls.Add(this._languagesListBox);
         this._languagesGroupBox.Controls.Add(this._languagesLabel);
         this._languagesGroupBox.Location = new System.Drawing.Point(14, 13);
         this._languagesGroupBox.Name = "_languagesGroupBox";
         this._languagesGroupBox.Size = new System.Drawing.Size(622, 294);
         this._languagesGroupBox.TabIndex = 0;
         this._languagesGroupBox.TabStop = false;
         this._languagesGroupBox.Text = "Select the OCR languages to enable in this demo:";
         // 
         // _languagesAdditionalLabel
         // 
         this._languagesAdditionalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this._languagesAdditionalLabel.Location = new System.Drawing.Point(18, 225);
         this._languagesAdditionalLabel.Name = "_languagesAdditionalLabel";
         this._languagesAdditionalLabel.Size = new System.Drawing.Size(584, 56);
         this._languagesAdditionalLabel.TabIndex = 8;
         // 
         // _languagesHintLabel
         // 
         this._languagesHintLabel.AutoSize = true;
         this._languagesHintLabel.Location = new System.Drawing.Point(16, 202);
         this._languagesHintLabel.Name = "_languagesHintLabel";
         this._languagesHintLabel.Size = new System.Drawing.Size(341, 13);
         this._languagesHintLabel.TabIndex = 7;
         this._languagesHintLabel.Text = "Hint: The main language is the first item in the \'Enabled Languages\' list.";
         // 
         // _languagesMoveTopButton
         // 
         this._languagesMoveTopButton.Location = new System.Drawing.Point(390, 49);
         this._languagesMoveTopButton.Name = "_languagesMoveTopButton";
         this._languagesMoveTopButton.Size = new System.Drawing.Size(32, 32);
         this._languagesMoveTopButton.TabIndex = 6;
         this._languagesMoveTopButton.Text = "^";
         this._languagesMoveTopButton.UseVisualStyleBackColor = true;
         this._languagesMoveTopButton.Click += new System.EventHandler(this._languagesMoveTopButton_Click);
         // 
         // _enabledLanguagesListBox
         // 
         this._enabledLanguagesListBox.FormattingEnabled = true;
         this._enabledLanguagesListBox.Location = new System.Drawing.Point(224, 49);
         this._enabledLanguagesListBox.Name = "_enabledLanguagesListBox";
         this._enabledLanguagesListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
         this._enabledLanguagesListBox.Size = new System.Drawing.Size(160, 147);
         this._enabledLanguagesListBox.TabIndex = 5;
         this._enabledLanguagesListBox.SelectedIndexChanged += new System.EventHandler(this._enabledLanguagesListBox_SelectedIndexChanged);
         // 
         // _enabledLanguagesLabel
         // 
         this._enabledLanguagesLabel.AutoSize = true;
         this._enabledLanguagesLabel.Location = new System.Drawing.Point(221, 27);
         this._enabledLanguagesLabel.Name = "_enabledLanguagesLabel";
         this._enabledLanguagesLabel.Size = new System.Drawing.Size(102, 13);
         this._enabledLanguagesLabel.TabIndex = 4;
         this._enabledLanguagesLabel.Text = "Enabled Languages";
         // 
         // _languagesMoveLeftButton
         // 
         this._languagesMoveLeftButton.Location = new System.Drawing.Point(185, 152);
         this._languagesMoveLeftButton.Name = "_languagesMoveLeftButton";
         this._languagesMoveLeftButton.Size = new System.Drawing.Size(32, 32);
         this._languagesMoveLeftButton.TabIndex = 3;
         this._languagesMoveLeftButton.Text = "<";
         this._languagesMoveLeftButton.UseVisualStyleBackColor = true;
         this._languagesMoveLeftButton.Click += new System.EventHandler(this._languagesMoveLeftButton_Click);
         // 
         // _languagesMoveRightButton
         // 
         this._languagesMoveRightButton.Location = new System.Drawing.Point(185, 114);
         this._languagesMoveRightButton.Name = "_languagesMoveRightButton";
         this._languagesMoveRightButton.Size = new System.Drawing.Size(32, 32);
         this._languagesMoveRightButton.TabIndex = 2;
         this._languagesMoveRightButton.Text = ">";
         this._languagesMoveRightButton.UseVisualStyleBackColor = true;
         this._languagesMoveRightButton.Click += new System.EventHandler(this._languagesMoveRightButton_Click);
         // 
         // _languagesListBox
         // 
         this._languagesListBox.FormattingEnabled = true;
         this._languagesListBox.Location = new System.Drawing.Point(19, 49);
         this._languagesListBox.Name = "_languagesListBox";
         this._languagesListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
         this._languagesListBox.Size = new System.Drawing.Size(160, 147);
         this._languagesListBox.TabIndex = 1;
         this._languagesListBox.SelectedIndexChanged += new System.EventHandler(this._languagesListBox_SelectedIndexChanged);
         // 
         // _languagesLabel
         // 
         this._languagesLabel.AutoSize = true;
         this._languagesLabel.Location = new System.Drawing.Point(16, 28);
         this._languagesLabel.Name = "_languagesLabel";
         this._languagesLabel.Size = new System.Drawing.Size(106, 13);
         this._languagesLabel.TabIndex = 0;
         this._languagesLabel.Text = "Available Languages";
         // 
         // _okButton
         // 
         this._okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this._okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
         this._okButton.Location = new System.Drawing.Point(516, 368);
         this._okButton.Name = "_okButton";
         this._okButton.Size = new System.Drawing.Size(75, 23);
         this._okButton.TabIndex = 2;
         this._okButton.Text = "OK";
         this._okButton.UseVisualStyleBackColor = true;
         this._okButton.Click += new System.EventHandler(this._okButton_Click);
         // 
         // _cancelButton
         // 
         this._cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this._cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this._cancelButton.Location = new System.Drawing.Point(597, 368);
         this._cancelButton.Name = "_cancelButton";
         this._cancelButton.Size = new System.Drawing.Size(75, 23);
         this._cancelButton.TabIndex = 3;
         this._cancelButton.Text = "Cancel";
         this._cancelButton.UseVisualStyleBackColor = true;
         // 
         // _aboutButton
         // 
         this._aboutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
         this._aboutButton.Location = new System.Drawing.Point(12, 368);
         this._aboutButton.Name = "_aboutButton";
         this._aboutButton.Size = new System.Drawing.Size(75, 23);
         this._aboutButton.TabIndex = 1;
         this._aboutButton.Text = "About...";
         this._aboutButton.UseVisualStyleBackColor = true;
         this._aboutButton.Click += new System.EventHandler(this._aboutButton_Click);
         // 
         // DocumentConverterDialog
         // 
         this.AcceptButton = this._okButton;
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.CancelButton = this._cancelButton;
         this.ClientSize = new System.Drawing.Size(684, 399);
         this.Controls.Add(this._aboutButton);
         this.Controls.Add(this._cancelButton);
         this.Controls.Add(this._okButton);
         this.Controls.Add(this._tabControl);
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "DocumentConverterDialog";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "Document Converter Options";
         this._tabControl.ResumeLayout(false);
         this._documentTabPage.ResumeLayout(false);
         this._optionsTabPage.ResumeLayout(false);
         this._ocrSettingsTabPage.ResumeLayout(false);
         this._ocrEnginePanel.ResumeLayout(false);
         this._ocrEnginePanel.PerformLayout();
         this._ocrLanguagesTabPage.ResumeLayout(false);
         this._languagesGroupBox.ResumeLayout(false);
         this._languagesGroupBox.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.TabControl _tabControl;
      private System.Windows.Forms.TabPage _documentTabPage;
      private System.Windows.Forms.TabPage _optionsTabPage;
      private System.Windows.Forms.Button _okButton;
      private System.Windows.Forms.Button _cancelButton;
      private DocumentConverterDocumentControl _documentControl;
      private DocumentConverterOptionsControl _optionsControl;
      private System.Windows.Forms.Button _aboutButton;
      private System.Windows.Forms.TabPage _ocrSettingsTabPage;
      private System.Windows.Forms.TabPage _ocrLanguagesTabPage;
      private OcrEngineSettingsControl _ocrEngineSettingsControl;
      private System.Windows.Forms.Panel _ocrEnginePanel;
      private System.Windows.Forms.Label _ocrEngineLabel;
      private System.Windows.Forms.GroupBox _languagesGroupBox;
      private System.Windows.Forms.Label _languagesLabel;
      private System.Windows.Forms.Button _languagesMoveTopButton;
      private System.Windows.Forms.ListBox _enabledLanguagesListBox;
      private System.Windows.Forms.Label _enabledLanguagesLabel;
      private System.Windows.Forms.Button _languagesMoveLeftButton;
      private System.Windows.Forms.Button _languagesMoveRightButton;
      private System.Windows.Forms.ListBox _languagesListBox;
      private System.Windows.Forms.Label _languagesHintLabel;
      private System.Windows.Forms.Label _languagesAdditionalLabel;
   }
}