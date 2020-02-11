namespace DocumentViewerDemo.UI
{
   partial class CustomRenderModeDialog
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomRenderModeDialog));
         this._okButton = new System.Windows.Forms.Button();
         this._cancelButton = new System.Windows.Forms.Button();
         this._descriptionLabel = new System.Windows.Forms.Label();
         this._visibleObjectsLabel = new System.Windows.Forms.Label();
         this._visibleObjectsListBox = new System.Windows.Forms.ListBox();
         this._invisibleObjectsListBox = new System.Windows.Forms.ListBox();
         this._invisibleObjectsLabel = new System.Windows.Forms.Label();
         this._moveToInvisibleButton = new System.Windows.Forms.Button();
         this._moveToVisibleButton = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // _okButton
         // 
         this._okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
         this._okButton.Location = new System.Drawing.Point(425, 117);
         this._okButton.Name = "_okButton";
         this._okButton.Size = new System.Drawing.Size(75, 23);
         this._okButton.TabIndex = 7;
         this._okButton.Text = "OK";
         this._okButton.UseVisualStyleBackColor = true;
         this._okButton.Click += new System.EventHandler(this._okButton_Click);
         // 
         // _cancelButton
         // 
         this._cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this._cancelButton.Location = new System.Drawing.Point(425, 146);
         this._cancelButton.Name = "_cancelButton";
         this._cancelButton.Size = new System.Drawing.Size(75, 23);
         this._cancelButton.TabIndex = 8;
         this._cancelButton.Text = "Cancel";
         this._cancelButton.UseVisualStyleBackColor = true;
         // 
         // _descriptionLabel
         // 
         this._descriptionLabel.Location = new System.Drawing.Point(13, 13);
         this._descriptionLabel.Name = "_descriptionLabel";
         this._descriptionLabel.Size = new System.Drawing.Size(406, 69);
         this._descriptionLabel.TabIndex = 0;
         this._descriptionLabel.Text = resources.GetString("_descriptionLabel.Text");
         // 
         // _visibleObjectsLabel
         // 
         this._visibleObjectsLabel.AutoSize = true;
         this._visibleObjectsLabel.Location = new System.Drawing.Point(10, 98);
         this._visibleObjectsLabel.Name = "_visibleObjectsLabel";
         this._visibleObjectsLabel.Size = new System.Drawing.Size(77, 13);
         this._visibleObjectsLabel.TabIndex = 1;
         this._visibleObjectsLabel.Text = "&Visible objects:";
         // 
         // _visibleObjectsListBox
         // 
         this._visibleObjectsListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
         this._visibleObjectsListBox.FormattingEnabled = true;
         this._visibleObjectsListBox.Location = new System.Drawing.Point(13, 117);
         this._visibleObjectsListBox.Name = "_visibleObjectsListBox";
         this._visibleObjectsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
         this._visibleObjectsListBox.Size = new System.Drawing.Size(200, 290);
         this._visibleObjectsListBox.Sorted = true;
         this._visibleObjectsListBox.TabIndex = 2;
         this._visibleObjectsListBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this._visibleObjectsListBox_DrawItem);
         this._visibleObjectsListBox.SelectedIndexChanged += new System.EventHandler(this._visibleObjectsListBox_SelectedIndexChanged);
         // 
         // _invisibleObjectsListBox
         // 
         this._invisibleObjectsListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
         this._invisibleObjectsListBox.FormattingEnabled = true;
         this._invisibleObjectsListBox.Location = new System.Drawing.Point(219, 117);
         this._invisibleObjectsListBox.Name = "_invisibleObjectsListBox";
         this._invisibleObjectsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
         this._invisibleObjectsListBox.Size = new System.Drawing.Size(200, 290);
         this._invisibleObjectsListBox.Sorted = true;
         this._invisibleObjectsListBox.TabIndex = 5;
         this._invisibleObjectsListBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this._invisibleObjectsListBox_DrawItem);
         this._invisibleObjectsListBox.SelectedIndexChanged += new System.EventHandler(this._invisibleObjectsListBox_SelectedIndexChanged);
         // 
         // _invisibleObjectsLabel
         // 
         this._invisibleObjectsLabel.AutoSize = true;
         this._invisibleObjectsLabel.Location = new System.Drawing.Point(216, 98);
         this._invisibleObjectsLabel.Name = "_invisibleObjectsLabel";
         this._invisibleObjectsLabel.Size = new System.Drawing.Size(85, 13);
         this._invisibleObjectsLabel.TabIndex = 4;
         this._invisibleObjectsLabel.Text = "&Invisible objects:";
         // 
         // _moveToInvisibleButton
         // 
         this._moveToInvisibleButton.Location = new System.Drawing.Point(138, 413);
         this._moveToInvisibleButton.Name = "_moveToInvisibleButton";
         this._moveToInvisibleButton.Size = new System.Drawing.Size(75, 23);
         this._moveToInvisibleButton.TabIndex = 3;
         this._moveToInvisibleButton.Text = ">>";
         this._moveToInvisibleButton.UseVisualStyleBackColor = true;
         this._moveToInvisibleButton.Click += new System.EventHandler(this._moveToInvisibleButton_Click);
         // 
         // _moveToVisibleButton
         // 
         this._moveToVisibleButton.Location = new System.Drawing.Point(219, 413);
         this._moveToVisibleButton.Name = "_moveToVisibleButton";
         this._moveToVisibleButton.Size = new System.Drawing.Size(75, 23);
         this._moveToVisibleButton.TabIndex = 6;
         this._moveToVisibleButton.Text = "<<";
         this._moveToVisibleButton.UseVisualStyleBackColor = true;
         this._moveToVisibleButton.Click += new System.EventHandler(this._moveToVisibleButton_Click);
         // 
         // CustomRenderModeDialog
         // 
         this.AcceptButton = this._okButton;
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.CancelButton = this._cancelButton;
         this.ClientSize = new System.Drawing.Size(509, 445);
         this.Controls.Add(this._moveToVisibleButton);
         this.Controls.Add(this._moveToInvisibleButton);
         this.Controls.Add(this._invisibleObjectsListBox);
         this.Controls.Add(this._invisibleObjectsLabel);
         this.Controls.Add(this._visibleObjectsListBox);
         this.Controls.Add(this._visibleObjectsLabel);
         this.Controls.Add(this._descriptionLabel);
         this.Controls.Add(this._cancelButton);
         this.Controls.Add(this._okButton);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "CustomRenderModeDialog";
         this.ShowIcon = false;
         this.ShowInTaskbar = false;
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "Customize Render Mode";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button _okButton;
      private System.Windows.Forms.Button _cancelButton;
      private System.Windows.Forms.Label _descriptionLabel;
      private System.Windows.Forms.Label _visibleObjectsLabel;
      private System.Windows.Forms.ListBox _visibleObjectsListBox;
      private System.Windows.Forms.ListBox _invisibleObjectsListBox;
      private System.Windows.Forms.Label _invisibleObjectsLabel;
      private System.Windows.Forms.Button _moveToInvisibleButton;
      private System.Windows.Forms.Button _moveToVisibleButton;
   }
}