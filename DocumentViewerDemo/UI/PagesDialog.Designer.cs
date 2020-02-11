namespace DocumentViewerDemo.UI
{
   partial class PagesDialog
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
         this._pagesGroupBox = new System.Windows.Forms.GroupBox();
         this._currentPageNumberLabel = new System.Windows.Forms.Label();
         this._allPagesCheckBox = new System.Windows.Forms.CheckBox();
         this._lastPageNumberNumericUpDown = new System.Windows.Forms.NumericUpDown();
         this._firstPageNumberNumericUpDown = new System.Windows.Forms.NumericUpDown();
         this._pagesLabel = new System.Windows.Forms.Label();
         this._lastPageNumberLabel = new System.Windows.Forms.Label();
         this._operationLabel = new System.Windows.Forms.Label();
         this._firstPageNumberLabel = new System.Windows.Forms.Label();
         this._lastPageCheckBox = new System.Windows.Forms.CheckBox();
         this._pagesGroupBox.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this._lastPageNumberNumericUpDown)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this._firstPageNumberNumericUpDown)).BeginInit();
         this.SuspendLayout();
         // 
         // _okButton
         // 
         this._okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
         this._okButton.Location = new System.Drawing.Point(484, 26);
         this._okButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this._okButton.Name = "_okButton";
         this._okButton.Size = new System.Drawing.Size(112, 35);
         this._okButton.TabIndex = 1;
         this._okButton.Text = "OK";
         this._okButton.UseVisualStyleBackColor = true;
         this._okButton.Click += new System.EventHandler(this._okButton_Click);
         // 
         // _cancelButton
         // 
         this._cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this._cancelButton.Location = new System.Drawing.Point(484, 71);
         this._cancelButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this._cancelButton.Name = "_cancelButton";
         this._cancelButton.Size = new System.Drawing.Size(112, 35);
         this._cancelButton.TabIndex = 2;
         this._cancelButton.Text = "Cancel";
         this._cancelButton.UseVisualStyleBackColor = true;
         // 
         // _pagesGroupBox
         // 
         this._pagesGroupBox.Controls.Add(this._lastPageCheckBox);
         this._pagesGroupBox.Controls.Add(this._currentPageNumberLabel);
         this._pagesGroupBox.Controls.Add(this._allPagesCheckBox);
         this._pagesGroupBox.Controls.Add(this._lastPageNumberNumericUpDown);
         this._pagesGroupBox.Controls.Add(this._firstPageNumberNumericUpDown);
         this._pagesGroupBox.Controls.Add(this._pagesLabel);
         this._pagesGroupBox.Controls.Add(this._lastPageNumberLabel);
         this._pagesGroupBox.Controls.Add(this._operationLabel);
         this._pagesGroupBox.Controls.Add(this._firstPageNumberLabel);
         this._pagesGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._pagesGroupBox.Location = new System.Drawing.Point(16, 17);
         this._pagesGroupBox.Name = "_pagesGroupBox";
         this._pagesGroupBox.Size = new System.Drawing.Size(447, 300);
         this._pagesGroupBox.TabIndex = 0;
         this._pagesGroupBox.TabStop = false;
         // 
         // _currentPageNumberLabel
         // 
         this._currentPageNumberLabel.AutoSize = true;
         this._currentPageNumberLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._currentPageNumberLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
         this._currentPageNumberLabel.Location = new System.Drawing.Point(21, 258);
         this._currentPageNumberLabel.Name = "_currentPageNumberLabel";
         this._currentPageNumberLabel.Size = new System.Drawing.Size(206, 20);
         this._currentPageNumberLabel.TabIndex = 7;
         this._currentPageNumberLabel.Text = "Current page number is ###";
         // 
         // _allPagesCheckBox
         // 
         this._allPagesCheckBox.AutoSize = true;
         this._allPagesCheckBox.Location = new System.Drawing.Point(22, 106);
         this._allPagesCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this._allPagesCheckBox.Name = "_allPagesCheckBox";
         this._allPagesCheckBox.Size = new System.Drawing.Size(100, 24);
         this._allPagesCheckBox.TabIndex = 2;
         this._allPagesCheckBox.Text = "&All pages";
         this._allPagesCheckBox.UseVisualStyleBackColor = true;
         this._allPagesCheckBox.CheckedChanged += new System.EventHandler(this._allPagesCheckBox_CheckedChanged);
         // 
         // _lastPageNumberNumericUpDown
         // 
         this._lastPageNumberNumericUpDown.Location = new System.Drawing.Point(234, 195);
         this._lastPageNumberNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this._lastPageNumberNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
         this._lastPageNumberNumericUpDown.Name = "_lastPageNumberNumericUpDown";
         this._lastPageNumberNumericUpDown.Size = new System.Drawing.Size(180, 26);
         this._lastPageNumberNumericUpDown.TabIndex = 6;
         this._lastPageNumberNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
         this._lastPageNumberNumericUpDown.ValueChanged += new System.EventHandler(this._lastPageNumberNumericUpDown_ValueChanged);
         // 
         // _firstPageNumberNumericUpDown
         // 
         this._firstPageNumberNumericUpDown.Location = new System.Drawing.Point(234, 155);
         this._firstPageNumberNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this._firstPageNumberNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
         this._firstPageNumberNumericUpDown.Name = "_firstPageNumberNumericUpDown";
         this._firstPageNumberNumericUpDown.Size = new System.Drawing.Size(180, 26);
         this._firstPageNumberNumericUpDown.TabIndex = 4;
         this._firstPageNumberNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
         this._firstPageNumberNumericUpDown.ValueChanged += new System.EventHandler(this._firstPageNumberNumericUpDown_ValueChanged);
         // 
         // _pagesLabel
         // 
         this._pagesLabel.AutoSize = true;
         this._pagesLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._pagesLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
         this._pagesLabel.Location = new System.Drawing.Point(21, 62);
         this._pagesLabel.Name = "_pagesLabel";
         this._pagesLabel.Size = new System.Drawing.Size(226, 20);
         this._pagesLabel.TabIndex = 1;
         this._pagesLabel.Text = "Document contains ### pages";
         // 
         // _lastPageNumberLabel
         // 
         this._lastPageNumberLabel.AutoSize = true;
         this._lastPageNumberLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._lastPageNumberLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
         this._lastPageNumberLabel.Location = new System.Drawing.Point(84, 198);
         this._lastPageNumberLabel.Name = "_lastPageNumberLabel";
         this._lastPageNumberLabel.Size = new System.Drawing.Size(142, 20);
         this._lastPageNumberLabel.TabIndex = 5;
         this._lastPageNumberLabel.Text = "&Last page number:";
         this._lastPageNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // _operationLabel
         // 
         this._operationLabel.AutoSize = true;
         this._operationLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._operationLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
         this._operationLabel.Location = new System.Drawing.Point(21, 28);
         this._operationLabel.Name = "_operationLabel";
         this._operationLabel.Size = new System.Drawing.Size(349, 20);
         this._operationLabel.TabIndex = 0;
         this._operationLabel.Text = "Select the page number(s) for the ### operation";
         // 
         // _firstPageNumberLabel
         // 
         this._firstPageNumberLabel.AutoSize = true;
         this._firstPageNumberLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this._firstPageNumberLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
         this._firstPageNumberLabel.Location = new System.Drawing.Point(84, 158);
         this._firstPageNumberLabel.Name = "_firstPageNumberLabel";
         this._firstPageNumberLabel.Size = new System.Drawing.Size(142, 20);
         this._firstPageNumberLabel.TabIndex = 3;
         this._firstPageNumberLabel.Text = "&First page number:";
         this._firstPageNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // _lastPageCheckBox
         // 
         this._lastPageCheckBox.AutoSize = true;
         this._lastPageCheckBox.Location = new System.Drawing.Point(234, 231);
         this._lastPageCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this._lastPageCheckBox.Name = "_lastPageCheckBox";
         this._lastPageCheckBox.Size = new System.Drawing.Size(106, 24);
         this._lastPageCheckBox.TabIndex = 8;
         this._lastPageCheckBox.Text = "&Last page";
         this._lastPageCheckBox.UseVisualStyleBackColor = true;
         this._lastPageCheckBox.CheckedChanged += new System.EventHandler(this._lastPageCheckBox_CheckedChanged);
         // 
         // PagesDialog
         // 
         this.AcceptButton = this._okButton;
         this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.CancelButton = this._cancelButton;
         this.ClientSize = new System.Drawing.Size(615, 340);
         this.Controls.Add(this._pagesGroupBox);
         this.Controls.Add(this._cancelButton);
         this.Controls.Add(this._okButton);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "PagesDialog";
         this.ShowIcon = false;
         this.ShowInTaskbar = false;
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "PagesDialog";
         this._pagesGroupBox.ResumeLayout(false);
         this._pagesGroupBox.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this._lastPageNumberNumericUpDown)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this._firstPageNumberNumericUpDown)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Button _okButton;
      private System.Windows.Forms.Button _cancelButton;
      private System.Windows.Forms.GroupBox _pagesGroupBox;
      private System.Windows.Forms.Label _lastPageNumberLabel;
      private System.Windows.Forms.Label _operationLabel;
      private System.Windows.Forms.Label _firstPageNumberLabel;
      private System.Windows.Forms.Label _pagesLabel;
      private System.Windows.Forms.CheckBox _allPagesCheckBox;
      private System.Windows.Forms.NumericUpDown _lastPageNumberNumericUpDown;
      private System.Windows.Forms.NumericUpDown _firstPageNumberNumericUpDown;
      private System.Windows.Forms.Label _currentPageNumberLabel;
      private System.Windows.Forms.CheckBox _lastPageCheckBox;
   }
}