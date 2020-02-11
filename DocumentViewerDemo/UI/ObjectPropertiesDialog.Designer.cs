namespace DocumentViewerDemo.UI
{
   partial class ObjectPropertiesDialog
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
         this._propertyGrid = new System.Windows.Forms.PropertyGrid();
         this.SuspendLayout();
         // 
         // _closeButton
         // 
         this._closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
         this._closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this._closeButton.Location = new System.Drawing.Point(12, 250);
         this._closeButton.Name = "_closeButton";
         this._closeButton.Size = new System.Drawing.Size(75, 23);
         this._closeButton.TabIndex = 1;
         this._closeButton.Text = "Close";
         this._closeButton.UseVisualStyleBackColor = true;
         // 
         // _propertyGrid
         // 
         this._propertyGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this._propertyGrid.Location = new System.Drawing.Point(13, 13);
         this._propertyGrid.Name = "_propertyGrid";
         this._propertyGrid.Size = new System.Drawing.Size(393, 231);
         this._propertyGrid.TabIndex = 0;
         // 
         // ObjectPropertiesDialog
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.CancelButton = this._closeButton;
         this.ClientSize = new System.Drawing.Size(418, 285);
         this.Controls.Add(this._propertyGrid);
         this.Controls.Add(this._closeButton);
         this.MinimizeBox = false;
         this.Name = "ObjectPropertiesDialog";
         this.ShowIcon = false;
         this.ShowInTaskbar = false;
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "ObjectPropertiesDialog";
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Button _closeButton;
      private System.Windows.Forms.PropertyGrid _propertyGrid;

   }
}