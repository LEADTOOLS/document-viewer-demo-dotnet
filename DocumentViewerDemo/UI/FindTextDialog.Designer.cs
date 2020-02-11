namespace DocumentViewerDemo.UI
{
   partial class FindTextDialog
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
         this._findTextBox = new System.Windows.Forms.TextBox();
         this._matchCaseCheckBox = new System.Windows.Forms.CheckBox();
         this._findLabel = new System.Windows.Forms.Label();
         this._wholeWordsOnlyCheckBox = new System.Windows.Forms.CheckBox();
         this._currentPageOnlyCheckBox = new System.Windows.Forms.CheckBox();
         this._nextButton = new System.Windows.Forms.Button();
         this._previousButton = new System.Windows.Forms.Button();
         this._optionsGroupBox = new System.Windows.Forms.GroupBox();
         this._optionsGroupBox.SuspendLayout();
         this.SuspendLayout();
         // 
         // _findTextBox
         // 
         this._findTextBox.Location = new System.Drawing.Point(42, 13);
         this._findTextBox.Name = "_findTextBox";
         this._findTextBox.Size = new System.Drawing.Size(227, 20);
         this._findTextBox.TabIndex = 1;
         // 
         // _matchCaseCheckBox
         // 
         this._matchCaseCheckBox.AutoSize = true;
         this._matchCaseCheckBox.Location = new System.Drawing.Point(42, 39);
         this._matchCaseCheckBox.Name = "_matchCaseCheckBox";
         this._matchCaseCheckBox.Size = new System.Drawing.Size(82, 17);
         this._matchCaseCheckBox.TabIndex = 2;
         this._matchCaseCheckBox.Text = "&Match case";
         this._matchCaseCheckBox.UseVisualStyleBackColor = true;
         // 
         // _findLabel
         // 
         this._findLabel.AutoSize = true;
         this._findLabel.Location = new System.Drawing.Point(6, 16);
         this._findLabel.Name = "_findLabel";
         this._findLabel.Size = new System.Drawing.Size(30, 13);
         this._findLabel.TabIndex = 0;
         this._findLabel.Text = "&Find:";
         // 
         // _wholeWordsOnlyCheckBox
         // 
         this._wholeWordsOnlyCheckBox.AutoSize = true;
         this._wholeWordsOnlyCheckBox.Location = new System.Drawing.Point(42, 62);
         this._wholeWordsOnlyCheckBox.Name = "_wholeWordsOnlyCheckBox";
         this._wholeWordsOnlyCheckBox.Size = new System.Drawing.Size(110, 17);
         this._wholeWordsOnlyCheckBox.TabIndex = 3;
         this._wholeWordsOnlyCheckBox.Text = "&Whole words only";
         this._wholeWordsOnlyCheckBox.UseVisualStyleBackColor = true;
         // 
         // _currentPageOnlyCheckBox
         // 
         this._currentPageOnlyCheckBox.AutoSize = true;
         this._currentPageOnlyCheckBox.Location = new System.Drawing.Point(42, 85);
         this._currentPageOnlyCheckBox.Name = "_currentPageOnlyCheckBox";
         this._currentPageOnlyCheckBox.Size = new System.Drawing.Size(142, 17);
         this._currentPageOnlyCheckBox.TabIndex = 4;
         this._currentPageOnlyCheckBox.Text = "Find in &current page only";
         this._currentPageOnlyCheckBox.UseVisualStyleBackColor = true;
         // 
         // _nextButton
         // 
         this._nextButton.Location = new System.Drawing.Point(219, 126);
         this._nextButton.Name = "_nextButton";
         this._nextButton.Size = new System.Drawing.Size(75, 23);
         this._nextButton.TabIndex = 2;
         this._nextButton.Text = "&Next";
         this._nextButton.UseVisualStyleBackColor = true;
         this._nextButton.Click += new System.EventHandler(this._nextButton_Click);
         // 
         // _previousButton
         // 
         this._previousButton.Location = new System.Drawing.Point(138, 126);
         this._previousButton.Name = "_previousButton";
         this._previousButton.Size = new System.Drawing.Size(75, 23);
         this._previousButton.TabIndex = 1;
         this._previousButton.Text = "&Previous";
         this._previousButton.UseVisualStyleBackColor = true;
         this._previousButton.Click += new System.EventHandler(this._previousButton_Click);
         // 
         // _optionsGroupBox
         // 
         this._optionsGroupBox.Controls.Add(this._findTextBox);
         this._optionsGroupBox.Controls.Add(this._matchCaseCheckBox);
         this._optionsGroupBox.Controls.Add(this._findLabel);
         this._optionsGroupBox.Controls.Add(this._currentPageOnlyCheckBox);
         this._optionsGroupBox.Controls.Add(this._wholeWordsOnlyCheckBox);
         this._optionsGroupBox.Location = new System.Drawing.Point(14, 12);
         this._optionsGroupBox.Name = "_optionsGroupBox";
         this._optionsGroupBox.Size = new System.Drawing.Size(280, 108);
         this._optionsGroupBox.TabIndex = 0;
         this._optionsGroupBox.TabStop = false;
         // 
         // FindTextDialog
         // 
         this.AcceptButton = this._nextButton;
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(306, 162);
         this.Controls.Add(this._optionsGroupBox);
         this.Controls.Add(this._previousButton);
         this.Controls.Add(this._nextButton);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "FindTextDialog";
         this.ShowInTaskbar = false;
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "Find Text";
         this._optionsGroupBox.ResumeLayout(false);
         this._optionsGroupBox.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.TextBox _findTextBox;
      private System.Windows.Forms.CheckBox _matchCaseCheckBox;
      private System.Windows.Forms.Label _findLabel;
      private System.Windows.Forms.CheckBox _wholeWordsOnlyCheckBox;
      private System.Windows.Forms.CheckBox _currentPageOnlyCheckBox;
      private System.Windows.Forms.Button _nextButton;
      private System.Windows.Forms.Button _previousButton;
      private System.Windows.Forms.GroupBox _optionsGroupBox;
   }
}