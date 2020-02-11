// *************************************************************
// Copyright (c) 1991-2019 LEAD Technologies, Inc.              
// All Rights Reserved.                                         
// *************************************************************
using System;
using System.Windows.Forms;

using Leadtools.Demos;

namespace DocumentViewerDemo.UI
{
   internal static class Helper
   {
      public static void ShowError(Form owner, Exception error)
      {
         if (owner != null && owner.InvokeRequired)
         {
            owner.BeginInvoke((MethodInvoker)delegate
            {
               Messager.ShowError(owner, error);
            });
         }
         else
         {
            Messager.ShowError(owner, error);
         }
      }

      public static void ShowError(Form owner, string message)
      {
         if (owner != null && owner.InvokeRequired)
         {
            owner.BeginInvoke((MethodInvoker)delegate
            {
               Messager.ShowError(owner, message);
            });
         }
         else
         {
            Messager.ShowError(owner, message);
         }
      }

      public static void ShowInformation(Form owner, string message)
      {
         if (owner != null && owner.InvokeRequired)
         {
            owner.BeginInvoke((MethodInvoker)delegate
            {
               Messager.ShowInformation(owner, message);
            });
         }
         else
         {
            Messager.ShowInformation(owner, message);
         }
      }

      public static void ShowWarning(Form owner, string message)
      {
         if (owner != null && owner.InvokeRequired)
         {
            owner.BeginInvoke((MethodInvoker)delegate
            {
               Messager.ShowWarning(owner, message);
            });
         }
         else
         {
            Messager.ShowWarning(owner, message);
         }
      }

      public static string AddTextNote(string message, bool noPages)
      {
         return string.Format(
            "{1}{0}{0}Note that 'Auto Get Text Mode' is off and {2}.{0}Either turn on 'Auto Get Text' from the 'Preferences' menu or get the text using the 'Page' menu.",
            Environment.NewLine,
            message,
            noPages ? "none of the pages have their text parsed" : "one or more pages do not have their text parsed");
      }
   }
}
