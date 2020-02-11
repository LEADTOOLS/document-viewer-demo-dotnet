namespace Leadtools.Demos
{
   partial class DocumentFormatSelector
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
         if(disposing && (components != null))
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocumentFormatSelector));
         this._formatComboBox = new System.Windows.Forms.ComboBox();
         this._formatOptionsButton = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // _formatComboBox
         // 
         this._formatComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this._formatComboBox.FormattingEnabled = true;
         resources.ApplyResources(this._formatComboBox, "_formatComboBox");
         this._formatComboBox.Name = "_formatComboBox";
         this._formatComboBox.SelectedIndexChanged += new System.EventHandler(this._formatComboBox_SelectedIndexChanged);
         // 
         // _formatOptionsButton
         // 
         resources.ApplyResources(this._formatOptionsButton, "_formatOptionsButton");
         this._formatOptionsButton.Name = "_formatOptionsButton";
         this._formatOptionsButton.UseVisualStyleBackColor = true;
         this._formatOptionsButton.Click += new System.EventHandler(this._formatOptionsButton_Click);
         // 
         // DocumentFormatSelector
         // 
         resources.ApplyResources(this, "$this");
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this._formatOptionsButton);
         this.Controls.Add(this._formatComboBox);
         this.Name = "DocumentFormatSelector";
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.ComboBox _formatComboBox;
      private System.Windows.Forms.Button _formatOptionsButton;
   }
}
