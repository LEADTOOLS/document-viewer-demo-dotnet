// *************************************************************
// Copyright (c) 1991-2019 LEAD Technologies, Inc.              
// All Rights Reserved.                                         
// *************************************************************
using System;
using System.Drawing;

using Leadtools;
using Leadtools.Drawing;

namespace Leadtools.Demos
{
   public sealed class Converters
   {
      private Converters()
      {
      }

      public static Color ToGdiPlusColor(RasterColor color)
      {
         return RasterColorConverter.ToColor(color);
      }

      public static RasterColor FromGdiPlusColor(Color color)
      {
         return RasterColorConverter.FromColor(color);
      }

      public static LeadRect ConvertRect(Rectangle rc)
      {
         return LeadRect.FromLTRB(rc.Left, rc.Top, rc.Right, rc.Bottom);
      }

      public static Rectangle ConvertRect(LeadRect rc)
      {
         return Rectangle.FromLTRB(rc.Left, rc.Top, rc.Right, rc.Bottom);
      }

      public static LeadPoint ConvertPoint(Point p)
      {
         return new LeadPoint(p.X, p.Y);
      }

      public static Point ConvertPoint(LeadPoint p)
      {
         return new Point(p.X, p.Y);
      }
   }
}
