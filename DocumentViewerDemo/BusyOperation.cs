// *************************************************************
// Copyright (c) 1991-2019 LEAD Technologies, Inc.              
// All Rights Reserved.                                         
// *************************************************************
using System;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;

namespace DocumentViewerDemo
{
   class BusyOperation<T>
   {
      public string Name;
      public Action Begin;
      public Func<T> InThread;
      public Action End;
      public Action<T> ThenInvoke;
      public Action<Exception> Error;

      private BusyOperation() { }
      public BusyOperation(string name)
      {
         this.Name = name;
      }

      public void Run(Control invoker)
      {
         if (this.Begin != null)
         {
            Debug.WriteLine("Begin busy operation " + this.Name);
            this.Begin();
         }

         ThreadPool.QueueUserWorkItem((object state) =>
         {
            T result = default(T);
            var doInvoke = false;

            try
            {
               Debug.WriteLine("In thread busy operation " + this.Name);
               result = this.InThread();
               doInvoke = true;
            }
            catch (Exception ex)
            {
               Debug.WriteLine("Error busy operation " + this.Name);
               this.Error(ex);
            }

            if (this.End != null)
            {
               Debug.WriteLine("End busy operation " + this.Name);
               this.End();
            }

            if (doInvoke && invoker != null && this.ThenInvoke != null)
            {
               Debug.WriteLine("Then invoke busy operation " + this.Name);
               invoker.BeginInvoke((MethodInvoker)delegate
               {
                  this.ThenInvoke(result);
               });
            }
         });
      }
   }
}
