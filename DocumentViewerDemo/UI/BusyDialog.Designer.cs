namespace DocumentViewerDemo.UI
{
   partial class BusyDialog
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BusyDialog));
         this._descriptionLabel = new System.Windows.Forms.Label();
         this._progressBar = new System.Windows.Forms.ProgressBar();
         this._cancelButton = new System.Windows.Forms.Button();
         this._cancellingLabel = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // _descriptionLabel
         // 
         resources.ApplyResources(this._descriptionLabel, "_descriptionLabel");
         this._descriptionLabel.Name = "_descriptionLabel";
         // 
         // _progressBar
         // 
         resources.ApplyResources(this._progressBar, "_progressBar");
         this._progressBar.MarqueeAnimationSpeed = 50;
         this._progressBar.Name = "_progressBar";
         this._progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
         // 
         // _cancelButton
         // 
         this._cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         resources.ApplyResources(this._cancelButton, "_cancelButton");
         this._cancelButton.Name = "_cancelButton";
         this._cancelButton.UseVisualStyleBackColor = true;
         this._cancelButton.Click += new System.EventHandler(this._cancelButton_Click);
         // 
         // _cancellingLabel
         // 
         resources.ApplyResources(this._cancellingLabel, "_cancellingLabel");
         this._cancellingLabel.Name = "_cancellingLabel";
         // 
         // BusyDialog
         // 
         resources.ApplyResources(this, "$this");
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.CancelButton = this._cancelButton;
         this.ControlBox = false;
         this.Controls.Add(this._cancellingLabel);
         this.Controls.Add(this._cancelButton);
         this.Controls.Add(this._descriptionLabel);
         this.Controls.Add(this._progressBar);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "BusyDialog";
         this.ShowInTaskbar = false;
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label _descriptionLabel;
      private System.Windows.Forms.ProgressBar _progressBar;
      private System.Windows.Forms.Button _cancelButton;
      private System.Windows.Forms.Label _cancellingLabel;
   }
}