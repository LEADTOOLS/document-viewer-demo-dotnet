namespace DocumentViewerDemo.UI
{
   partial class DocumentTextOptionsDialog
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
         this._cancelButton = new System.Windows.Forms.Button();
         this._okButton = new System.Windows.Forms.Button();
         this._imagesRecognitionModeLabel = new System.Windows.Forms.Label();
         this._imagesRecognitionModeComboBox = new System.Windows.Forms.ComboBox();
         this._optionsGroupBox = new System.Windows.Forms.GroupBox();
         this._textExtractionModeComboBox = new System.Windows.Forms.ComboBox();
         this._textExtractionModeLabel = new System.Windows.Forms.Label();
         this._noteLabel = new System.Windows.Forms.Label();
         this._optionsGroupBox.SuspendLayout();
         this.SuspendLayout();
         // 
         // _cancelButton
         // 
         this._cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this._cancelButton.Location = new System.Drawing.Point(502, 75);
         this._cancelButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this._cancelButton.Name = "_cancelButton";
         this._cancelButton.Size = new System.Drawing.Size(112, 35);
         this._cancelButton.TabIndex = 2;
         this._cancelButton.Text = "Cancel";
         this._cancelButton.UseVisualStyleBackColor = true;
         // 
         // _okButton
         // 
         this._okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
         this._okButton.Location = new System.Drawing.Point(502, 30);
         this._okButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this._okButton.Name = "_okButton";
         this._okButton.Size = new System.Drawing.Size(112, 35);
         this._okButton.TabIndex = 1;
         this._okButton.Text = "OK";
         this._okButton.UseVisualStyleBackColor = true;
         this._okButton.Click += new System.EventHandler(this._okButton_Click);
         // 
         // _imagesRecognitionModeLabel
         // 
         this._imagesRecognitionModeLabel.AutoSize = true;
         this._imagesRecognitionModeLabel.Location = new System.Drawing.Point(15, 31);
         this._imagesRecognitionModeLabel.Name = "_imagesRecognitionModeLabel";
         this._imagesRecognitionModeLabel.Size = new System.Drawing.Size(192, 20);
         this._imagesRecognitionModeLabel.TabIndex = 0;
         this._imagesRecognitionModeLabel.Text = "Images recognition mode:";
         // 
         // _imagesRecognitionModeComboBox
         // 
         this._imagesRecognitionModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this._imagesRecognitionModeComboBox.FormattingEnabled = true;
         this._imagesRecognitionModeComboBox.Location = new System.Drawing.Point(255, 28);
         this._imagesRecognitionModeComboBox.Name = "_imagesRecognitionModeComboBox";
         this._imagesRecognitionModeComboBox.Size = new System.Drawing.Size(183, 28);
         this._imagesRecognitionModeComboBox.TabIndex = 1;
         // 
         // _optionsGroupBox
         // 
         this._optionsGroupBox.Controls.Add(this._noteLabel);
         this._optionsGroupBox.Controls.Add(this._textExtractionModeComboBox);
         this._optionsGroupBox.Controls.Add(this._textExtractionModeLabel);
         this._optionsGroupBox.Controls.Add(this._imagesRecognitionModeComboBox);
         this._optionsGroupBox.Controls.Add(this._imagesRecognitionModeLabel);
         this._optionsGroupBox.Location = new System.Drawing.Point(12, 14);
         this._optionsGroupBox.Name = "_optionsGroupBox";
         this._optionsGroupBox.Size = new System.Drawing.Size(468, 228);
         this._optionsGroupBox.TabIndex = 0;
         this._optionsGroupBox.TabStop = false;
         // 
         // _textExtractionModeComboBox
         // 
         this._textExtractionModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this._textExtractionModeComboBox.FormattingEnabled = true;
         this._textExtractionModeComboBox.Location = new System.Drawing.Point(255, 68);
         this._textExtractionModeComboBox.Name = "_textExtractionModeComboBox";
         this._textExtractionModeComboBox.Size = new System.Drawing.Size(183, 28);
         this._textExtractionModeComboBox.TabIndex = 3;
         // 
         // _textExtractionModeLabel
         // 
         this._textExtractionModeLabel.AutoSize = true;
         this._textExtractionModeLabel.Location = new System.Drawing.Point(15, 71);
         this._textExtractionModeLabel.Name = "_textExtractionModeLabel";
         this._textExtractionModeLabel.Size = new System.Drawing.Size(160, 20);
         this._textExtractionModeLabel.TabIndex = 2;
         this._textExtractionModeLabel.Text = "Text extraction mode:";
         // 
         // _noteLabel
         // 
         this._noteLabel.AutoSize = true;
         this._noteLabel.Location = new System.Drawing.Point(19, 123);
         this._noteLabel.Name = "_noteLabel";
         this._noteLabel.Size = new System.Drawing.Size(318, 40);
         this._noteLabel.TabIndex = 4;
         this._noteLabel.Text = "Note that these options will not take effect if\r\nthe page text has already been o" +
    "btained.";
         // 
         // DocumentTextOptionsDialog
         // 
         this.AcceptButton = this._okButton;
         this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.CancelButton = this._cancelButton;
         this.ClientSize = new System.Drawing.Size(638, 254);
         this.Controls.Add(this._optionsGroupBox);
         this.Controls.Add(this._cancelButton);
         this.Controls.Add(this._okButton);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "DocumentTextOptionsDialog";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "Document Text Options";
         this._optionsGroupBox.ResumeLayout(false);
         this._optionsGroupBox.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion
      private System.Windows.Forms.Button _cancelButton;
      private System.Windows.Forms.Button _okButton;
      private System.Windows.Forms.Label _imagesRecognitionModeLabel;
      private System.Windows.Forms.ComboBox _imagesRecognitionModeComboBox;
      private System.Windows.Forms.GroupBox _optionsGroupBox;
      private System.Windows.Forms.ComboBox _textExtractionModeComboBox;
      private System.Windows.Forms.Label _textExtractionModeLabel;
      private System.Windows.Forms.Label _noteLabel;
   }
}