namespace DocumentViewerDemo.UI
{
   partial class InputDialog
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
         this._cancelButton = new System.Windows.Forms.Button();
         this._valueLabel1 = new System.Windows.Forms.Label();
         this._valueTextBox = new System.Windows.Forms.TextBox();
         this._valueGroupBox = new System.Windows.Forms.GroupBox();
         this._valueLabel2 = new System.Windows.Forms.Label();
         this._valueGroupBox.SuspendLayout();
         this.SuspendLayout();
         // 
         // _okButton
         // 
         this._okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
         this._okButton.Location = new System.Drawing.Point(415, 28);
         this._okButton.Name = "_okButton";
         this._okButton.Size = new System.Drawing.Size(75, 23);
         this._okButton.TabIndex = 1;
         this._okButton.Text = "OK";
         this._okButton.UseVisualStyleBackColor = true;
         this._okButton.Click += new System.EventHandler(this._okButton_Click);
         // 
         // _cancelButton
         // 
         this._cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this._cancelButton.Location = new System.Drawing.Point(415, 57);
         this._cancelButton.Name = "_cancelButton";
         this._cancelButton.Size = new System.Drawing.Size(75, 23);
         this._cancelButton.TabIndex = 2;
         this._cancelButton.Text = "Cancel";
         this._cancelButton.UseVisualStyleBackColor = true;
         // 
         // _valueLabel1
         // 
         this._valueLabel1.Location = new System.Drawing.Point(6, 26);
         this._valueLabel1.Name = "_valueLabel1";
         this._valueLabel1.Size = new System.Drawing.Size(382, 13);
         this._valueLabel1.TabIndex = 0;
         this._valueLabel1.Text = "_valueLabel1";
         // 
         // _valueTextBox
         // 
         this._valueTextBox.Location = new System.Drawing.Point(6, 61);
         this._valueTextBox.Name = "_valueTextBox";
         this._valueTextBox.Size = new System.Drawing.Size(382, 20);
         this._valueTextBox.TabIndex = 1;
         // 
         // _valueGroupBox
         // 
         this._valueGroupBox.Controls.Add(this._valueLabel2);
         this._valueGroupBox.Controls.Add(this._valueLabel1);
         this._valueGroupBox.Controls.Add(this._valueTextBox);
         this._valueGroupBox.Location = new System.Drawing.Point(12, 12);
         this._valueGroupBox.Name = "_valueGroupBox";
         this._valueGroupBox.Size = new System.Drawing.Size(397, 93);
         this._valueGroupBox.TabIndex = 0;
         this._valueGroupBox.TabStop = false;
         this._valueGroupBox.Text = "_valueGroupBox";
         // 
         // _valueLabel2
         // 
         this._valueLabel2.Location = new System.Drawing.Point(6, 45);
         this._valueLabel2.Name = "_valueLabel2";
         this._valueLabel2.Size = new System.Drawing.Size(382, 13);
         this._valueLabel2.TabIndex = 2;
         this._valueLabel2.Text = "_valueLabel2";
         // 
         // InputDialog
         // 
         this.AcceptButton = this._okButton;
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.CancelButton = this._cancelButton;
         this.ClientSize = new System.Drawing.Size(502, 115);
         this.Controls.Add(this._valueGroupBox);
         this.Controls.Add(this._cancelButton);
         this.Controls.Add(this._okButton);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "InputDialog";
         this.ShowInTaskbar = false;
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "InputDialog";
         this._valueGroupBox.ResumeLayout(false);
         this._valueGroupBox.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Button _okButton;
      private System.Windows.Forms.Button _cancelButton;
      private System.Windows.Forms.Label _valueLabel1;
      private System.Windows.Forms.TextBox _valueTextBox;
      private System.Windows.Forms.GroupBox _valueGroupBox;
      private System.Windows.Forms.Label _valueLabel2;
   }
}