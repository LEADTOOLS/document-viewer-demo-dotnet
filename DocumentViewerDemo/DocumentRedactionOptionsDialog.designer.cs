namespace Leadtools.Demos
{
   partial class DocumentRedactionOptionsDialog
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
         this._tabControl = new System.Windows.Forms.TabControl();
         this._viewRedactionTabPage = new System.Windows.Forms.TabPage();
         this._noteTextBox = new System.Windows.Forms.TextBox();
         this._viewRedactionOptionsControl = new Leadtools.Demos.DocumentRedactionOptionsControl();
         this._convertRedactionTabPage = new System.Windows.Forms.TabPage();
         this._convertRedactionOptionsControl = new Leadtools.Demos.DocumentRedactionOptionsControl();
         this._tabControl.SuspendLayout();
         this._viewRedactionTabPage.SuspendLayout();
         this._convertRedactionTabPage.SuspendLayout();
         this.SuspendLayout();
         // 
         // _okButton
         // 
         this._okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this._okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
         this._okButton.Location = new System.Drawing.Point(236, 172);
         this._okButton.Name = "_okButton";
         this._okButton.Size = new System.Drawing.Size(75, 23);
         this._okButton.TabIndex = 2;
         this._okButton.Text = "OK";
         this._okButton.UseVisualStyleBackColor = true;
         // 
         // _tabControl
         // 
         this._tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this._tabControl.Controls.Add(this._viewRedactionTabPage);
         this._tabControl.Controls.Add(this._convertRedactionTabPage);
         this._tabControl.Location = new System.Drawing.Point(12, 12);
         this._tabControl.Name = "_tabControl";
         this._tabControl.SelectedIndex = 0;
         this._tabControl.Size = new System.Drawing.Size(303, 154);
         this._tabControl.TabIndex = 0;
         // 
         // _viewRedactionTabPage
         // 
         this._viewRedactionTabPage.Controls.Add(this._noteTextBox);
         this._viewRedactionTabPage.Controls.Add(this._viewRedactionOptionsControl);
         this._viewRedactionTabPage.Location = new System.Drawing.Point(4, 22);
         this._viewRedactionTabPage.Name = "_viewRedactionTabPage";
         this._viewRedactionTabPage.Padding = new System.Windows.Forms.Padding(3);
         this._viewRedactionTabPage.Size = new System.Drawing.Size(295, 128);
         this._viewRedactionTabPage.TabIndex = 0;
         this._viewRedactionTabPage.Text = "View";
         this._viewRedactionTabPage.UseVisualStyleBackColor = true;
         // 
         // _noteTextBox
         // 
         this._noteTextBox.BackColor = System.Drawing.SystemColors.Window;
         this._noteTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this._noteTextBox.Location = new System.Drawing.Point(7, 86);
         this._noteTextBox.Multiline = true;
         this._noteTextBox.Name = "_noteTextBox";
         this._noteTextBox.ReadOnly = true;
         this._noteTextBox.Size = new System.Drawing.Size(282, 39);
         this._noteTextBox.TabIndex = 0;
         this._noteTextBox.Text = "Changes made to this option will cause saving the document to cache then reload i" +
    "t.";
         // 
         // _viewRedactionOptionsControl
         // 
         this._viewRedactionOptionsControl.Location = new System.Drawing.Point(7, 7);
         this._viewRedactionOptionsControl.Name = "_viewRedactionOptionsControl";
         this._viewRedactionOptionsControl.Size = new System.Drawing.Size(282, 96);
         this._viewRedactionOptionsControl.TabIndex = 0;
         // 
         // _convertRedactionTabPage
         // 
         this._convertRedactionTabPage.Controls.Add(this._convertRedactionOptionsControl);
         this._convertRedactionTabPage.Location = new System.Drawing.Point(4, 22);
         this._convertRedactionTabPage.Name = "_convertRedactionTabPage";
         this._convertRedactionTabPage.Padding = new System.Windows.Forms.Padding(3);
         this._convertRedactionTabPage.Size = new System.Drawing.Size(295, 158);
         this._convertRedactionTabPage.TabIndex = 1;
         this._convertRedactionTabPage.Text = "Convert";
         this._convertRedactionTabPage.UseVisualStyleBackColor = true;
         // 
         // _convertRedactionOptionsControl
         // 
         this._convertRedactionOptionsControl.Location = new System.Drawing.Point(7, 7);
         this._convertRedactionOptionsControl.Name = "_convertRedactionOptionsControl";
         this._convertRedactionOptionsControl.Size = new System.Drawing.Size(282, 96);
         this._convertRedactionOptionsControl.TabIndex = 0;
         // 
         // DocumentRedactionOptionsDialog
         // 
         this.AcceptButton = this._okButton;
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.CancelButton = this._okButton;
         this.ClientSize = new System.Drawing.Size(327, 207);
         this.Controls.Add(this._tabControl);
         this.Controls.Add(this._okButton);
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "DocumentRedactionOptionsDialog";
         this.ShowIcon = false;
         this.ShowInTaskbar = false;
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "Document Redaction Options";
         this._tabControl.ResumeLayout(false);
         this._viewRedactionTabPage.ResumeLayout(false);
         this._viewRedactionTabPage.PerformLayout();
         this._convertRedactionTabPage.ResumeLayout(false);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Button _okButton;
      private System.Windows.Forms.TabControl _tabControl;
      private System.Windows.Forms.TabPage _viewRedactionTabPage;
      private System.Windows.Forms.TabPage _convertRedactionTabPage;
      private Leadtools.Demos.DocumentRedactionOptionsControl _viewRedactionOptionsControl;
      private Leadtools.Demos.DocumentRedactionOptionsControl _convertRedactionOptionsControl;
      private System.Windows.Forms.TextBox _noteTextBox;
   }
}