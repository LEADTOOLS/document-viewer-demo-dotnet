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

using Leadtools;
using Leadtools.Document;

namespace DocumentViewerDemo.UI
{
   public partial class DocumentPropertiesDialog : Form
   {
      public DocumentPropertiesDialog()
      {
         InitializeComponent();
      }

      public LEADDocument Document { get; set; }

      protected override void OnLoad(EventArgs e)
      {
         if (!DesignMode)
         {
            Init();
         }

         base.OnLoad(e);
      }

      private void Init()
      {
         var document = this.Document;

         _documentListView.Items.Add(new ListViewItem(new string[] { "Document ID", document.DocumentId }));

         var uriType = "URL";
         var uriValue = "none";

         var uri = document.Uri;
         if (uri != null)
         {
            if (uri.IsFile)
            {
               uriType = "File";
               uriValue = uri.LocalPath;
            }
            else
            {
               uriType = "URL";
               uriValue = uri.ToString();
            }
         }

         _documentListView.Items.Add(new ListViewItem(new string[] { uriType, uriValue }));
         _documentListView.Items.Add(new ListViewItem(new string[] { "MIME Type", document.MimeType }));
         _documentListView.Items.Add(new ListViewItem(new string[] { "Encrypted", document.IsDecrypted ? "Yes" : "No" }));

         uri = document.Annotations.AnnotationsUri;
         if (uri != null)
         {
            if (uri.IsFile)
               _documentListView.Items.Add(new ListViewItem(new string[] { "Annotations file", uri.LocalPath }));
            else
               _documentListView.Items.Add(new ListViewItem(new string[] { "Annotations URL", uri.ToString() }));
         }

         var pageCount = document.Pages.Count;
         _documentListView.Items.Add(new ListViewItem(new string[] { "Pages", pageCount.ToString() }));

         if (pageCount > 0)
         {
            var page = document.Pages[0];
            var pageSize = page.Size;
            var sizeInchdes = LeadSizeD.Create(pageSize.Width / LEADDocument.UnitsPerInch, pageSize.Height / LEADDocument.UnitsPerInch);
            var sizePixels = document.SizeToPixels(pageSize);
            _documentListView.Items.Add(new ListViewItem(new string[] { "Page size", string.Format("{0} x {1} in ({2} x {3} px)", sizeInchdes.Width, sizeInchdes.Height, sizePixels.Width, sizePixels.Height) }));
         }

         foreach (var iter in document.Metadata)
            _metadataListView.Items.Add(new ListViewItem(new string[] { iter.Key, iter.Value }));
      }

      protected override void OnSizeChanged(EventArgs e)
      {
         _documentListView.Columns[_documentListView.Columns.Count - 1].Width = -2;
         _metadataListView.Columns[_metadataListView.Columns.Count - 1].Width = -2;

          base.OnSizeChanged(e);
      }
   }
}
