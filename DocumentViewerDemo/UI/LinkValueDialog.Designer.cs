namespace DocumentViewerDemo.UI
{
   partial class LinkValueDialog
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
         this._closeButton = new System.Windows.Forms.Button();
         this._infoLabel = new System.Windows.Forms.Label();
         this._linkValueTextBox = new System.Windows.Forms.TextBox();
         this.SuspendLayout();
         // 
         // _closeButton
         // 
         this._closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this._closeButton.Location = new System.Drawing.Point(200, 110);
         this._closeButton.Name = "_closeButton";
         this._closeButton.Size = new System.Drawing.Size(75, 23);
         this._closeButton.TabIndex = 2;
         this._closeButton.Text = "C&lose";
         this._closeButton.UseVisualStyleBackColor = true;
         // 
         // _infoLabel
         // 
         this._infoLabel.Location = new System.Drawing.Point(13, 13);
         this._infoLabel.Name = "_infoLabel";
         this._infoLabel.Size = new System.Drawing.Size(259, 56);
         this._infoLabel.TabIndex = 0;
         this._infoLabel.Text = "You clicked the following link value that cannot be executed by the system:";
         // 
         // _linkValueTextBox
         // 
         this._linkValueTextBox.Location = new System.Drawing.Point(16, 72);
         this._linkValueTextBox.Name = "_linkValueTextBox";
         this._linkValueTextBox.Size = new System.Drawing.Size(259, 20);
         this._linkValueTextBox.TabIndex = 1;
         // 
         // LinkValueDialog
         // 
         this.AcceptButton = this._closeButton;
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.CancelButton = this._closeButton;
         this.ClientSize = new System.Drawing.Size(284, 148);
         this.Controls.Add(this._linkValueTextBox);
         this.Controls.Add(this._infoLabel);
         this.Controls.Add(this._closeButton);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "LinkValueDialog";
         this.ShowInTaskbar = false;
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "Link Value";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button _closeButton;
      private System.Windows.Forms.Label _infoLabel;
      private System.Windows.Forms.TextBox _linkValueTextBox;
   }
}