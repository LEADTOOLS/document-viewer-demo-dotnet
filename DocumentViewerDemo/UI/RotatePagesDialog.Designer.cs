namespace DocumentViewerDemo.UI
{
   partial class RotatePagesDialog
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
         this._cancelButton = new System.Windows.Forms.Button();
         this._okButton = new System.Windows.Forms.Button();
         this._directionLabel = new System.Windows.Forms.Label();
         this._directionComboBox = new System.Windows.Forms.ComboBox();
         this._rangeGroupBox = new System.Windows.Forms.GroupBox();
         this._allRadioButton = new System.Windows.Forms.RadioButton();
         this._selectedRadioButton = new System.Windows.Forms.RadioButton();
         this._pagesRadioButton = new System.Windows.Forms.RadioButton();
         this._fromLabel = new System.Windows.Forms.Label();
         this._fromTextBox = new System.Windows.Forms.TextBox();
         this._toTextBox = new System.Windows.Forms.TextBox();
         this._toLabel = new System.Windows.Forms.Label();
         this._rotateLabel = new System.Windows.Forms.Label();
         this._evenOddComboBox = new System.Windows.Forms.ComboBox();
         this._orientationComboBox = new System.Windows.Forms.ComboBox();
         this._ofLabel = new System.Windows.Forms.Label();
         this._rangeGroupBox.SuspendLayout();
         this.SuspendLayout();
         // 
         // _cancelButton
         // 
         this._cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this._cancelButton.Location = new System.Drawing.Point(496, 357);
         this._cancelButton.Name = "_cancelButton";
         this._cancelButton.Size = new System.Drawing.Size(112, 35);
         this._cancelButton.TabIndex = 4;
         this._cancelButton.Text = "Cancel";
         this._cancelButton.UseVisualStyleBackColor = true;
         // 
         // _okButton
         // 
         this._okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
         this._okButton.Location = new System.Drawing.Point(378, 357);
         this._okButton.Name = "_okButton";
         this._okButton.Size = new System.Drawing.Size(112, 35);
         this._okButton.TabIndex = 3;
         this._okButton.Text = "OK";
         this._okButton.UseVisualStyleBackColor = true;
         this._okButton.Click += new System.EventHandler(this._okButton_Click);
         // 
         // _directionLabel
         // 
         this._directionLabel.AutoSize = true;
         this._directionLabel.Location = new System.Drawing.Point(37, 34);
         this._directionLabel.Name = "_directionLabel";
         this._directionLabel.Size = new System.Drawing.Size(76, 20);
         this._directionLabel.TabIndex = 0;
         this._directionLabel.Text = "&Direction:";
         // 
         // _directionComboBox
         // 
         this._directionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this._directionComboBox.FormattingEnabled = true;
         this._directionComboBox.Location = new System.Drawing.Point(152, 31);
         this._directionComboBox.Name = "_directionComboBox";
         this._directionComboBox.Size = new System.Drawing.Size(271, 28);
         this._directionComboBox.TabIndex = 1;
         // 
         // _rangeGroupBox
         // 
         this._rangeGroupBox.Controls.Add(this._ofLabel);
         this._rangeGroupBox.Controls.Add(this._orientationComboBox);
         this._rangeGroupBox.Controls.Add(this._evenOddComboBox);
         this._rangeGroupBox.Controls.Add(this._rotateLabel);
         this._rangeGroupBox.Controls.Add(this._toTextBox);
         this._rangeGroupBox.Controls.Add(this._toLabel);
         this._rangeGroupBox.Controls.Add(this._fromTextBox);
         this._rangeGroupBox.Controls.Add(this._fromLabel);
         this._rangeGroupBox.Controls.Add(this._pagesRadioButton);
         this._rangeGroupBox.Controls.Add(this._selectedRadioButton);
         this._rangeGroupBox.Controls.Add(this._allRadioButton);
         this._rangeGroupBox.Location = new System.Drawing.Point(30, 86);
         this._rangeGroupBox.Name = "_rangeGroupBox";
         this._rangeGroupBox.Size = new System.Drawing.Size(588, 265);
         this._rangeGroupBox.TabIndex = 2;
         this._rangeGroupBox.TabStop = false;
         this._rangeGroupBox.Text = "&Range";
         // 
         // _allRadioButton
         // 
         this._allRadioButton.AutoSize = true;
         this._allRadioButton.Location = new System.Drawing.Point(42, 49);
         this._allRadioButton.Name = "_allRadioButton";
         this._allRadioButton.Size = new System.Drawing.Size(51, 24);
         this._allRadioButton.TabIndex = 0;
         this._allRadioButton.TabStop = true;
         this._allRadioButton.Text = "&All";
         this._allRadioButton.UseVisualStyleBackColor = true;
         this._allRadioButton.CheckedChanged += new System.EventHandler(this._allRadioButton_CheckedChanged);
         // 
         // _selectedRadioButton
         // 
         this._selectedRadioButton.AutoSize = true;
         this._selectedRadioButton.Location = new System.Drawing.Point(42, 92);
         this._selectedRadioButton.Name = "_selectedRadioButton";
         this._selectedRadioButton.Size = new System.Drawing.Size(97, 24);
         this._selectedRadioButton.TabIndex = 1;
         this._selectedRadioButton.TabStop = true;
         this._selectedRadioButton.Text = "&Selected";
         this._selectedRadioButton.UseVisualStyleBackColor = true;
         this._selectedRadioButton.CheckedChanged += new System.EventHandler(this._selectedRadioButton_CheckedChanged);
         // 
         // _pagesRadioButton
         // 
         this._pagesRadioButton.AutoSize = true;
         this._pagesRadioButton.Location = new System.Drawing.Point(42, 135);
         this._pagesRadioButton.Name = "_pagesRadioButton";
         this._pagesRadioButton.Size = new System.Drawing.Size(79, 24);
         this._pagesRadioButton.TabIndex = 2;
         this._pagesRadioButton.TabStop = true;
         this._pagesRadioButton.Text = "&Pages";
         this._pagesRadioButton.UseVisualStyleBackColor = true;
         this._pagesRadioButton.CheckedChanged += new System.EventHandler(this._pagesRadioButton_CheckedChanged);
         // 
         // _fromLabel
         // 
         this._fromLabel.AutoSize = true;
         this._fromLabel.Location = new System.Drawing.Point(159, 138);
         this._fromLabel.Name = "_fromLabel";
         this._fromLabel.Size = new System.Drawing.Size(50, 20);
         this._fromLabel.TabIndex = 3;
         this._fromLabel.Text = "&From:";
         // 
         // _fromTextBox
         // 
         this._fromTextBox.Location = new System.Drawing.Point(215, 135);
         this._fromTextBox.Name = "_fromTextBox";
         this._fromTextBox.Size = new System.Drawing.Size(100, 26);
         this._fromTextBox.TabIndex = 4;
         // 
         // _toTextBox
         // 
         this._toTextBox.Location = new System.Drawing.Point(372, 135);
         this._toTextBox.Name = "_toTextBox";
         this._toTextBox.Size = new System.Drawing.Size(100, 26);
         this._toTextBox.TabIndex = 6;
         // 
         // _toLabel
         // 
         this._toLabel.AutoSize = true;
         this._toLabel.Location = new System.Drawing.Point(335, 137);
         this._toLabel.Name = "_toLabel";
         this._toLabel.Size = new System.Drawing.Size(31, 20);
         this._toLabel.TabIndex = 5;
         this._toLabel.Text = "&To:";
         // 
         // _rotateLabel
         // 
         this._rotateLabel.AutoSize = true;
         this._rotateLabel.Location = new System.Drawing.Point(38, 186);
         this._rotateLabel.Name = "_rotateLabel";
         this._rotateLabel.Size = new System.Drawing.Size(62, 20);
         this._rotateLabel.TabIndex = 8;
         this._rotateLabel.Text = "R&otate:";
         // 
         // _evenOddComboBox
         // 
         this._evenOddComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this._evenOddComboBox.FormattingEnabled = true;
         this._evenOddComboBox.Location = new System.Drawing.Point(122, 183);
         this._evenOddComboBox.Name = "_evenOddComboBox";
         this._evenOddComboBox.Size = new System.Drawing.Size(271, 28);
         this._evenOddComboBox.TabIndex = 9;
         // 
         // _orientationComboBox
         // 
         this._orientationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this._orientationComboBox.FormattingEnabled = true;
         this._orientationComboBox.Location = new System.Drawing.Point(122, 217);
         this._orientationComboBox.Name = "_orientationComboBox";
         this._orientationComboBox.Size = new System.Drawing.Size(271, 28);
         this._orientationComboBox.TabIndex = 10;
         // 
         // _ofLabel
         // 
         this._ofLabel.AutoSize = true;
         this._ofLabel.Location = new System.Drawing.Point(478, 139);
         this._ofLabel.Name = "_ofLabel";
         this._ofLabel.Size = new System.Drawing.Size(54, 20);
         this._ofLabel.TabIndex = 7;
         this._ofLabel.Text = "of ###";
         // 
         // RotatePagesDialog
         // 
         this.AcceptButton = this._okButton;
         this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.CancelButton = this._cancelButton;
         this.ClientSize = new System.Drawing.Size(647, 407);
         this.Controls.Add(this._rangeGroupBox);
         this.Controls.Add(this._directionComboBox);
         this.Controls.Add(this._directionLabel);
         this.Controls.Add(this._okButton);
         this.Controls.Add(this._cancelButton);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "RotatePagesDialog";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "Rotate Pages";
         this._rangeGroupBox.ResumeLayout(false);
         this._rangeGroupBox.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button _cancelButton;
      private System.Windows.Forms.Button _okButton;
      private System.Windows.Forms.Label _directionLabel;
      private System.Windows.Forms.ComboBox _directionComboBox;
      private System.Windows.Forms.GroupBox _rangeGroupBox;
      private System.Windows.Forms.TextBox _toTextBox;
      private System.Windows.Forms.Label _toLabel;
      private System.Windows.Forms.TextBox _fromTextBox;
      private System.Windows.Forms.Label _fromLabel;
      private System.Windows.Forms.RadioButton _pagesRadioButton;
      private System.Windows.Forms.RadioButton _selectedRadioButton;
      private System.Windows.Forms.RadioButton _allRadioButton;
      private System.Windows.Forms.ComboBox _orientationComboBox;
      private System.Windows.Forms.ComboBox _evenOddComboBox;
      private System.Windows.Forms.Label _rotateLabel;
      private System.Windows.Forms.Label _ofLabel;
   }
}