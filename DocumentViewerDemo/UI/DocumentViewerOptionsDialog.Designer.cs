namespace DocumentViewerDemo.UI
{
   partial class DocumentViewerOptionsDialog
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
         this._okButton = new System.Windows.Forms.Button();
         this._cancelButton = new System.Windows.Forms.Button();
         this._thumbnailsOptionsGroupBox = new System.Windows.Forms.GroupBox();
         this._thumbnailsGridPixelSizeTextBox = new System.Windows.Forms.TextBox();
         this._thumbnailsGridPixelSizeLabel = new System.Windows.Forms.Label();
         this._thumbnailsUseGridsCheckBox = new System.Windows.Forms.CheckBox();
         this._noteLabel = new System.Windows.Forms.Label();
         this._timeoutsGroupBox = new System.Windows.Forms.GroupBox();
         this._loadDocumentTimeoutHelpLabel = new System.Windows.Forms.Label();
         this._loadDocumentTimeoutTextBox = new System.Windows.Forms.TextBox();
         this._loadDocumentTimeoutLabel = new System.Windows.Forms.Label();
         this._imagesOptionsGroupBox = new System.Windows.Forms.GroupBox();
         this._maximumImagesPixelSizeTextBox = new System.Windows.Forms.TextBox();
         this._maximumImagesPixelSizeLabel = new System.Windows.Forms.Label();
         this._maximumImagesPixelSizeHelpLabel = new System.Windows.Forms.Label();
         this._thumbnailsOptionsGroupBox.SuspendLayout();
         this._timeoutsGroupBox.SuspendLayout();
         this._imagesOptionsGroupBox.SuspendLayout();
         this.SuspendLayout();
         // 
         // _okButton
         // 
         this._okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
         this._okButton.Location = new System.Drawing.Point(842, 432);
         this._okButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this._okButton.Name = "_okButton";
         this._okButton.Size = new System.Drawing.Size(112, 35);
         this._okButton.TabIndex = 5;
         this._okButton.Text = "OK";
         this._okButton.UseVisualStyleBackColor = true;
         this._okButton.Click += new System.EventHandler(this._okButton_Click);
         // 
         // _cancelButton
         // 
         this._cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this._cancelButton.Location = new System.Drawing.Point(725, 432);
         this._cancelButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this._cancelButton.Name = "_cancelButton";
         this._cancelButton.Size = new System.Drawing.Size(112, 35);
         this._cancelButton.TabIndex = 4;
         this._cancelButton.Text = "Cancel";
         this._cancelButton.UseVisualStyleBackColor = true;
         // 
         // _thumbnailsOptionsGroupBox
         // 
         this._thumbnailsOptionsGroupBox.Controls.Add(this._thumbnailsGridPixelSizeTextBox);
         this._thumbnailsOptionsGroupBox.Controls.Add(this._thumbnailsGridPixelSizeLabel);
         this._thumbnailsOptionsGroupBox.Controls.Add(this._thumbnailsUseGridsCheckBox);
         this._thumbnailsOptionsGroupBox.Location = new System.Drawing.Point(18, 18);
         this._thumbnailsOptionsGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this._thumbnailsOptionsGroupBox.Name = "_thumbnailsOptionsGroupBox";
         this._thumbnailsOptionsGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this._thumbnailsOptionsGroupBox.Size = new System.Drawing.Size(459, 154);
         this._thumbnailsOptionsGroupBox.TabIndex = 0;
         this._thumbnailsOptionsGroupBox.TabStop = false;
         this._thumbnailsOptionsGroupBox.Text = "Thumbnails:";
         // 
         // _thumbnailsGridPixelSizeTextBox
         // 
         this._thumbnailsGridPixelSizeTextBox.Location = new System.Drawing.Point(112, 81);
         this._thumbnailsGridPixelSizeTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this._thumbnailsGridPixelSizeTextBox.Name = "_thumbnailsGridPixelSizeTextBox";
         this._thumbnailsGridPixelSizeTextBox.Size = new System.Drawing.Size(148, 26);
         this._thumbnailsGridPixelSizeTextBox.TabIndex = 2;
         // 
         // _thumbnailsGridPixelSizeLabel
         // 
         this._thumbnailsGridPixelSizeLabel.AutoSize = true;
         this._thumbnailsGridPixelSizeLabel.Location = new System.Drawing.Point(27, 81);
         this._thumbnailsGridPixelSizeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this._thumbnailsGridPixelSizeLabel.Name = "_thumbnailsGridPixelSizeLabel";
         this._thumbnailsGridPixelSizeLabel.Size = new System.Drawing.Size(77, 20);
         this._thumbnailsGridPixelSizeLabel.TabIndex = 1;
         this._thumbnailsGridPixelSizeLabel.Text = "Pixel size:";
         // 
         // _thumbnailsUseGridsCheckBox
         // 
         this._thumbnailsUseGridsCheckBox.AutoSize = true;
         this._thumbnailsUseGridsCheckBox.Location = new System.Drawing.Point(31, 45);
         this._thumbnailsUseGridsCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this._thumbnailsUseGridsCheckBox.Name = "_thumbnailsUseGridsCheckBox";
         this._thumbnailsUseGridsCheckBox.Size = new System.Drawing.Size(102, 24);
         this._thumbnailsUseGridsCheckBox.TabIndex = 0;
         this._thumbnailsUseGridsCheckBox.Text = "Use grids";
         this._thumbnailsUseGridsCheckBox.UseVisualStyleBackColor = true;
         this._thumbnailsUseGridsCheckBox.CheckedChanged += new System.EventHandler(this._thumbnailsUseGridsCheckBox_CheckedChanged);
         // 
         // _noteLabel
         // 
         this._noteLabel.AutoSize = true;
         this._noteLabel.Location = new System.Drawing.Point(14, 432);
         this._noteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this._noteLabel.Name = "_noteLabel";
         this._noteLabel.Size = new System.Drawing.Size(463, 20);
         this._noteLabel.TabIndex = 2;
         this._noteLabel.Text = "These options will take effect the next time you load a document.";
         // 
         // _timeoutsGroupBox
         // 
         this._timeoutsGroupBox.Controls.Add(this._loadDocumentTimeoutHelpLabel);
         this._timeoutsGroupBox.Controls.Add(this._loadDocumentTimeoutTextBox);
         this._timeoutsGroupBox.Controls.Add(this._loadDocumentTimeoutLabel);
         this._timeoutsGroupBox.Location = new System.Drawing.Point(18, 180);
         this._timeoutsGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this._timeoutsGroupBox.Name = "_timeoutsGroupBox";
         this._timeoutsGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this._timeoutsGroupBox.Size = new System.Drawing.Size(459, 229);
         this._timeoutsGroupBox.TabIndex = 1;
         this._timeoutsGroupBox.TabStop = false;
         this._timeoutsGroupBox.Text = "Timeouts:";
         // 
         // _loadDocumentTimeoutHelpLabel
         // 
         this._loadDocumentTimeoutHelpLabel.Location = new System.Drawing.Point(27, 84);
         this._loadDocumentTimeoutHelpLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this._loadDocumentTimeoutHelpLabel.Name = "_loadDocumentTimeoutHelpLabel";
         this._loadDocumentTimeoutHelpLabel.Size = new System.Drawing.Size(398, 126);
         this._loadDocumentTimeoutHelpLabel.TabIndex = 3;
         this._loadDocumentTimeoutHelpLabel.Text = "Abort loading documents if it takes more than this value. A value of 0 means wait" +
    " indefinitely till document loading finishes.";
         // 
         // _loadDocumentTimeoutTextBox
         // 
         this._loadDocumentTimeoutTextBox.Location = new System.Drawing.Point(277, 47);
         this._loadDocumentTimeoutTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this._loadDocumentTimeoutTextBox.Name = "_loadDocumentTimeoutTextBox";
         this._loadDocumentTimeoutTextBox.Size = new System.Drawing.Size(148, 26);
         this._loadDocumentTimeoutTextBox.TabIndex = 2;
         // 
         // _loadDocumentTimeoutLabel
         // 
         this._loadDocumentTimeoutLabel.AutoSize = true;
         this._loadDocumentTimeoutLabel.Location = new System.Drawing.Point(27, 50);
         this._loadDocumentTimeoutLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this._loadDocumentTimeoutLabel.Name = "_loadDocumentTimeoutLabel";
         this._loadDocumentTimeoutLabel.Size = new System.Drawing.Size(232, 20);
         this._loadDocumentTimeoutLabel.TabIndex = 1;
         this._loadDocumentTimeoutLabel.Text = "Load document timeout (in ms):";
         // 
         // _imagesOptionsGroupBox
         // 
         this._imagesOptionsGroupBox.Controls.Add(this._maximumImagesPixelSizeHelpLabel);
         this._imagesOptionsGroupBox.Controls.Add(this._maximumImagesPixelSizeTextBox);
         this._imagesOptionsGroupBox.Controls.Add(this._maximumImagesPixelSizeLabel);
         this._imagesOptionsGroupBox.Location = new System.Drawing.Point(495, 18);
         this._imagesOptionsGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this._imagesOptionsGroupBox.Name = "_imagesOptionsGroupBox";
         this._imagesOptionsGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this._imagesOptionsGroupBox.Size = new System.Drawing.Size(459, 391);
         this._imagesOptionsGroupBox.TabIndex = 3;
         this._imagesOptionsGroupBox.TabStop = false;
         this._imagesOptionsGroupBox.Text = "Images:";
         // 
         // _maximumImagesPixelSizeTextBox
         // 
         this._maximumImagesPixelSizeTextBox.Location = new System.Drawing.Point(230, 46);
         this._maximumImagesPixelSizeTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this._maximumImagesPixelSizeTextBox.Name = "_maximumImagesPixelSizeTextBox";
         this._maximumImagesPixelSizeTextBox.Size = new System.Drawing.Size(148, 26);
         this._maximumImagesPixelSizeTextBox.TabIndex = 2;
         // 
         // _maximumImagesPixelSizeLabel
         // 
         this._maximumImagesPixelSizeLabel.AutoSize = true;
         this._maximumImagesPixelSizeLabel.Location = new System.Drawing.Point(20, 49);
         this._maximumImagesPixelSizeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this._maximumImagesPixelSizeLabel.Name = "_maximumImagesPixelSizeLabel";
         this._maximumImagesPixelSizeLabel.Size = new System.Drawing.Size(202, 20);
         this._maximumImagesPixelSizeLabel.TabIndex = 1;
         this._maximumImagesPixelSizeLabel.Text = "Maximum images pixel size:";
         // 
         // _maximumImagesPixelSizeHelpLabel
         // 
         this._maximumImagesPixelSizeHelpLabel.Location = new System.Drawing.Point(20, 84);
         this._maximumImagesPixelSizeHelpLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this._maximumImagesPixelSizeHelpLabel.Name = "_maximumImagesPixelSizeHelpLabel";
         this._maximumImagesPixelSizeHelpLabel.Size = new System.Drawing.Size(431, 116);
         this._maximumImagesPixelSizeHelpLabel.TabIndex = 4;
         this._maximumImagesPixelSizeHelpLabel.Text = "Maximum width or height in pixels to use when obtaining raster image data from th" +
    "e pages in the document. Value of 0 means to use the original size.";
         // 
         // DocumentViewerOptionsDialog
         // 
         this.AcceptButton = this._okButton;
         this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.CancelButton = this._cancelButton;
         this.ClientSize = new System.Drawing.Size(973, 479);
         this.Controls.Add(this._imagesOptionsGroupBox);
         this.Controls.Add(this._timeoutsGroupBox);
         this.Controls.Add(this._noteLabel);
         this.Controls.Add(this._thumbnailsOptionsGroupBox);
         this.Controls.Add(this._cancelButton);
         this.Controls.Add(this._okButton);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "DocumentViewerOptionsDialog";
         this.ShowIcon = false;
         this.ShowInTaskbar = false;
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "Document Viewer Options";
         this._thumbnailsOptionsGroupBox.ResumeLayout(false);
         this._thumbnailsOptionsGroupBox.PerformLayout();
         this._timeoutsGroupBox.ResumeLayout(false);
         this._timeoutsGroupBox.PerformLayout();
         this._imagesOptionsGroupBox.ResumeLayout(false);
         this._imagesOptionsGroupBox.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button _okButton;
      private System.Windows.Forms.Button _cancelButton;
      private System.Windows.Forms.GroupBox _thumbnailsOptionsGroupBox;
      private System.Windows.Forms.CheckBox _thumbnailsUseGridsCheckBox;
      private System.Windows.Forms.Label _noteLabel;
      private System.Windows.Forms.Label _thumbnailsGridPixelSizeLabel;
      private System.Windows.Forms.TextBox _thumbnailsGridPixelSizeTextBox;
      private System.Windows.Forms.GroupBox _timeoutsGroupBox;
      private System.Windows.Forms.TextBox _loadDocumentTimeoutTextBox;
      private System.Windows.Forms.Label _loadDocumentTimeoutLabel;
      private System.Windows.Forms.Label _loadDocumentTimeoutHelpLabel;
      private System.Windows.Forms.GroupBox _imagesOptionsGroupBox;
      private System.Windows.Forms.TextBox _maximumImagesPixelSizeTextBox;
      private System.Windows.Forms.Label _maximumImagesPixelSizeLabel;
      private System.Windows.Forms.Label _maximumImagesPixelSizeHelpLabel;
   }
}