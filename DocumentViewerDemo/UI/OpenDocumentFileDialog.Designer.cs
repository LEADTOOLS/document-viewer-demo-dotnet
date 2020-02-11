namespace DocumentViewerDemo.UI
{
   partial class OpenDocumentFileDialog
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
         this._documentLocationGroupBox = new System.Windows.Forms.GroupBox();
         this._documentLocationLabel = new System.Windows.Forms.Label();
         this._documentLocationBrowseButton = new System.Windows.Forms.Button();
         this._documentLocationTextBox = new System.Windows.Forms.TextBox();
         this._annotationsGroupBox = new System.Windows.Forms.GroupBox();
         this._externalAnnotationsLabel = new System.Windows.Forms.Label();
         this._embeddedAnnotationsLabel = new System.Windows.Forms.Label();
         this._noAnnotationsLabel = new System.Windows.Forms.Label();
         this._externalAnnotationsLocationLabel = new System.Windows.Forms.Label();
         this._externalAnnotationsRadioButton = new System.Windows.Forms.RadioButton();
         this._embeddedAnnotationsRadioButton = new System.Windows.Forms.RadioButton();
         this._noAnnotationsRadioButton = new System.Windows.Forms.RadioButton();
         this._annotationsLocationBrowseButton = new System.Windows.Forms.Button();
         this._annotationsLocationTextBox = new System.Windows.Forms.TextBox();
         this._pagesButton = new System.Windows.Forms.Button();
         this._pagesLabel = new System.Windows.Forms.Label();
         this._documentLocationGroupBox.SuspendLayout();
         this._annotationsGroupBox.SuspendLayout();
         this.SuspendLayout();
         // 
         // _okButton
         // 
         this._okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
         this._okButton.Location = new System.Drawing.Point(564, 655);
         this._okButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this._okButton.Name = "_okButton";
         this._okButton.Size = new System.Drawing.Size(112, 35);
         this._okButton.TabIndex = 2;
         this._okButton.Text = "OK";
         this._okButton.UseVisualStyleBackColor = true;
         this._okButton.Click += new System.EventHandler(this._okButton_Click);
         // 
         // _cancelButton
         // 
         this._cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this._cancelButton.Location = new System.Drawing.Point(686, 655);
         this._cancelButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this._cancelButton.Name = "_cancelButton";
         this._cancelButton.Size = new System.Drawing.Size(112, 35);
         this._cancelButton.TabIndex = 3;
         this._cancelButton.Text = "Cancel";
         this._cancelButton.UseVisualStyleBackColor = true;
         // 
         // _documentLocationGroupBox
         // 
         this._documentLocationGroupBox.Controls.Add(this._pagesLabel);
         this._documentLocationGroupBox.Controls.Add(this._pagesButton);
         this._documentLocationGroupBox.Controls.Add(this._documentLocationLabel);
         this._documentLocationGroupBox.Controls.Add(this._documentLocationBrowseButton);
         this._documentLocationGroupBox.Controls.Add(this._documentLocationTextBox);
         this._documentLocationGroupBox.Location = new System.Drawing.Point(18, 18);
         this._documentLocationGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this._documentLocationGroupBox.Name = "_documentLocationGroupBox";
         this._documentLocationGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this._documentLocationGroupBox.Size = new System.Drawing.Size(780, 169);
         this._documentLocationGroupBox.TabIndex = 0;
         this._documentLocationGroupBox.TabStop = false;
         this._documentLocationGroupBox.Text = "Document &file name:";
         // 
         // _documentLocationLabel
         // 
         this._documentLocationLabel.AutoSize = true;
         this._documentLocationLabel.Location = new System.Drawing.Point(9, 77);
         this._documentLocationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this._documentLocationLabel.Name = "_documentLocationLabel";
         this._documentLocationLabel.Size = new System.Drawing.Size(261, 20);
         this._documentLocationLabel.TabIndex = 2;
         this._documentLocationLabel.Text = "For example: C:\\Documents\\File.pdf";
         // 
         // _documentLocationBrowseButton
         // 
         this._documentLocationBrowseButton.Location = new System.Drawing.Point(724, 38);
         this._documentLocationBrowseButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this._documentLocationBrowseButton.Name = "_documentLocationBrowseButton";
         this._documentLocationBrowseButton.Size = new System.Drawing.Size(46, 35);
         this._documentLocationBrowseButton.TabIndex = 1;
         this._documentLocationBrowseButton.Text = "...";
         this._documentLocationBrowseButton.UseVisualStyleBackColor = true;
         this._documentLocationBrowseButton.Click += new System.EventHandler(this._documentLocationBrowseButton_Click);
         // 
         // _documentLocationTextBox
         // 
         this._documentLocationTextBox.Location = new System.Drawing.Point(9, 42);
         this._documentLocationTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this._documentLocationTextBox.Name = "_documentLocationTextBox";
         this._documentLocationTextBox.Size = new System.Drawing.Size(704, 26);
         this._documentLocationTextBox.TabIndex = 0;
         this._documentLocationTextBox.TextChanged += new System.EventHandler(this._locationTextBox_TextChanged);
         // 
         // _annotationsGroupBox
         // 
         this._annotationsGroupBox.Controls.Add(this._externalAnnotationsLabel);
         this._annotationsGroupBox.Controls.Add(this._embeddedAnnotationsLabel);
         this._annotationsGroupBox.Controls.Add(this._noAnnotationsLabel);
         this._annotationsGroupBox.Controls.Add(this._externalAnnotationsLocationLabel);
         this._annotationsGroupBox.Controls.Add(this._externalAnnotationsRadioButton);
         this._annotationsGroupBox.Controls.Add(this._embeddedAnnotationsRadioButton);
         this._annotationsGroupBox.Controls.Add(this._noAnnotationsRadioButton);
         this._annotationsGroupBox.Controls.Add(this._annotationsLocationBrowseButton);
         this._annotationsGroupBox.Controls.Add(this._annotationsLocationTextBox);
         this._annotationsGroupBox.Location = new System.Drawing.Point(18, 197);
         this._annotationsGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this._annotationsGroupBox.Name = "_annotationsGroupBox";
         this._annotationsGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this._annotationsGroupBox.Size = new System.Drawing.Size(780, 442);
         this._annotationsGroupBox.TabIndex = 1;
         this._annotationsGroupBox.TabStop = false;
         this._annotationsGroupBox.Text = "&Annotations";
         // 
         // _externalAnnotationsLabel
         // 
         this._externalAnnotationsLabel.Location = new System.Drawing.Point(58, 309);
         this._externalAnnotationsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this._externalAnnotationsLabel.Name = "_externalAnnotationsLabel";
         this._externalAnnotationsLabel.Size = new System.Drawing.Size(690, 77);
         this._externalAnnotationsLabel.TabIndex = 5;
         this._externalAnnotationsLabel.Text = "Select this option if the annotations are stored in an external location, such as" +
    " LEADTOOLS annotations store in an XML file (for example: C:\\Documents\\File.xml)" +
    ".";
         // 
         // _embeddedAnnotationsLabel
         // 
         this._embeddedAnnotationsLabel.Location = new System.Drawing.Point(58, 197);
         this._embeddedAnnotationsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this._embeddedAnnotationsLabel.Name = "_embeddedAnnotationsLabel";
         this._embeddedAnnotationsLabel.Size = new System.Drawing.Size(690, 77);
         this._embeddedAnnotationsLabel.TabIndex = 3;
         this._embeddedAnnotationsLabel.Text = "Some document formats such as PDF and TIFF can have embedded annotations inside t" +
    "he file itself. Select this option to try to load these annotations if they exis" +
    "t.";
         // 
         // _noAnnotationsLabel
         // 
         this._noAnnotationsLabel.Location = new System.Drawing.Point(58, 75);
         this._noAnnotationsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this._noAnnotationsLabel.Name = "_noAnnotationsLabel";
         this._noAnnotationsLabel.Size = new System.Drawing.Size(690, 77);
         this._noAnnotationsLabel.TabIndex = 1;
         this._noAnnotationsLabel.Text = "Annotations will not be loaded.";
         // 
         // _externalAnnotationsLocationLabel
         // 
         this._externalAnnotationsLocationLabel.AutoSize = true;
         this._externalAnnotationsLocationLabel.Location = new System.Drawing.Point(75, 405);
         this._externalAnnotationsLocationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this._externalAnnotationsLocationLabel.Name = "_externalAnnotationsLocationLabel";
         this._externalAnnotationsLocationLabel.Size = new System.Drawing.Size(82, 20);
         this._externalAnnotationsLocationLabel.TabIndex = 6;
         this._externalAnnotationsLocationLabel.Text = "File &name:";
         // 
         // _externalAnnotationsRadioButton
         // 
         this._externalAnnotationsRadioButton.AutoSize = true;
         this._externalAnnotationsRadioButton.Location = new System.Drawing.Point(34, 278);
         this._externalAnnotationsRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this._externalAnnotationsRadioButton.Name = "_externalAnnotationsRadioButton";
         this._externalAnnotationsRadioButton.Size = new System.Drawing.Size(362, 24);
         this._externalAnnotationsRadioButton.TabIndex = 4;
         this._externalAnnotationsRadioButton.TabStop = true;
         this._externalAnnotationsRadioButton.Text = "&Load the annotations from an external location";
         this._externalAnnotationsRadioButton.UseVisualStyleBackColor = true;
         this._externalAnnotationsRadioButton.CheckedChanged += new System.EventHandler(this._annotationsRadioButton_CheckedChanged);
         // 
         // _embeddedAnnotationsRadioButton
         // 
         this._embeddedAnnotationsRadioButton.AutoSize = true;
         this._embeddedAnnotationsRadioButton.Location = new System.Drawing.Point(34, 166);
         this._embeddedAnnotationsRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this._embeddedAnnotationsRadioButton.Name = "_embeddedAnnotationsRadioButton";
         this._embeddedAnnotationsRadioButton.Size = new System.Drawing.Size(383, 24);
         this._embeddedAnnotationsRadioButton.TabIndex = 2;
         this._embeddedAnnotationsRadioButton.TabStop = true;
         this._embeddedAnnotationsRadioButton.Text = "Load the annotations &embedded in the document";
         this._embeddedAnnotationsRadioButton.UseVisualStyleBackColor = true;
         this._embeddedAnnotationsRadioButton.CheckedChanged += new System.EventHandler(this._annotationsRadioButton_CheckedChanged);
         // 
         // _noAnnotationsRadioButton
         // 
         this._noAnnotationsRadioButton.AutoSize = true;
         this._noAnnotationsRadioButton.Location = new System.Drawing.Point(34, 45);
         this._noAnnotationsRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this._noAnnotationsRadioButton.Name = "_noAnnotationsRadioButton";
         this._noAnnotationsRadioButton.Size = new System.Drawing.Size(233, 24);
         this._noAnnotationsRadioButton.TabIndex = 0;
         this._noAnnotationsRadioButton.TabStop = true;
         this._noAnnotationsRadioButton.Text = "&Do not load any annotations";
         this._noAnnotationsRadioButton.UseVisualStyleBackColor = true;
         this._noAnnotationsRadioButton.CheckedChanged += new System.EventHandler(this._annotationsRadioButton_CheckedChanged);
         // 
         // _annotationsLocationBrowseButton
         // 
         this._annotationsLocationBrowseButton.Location = new System.Drawing.Point(724, 397);
         this._annotationsLocationBrowseButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this._annotationsLocationBrowseButton.Name = "_annotationsLocationBrowseButton";
         this._annotationsLocationBrowseButton.Size = new System.Drawing.Size(46, 35);
         this._annotationsLocationBrowseButton.TabIndex = 8;
         this._annotationsLocationBrowseButton.Text = "...";
         this._annotationsLocationBrowseButton.UseVisualStyleBackColor = true;
         this._annotationsLocationBrowseButton.Click += new System.EventHandler(this._annotationsLocationBrowseButton_Click);
         // 
         // _annotationsLocationTextBox
         // 
         this._annotationsLocationTextBox.Location = new System.Drawing.Point(166, 400);
         this._annotationsLocationTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this._annotationsLocationTextBox.Name = "_annotationsLocationTextBox";
         this._annotationsLocationTextBox.Size = new System.Drawing.Size(547, 26);
         this._annotationsLocationTextBox.TabIndex = 7;
         this._annotationsLocationTextBox.TextChanged += new System.EventHandler(this._locationTextBox_TextChanged);
         // 
         // _pagesButton
         // 
         this._pagesButton.Location = new System.Drawing.Point(13, 116);
         this._pagesButton.Name = "_pagesButton";
         this._pagesButton.Size = new System.Drawing.Size(112, 35);
         this._pagesButton.TabIndex = 3;
         this._pagesButton.Text = "&Pages...";
         this._pagesButton.UseVisualStyleBackColor = true;
         this._pagesButton.Click += new System.EventHandler(this._pagesButton_Click);
         // 
         // _pagesLabel
         // 
         this._pagesLabel.AutoSize = true;
         this._pagesLabel.Location = new System.Drawing.Point(140, 123);
         this._pagesLabel.Name = "_pagesLabel";
         this._pagesLabel.Size = new System.Drawing.Size(0, 20);
         this._pagesLabel.TabIndex = 4;
         // 
         // OpenDocumentFileDialog
         // 
         this.AcceptButton = this._okButton;
         this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.CancelButton = this._cancelButton;
         this.ClientSize = new System.Drawing.Size(819, 708);
         this.Controls.Add(this._annotationsGroupBox);
         this.Controls.Add(this._documentLocationGroupBox);
         this.Controls.Add(this._cancelButton);
         this.Controls.Add(this._okButton);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "OpenDocumentFileDialog";
         this.ShowInTaskbar = false;
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "Open File";
         this._documentLocationGroupBox.ResumeLayout(false);
         this._documentLocationGroupBox.PerformLayout();
         this._annotationsGroupBox.ResumeLayout(false);
         this._annotationsGroupBox.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Button _okButton;
      private System.Windows.Forms.Button _cancelButton;
      private System.Windows.Forms.GroupBox _documentLocationGroupBox;
      private System.Windows.Forms.Button _documentLocationBrowseButton;
      private System.Windows.Forms.TextBox _documentLocationTextBox;
      private System.Windows.Forms.Label _documentLocationLabel;
      private System.Windows.Forms.GroupBox _annotationsGroupBox;
      private System.Windows.Forms.Button _annotationsLocationBrowseButton;
      private System.Windows.Forms.TextBox _annotationsLocationTextBox;
      private System.Windows.Forms.Label _externalAnnotationsLocationLabel;
      private System.Windows.Forms.RadioButton _externalAnnotationsRadioButton;
      private System.Windows.Forms.RadioButton _embeddedAnnotationsRadioButton;
      private System.Windows.Forms.RadioButton _noAnnotationsRadioButton;
      private System.Windows.Forms.Label _noAnnotationsLabel;
      private System.Windows.Forms.Label _externalAnnotationsLabel;
      private System.Windows.Forms.Label _embeddedAnnotationsLabel;
      private System.Windows.Forms.Label _pagesLabel;
      private System.Windows.Forms.Button _pagesButton;
   }
}