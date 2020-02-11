// *************************************************************
// Copyright (c) 1991-2019 LEAD Technologies, Inc.              
// All Rights Reserved.                                         
// *************************************************************
using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

using Leadtools.Caching;
using Leadtools.Document.Viewer;

namespace DocumentViewerDemo
{
   // Demo preferences and global settings
   // Can be loaded/saved from %LocalApplicationData%\DocumentViewerDemo.xml
   [Serializable]
   public struct Preferences
   {
      // Directory where cache is stored
      public string CacheDir;

      // Last successful document file and annotations we opened, so we-try to re-open in the demo
      public string LastDocumentFileName;
      public string LastAnnotationsFileName;
      public bool LastFileLoadEmbeddedAnnotations;
      public int LastDocumentFirstPageNumber;
      public int LastDocumentLastPageNumber;
      // Last successful document URL we opened, so we-try to re-open in the demo
      public string LastDocumentUri;
      public int LastDocumentUriFirstPageNumber;
      public int LastDocumentUriLastPageNumber;
      public string LastAnnotationsUri;
      public bool LastUriLoadEmbeddedAnnotations;
      // Show the operations output window
      public bool ShowOperations;
      // Show the text indicators on thumbnails and viewer
      public bool ShowTextIndicators;
      // Automatically get the text of the document when needed
      public bool AutoGetText;
      // Enable annotations tool-tips
      public bool EnableTooltips;
      // Enable inertia-scroll
      public bool EnableInertiaScroll;

      public static Preferences Default
      {
         get
         {
            var result = new Preferences();

            // Default directory to store the cache items
            result.CacheDir = Path.Combine(Leadtools.Demos.DemosGlobal.ImagesFolder, @"cache");
            result.AutoGetText = true;
            result.ShowOperations = true;
            result.ShowTextIndicators = true;
            result.EnableTooltips = true;
            result.EnableInertiaScroll = true;
            return result;
         }
      }

      public static string FileName
      {
         get
         {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), @"DocumentViewerDemo.xml");
         }
      }

      private static XmlSerializer _serializer = new XmlSerializer(typeof(Preferences));

      // Load the preferences from local application data, if not found or error, returns default preferences
      public static Preferences Load()
      {
         try
         {
            var file = FileName;
            if (File.Exists(file))
            {
               using (var reader = new XmlTextReader(file))
                  return (Preferences)_serializer.Deserialize(reader);
            }
         }
         catch { }

         return Preferences.Default;
      }

      // Save the preferences to local application data
      public void Save()
      {
         try
         {
            var file = FileName;
            using (var writer = new XmlTextWriter(file, Encoding.Unicode))
            {
               writer.Formatting = Formatting.Indented;
               writer.Indentation = 2;
               _serializer.Serialize(writer, this);
            }
         }
         catch { }
      }
   }
}
