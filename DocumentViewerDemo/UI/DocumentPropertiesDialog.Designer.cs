namespace DocumentViewerDemo.UI
{
   partial class DocumentPropertiesDialog
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
         this._documentTabPage = new System.Windows.Forms.TabPage();
         this._documentListView = new System.Windows.Forms.ListView();
         this._keyColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this._valueColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this._metadataTabPage = new System.Windows.Forms.TabPage();
         this._metadataListView = new System.Windows.Forms.ListView();
         this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this._tabControl.SuspendLayout();
         this._documentTabPage.SuspendLayout();
         this._metadataTabPage.SuspendLayout();
         this.SuspendLayout();
         // 
         // _okButton
         // 
         this._okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this._okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
         this._okButton.Location = new System.Drawing.Point(392, 370);
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
         this._tabControl.Controls.Add(this._documentTabPage);
         this._tabControl.Controls.Add(this._metadataTabPage);
         this._tabControl.Location = new System.Drawing.Point(12, 12);
         this._tabControl.Name = "_tabControl";
         this._tabControl.SelectedIndex = 0;
         this._tabControl.Size = new System.Drawing.Size(459, 356);
         this._tabControl.TabIndex = 0;
         // 
         // _documentTabPage
         // 
         this._documentTabPage.Controls.Add(this._documentListView);
         this._documentTabPage.Location = new System.Drawing.Point(4, 22);
         this._documentTabPage.Name = "_documentTabPage";
         this._documentTabPage.Padding = new System.Windows.Forms.Padding(3);
         this._documentTabPage.Size = new System.Drawing.Size(451, 330);
         this._documentTabPage.TabIndex = 0;
         this._documentTabPage.Text = "Document";
         this._documentTabPage.UseVisualStyleBackColor = true;
         // 
         // _documentListView
         // 
         this._documentListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._keyColumnHeader,
            this._valueColumnHeader});
         this._documentListView.Dock = System.Windows.Forms.DockStyle.Fill;
         this._documentListView.Location = new System.Drawing.Point(3, 3);
         this._documentListView.Name = "_documentListView";
         this._documentListView.Size = new System.Drawing.Size(445, 324);
         this._documentListView.TabIndex = 0;
         this._documentListView.UseCompatibleStateImageBehavior = false;
         this._documentListView.View = System.Windows.Forms.View.Details;
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
         // _metadataTabPage
         // 
         this._metadataTabPage.Controls.Add(this._metadataListView);
         this._metadataTabPage.Location = new System.Drawing.Point(4, 22);
         this._metadataTabPage.Name = "_metadataTabPage";
         this._metadataTabPage.Padding = new System.Windows.Forms.Padding(3);
         this._metadataTabPage.Size = new System.Drawing.Size(451, 330);
         this._metadataTabPage.TabIndex = 1;
         this._metadataTabPage.Text = "Metadata";
         this._metadataTabPage.UseVisualStyleBackColor = true;
         // 
         // _metadataListView
         // 
         this._metadataListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
         this._metadataListView.Dock = System.Windows.Forms.DockStyle.Fill;
         this._metadataListView.Location = new System.Drawing.Point(3, 3);
         this._metadataListView.Name = "_metadataListView";
         this._metadataListView.Size = new System.Drawing.Size(445, 324);
         this._metadataListView.TabIndex = 1;
         this._metadataListView.UseCompatibleStateImageBehavior = false;
         this._metadataListView.View = System.Windows.Forms.View.Details;
         // 
         // columnHeader1
         // 
         this.columnHeader1.Text = "Key";
         this.columnHeader1.Width = 80;
         // 
         // columnHeader2
         // 
         this.columnHeader2.Text = "Value";
         // 
         // DocumentPropertiesDialog
         // 
         this.AcceptButton = this._okButton;
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.CancelButton = this._okButton;
         this.ClientSize = new System.Drawing.Size(482, 403);
         this.Controls.Add(this._tabControl);
         this.Controls.Add(this._okButton);
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "DocumentPropertiesDialog";
         this.ShowIcon = false;
         this.ShowInTaskbar = false;
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "Document Properties";
         this._tabControl.ResumeLayout(false);
         this._documentTabPage.ResumeLayout(false);
         this._metadataTabPage.ResumeLayout(false);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Button _okButton;
      private System.Windows.Forms.TabControl _tabControl;
      private System.Windows.Forms.TabPage _documentTabPage;
      private System.Windows.Forms.ListView _documentListView;
      private System.Windows.Forms.ColumnHeader _keyColumnHeader;
      private System.Windows.Forms.ColumnHeader _valueColumnHeader;
      private System.Windows.Forms.TabPage _metadataTabPage;
      private System.Windows.Forms.ListView _metadataListView;
      private System.Windows.Forms.ColumnHeader columnHeader1;
      private System.Windows.Forms.ColumnHeader columnHeader2;
   }
}