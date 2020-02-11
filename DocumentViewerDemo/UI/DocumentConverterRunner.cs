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
using System.Diagnostics;
using System.Threading;

using Leadtools.Demos;
using Leadtools;
using Leadtools.Ocr;
using Leadtools.Caching;
using Leadtools.Document;
using Leadtools.Document.Converter;

namespace DocumentViewerDemo.UI
{
   public partial class DocumentConverterRunner : Form
   {
      public DocumentConverterRunner()
      {
         InitializeComponent();
      }

      public DocumentConverterPreferences Preferences;

      // Document to convert, if null, will ask for an input file (for File/Convert operation)
      public LEADDocument InputDocument;
      // Cache to use if document is not null
      public ObjectCache Cache;

      private bool _isWorking;
      private bool _cancelPending;

      protected override void OnLoad(EventArgs e)
      {
         if (!DesignMode)
         {
            this.ControlBox = false;

            ThreadPool.QueueUserWorkItem((object state) =>
            {
               _cancelPending = false;
               _isWorking = true;
               this.Run();
            });
         }

         base.OnLoad(e);
      }

      protected override void OnFormClosing(FormClosingEventArgs e)
      {
         e.Cancel = _isWorking;
         base.OnFormClosing(e);
      }

      private void Run()
      {
         // Initialize Trace
         var traceListener = new OutputWindowTraceListener(_outputWindow);
         Trace.Listeners.Add(traceListener);

         // Create it here and hook to the operation event so we can cancel
         var converter = new DocumentConverter();
         EventHandler<DocumentConverterJobEventArgs> jobOperationHandler = (sender, e) =>
         {
            if (this._cancelPending)
               e.Status = DocumentConverterJobStatus.Aborted;
         };

         converter.Jobs.JobOperation += jobOperationHandler;

         try
         {
            this.Preferences.Run(this.Cache, this.InputDocument, converter, null);
         }
         catch (OcrException ex)
         {
            this.BeginInvoke((MethodInvoker)delegate
            {
               UI.Helper.ShowError(this, string.Format("OCR error code: {0}\n{1}", ex.Code, ex.Message));
            });
         }
         catch (RasterException ex)
         {
            this.BeginInvoke((MethodInvoker)delegate
            {
               UI.Helper.ShowError(this, string.Format("LEADTOOLS error code: {0}\n{1}", ex.Code, ex.Message));
            });
         }
         catch (Exception ex)
         {
            this.BeginInvoke((MethodInvoker)delegate
            {
               UI.Helper.ShowError(this, ex);
            });
         }
         finally
         {
            Trace.Listeners.Remove(traceListener);
            converter.Jobs.JobOperation -= jobOperationHandler;

            _isWorking = false;

            this.BeginInvoke((MethodInvoker)delegate
            {
               this.ControlBox = true;
               _cancelButton.Text = "C&lose";
            });
         }
      }

      private void _cancelButton_Click(object sender, EventArgs e)
      {
         if (_isWorking)
         {
            // Just cancel the operation, dont close us
            _cancelPending = true;
            this.DialogResult = DialogResult.None;
         }
      }
   }
}
