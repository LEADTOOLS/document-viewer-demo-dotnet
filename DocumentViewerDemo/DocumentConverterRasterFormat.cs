// *************************************************************
// Copyright (c) 1991-2019 LEAD Technologies, Inc.              
// All Rights Reserved.                                         
// *************************************************************
using System;

namespace Leadtools.Demos
{
   public class DocumentConverterRasterFormat
   {
      public DocumentConverterRasterFormat()
      {
      }

      // Friendly name
      private string _friendlyName;
      public string FriendlyName
      {
         get { return _friendlyName; }
         set { _friendlyName = value; }
      }

      // Format to use when saving
      private RasterImageFormat _rasterImageFormat;
      public RasterImageFormat RasterImageFormat
      {
         get { return _rasterImageFormat; }
         set { _rasterImageFormat = value; }
      }

      // Bits/pixel to use when saving
      private int _bitsPerPixel;
      public int BitsPerPixel
      {
         get { return _bitsPerPixel; }
         set { _bitsPerPixel = value; }
      }

      // Default file extension to use when saving
      private string _extension;
      public string Extension
      {
         get { return _extension; }
         set { _extension = value; }
      }

      public override string ToString()
      {
         if (!string.IsNullOrEmpty(this.Extension))
            return string.Format("{0} ({1})", this.FriendlyName, this.Extension.ToUpperInvariant());
         else
            return this.FriendlyName;
      }
   }
}
