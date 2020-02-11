namespace DocumentViewerDemo.UI
{
   partial class DocumentConverterRunner
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
         this.components = new System.ComponentModel.Container();
         this._cancelButton = new System.Windows.Forms.Button();
         this._outputWindow = new DocumentViewerDemo.UI.OutputWindow();
         this.SuspendLayout();
         // 
         // _cancelButton
         // 
         this._cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this._cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this._cancelButton.Location = new System.Drawing.Point(420, 271);
         this._cancelButton.Name = "_cancelButton";
         this._cancelButton.Size = new System.Drawing.Size(75, 23);
         this._cancelButton.TabIndex = 1;
         this._cancelButton.Text = "Cancel";
         this._cancelButton.UseVisualStyleBackColor = true;
         this._cancelButton.Click += new System.EventHandler(this._cancelButton_Click);
         // 
         // _outputWindow
         // 
         this._outputWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this._outputWindow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this._outputWindow.Font = new System.Drawing.Font("Consolas", 8F);
         this._outputWindow.Location = new System.Drawing.Point(12, 12);
         this._outputWindow.Name = "_outputWindow";
         this._outputWindow.Size = new System.Drawing.Size(483, 253);
         this._outputWindow.TabIndex = 0;
         this._outputWindow.Text = "";
         // 
         // DocumentConverterRunner
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.CancelButton = this._cancelButton;
         this.ClientSize = new System.Drawing.Size(507, 306);
         this.Controls.Add(this._cancelButton);
         this.Controls.Add(this._outputWindow);
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "DocumentConverterRunner";
         this.ShowIcon = false;
         this.ShowInTaskbar = false;
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "Convert Document";
         this.ResumeLayout(false);

      }

      #endregion

      private OutputWindow _outputWindow;
      private System.Windows.Forms.Button _cancelButton;
   }
}