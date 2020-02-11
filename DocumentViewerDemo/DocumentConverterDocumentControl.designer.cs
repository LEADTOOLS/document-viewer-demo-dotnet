namespace Leadtools.Demos
{
   partial class DocumentConverterDocumentControl
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

      #region Component Designer generated code

      /// <summary> 
      /// Required method for Designer support - do not modify 
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this._inputDocumentGroupBox = new System.Windows.Forms.GroupBox();
         this._disabledPagesLabel = new System.Windows.Forms.Label();
         this._lastPageCheckBox = new System.Windows.Forms.CheckBox();
         this._toPageNumericUpDown = new System.Windows.Forms.NumericUpDown();
         this._toPageLabel = new System.Windows.Forms.Label();
         this._firstPageCheckBox = new System.Windows.Forms.CheckBox();
         this._fromPageNumericUpDown = new System.Windows.Forms.NumericUpDown();
         this._fromPageLabel = new System.Windows.Forms.Label();
         this._inputAnnotationsModeComboBox = new System.Windows.Forms.ComboBox();
         this._inputAnnotationsModeLabel = new System.Windows.Forms.Label();
         this._inputAnnotationsFileBrowseButton = new System.Windows.Forms.Button();
         this._inputAnnotationsFileTextBox = new System.Windows.Forms.TextBox();
         this._inputAnnotationsFileLabel = new System.Windows.Forms.Label();
         this._inputDocumentPagesLabel = new System.Windows.Forms.Label();
         this._inputDocumentFileBrowseButton = new System.Windows.Forms.Button();
         this._inputDocumentFileTextBox = new System.Windows.Forms.TextBox();
         this._inputDocumentFileLabel = new System.Windows.Forms.Label();
         this._outputDocumentGroupBox = new System.Windows.Forms.GroupBox();
         this._outputFormatPanel = new System.Windows.Forms.Panel();
         this._rasterImageFormatComboBox = new System.Windows.Forms.ComboBox();
         this._outputFormatComboBox = new System.Windows.Forms.ComboBox();
         this._outputFormatLabel = new System.Windows.Forms.Label();
         this._outputAnnotationsModeComboBox = new System.Windows.Forms.ComboBox();
         this._outputAnnotationsModeLabel = new System.Windows.Forms.Label();
         this._outputAnnotationsFileBrowseButton = new System.Windows.Forms.Button();
         this._outputAnnotationsFileTextBox = new System.Windows.Forms.TextBox();
         this._outputAnnotationsFileLabel = new System.Windows.Forms.Label();
         this._outputDocumentFileBrowseButton = new System.Windows.Forms.Button();
         this._outputDocumentFileTextBox = new System.Windows.Forms.TextBox();
         this._outputDocumentFileLabel = new System.Windows.Forms.Label();
         this._inputDocumentGroupBox.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this._toPageNumericUpDown)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this._fromPageNumericUpDown)).BeginInit();
         this._outputDocumentGroupBox.SuspendLayout();
         this._outputFormatPanel.SuspendLayout();
         this.SuspendLayout();
         // 
         // _inputDocumentGroupBox
         // 
         this._inputDocumentGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this._inputDocumentGroupBox.Controls.Add(this._disabledPagesLabel);
         this._inputDocumentGroupBox.Controls.Add(this._lastPageCheckBox);
         this._inputDocumentGroupBox.Controls.Add(this._toPageNumericUpDown);
         this._inputDocumentGroupBox.Controls.Add(this._toPageLabel);
         this._inputDocumentGroupBox.Controls.Add(this._firstPageCheckBox);
         this._inputDocumentGroupBox.Controls.Add(this._fromPageNumericUpDown);
         this._inputDocumentGroupBox.Controls.Add(this._fromPageLabel);
         this._inputDocumentGroupBox.Controls.Add(this._inputAnnotationsModeComboBox);
         this._inputDocumentGroupBox.Controls.Add(this._inputAnnotationsModeLabel);
         this._inputDocumentGroupBox.Controls.Add(this._inputAnnotationsFileBrowseButton);
         this._inputDocumentGroupBox.Controls.Add(this._inputAnnotationsFileTextBox);
         this._inputDocumentGroupBox.Controls.Add(this._inputAnnotationsFileLabel);
         this._inputDocumentGroupBox.Controls.Add(this._inputDocumentPagesLabel);
         this._inputDocumentGroupBox.Controls.Add(this._inputDocumentFileBrowseButton);
         this._inputDocumentGroupBox.Controls.Add(this._inputDocumentFileTextBox);
         this._inputDocumentGroupBox.Controls.Add(this._inputDocumentFileLabel);
         this._inputDocumentGroupBox.Location = new System.Drawing.Point(8, 8);
         this._inputDocumentGroupBox.Name = "_inputDocumentGroupBox";
         this._inputDocumentGroupBox.Size = new System.Drawing.Size(619, 143);
         this._inputDocumentGroupBox.TabIndex = 0;
         this._inputDocumentGroupBox.TabStop = false;
         this._inputDocumentGroupBox.Text = "&Input document";
         // 
         // _disabledPagesLabel
         // 
         this._disabledPagesLabel.AutoSize = true;
         this._disabledPagesLabel.Location = new System.Drawing.Point(446, 54);
         this._disabledPagesLabel.Name = "_disabledPagesLabel";
         this._disabledPagesLabel.Size = new System.Drawing.Size(131, 26);
         this._disabledPagesLabel.TabIndex = 15;
         this._disabledPagesLabel.Text = "Disabled pages are not\r\nincluded in the conversion";
         // 
         // _lastPageCheckBox
         // 
         this._lastPageCheckBox.AutoSize = true;
         this._lastPageCheckBox.Location = new System.Drawing.Point(370, 59);
         this._lastPageCheckBox.Name = "_lastPageCheckBox";
         this._lastPageCheckBox.Size = new System.Drawing.Size(73, 17);
         this._lastPageCheckBox.TabIndex = 9;
         this._lastPageCheckBox.Text = "&Last page";
         this._lastPageCheckBox.UseVisualStyleBackColor = true;
         this._lastPageCheckBox.CheckedChanged += new System.EventHandler(this._lastPageCheckBox_CheckedChanged);
         // 
         // _toPageNumericUpDown
         // 
         this._toPageNumericUpDown.Location = new System.Drawing.Point(305, 58);
         this._toPageNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
         this._toPageNumericUpDown.Name = "_toPageNumericUpDown";
         this._toPageNumericUpDown.Size = new System.Drawing.Size(59, 20);
         this._toPageNumericUpDown.TabIndex = 8;
         this._toPageNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
         this._toPageNumericUpDown.ValueChanged += new System.EventHandler(this._toPageNumericUpDown_ValueChanged);
         // 
         // _toPageLabel
         // 
         this._toPageLabel.AutoSize = true;
         this._toPageLabel.Location = new System.Drawing.Point(280, 60);
         this._toPageLabel.Name = "_toPageLabel";
         this._toPageLabel.Size = new System.Drawing.Size(19, 13);
         this._toPageLabel.TabIndex = 7;
         this._toPageLabel.Text = "t&o:";
         // 
         // _firstPageCheckBox
         // 
         this._firstPageCheckBox.AutoSize = true;
         this._firstPageCheckBox.Location = new System.Drawing.Point(202, 59);
         this._firstPageCheckBox.Name = "_firstPageCheckBox";
         this._firstPageCheckBox.Size = new System.Drawing.Size(72, 17);
         this._firstPageCheckBox.TabIndex = 6;
         this._firstPageCheckBox.Text = "&First page";
         this._firstPageCheckBox.UseVisualStyleBackColor = true;
         this._firstPageCheckBox.CheckedChanged += new System.EventHandler(this._firstPageCheckBox_CheckedChanged);
         // 
         // _fromPageNumericUpDown
         // 
         this._fromPageNumericUpDown.Location = new System.Drawing.Point(136, 57);
         this._fromPageNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
         this._fromPageNumericUpDown.Name = "_fromPageNumericUpDown";
         this._fromPageNumericUpDown.Size = new System.Drawing.Size(59, 20);
         this._fromPageNumericUpDown.TabIndex = 5;
         this._fromPageNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
         this._fromPageNumericUpDown.ValueChanged += new System.EventHandler(this._fromPageNumericUpDown_ValueChanged);
         // 
         // _fromPageLabel
         // 
         this._fromPageLabel.AutoSize = true;
         this._fromPageLabel.Location = new System.Drawing.Point(100, 59);
         this._fromPageLabel.Name = "_fromPageLabel";
         this._fromPageLabel.Size = new System.Drawing.Size(30, 13);
         this._fromPageLabel.TabIndex = 4;
         this._fromPageLabel.Text = "f&rom:";
         // 
         // _inputAnnotationsModeComboBox
         // 
         this._inputAnnotationsModeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this._inputAnnotationsModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this._inputAnnotationsModeComboBox.FormattingEnabled = true;
         this._inputAnnotationsModeComboBox.Items.AddRange(new object[] {
            "Do not import annotations",
            "Import the annotations embedded in the document (if found)",
            "Import from an external file"});
         this._inputAnnotationsModeComboBox.Location = new System.Drawing.Point(100, 83);
         this._inputAnnotationsModeComboBox.Name = "_inputAnnotationsModeComboBox";
         this._inputAnnotationsModeComboBox.Size = new System.Drawing.Size(476, 21);
         this._inputAnnotationsModeComboBox.TabIndex = 11;
         this._inputAnnotationsModeComboBox.SelectedIndexChanged += new System.EventHandler(this._inputAnnotationsModeComboBox_SelectedIndexChanged);
         // 
         // _inputAnnotationsModeLabel
         // 
         this._inputAnnotationsModeLabel.AutoSize = true;
         this._inputAnnotationsModeLabel.Location = new System.Drawing.Point(27, 86);
         this._inputAnnotationsModeLabel.Name = "_inputAnnotationsModeLabel";
         this._inputAnnotationsModeLabel.Size = new System.Drawing.Size(66, 13);
         this._inputAnnotationsModeLabel.TabIndex = 10;
         this._inputAnnotationsModeLabel.Text = "&Annotations:";
         // 
         // _inputAnnotationsFileBrowseButton
         // 
         this._inputAnnotationsFileBrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this._inputAnnotationsFileBrowseButton.Location = new System.Drawing.Point(581, 107);
         this._inputAnnotationsFileBrowseButton.Name = "_inputAnnotationsFileBrowseButton";
         this._inputAnnotationsFileBrowseButton.Size = new System.Drawing.Size(30, 23);
         this._inputAnnotationsFileBrowseButton.TabIndex = 14;
         this._inputAnnotationsFileBrowseButton.Text = "...";
         this._inputAnnotationsFileBrowseButton.UseVisualStyleBackColor = true;
         this._inputAnnotationsFileBrowseButton.Click += new System.EventHandler(this._inputAnnotationsFileBrowseButton_Click);
         // 
         // _inputAnnotationsFileTextBox
         // 
         this._inputAnnotationsFileTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this._inputAnnotationsFileTextBox.Location = new System.Drawing.Point(100, 110);
         this._inputAnnotationsFileTextBox.Name = "_inputAnnotationsFileTextBox";
         this._inputAnnotationsFileTextBox.Size = new System.Drawing.Size(476, 20);
         this._inputAnnotationsFileTextBox.TabIndex = 13;
         this._inputAnnotationsFileTextBox.TextChanged += new System.EventHandler(this._inputAnnotationsFileTextBox_TextChanged);
         // 
         // _inputAnnotationsFileLabel
         // 
         this._inputAnnotationsFileLabel.AutoSize = true;
         this._inputAnnotationsFileLabel.Location = new System.Drawing.Point(11, 113);
         this._inputAnnotationsFileLabel.Name = "_inputAnnotationsFileLabel";
         this._inputAnnotationsFileLabel.Size = new System.Drawing.Size(82, 13);
         this._inputAnnotationsFileLabel.TabIndex = 12;
         this._inputAnnotationsFileLabel.Text = "A&nnotations file:";
         // 
         // _inputDocumentPagesLabel
         // 
         this._inputDocumentPagesLabel.AutoSize = true;
         this._inputDocumentPagesLabel.Location = new System.Drawing.Point(53, 59);
         this._inputDocumentPagesLabel.Name = "_inputDocumentPagesLabel";
         this._inputDocumentPagesLabel.Size = new System.Drawing.Size(40, 13);
         this._inputDocumentPagesLabel.TabIndex = 3;
         this._inputDocumentPagesLabel.Text = "&Pages:";
         // 
         // _inputDocumentFileBrowseButton
         // 
         this._inputDocumentFileBrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this._inputDocumentFileBrowseButton.Location = new System.Drawing.Point(581, 26);
         this._inputDocumentFileBrowseButton.Name = "_inputDocumentFileBrowseButton";
         this._inputDocumentFileBrowseButton.Size = new System.Drawing.Size(30, 23);
         this._inputDocumentFileBrowseButton.TabIndex = 2;
         this._inputDocumentFileBrowseButton.Text = "...";
         this._inputDocumentFileBrowseButton.UseVisualStyleBackColor = true;
         this._inputDocumentFileBrowseButton.Click += new System.EventHandler(this._inputDocumentFileBrowseButton_Click);
         // 
         // _inputDocumentFileTextBox
         // 
         this._inputDocumentFileTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this._inputDocumentFileTextBox.Location = new System.Drawing.Point(100, 28);
         this._inputDocumentFileTextBox.Name = "_inputDocumentFileTextBox";
         this._inputDocumentFileTextBox.Size = new System.Drawing.Size(476, 20);
         this._inputDocumentFileTextBox.TabIndex = 1;
         this._inputDocumentFileTextBox.TextChanged += new System.EventHandler(this._inputDocumentFileTextBox_TextChanged);
         // 
         // _inputDocumentFileLabel
         // 
         this._inputDocumentFileLabel.AutoSize = true;
         this._inputDocumentFileLabel.Location = new System.Drawing.Point(19, 31);
         this._inputDocumentFileLabel.Name = "_inputDocumentFileLabel";
         this._inputDocumentFileLabel.Size = new System.Drawing.Size(75, 13);
         this._inputDocumentFileLabel.TabIndex = 0;
         this._inputDocumentFileLabel.Text = "&Document file:";
         // 
         // _outputDocumentGroupBox
         // 
         this._outputDocumentGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this._outputDocumentGroupBox.Controls.Add(this._outputFormatPanel);
         this._outputDocumentGroupBox.Controls.Add(this._outputFormatComboBox);
         this._outputDocumentGroupBox.Controls.Add(this._outputFormatLabel);
         this._outputDocumentGroupBox.Controls.Add(this._outputAnnotationsModeComboBox);
         this._outputDocumentGroupBox.Controls.Add(this._outputAnnotationsModeLabel);
         this._outputDocumentGroupBox.Controls.Add(this._outputAnnotationsFileBrowseButton);
         this._outputDocumentGroupBox.Controls.Add(this._outputAnnotationsFileTextBox);
         this._outputDocumentGroupBox.Controls.Add(this._outputAnnotationsFileLabel);
         this._outputDocumentGroupBox.Controls.Add(this._outputDocumentFileBrowseButton);
         this._outputDocumentGroupBox.Controls.Add(this._outputDocumentFileTextBox);
         this._outputDocumentGroupBox.Controls.Add(this._outputDocumentFileLabel);
         this._outputDocumentGroupBox.Location = new System.Drawing.Point(8, 157);
         this._outputDocumentGroupBox.Name = "_outputDocumentGroupBox";
         this._outputDocumentGroupBox.Size = new System.Drawing.Size(619, 144);
         this._outputDocumentGroupBox.TabIndex = 1;
         this._outputDocumentGroupBox.TabStop = false;
         this._outputDocumentGroupBox.Text = "&Output document";
         // 
         // _outputFormatPanel
         // 
         this._outputFormatPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this._outputFormatPanel.Controls.Add(this._rasterImageFormatComboBox);
         this._outputFormatPanel.Location = new System.Drawing.Point(227, 26);
         this._outputFormatPanel.Name = "_outputFormatPanel";
         this._outputFormatPanel.Size = new System.Drawing.Size(349, 24);
         this._outputFormatPanel.TabIndex = 2;
         // 
         // _rasterImageFormatComboBox
         // 
         this._rasterImageFormatComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
         this._rasterImageFormatComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this._rasterImageFormatComboBox.FormattingEnabled = true;
         this._rasterImageFormatComboBox.Location = new System.Drawing.Point(0, 0);
         this._rasterImageFormatComboBox.Name = "_rasterImageFormatComboBox";
         this._rasterImageFormatComboBox.Size = new System.Drawing.Size(349, 21);
         this._rasterImageFormatComboBox.TabIndex = 0;
         this._rasterImageFormatComboBox.SelectedIndexChanged += new System.EventHandler(this._rasterImageFormatComboBox_SelectedIndexChanged);
         // 
         // _outputFormatComboBox
         // 
         this._outputFormatComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this._outputFormatComboBox.FormattingEnabled = true;
         this._outputFormatComboBox.Items.AddRange(new object[] {
            "Document",
            "Raster"});
         this._outputFormatComboBox.Location = new System.Drawing.Point(100, 27);
         this._outputFormatComboBox.Name = "_outputFormatComboBox";
         this._outputFormatComboBox.Size = new System.Drawing.Size(121, 21);
         this._outputFormatComboBox.TabIndex = 1;
         this._outputFormatComboBox.SelectedIndexChanged += new System.EventHandler(this._outputFormatComboBox_SelectedIndexChanged);
         // 
         // _outputFormatLabel
         // 
         this._outputFormatLabel.AutoSize = true;
         this._outputFormatLabel.Location = new System.Drawing.Point(51, 30);
         this._outputFormatLabel.Name = "_outputFormatLabel";
         this._outputFormatLabel.Size = new System.Drawing.Size(42, 13);
         this._outputFormatLabel.TabIndex = 0;
         this._outputFormatLabel.Text = "For&mat:";
         // 
         // _outputAnnotationsModeComboBox
         // 
         this._outputAnnotationsModeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this._outputAnnotationsModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this._outputAnnotationsModeComboBox.FormattingEnabled = true;
         this._outputAnnotationsModeComboBox.Items.AddRange(new object[] {
            "Do not export any annotations",
            "Export to an external file",
            "Overlay (works with Raster formats only)",
            "Embed into the output document (works with PDF and TIF files only)"});
         this._outputAnnotationsModeComboBox.Location = new System.Drawing.Point(100, 83);
         this._outputAnnotationsModeComboBox.Name = "_outputAnnotationsModeComboBox";
         this._outputAnnotationsModeComboBox.Size = new System.Drawing.Size(476, 21);
         this._outputAnnotationsModeComboBox.TabIndex = 7;
         this._outputAnnotationsModeComboBox.SelectedIndexChanged += new System.EventHandler(this._outputAnnotationsModeComboBox_SelectedIndexChanged);
         // 
         // _outputAnnotationsModeLabel
         // 
         this._outputAnnotationsModeLabel.AutoSize = true;
         this._outputAnnotationsModeLabel.Location = new System.Drawing.Point(27, 86);
         this._outputAnnotationsModeLabel.Name = "_outputAnnotationsModeLabel";
         this._outputAnnotationsModeLabel.Size = new System.Drawing.Size(66, 13);
         this._outputAnnotationsModeLabel.TabIndex = 6;
         this._outputAnnotationsModeLabel.Text = "Annotat&ions:";
         // 
         // _outputAnnotationsFileBrowseButton
         // 
         this._outputAnnotationsFileBrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this._outputAnnotationsFileBrowseButton.Location = new System.Drawing.Point(581, 108);
         this._outputAnnotationsFileBrowseButton.Name = "_outputAnnotationsFileBrowseButton";
         this._outputAnnotationsFileBrowseButton.Size = new System.Drawing.Size(30, 23);
         this._outputAnnotationsFileBrowseButton.TabIndex = 10;
         this._outputAnnotationsFileBrowseButton.Text = "...";
         this._outputAnnotationsFileBrowseButton.UseVisualStyleBackColor = true;
         this._outputAnnotationsFileBrowseButton.Click += new System.EventHandler(this._outputAnnotationsFileBrowseButton_Click);
         // 
         // _outputAnnotationsFileTextBox
         // 
         this._outputAnnotationsFileTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this._outputAnnotationsFileTextBox.Location = new System.Drawing.Point(100, 110);
         this._outputAnnotationsFileTextBox.Name = "_outputAnnotationsFileTextBox";
         this._outputAnnotationsFileTextBox.Size = new System.Drawing.Size(476, 20);
         this._outputAnnotationsFileTextBox.TabIndex = 9;
         this._outputAnnotationsFileTextBox.TextChanged += new System.EventHandler(this._outputAnnotationsFileTextBox_TextChanged);
         // 
         // _outputAnnotationsFileLabel
         // 
         this._outputAnnotationsFileLabel.AutoSize = true;
         this._outputAnnotationsFileLabel.Location = new System.Drawing.Point(11, 113);
         this._outputAnnotationsFileLabel.Name = "_outputAnnotationsFileLabel";
         this._outputAnnotationsFileLabel.Size = new System.Drawing.Size(82, 13);
         this._outputAnnotationsFileLabel.TabIndex = 8;
         this._outputAnnotationsFileLabel.Text = "Annotations fil&e:";
         // 
         // _outputDocumentFileBrowseButton
         // 
         this._outputDocumentFileBrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this._outputDocumentFileBrowseButton.Location = new System.Drawing.Point(581, 54);
         this._outputDocumentFileBrowseButton.Name = "_outputDocumentFileBrowseButton";
         this._outputDocumentFileBrowseButton.Size = new System.Drawing.Size(30, 23);
         this._outputDocumentFileBrowseButton.TabIndex = 5;
         this._outputDocumentFileBrowseButton.Text = "...";
         this._outputDocumentFileBrowseButton.UseVisualStyleBackColor = true;
         this._outputDocumentFileBrowseButton.Click += new System.EventHandler(this._outputDocumentFileBrowseButton_Click);
         // 
         // _outputDocumentFileTextBox
         // 
         this._outputDocumentFileTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this._outputDocumentFileTextBox.Location = new System.Drawing.Point(100, 56);
         this._outputDocumentFileTextBox.Name = "_outputDocumentFileTextBox";
         this._outputDocumentFileTextBox.Size = new System.Drawing.Size(476, 20);
         this._outputDocumentFileTextBox.TabIndex = 4;
         this._outputDocumentFileTextBox.TextChanged += new System.EventHandler(this._outputDocumentFileTextBox_TextChanged);
         // 
         // _outputDocumentFileLabel
         // 
         this._outputDocumentFileLabel.AutoSize = true;
         this._outputDocumentFileLabel.Location = new System.Drawing.Point(19, 59);
         this._outputDocumentFileLabel.Name = "_outputDocumentFileLabel";
         this._outputDocumentFileLabel.Size = new System.Drawing.Size(75, 13);
         this._outputDocumentFileLabel.TabIndex = 3;
         this._outputDocumentFileLabel.Text = "Do&cument file:";
         // 
         // DocumentConverterDocumentControl
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this._outputDocumentGroupBox);
         this.Controls.Add(this._inputDocumentGroupBox);
         this.Name = "DocumentConverterDocumentControl";
         this.Size = new System.Drawing.Size(640, 320);
         this._inputDocumentGroupBox.ResumeLayout(false);
         this._inputDocumentGroupBox.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this._toPageNumericUpDown)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this._fromPageNumericUpDown)).EndInit();
         this._outputDocumentGroupBox.ResumeLayout(false);
         this._outputDocumentGroupBox.PerformLayout();
         this._outputFormatPanel.ResumeLayout(false);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.GroupBox _inputDocumentGroupBox;
      private System.Windows.Forms.Label _inputDocumentFileLabel;
      private System.Windows.Forms.TextBox _inputDocumentFileTextBox;
      private System.Windows.Forms.Button _inputDocumentFileBrowseButton;
      private System.Windows.Forms.Label _inputDocumentPagesLabel;
      private System.Windows.Forms.Label _inputAnnotationsFileLabel;
      private System.Windows.Forms.Button _inputAnnotationsFileBrowseButton;
      private System.Windows.Forms.TextBox _inputAnnotationsFileTextBox;
      private System.Windows.Forms.Label _inputAnnotationsModeLabel;
      private System.Windows.Forms.ComboBox _inputAnnotationsModeComboBox;
      private System.Windows.Forms.GroupBox _outputDocumentGroupBox;
      private System.Windows.Forms.ComboBox _outputAnnotationsModeComboBox;
      private System.Windows.Forms.Label _outputAnnotationsModeLabel;
      private System.Windows.Forms.Button _outputAnnotationsFileBrowseButton;
      private System.Windows.Forms.TextBox _outputAnnotationsFileTextBox;
      private System.Windows.Forms.Label _outputAnnotationsFileLabel;
      private System.Windows.Forms.Button _outputDocumentFileBrowseButton;
      private System.Windows.Forms.TextBox _outputDocumentFileTextBox;
      private System.Windows.Forms.Label _outputDocumentFileLabel;
      private System.Windows.Forms.Label _outputFormatLabel;
      private System.Windows.Forms.ComboBox _outputFormatComboBox;
      private System.Windows.Forms.Panel _outputFormatPanel;
      private System.Windows.Forms.ComboBox _rasterImageFormatComboBox;
      private System.Windows.Forms.CheckBox _firstPageCheckBox;
      private System.Windows.Forms.NumericUpDown _fromPageNumericUpDown;
      private System.Windows.Forms.Label _fromPageLabel;
      private System.Windows.Forms.CheckBox _lastPageCheckBox;
      private System.Windows.Forms.NumericUpDown _toPageNumericUpDown;
      private System.Windows.Forms.Label _toPageLabel;
      private System.Windows.Forms.Label _disabledPagesLabel;
   }
}
