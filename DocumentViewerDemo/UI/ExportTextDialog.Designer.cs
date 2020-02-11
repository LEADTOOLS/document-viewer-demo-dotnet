namespace DocumentViewerDemo.UI
{
   partial class ExportTextDialog
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
         this._textBox = new System.Windows.Forms.TextBox();
         this._saveButton = new System.Windows.Forms.Button();
         this._closeButton = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // _textBox
         // 
         this._textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this._textBox.Location = new System.Drawing.Point(13, 13);
         this._textBox.Multiline = true;
         this._textBox.Name = "_textBox";
         this._textBox.ReadOnly = true;
         this._textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
         this._textBox.Size = new System.Drawing.Size(450, 266);
         this._textBox.TabIndex = 0;
         // 
         // _saveButton
         // 
         this._saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this._saveButton.Location = new System.Drawing.Point(478, 10);
         this._saveButton.Name = "_saveButton";
         this._saveButton.Size = new System.Drawing.Size(75, 23);
         this._saveButton.TabIndex = 1;
         this._saveButton.Text = "&Save...";
         this._saveButton.UseVisualStyleBackColor = true;
         this._saveButton.Click += new System.EventHandler(this._saveButton_Click);
         // 
         // _closeButton
         // 
         this._closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this._closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this._closeButton.Location = new System.Drawing.Point(478, 39);
         this._closeButton.Name = "_closeButton";
         this._closeButton.Size = new System.Drawing.Size(75, 23);
         this._closeButton.TabIndex = 2;
         this._closeButton.Text = "Close";
         this._closeButton.UseVisualStyleBackColor = true;
         // 
         // ExportTextDialog
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.CancelButton = this._closeButton;
         this.ClientSize = new System.Drawing.Size(565, 291);
         this.Controls.Add(this._closeButton);
         this.Controls.Add(this._saveButton);
         this.Controls.Add(this._textBox);
         this.MinimizeBox = false;
         this.Name = "ExportTextDialog";
         this.ShowIcon = false;
         this.ShowInTaskbar = false;
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "Export Text";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TextBox _textBox;
      private System.Windows.Forms.Button _saveButton;
      private System.Windows.Forms.Button _closeButton;

   }
}