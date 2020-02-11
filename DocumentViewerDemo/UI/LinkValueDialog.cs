// *************************************************************
// Copyright (c) 1991-2019 LEAD Technologies, Inc.              
// All Rights Reserved.                                         
// *************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DocumentViewerDemo.UI
{
   public partial class LinkValueDialog : Form
   {
      public LinkValueDialog()
      {
         InitializeComponent();
      }

      public string LinkValue;

      protected override void OnLoad(EventArgs e)
      {
         if (!DesignMode)
         {
            _linkValueTextBox.Text = LinkValue;
         }

         base.OnLoad(e);
      }
   }
}
