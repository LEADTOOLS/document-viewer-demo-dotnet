// *************************************************************
// Copyright (c) 1991-2019 LEAD Technologies, Inc.              
// All Rights Reserved.                                         
// *************************************************************
using System;
using System.Windows.Forms;

using Leadtools.Document;

namespace Leadtools.Demos
{
   public partial class DocumentRedactionOptionsControl : UserControl
   {
      private AnnotationsRedactionOptions _options = new AnnotationsRedactionOptions();
      public AnnotationsRedactionOptions Options
      {
         get { return this._options; }
         set
         {
            this._options = value;
            this._redactionModeComboBox.SelectedIndex = (int)this._options.Mode;
            this._replaceCharacterTextBox.Text = this._options.ReplaceCharacter == '\0' ? string.Empty : this._options.ReplaceCharacter.ToString();
         }
      }

      public DocumentRedactionOptionsControl()
      {
         InitializeComponent();

         var redactionModes = new string[]
         {
            "None",
            "Apply",
            "Apply then rasterize",
         };

         this._redactionModeComboBox.Items.AddRange(redactionModes);
      }

      private void _redactionModeComboBox_SelectedIndexChanged(object sender, EventArgs e)
      {
         if (this._options == null)
            return;

         _options.Mode = (DocumentRedactionMode)this._redactionModeComboBox.SelectedIndex;
         this._replaceCharacterTextBox.Enabled = _options.Mode != DocumentRedactionMode.None;
      }

      private void _replaceCharacterTextBox_TextChanged(object sender, EventArgs e)
      {
         if (this._options == null)
            return;

         this._options.ReplaceCharacter = !string.IsNullOrEmpty(this._replaceCharacterTextBox.Text) ? this._replaceCharacterTextBox.Text[0] : '\0';
      }
   }
}
