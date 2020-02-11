namespace Leadtools.Demos
{
   partial class DocumentConverterOptionsControl
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

      #region Component Designer generated code

      /// <summary> 
      /// Required method for Designer support - do not modify 
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this._deskewCheckBox = new System.Windows.Forms.CheckBox();
         this._orientCheckBox = new System.Windows.Forms.CheckBox();
         this._invertCheckBox = new System.Windows.Forms.CheckBox();
         this._preprocessingComboBox = new System.Windows.Forms.GroupBox();
         this._generalGroupBox = new System.Windows.Forms.GroupBox();
         this._svgImagesRecognitionModeHelpLabel = new System.Windows.Forms.Label();
         this._emptyPageModeModeLabel = new System.Windows.Forms.Label();
         this._emptyPageModeComboBox = new System.Windows.Forms.ComboBox();
         this._useThreadsCheckBox = new System.Windows.Forms.CheckBox();
         this._svgImagesRecognitionModeLabel = new System.Windows.Forms.Label();
         this._svgImagesRecognitionModeComboBox = new System.Windows.Forms.ComboBox();
         this._jobNameTextBox = new System.Windows.Forms.TextBox();
         this._jobNameLabel = new System.Windows.Forms.Label();
         this._enableSvgConversionCheckBox = new System.Windows.Forms.CheckBox();
         this._openOutputDocumentCheckBox = new System.Windows.Forms.CheckBox();
         this._enableTraceCheckBox = new System.Windows.Forms.CheckBox();
         this._continueOnRecoverableErrorsCheckBox = new System.Windows.Forms.CheckBox();
         this._defaultButton = new System.Windows.Forms.Button();
         this._redactionOptionsGroupBox = new System.Windows.Forms.GroupBox();
         this._redactionOptionsControl = new Leadtools.Demos.DocumentRedactionOptionsControl();
         this._preprocessingComboBox.SuspendLayout();
         this._generalGroupBox.SuspendLayout();
         this._redactionOptionsGroupBox.SuspendLayout();
         this.SuspendLayout();
         // 
         // _deskewCheckBox
         // 
         this._deskewCheckBox.AutoSize = true;
         this._deskewCheckBox.Location = new System.Drawing.Point(28, 31);
         this._deskewCheckBox.Name = "_deskewCheckBox";
         this._deskewCheckBox.Size = new System.Drawing.Size(65, 17);
         this._deskewCheckBox.TabIndex = 0;
         this._deskewCheckBox.Text = "&Deskew";
         this._deskewCheckBox.UseVisualStyleBackColor = true;
         // 
         // _orientCheckBox
         // 
         this._orientCheckBox.AutoSize = true;
         this._orientCheckBox.Location = new System.Drawing.Point(205, 31);
         this._orientCheckBox.Name = "_orientCheckBox";
         this._orientCheckBox.Size = new System.Drawing.Size(54, 17);
         this._orientCheckBox.TabIndex = 2;
         this._orientCheckBox.Text = "O&rient";
         this._orientCheckBox.UseVisualStyleBackColor = true;
         // 
         // _invertCheckBox
         // 
         this._invertCheckBox.AutoSize = true;
         this._invertCheckBox.Location = new System.Drawing.Point(117, 31);
         this._invertCheckBox.Name = "_invertCheckBox";
         this._invertCheckBox.Size = new System.Drawing.Size(53, 17);
         this._invertCheckBox.TabIndex = 1;
         this._invertCheckBox.Text = "&Invert";
         this._invertCheckBox.UseVisualStyleBackColor = true;
         // 
         // _preprocessingComboBox
         // 
         this._preprocessingComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this._preprocessingComboBox.Controls.Add(this._deskewCheckBox);
         this._preprocessingComboBox.Controls.Add(this._orientCheckBox);
         this._preprocessingComboBox.Controls.Add(this._invertCheckBox);
         this._preprocessingComboBox.Location = new System.Drawing.Point(14, 157);
         this._preprocessingComboBox.Name = "_preprocessingComboBox";
         this._preprocessingComboBox.Size = new System.Drawing.Size(285, 80);
         this._preprocessingComboBox.TabIndex = 1;
         this._preprocessingComboBox.TabStop = false;
         this._preprocessingComboBox.Text = "&Preprocessing";
         // 
         // _generalGroupBox
         // 
         this._generalGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this._generalGroupBox.Controls.Add(this._svgImagesRecognitionModeHelpLabel);
         this._generalGroupBox.Controls.Add(this._emptyPageModeModeLabel);
         this._generalGroupBox.Controls.Add(this._emptyPageModeComboBox);
         this._generalGroupBox.Controls.Add(this._useThreadsCheckBox);
         this._generalGroupBox.Controls.Add(this._svgImagesRecognitionModeLabel);
         this._generalGroupBox.Controls.Add(this._svgImagesRecognitionModeComboBox);
         this._generalGroupBox.Controls.Add(this._jobNameTextBox);
         this._generalGroupBox.Controls.Add(this._jobNameLabel);
         this._generalGroupBox.Controls.Add(this._enableSvgConversionCheckBox);
         this._generalGroupBox.Controls.Add(this._openOutputDocumentCheckBox);
         this._generalGroupBox.Controls.Add(this._enableTraceCheckBox);
         this._generalGroupBox.Controls.Add(this._continueOnRecoverableErrorsCheckBox);
         this._generalGroupBox.Location = new System.Drawing.Point(14, 3);
         this._generalGroupBox.Name = "_generalGroupBox";
         this._generalGroupBox.Size = new System.Drawing.Size(618, 148);
         this._generalGroupBox.TabIndex = 0;
         this._generalGroupBox.TabStop = false;
         this._generalGroupBox.Text = "&General";
         // 
         // _svgImagesRecognitionModeHelpLabel
         // 
         this._svgImagesRecognitionModeHelpLabel.Location = new System.Drawing.Point(311, 42);
         this._svgImagesRecognitionModeHelpLabel.Name = "_svgImagesRecognitionModeHelpLabel";
         this._svgImagesRecognitionModeHelpLabel.Size = new System.Drawing.Size(291, 32);
         this._svgImagesRecognitionModeHelpLabel.TabIndex = 11;
         this._svgImagesRecognitionModeHelpLabel.Text = "Help";
         // 
         // _emptyPageModeModeLabel
         // 
         this._emptyPageModeModeLabel.AutoSize = true;
         this._emptyPageModeModeLabel.Location = new System.Drawing.Point(311, 88);
         this._emptyPageModeModeLabel.Name = "_emptyPageModeModeLabel";
         this._emptyPageModeModeLabel.Size = new System.Drawing.Size(95, 13);
         this._emptyPageModeModeLabel.TabIndex = 7;
         this._emptyPageModeModeLabel.Text = "Empty page mode:";
         // 
         // _emptyPageModeComboBox
         // 
         this._emptyPageModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this._emptyPageModeComboBox.FormattingEnabled = true;
         this._emptyPageModeComboBox.Location = new System.Drawing.Point(481, 85);
         this._emptyPageModeComboBox.Name = "_emptyPageModeComboBox";
         this._emptyPageModeComboBox.Size = new System.Drawing.Size(121, 21);
         this._emptyPageModeComboBox.TabIndex = 8;
         // 
         // _useThreadsCheckBox
         // 
         this._useThreadsCheckBox.AutoSize = true;
         this._useThreadsCheckBox.Location = new System.Drawing.Point(114, 42);
         this._useThreadsCheckBox.Name = "_useThreadsCheckBox";
         this._useThreadsCheckBox.Size = new System.Drawing.Size(83, 17);
         this._useThreadsCheckBox.TabIndex = 1;
         this._useThreadsCheckBox.Text = "Use &threads";
         this._useThreadsCheckBox.UseVisualStyleBackColor = true;
         // 
         // _svgImagesRecognitionModeLabel
         // 
         this._svgImagesRecognitionModeLabel.AutoSize = true;
         this._svgImagesRecognitionModeLabel.Location = new System.Drawing.Point(311, 19);
         this._svgImagesRecognitionModeLabel.Name = "_svgImagesRecognitionModeLabel";
         this._svgImagesRecognitionModeLabel.Size = new System.Drawing.Size(149, 13);
         this._svgImagesRecognitionModeLabel.TabIndex = 5;
         this._svgImagesRecognitionModeLabel.Text = "SVG images OCR recognition:";
         // 
         // _svgImagesRecognitionModeComboBox
         // 
         this._svgImagesRecognitionModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this._svgImagesRecognitionModeComboBox.FormattingEnabled = true;
         this._svgImagesRecognitionModeComboBox.Location = new System.Drawing.Point(482, 17);
         this._svgImagesRecognitionModeComboBox.Name = "_svgImagesRecognitionModeComboBox";
         this._svgImagesRecognitionModeComboBox.Size = new System.Drawing.Size(121, 21);
         this._svgImagesRecognitionModeComboBox.TabIndex = 6;
         this._svgImagesRecognitionModeComboBox.SelectedIndexChanged += new System.EventHandler(this._svgImagesRecognitionModeComboBox_SelectedIndexChanged);
         // 
         // _jobNameTextBox
         // 
         this._jobNameTextBox.Location = new System.Drawing.Point(503, 111);
         this._jobNameTextBox.Name = "_jobNameTextBox";
         this._jobNameTextBox.Size = new System.Drawing.Size(100, 20);
         this._jobNameTextBox.TabIndex = 10;
         // 
         // _jobNameLabel
         // 
         this._jobNameLabel.AutoSize = true;
         this._jobNameLabel.Location = new System.Drawing.Point(438, 114);
         this._jobNameLabel.Name = "_jobNameLabel";
         this._jobNameLabel.Size = new System.Drawing.Size(56, 13);
         this._jobNameLabel.TabIndex = 9;
         this._jobNameLabel.Text = "Job name:";
         // 
         // _enableSvgConversionCheckBox
         // 
         this._enableSvgConversionCheckBox.AutoSize = true;
         this._enableSvgConversionCheckBox.Location = new System.Drawing.Point(114, 19);
         this._enableSvgConversionCheckBox.Name = "_enableSvgConversionCheckBox";
         this._enableSvgConversionCheckBox.Size = new System.Drawing.Size(178, 17);
         this._enableSvgConversionCheckBox.TabIndex = 0;
         this._enableSvgConversionCheckBox.Text = "&Use SVG conversion if available";
         this._enableSvgConversionCheckBox.UseVisualStyleBackColor = true;
         // 
         // _openOutputDocumentCheckBox
         // 
         this._openOutputDocumentCheckBox.AutoSize = true;
         this._openOutputDocumentCheckBox.Location = new System.Drawing.Point(114, 111);
         this._openOutputDocumentCheckBox.Name = "_openOutputDocumentCheckBox";
         this._openOutputDocumentCheckBox.Size = new System.Drawing.Size(292, 17);
         this._openOutputDocumentCheckBox.TabIndex = 4;
         this._openOutputDocumentCheckBox.Text = "Open output document in default application on &success";
         this._openOutputDocumentCheckBox.UseVisualStyleBackColor = true;
         // 
         // _enableTraceCheckBox
         // 
         this._enableTraceCheckBox.AutoSize = true;
         this._enableTraceCheckBox.Location = new System.Drawing.Point(114, 88);
         this._enableTraceCheckBox.Name = "_enableTraceCheckBox";
         this._enableTraceCheckBox.Size = new System.Drawing.Size(86, 17);
         this._enableTraceCheckBox.TabIndex = 3;
         this._enableTraceCheckBox.Text = "E&nable trace";
         this._enableTraceCheckBox.UseVisualStyleBackColor = true;
         // 
         // _continueOnRecoverableErrorsCheckBox
         // 
         this._continueOnRecoverableErrorsCheckBox.AutoSize = true;
         this._continueOnRecoverableErrorsCheckBox.Location = new System.Drawing.Point(114, 65);
         this._continueOnRecoverableErrorsCheckBox.Name = "_continueOnRecoverableErrorsCheckBox";
         this._continueOnRecoverableErrorsCheckBox.Size = new System.Drawing.Size(171, 17);
         this._continueOnRecoverableErrorsCheckBox.TabIndex = 2;
         this._continueOnRecoverableErrorsCheckBox.Text = "&Continue on recoverable errors";
         this._continueOnRecoverableErrorsCheckBox.UseVisualStyleBackColor = true;
         // 
         // _defaultButton
         // 
         this._defaultButton.Location = new System.Drawing.Point(14, 246);
         this._defaultButton.Name = "_defaultButton";
         this._defaultButton.Size = new System.Drawing.Size(165, 23);
         this._defaultButton.TabIndex = 2;
         this._defaultButton.Text = "Revert &back to defaults";
         this._defaultButton.UseVisualStyleBackColor = true;
         this._defaultButton.Click += new System.EventHandler(this._defaultButton_Click);
         // 
         // _redactionOptionsGroupBox
         // 
         this._redactionOptionsGroupBox.Controls.Add(this._redactionOptionsControl);
         this._redactionOptionsGroupBox.Location = new System.Drawing.Point(306, 157);
         this._redactionOptionsGroupBox.Name = "_redactionOptionsGroupBox";
         this._redactionOptionsGroupBox.Size = new System.Drawing.Size(326, 80);
         this._redactionOptionsGroupBox.TabIndex = 3;
         this._redactionOptionsGroupBox.TabStop = false;
         this._redactionOptionsGroupBox.Text = "Redaction Options";
         // 
         // _redactionOptionsControl
         // 
         this._redactionOptionsControl.Location = new System.Drawing.Point(7, 13);
         this._redactionOptionsControl.Name = "_redactionOptionsControl";
         this._redactionOptionsControl.Size = new System.Drawing.Size(282, 63);
         this._redactionOptionsControl.TabIndex = 0;
         // 
         // DocumentConverterOptionsControl
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this._redactionOptionsGroupBox);
         this.Controls.Add(this._defaultButton);
         this.Controls.Add(this._generalGroupBox);
         this.Controls.Add(this._preprocessingComboBox);
         this.Name = "DocumentConverterOptionsControl";
         this.Size = new System.Drawing.Size(640, 277);
         this._preprocessingComboBox.ResumeLayout(false);
         this._preprocessingComboBox.PerformLayout();
         this._generalGroupBox.ResumeLayout(false);
         this._generalGroupBox.PerformLayout();
         this._redactionOptionsGroupBox.ResumeLayout(false);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.CheckBox _deskewCheckBox;
      private System.Windows.Forms.CheckBox _orientCheckBox;
      private System.Windows.Forms.CheckBox _invertCheckBox;
      private System.Windows.Forms.GroupBox _preprocessingComboBox;
      private System.Windows.Forms.GroupBox _generalGroupBox;
      private System.Windows.Forms.CheckBox _continueOnRecoverableErrorsCheckBox;
      private System.Windows.Forms.CheckBox _enableTraceCheckBox;
      private System.Windows.Forms.CheckBox _openOutputDocumentCheckBox;
      private System.Windows.Forms.Button _defaultButton;
      private System.Windows.Forms.CheckBox _enableSvgConversionCheckBox;
      private System.Windows.Forms.TextBox _jobNameTextBox;
      private System.Windows.Forms.Label _jobNameLabel;
      private System.Windows.Forms.ComboBox _svgImagesRecognitionModeComboBox;
      private System.Windows.Forms.Label _svgImagesRecognitionModeLabel;
      private System.Windows.Forms.CheckBox _useThreadsCheckBox;
      private System.Windows.Forms.Label _emptyPageModeModeLabel;
      private System.Windows.Forms.ComboBox _emptyPageModeComboBox;
      private System.Windows.Forms.Label _svgImagesRecognitionModeHelpLabel;
      private System.Windows.Forms.GroupBox _redactionOptionsGroupBox;
      private DocumentRedactionOptionsControl _redactionOptionsControl;
   }
}
