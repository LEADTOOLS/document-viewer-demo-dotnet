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
   public partial class ParsePageLinksDialog : Form
   {
      public ParsePageLinksDialog()
      {
         InitializeComponent();
      }

      public int MaxPageCount;
      public bool AutoParsePageLinksDecisionFinal;

      protected override void OnLoad(EventArgs e)
      {
         if (!DesignMode)
         {
            _infoLabel.Text = _infoLabel.Text.Replace("###", MaxPageCount.ToString());
         }

         base.OnLoad(e);
      }

      private void _yesButton_Click(object sender, EventArgs e)
      {
         this.AutoParsePageLinksDecisionFinal = _rememberDecisionCheckBox.Checked;
      }

      private void _noButton_Click(object sender, EventArgs e)
      {
         this.AutoParsePageLinksDecisionFinal = _rememberDecisionCheckBox.Checked;
      }
   }
}
