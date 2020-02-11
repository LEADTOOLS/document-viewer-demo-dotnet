// *************************************************************
// Copyright (c) 1991-2019 LEAD Technologies, Inc.              
// All Rights Reserved.                                         
// *************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DocumentViewerDemo.UI
{
   public partial class ObjectPropertiesDialog : Form
   {
      public ObjectPropertiesDialog()
      {
         InitializeComponent();
      }

      public PropertyGrid PropertyGrid
      {
         get { return _propertyGrid; }
      }
   }
}
