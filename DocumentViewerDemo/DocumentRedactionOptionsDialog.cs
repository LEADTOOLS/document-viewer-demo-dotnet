// *************************************************************
// Copyright (c) 1991-2019 LEAD Technologies, Inc.              
// All Rights Reserved.                                         
// *************************************************************

using System.Windows.Forms;

using Leadtools.Document;

namespace Leadtools.Demos
{
   public partial class DocumentRedactionOptionsDialog : Form
   {
      private DocumentRedactionOptions _options = new DocumentRedactionOptions();
      public DocumentRedactionOptions Options
      {
         get { return this._options; }
         set
         {
            this._options = value;
            this.UpdateOptions();
         }
      }

      public DocumentRedactionOptionsDialog()
      {
         InitializeComponent();

         UpdateOptions();
      }

      private void UpdateOptions()
      {
         this._viewRedactionOptionsControl.Options = this._options.ViewOptions;
         this._convertRedactionOptionsControl.Options = this._options.ConvertOptions;
      }
   }
}
