namespace Leadtools.Demos
{
   partial class DocumentRedactionOptionsControl
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

      #region Component Designer generated code

      /// <summary> 
      /// Required method for Designer support - do not modify 
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this._redactionModeLabel = new System.Windows.Forms.Label();
         this._replaceCharacterLabel = new System.Windows.Forms.Label();
         this._redactionModeComboBox = new System.Windows.Forms.ComboBox();
         this._replaceCharacterTextBox = new System.Windows.Forms.TextBox();
         this.SuspendLayout();
         // 
         // _redactionModeLabel
         // 
         this._redactionModeLabel.AutoSize = true;
         this._redactionModeLabel.Location = new System.Drawing.Point(13, 11);
         this._redactionModeLabel.Name = "_redactionModeLabel";
         this._redactionModeLabel.Size = new System.Drawing.Size(86, 13);
         this._redactionModeLabel.TabIndex = 0;
         this._redactionModeLabel.Text = "Redaction Mode";
         // 
         // _replaceCharacterLabel
         // 
         this._replaceCharacterLabel.AutoSize = true;
         this._replaceCharacterLabel.Location = new System.Drawing.Point(13, 37);
         this._replaceCharacterLabel.Name = "_replaceCharacterLabel";
         this._replaceCharacterLabel.Size = new System.Drawing.Size(96, 13);
         this._replaceCharacterLabel.TabIndex = 1;
         this._replaceCharacterLabel.Text = "Replace Character";
         // 
         // _redactionModeComboBox
         // 
         this._redactionModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this._redactionModeComboBox.FormattingEnabled = true;
         this._redactionModeComboBox.Location = new System.Drawing.Point(125, 5);
         this._redactionModeComboBox.Name = "_redactionModeComboBox";
         this._redactionModeComboBox.Size = new System.Drawing.Size(139, 21);
         this._redactionModeComboBox.TabIndex = 2;
         this._redactionModeComboBox.SelectedIndexChanged += new System.EventHandler(this._redactionModeComboBox_SelectedIndexChanged);
         // 
         // _replaceCharacterTextBox
         // 
         this._replaceCharacterTextBox.Location = new System.Drawing.Point(125, 34);
         this._replaceCharacterTextBox.MaxLength = 1;
         this._replaceCharacterTextBox.Name = "_replaceCharacterTextBox";
         this._replaceCharacterTextBox.Size = new System.Drawing.Size(139, 20);
         this._replaceCharacterTextBox.TabIndex = 3;
         this._replaceCharacterTextBox.TextChanged += new System.EventHandler(this._replaceCharacterTextBox_TextChanged);
         // 
         // DocumentRedactionOptionsControl
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this._replaceCharacterTextBox);
         this.Controls.Add(this._redactionModeComboBox);
         this.Controls.Add(this._replaceCharacterLabel);
         this.Controls.Add(this._redactionModeLabel);
         this.Name = "DocumentRedactionOptionsControl";
         this.Size = new System.Drawing.Size(282, 63);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label _redactionModeLabel;
      private System.Windows.Forms.Label _replaceCharacterLabel;
      private System.Windows.Forms.ComboBox _redactionModeComboBox;
      private System.Windows.Forms.TextBox _replaceCharacterTextBox;
   }
}
