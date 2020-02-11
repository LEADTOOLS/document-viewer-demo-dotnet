namespace DocumentViewerDemo.UI
{
   partial class ParsePageLinksDialog
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParsePageLinksDialog));
         this._noButton = new System.Windows.Forms.Button();
         this._yesButton = new System.Windows.Forms.Button();
         this._infoLabel = new System.Windows.Forms.Label();
         this._rememberDecisionCheckBox = new System.Windows.Forms.CheckBox();
         this.SuspendLayout();
         // 
         // _noButton
         // 
         this._noButton.DialogResult = System.Windows.Forms.DialogResult.No;
         this._noButton.Location = new System.Drawing.Point(380, 101);
         this._noButton.Name = "_noButton";
         this._noButton.Size = new System.Drawing.Size(75, 23);
         this._noButton.TabIndex = 3;
         this._noButton.Text = "No";
         this._noButton.UseVisualStyleBackColor = true;
         this._noButton.Click += new System.EventHandler(this._noButton_Click);
         // 
         // _yesButton
         // 
         this._yesButton.DialogResult = System.Windows.Forms.DialogResult.Yes;
         this._yesButton.Location = new System.Drawing.Point(299, 101);
         this._yesButton.Name = "_yesButton";
         this._yesButton.Size = new System.Drawing.Size(75, 23);
         this._yesButton.TabIndex = 2;
         this._yesButton.Text = "Yes";
         this._yesButton.UseVisualStyleBackColor = true;
         this._yesButton.Click += new System.EventHandler(this._yesButton_Click);
         // 
         // _infoLabel
         // 
         this._infoLabel.Location = new System.Drawing.Point(13, 13);
         this._infoLabel.Name = "_infoLabel";
         this._infoLabel.Size = new System.Drawing.Size(442, 69);
         this._infoLabel.TabIndex = 0;
         this._infoLabel.Text = resources.GetString("_infoLabel.Text");
         // 
         // _rememberDecisionCheckBox
         // 
         this._rememberDecisionCheckBox.AutoSize = true;
         this._rememberDecisionCheckBox.Location = new System.Drawing.Point(16, 101);
         this._rememberDecisionCheckBox.Name = "_rememberDecisionCheckBox";
         this._rememberDecisionCheckBox.Size = new System.Drawing.Size(135, 17);
         this._rememberDecisionCheckBox.TabIndex = 1;
         this._rememberDecisionCheckBox.Text = "&Remember my decision";
         this._rememberDecisionCheckBox.UseVisualStyleBackColor = true;
         // 
         // ParsePageLinksDialog
         // 
         this.AcceptButton = this._noButton;
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.CancelButton = this._yesButton;
         this.ClientSize = new System.Drawing.Size(467, 139);
         this.Controls.Add(this._rememberDecisionCheckBox);
         this.Controls.Add(this._infoLabel);
         this.Controls.Add(this._yesButton);
         this.Controls.Add(this._noButton);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "ParsePageLinksDialog";
         this.ShowInTaskbar = false;
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "Parse Page Links";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button _noButton;
      private System.Windows.Forms.Button _yesButton;
      private System.Windows.Forms.Label _infoLabel;
      private System.Windows.Forms.CheckBox _rememberDecisionCheckBox;
   }
}