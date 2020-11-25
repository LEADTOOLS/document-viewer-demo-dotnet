namespace DocumentViewerDemo.UI
{
   partial class AttachmentPropertiesDialog
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
         this._propertiesListView = new System.Windows.Forms.ListView();
         this._keyColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this._valueColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.SuspendLayout();
         // 
         // _okButton
         // 
         this._okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this._okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
         this._okButton.Location = new System.Drawing.Point(569, 407);
         this._okButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this._okButton.Name = "_okButton";
         this._okButton.Size = new System.Drawing.Size(112, 35);
         this._okButton.TabIndex = 3;
         this._okButton.Text = "OK";
         this._okButton.UseVisualStyleBackColor = true;
         // 
         // _propertiesListView
         // 
         this._propertiesListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this._propertiesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._keyColumnHeader,
            this._valueColumnHeader});
         this._propertiesListView.HideSelection = false;
         this._propertiesListView.Location = new System.Drawing.Point(13, 14);
         this._propertiesListView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this._propertiesListView.Name = "_propertiesListView";
         this._propertiesListView.Size = new System.Drawing.Size(667, 377);
         this._propertiesListView.TabIndex = 4;
         this._propertiesListView.UseCompatibleStateImageBehavior = false;
         this._propertiesListView.View = System.Windows.Forms.View.Details;
         // 
         // _keyColumnHeader
         // 
         this._keyColumnHeader.Text = "Key";
         this._keyColumnHeader.Width = 80;
         // 
         // _valueColumnHeader
         // 
         this._valueColumnHeader.Text = "Value";
         // 
         // AttachmentPropertiesDialog
         // 
         this.AcceptButton = this._okButton;
         this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.CancelButton = this._okButton;
         this.ClientSize = new System.Drawing.Size(695, 456);
         this.Controls.Add(this._propertiesListView);
         this.Controls.Add(this._okButton);
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "AttachmentPropertiesDialog";
         this.ShowIcon = false;
         this.ShowInTaskbar = false;
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "Attachment";
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Button _okButton;
      private System.Windows.Forms.ListView _propertiesListView;
      private System.Windows.Forms.ColumnHeader _keyColumnHeader;
      private System.Windows.Forms.ColumnHeader _valueColumnHeader;
   }
}