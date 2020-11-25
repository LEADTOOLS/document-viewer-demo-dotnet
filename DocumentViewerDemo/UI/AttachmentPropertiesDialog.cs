// *************************************************************
// Copyright (c) 1991-2020 LEAD Technologies, Inc.              
// All Rights Reserved.                                         
// *************************************************************
using Leadtools.Document;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DocumentViewerDemo.UI
{
   public partial class AttachmentPropertiesDialog : Form
   {
      public DocumentAttachment Attachment { get; set; }

      public AttachmentPropertiesDialog()
      {
         InitializeComponent();
      }

      protected override void OnLoad(EventArgs e)
      {
         if (!DesignMode)
         {
            DocumentAttachment attachment = this.Attachment;

            if (attachment != null)
            {
               _propertiesListView.Items.Add(new ListViewItem(new string[] { "Document ID", attachment.DocumentId }));
               _propertiesListView.Items.Add(new ListViewItem(new string[] { "File name", attachment.FileName }));
               _propertiesListView.Items.Add(new ListViewItem(new string[] { "Display name", attachment.DisplayName }));
               _propertiesListView.Items.Add(new ListViewItem(new string[] { "File length", attachment.FileLength.ToString() }));
               _propertiesListView.Items.Add(new ListViewItem(new string[] { "Mime type", attachment.MimeType }));
               _propertiesListView.Items.Add(new ListViewItem(new string[] { "Is embedded", attachment.IsEmbedded ? "Yes" : "No" }));

               var sortedMetadata = new SortedDictionary<string, string>(attachment.Metadata);

               foreach (var item in sortedMetadata)
               {
                  string value = item.Value;

                  if (item.Key == "TimeCreated" || item.Key == "TimeModified")
                  {
                     DateTime time;
                     if (DateTime.TryParse(item.Value, out time))
                        value = time.ToString();
                  }
                  _propertiesListView.Items.Add(new ListViewItem(new string[] { item.Key, value }));
               }

               _propertiesListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
               _propertiesListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
         }

         base.OnLoad(e);
      }
   }
}
