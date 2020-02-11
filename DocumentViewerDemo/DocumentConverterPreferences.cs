// *************************************************************
// Copyright (c) 1991-2019 LEAD Technologies, Inc.              
// All Rights Reserved.                                         
// *************************************************************
using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.Diagnostics;
using System.Globalization;
using System.Collections.Generic;

using Leadtools;
using Leadtools.Codecs;
using Leadtools.Ocr;
using Leadtools.Document.Writer;
using Leadtools.Caching;
using Leadtools.Document;
using Leadtools.Document.Converter;
using Leadtools.Annotations.Engine;

namespace Leadtools.Demos
{
   // Options for the DocumentConverterDialog
   [Serializable]
   public class DocumentConverterPreferences
   {
      public DocumentConverterPreferences()
      {
         this.InputFirstPage = 1;
         this.InputLastPage = -1;
         this.DocumentFormat = DocumentFormat.User;
         this.RasterImageFormat = RasterImageFormat.Unknown;
         this.RasterImageBitsPerPixel = 24;
         this.OutputAnnotationsMode = DocumentConverterAnnotationsMode.None;
         this.EnableSvgConversion = true;
         this.SvgImagesRecognitionMode = DocumentConverterSvgImagesRecognitionMode.Auto;
         this.EmptyPageMode = DocumentConverterEmptyPageMode.None;
         this.UseThreads = true;
         this.ErrorMode = DocumentConverterJobErrorMode.Continue;
         this.EnableTrace = true;
         this.JobName = "My Job";
         this.OpenOutputDocument = true;
         this.OpenOutputDocumentAllowed = true;
         this.OCREngineType = OcrEngineType.LEAD;
      }

      public DocumentConverterPreferences Clone()
      {
         var result = new DocumentConverterPreferences();
         result.InputDocumentFileName = this.InputDocumentFileName;
         result.InputDocumentPageCount = this.InputDocumentPageCount;
         result.InputFirstPage = this.InputFirstPage;
         result.InputLastPage = this.InputLastPage;
         result.InputMaximumPages = this.InputMaximumPages;
         result.InputAnnotationsFileName = this.InputAnnotationsFileName;
         result.LoadEmbeddedAnnotation = this.LoadEmbeddedAnnotation;
         result.DocumentFormat = this.DocumentFormat;
         result.RasterImageFormat = this.RasterImageFormat;
         result.RasterImageBitsPerPixel = this.RasterImageBitsPerPixel;
         result.OutputDocumentFileName = this.OutputDocumentFileName;
         result.OutputAnnotationsMode = this.OutputAnnotationsMode;
         result.OutputAnnotationsFileName = this.OutputAnnotationsFileName;
         result.PageNumberingTemplate = this.PageNumberingTemplate;
         result.EnableSvgConversion = this.EnableSvgConversion;
         result.SvgImagesRecognitionMode = this.SvgImagesRecognitionMode;
         result.EmptyPageMode = this.EmptyPageMode;
         result.UseThreads = this.UseThreads;
         result.PreprocessingDeskew = this.PreprocessingDeskew;
         result.PreprocessingInvert = this.PreprocessingInvert;
         result.PreprocessingOrient = this.PreprocessingOrient;
         result.ErrorMode = this.ErrorMode;
         result.EnableTrace = this.EnableTrace;
         result.JobName = this.JobName;
         result.OpenOutputDocument = this.OpenOutputDocument;
         result.OpenOutputDocumentAllowed = this.OpenOutputDocumentAllowed;
         result.OCREngineType = this.OCREngineType;
         result.OCREngineRuntimePath = this.OCREngineRuntimePath;
         result.RasterCodecsOptionsPath = this.RasterCodecsOptionsPath;
         result.DocumentWriterOptionsPath = this.DocumentWriterOptionsPath;
         result.CacheDirectory = this.CacheDirectory;
         result.CacheDataSerializationMode = this.CacheDataSerializationMode;
         result.CachePolicySerializationMode = this.CachePolicySerializationMode;

         result.DocumentId = this.DocumentId;
         result.DocumentUserToken = this.DocumentUserToken;
         result.OutputFiles = this.OutputFiles;
         result.OutputDocumentFiles = this.OutputDocumentFiles;
         result.OutputDocumentExtraFiles = this.OutputDocumentExtraFiles;
         result.OutputAnnotationFiles = this.OutputAnnotationFiles;
         result.PurgeOutputFilesOnError = this.PurgeOutputFilesOnError;

         // Be careful, we are using the same objects here
         result.RasterCodecsInstance = this.RasterCodecsInstance;
         result.OcrEngineInstance = this.OcrEngineInstance;
         result.DocumentWriterInstance = this.DocumentWriterInstance;
         result.IsSilentMode = this.IsSilentMode;
         result.ErrorMessage = this.ErrorMessage;
         result.AnnRenderingEngine = this.AnnRenderingEngine;

         return result;
      }

      // The input document file name
      public string InputDocumentFileName { get; set; }

      // Used by the UI. If it has 0 means we don't know
      [XmlIgnore]
      public int InputDocumentPageCount { get; set; }

      // Used by the UI. If it has 1 means first page
      public int InputFirstPage { get; set; }

      // Used by the UI. If it has -1 means last page
      public int InputLastPage { get; set; }

      // Maximum number of pages to convert, less than 1 means no limit. Works with a Document input only
      public int InputMaximumPages { get; set; }

      // The input annotation file
      public string InputAnnotationsFileName { get; set; }

      // Or if the annotations will be loaded from the input document file directly
      public bool LoadEmbeddedAnnotation { get; set; }

      // Document format to use
      public DocumentFormat DocumentFormat { get; set; }
      // Or RasterImage format
      public RasterImageFormat RasterImageFormat { get; set; }
      // Options to use when saving as Raster
      public int RasterImageBitsPerPixel { get; set; }

      // The output document file name
      public string OutputDocumentFileName { get; set; }

      // Output annotation mode and file name
      public DocumentConverterAnnotationsMode OutputAnnotationsMode { get; set; }
      public string OutputAnnotationsFileName { get; set; }

      // Page Numbering Template
      public string PageNumberingTemplate { get; set; }

      // SVG conversion
      public bool EnableSvgConversion { get; set; }

      // If to recognize embedded images in SVG images
      public DocumentConverterSvgImagesRecognitionMode SvgImagesRecognitionMode { get; set; }

      // Empty page mode
      public DocumentConverterEmptyPageMode EmptyPageMode { get; set; }

      // Use threads
      public bool UseThreads { get; set; }

      // Preprocessing
      public bool PreprocessingDeskew { get; set; }
      public bool PreprocessingInvert { get; set; }
      public bool PreprocessingOrient { get; set; }

      // Misc.
      public DocumentConverterJobErrorMode ErrorMode { get; set; }
      public bool EnableTrace { get; set; }
      public string JobName { get; set; }
      public bool OpenOutputDocument { get; set; }
      [XmlIgnore]
      public bool OpenOutputDocumentAllowed { get; set; }

      // OCR
      public OcrEngineType OCREngineType { get; set; }
      public string OCREngineRuntimePath { get; set; }

      // RasterCodecs
      public string RasterCodecsOptionsPath { get; set; }

      // DocumentWriter options
      public string DocumentWriterOptionsPath { get; set; }

      // Cache directory
      public string CacheDirectory { get; set; }

      // Cache Data Serialization Mode
      public CacheSerializationMode CacheDataSerializationMode { get; set; }

      // Cache Policy Serialization Mode
      public CacheSerializationMode CachePolicySerializationMode { get; set; }

      // Input Document ID
      public string DocumentId { get; set; }

      // Input Document user token
      public string DocumentUserToken { get; set; }

      // Output files
      [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
      public string[] OutputFiles { get; set; }

      // Output Document files (subset)
      [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
      public string[] OutputDocumentFiles { get; set; }

      // Output Document extra files (subset)
      [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
      public string[] OutputDocumentExtraFiles { get; set; }

      // Output Annotation files (subset)
      [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
      public string[] OutputAnnotationFiles { get; set; }

      // Delete the output files if an error occurs
      public bool PurgeOutputFilesOnError { get; set; }

      [XmlIgnore]
      public RasterCodecs RasterCodecsInstance { get; set; }

      [XmlIgnore]
      public IOcrEngine OcrEngineInstance { get; set; }

      [XmlIgnore]
      public DocumentWriter DocumentWriterInstance { get; set; }

      [XmlIgnore]
      public AnnRenderingEngine AnnRenderingEngine { get; set; }

      [XmlIgnore]
      public bool IsSilentMode { get; set; }

      public string ErrorMessage { get; set; }

      // The demo name
      public static string DemoName { get; set; }

      public static string XmlFileName { get; set; }

      private static string GetOutputFileName()
      {
         if (string.IsNullOrEmpty(XmlFileName)) throw new InvalidOperationException("Set XmlFileName before calling this method");

         return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), XmlFileName + ".xml");
      }

      private static XmlSerializer _serializer = new XmlSerializer(typeof(DocumentConverterPreferences));

      // Load the preferences from local application data, if not found or error, returns default preferences
      public static DocumentConverterPreferences Load()
      {
         try
         {
            var fileName = GetOutputFileName();
            if (File.Exists(fileName))
            {
               return Load(fileName);
            }
         }
         catch (Exception ex)
         {
            Debug.WriteLine(ex.Message);
         }

         return new DocumentConverterPreferences();
      }

      public static DocumentConverterPreferences Load(string fileName)
      {
         using (var reader = new XmlTextReader(fileName))
            return _serializer.Deserialize(reader) as DocumentConverterPreferences;
      }

      // Save the preferences to local application data
      public void Save()
      {
         try
         {
            var fileName = GetOutputFileName();
            Save(fileName);
         }
         catch { }
      }

      public void Save(string fileName)
      {
         using (var writer = new XmlTextWriter(fileName, Encoding.Unicode))
         {
            writer.Formatting = Formatting.Indented;
            writer.Indentation = 2;
            _serializer.Serialize(writer, this);
         }
      }

      // Run the conversion
      public bool Run(ObjectCache cache, LEADDocument document, DocumentConverter converter, ConvertRedactionOptions redactionOptions)
      {
         this.ErrorMessage = null;
         this.OutputFiles = null;
         this.OutputDocumentFiles = null;
         this.OutputDocumentExtraFiles = null;
         this.OutputAnnotationFiles = null;

         // Show its info
         ShowInfo(document);

         var disposeConverter = false;

         try
         {
            // If the user did not specify a document converter, create one
            if (converter == null)
            {
               converter = new DocumentConverter();
               disposeConverter = true;
            }

            // Set the options in the document converter from our data
            SetOptions(converter, cache, document, redactionOptions);

            // Create the document converter job
            var job = CreateConverterJob(converter, document);

            // Run it
            Trace.WriteLine("Running job...");
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            converter.Jobs.RunJob(job);
            stopwatch.Stop();

            // Show the results
            ShowResults(job);

            // Handle the output files (if any)
            HandleOutputFiles(job);

            Trace.WriteLine("----------------------------");
            Trace.WriteLine("Total conversion time: " + stopwatch.Elapsed.ToString());

            // See if we need to open the final document. LTD format has no viewer ...
            ViewOutputFile(job);

            // Check the errors
            if (job.Status == DocumentConverterJobStatus.Aborted)
            {
               // Get the first error
               if (job.Errors.Count > 0)
                  this.ErrorMessage = job.Errors[0].Error.Message;
            }

            return job.Status != DocumentConverterJobStatus.Aborted;
         }
         catch (OcrException ex)
         {
            this.ErrorMessage = ex.Message;
            Trace.WriteLine(string.Format("OCR error code: {0}\n{1}", ex.Code, ex.Message));
         }
         catch (RasterException ex)
         {
            this.ErrorMessage = ex.Message;
            Trace.WriteLine(string.Format("LEADTOOLS error code: {0}\n{1}", ex.Code, ex.Message));
         }
         catch (Exception ex)
         {
            this.ErrorMessage = ex.Message;
            Trace.WriteLine("Error: " + ex.Message);
         }
         finally
         {
            // If we created the converter, dispose it
            if (converter != null && disposeConverter)
               converter.Dispose();
         }

         return false;
      }

      private void HandleOutputFiles(DocumentConverterJob job)
      {
         if (job.Status != DocumentConverterJobStatus.Aborted)
         {
            // Copy the output files to job.OutputFiles so the user can get them
            this.OutputFiles = new string[job.OutputFiles.Count];
            job.OutputFiles.CopyTo(this.OutputFiles, 0);

            // Copy these subsets also
            if (job.OutputDocumentFiles != null)
            {
               this.OutputDocumentFiles = new string[job.OutputDocumentFiles.Count];
               job.OutputDocumentFiles.CopyTo(this.OutputDocumentFiles, 0);
            }
            if (job.OutputDocumentExtraFiles != null)
            {
               this.OutputDocumentExtraFiles = new string[job.OutputDocumentExtraFiles.Count];
               job.OutputDocumentExtraFiles.CopyTo(this.OutputDocumentExtraFiles, 0);
            }
            if (job.OutputAnnotationFiles != null)
            {
               this.OutputAnnotationFiles = new string[job.OutputAnnotationFiles.Count];
               job.OutputAnnotationFiles.CopyTo(this.OutputAnnotationFiles, 0);
            }

            // Show output files
            Trace.WriteLine("----------------------------");
            Trace.WriteLine("Output files:");
            foreach (var outputFile in job.OutputFiles)
            {
               Trace.WriteLine(outputFile);
            }
         }
         else
         {
            // An error occurred, see if we need to delete the output files
            if (this.PurgeOutputFilesOnError)
            {
               DeleteAllFiles(job.OutputFiles);
            }
         }
      }

      private static void ShowResults(DocumentConverterJob job)
      {
         // If we have errors, show them
         Trace.WriteLine("----------------------------------");
         Trace.WriteLine("Status: " + job.Status);

         if (job.Errors.Count > 0)
         {
            // We have errors, show them
            Trace.WriteLine("----------------------------------");
            Trace.WriteLine("Errors found:");
            foreach (var error in job.Errors)
            {
               if (error.InputDocumentPageNumber != 0)
                  Trace.WriteLine(string.Format("Operation: {0} - Page: {1} - Error: {2}", error.Operation, error.InputDocumentPageNumber, error.Error));
               else
                  Trace.WriteLine(string.Format("Operation: {0} - Error: {1}", error.Operation, error.Error));
            }
         }
      }

      private DocumentConverterJob CreateConverterJob(DocumentConverter converter, LEADDocument document)
      {
         // Set the maximum page
         var firstPage = this.InputFirstPage;
         if (firstPage == 0)
            firstPage = 1;

         var lastPage = this.InputLastPage;
         if (lastPage == 0)
            lastPage = -1;

         if (document != null && this.InputMaximumPages > 0)
         {
            if (lastPage == -1)
               lastPage = document.Pages.Count;
            lastPage = Math.Min(lastPage, firstPage + this.InputMaximumPages - 1);
         }

         // Create a job
         var jobData = new DocumentConverterJobData
         {
            InputDocumentFileName = document == null ? this.InputDocumentFileName : null,
            Document = document,
            InputDocumentFirstPageNumber = firstPage,
            InputDocumentLastPageNumber = lastPage,
            DocumentFormat = this.DocumentFormat,
            RasterImageFormat = this.RasterImageFormat,
            RasterImageBitsPerPixel = this.RasterImageBitsPerPixel,
            OutputDocumentFileName = this.OutputDocumentFileName,
            AnnotationsMode = this.OutputAnnotationsMode,
            OutputAnnotationsFileName = this.OutputAnnotationsFileName,
            JobName = this.JobName,
            UserData = null,
         };

         jobData.InputAnnotationsFileName = this.InputAnnotationsFileName;

         var job = converter.Jobs.CreateJob(jobData);
         return job;
      }

      private void SetOptions(DocumentConverter converter, ObjectCache cache, LEADDocument document, ConvertRedactionOptions redactionOptions)
      {
         converter.SetAnnRenderingEngineInstance(this.AnnRenderingEngine);

         // Set the RasterCodecs instance, should go into the DocumentFactory class which will be used to load the document
         if (this.RasterCodecsInstance != null)
            DocumentFactory.RasterCodecsTemplate = this.RasterCodecsInstance;

         // Set the OCR engine
         if (this.OcrEngineInstance != null && this.OcrEngineInstance.IsStarted)
            converter.SetOcrEngineInstance(this.OcrEngineInstance, false);

         if (this.DocumentWriterInstance != null)
            converter.SetDocumentWriterInstance(this.DocumentWriterInstance);

         // Set pre-processing options
         converter.Preprocessor.Deskew = this.PreprocessingDeskew;
         converter.Preprocessor.Invert = this.PreprocessingInvert;
         converter.Preprocessor.Orient = this.PreprocessingOrient;

         // Enable trace
         converter.Diagnostics.EnableTrace = this.EnableTrace;

         // Setup the load document options
         var loadDocumentOptions = new LoadDocumentOptions();
         // Setup cache
         loadDocumentOptions.Cache = cache;
         loadDocumentOptions.UseCache = cache != null;

         if (document == null)
         {
            // Set the input annotation mode or file name
            loadDocumentOptions.LoadEmbeddedAnnotations = this.LoadEmbeddedAnnotation;
            if (!this.LoadEmbeddedAnnotation && !string.IsNullOrEmpty(this.InputAnnotationsFileName) && File.Exists(this.InputAnnotationsFileName))
            {
               // We will use this instead of DocumentConverterJobData.InputAnnotationsFileName (this will override it anyway if we give the
               // document converter a loadDocumentOptions)
               loadDocumentOptions.AnnotationsUri = new Uri(this.InputAnnotationsFileName);
            }
         }

         converter.LoadDocumentOptions = loadDocumentOptions;

         // Set options
         converter.Options.JobErrorMode = this.ErrorMode;
         if (!string.IsNullOrEmpty(this.PageNumberingTemplate))
            converter.Options.PageNumberingTemplate = this.PageNumberingTemplate;
         converter.Options.EnableSvgConversion = this.EnableSvgConversion;
         converter.Options.SvgImagesRecognitionMode = (this.OcrEngineInstance != null && this.OcrEngineInstance.IsStarted) ? this.SvgImagesRecognitionMode : DocumentConverterSvgImagesRecognitionMode.Disabled;
         converter.Options.EmptyPageMode = this.EmptyPageMode;
         converter.Options.UseThreads = this.UseThreads;
         converter.Diagnostics.EnableTrace = this.EnableTrace;

         // Set Redaction Options
         if (redactionOptions != null)
         {
            var documentRedactionOptions = new DocumentRedactionOptions();
            documentRedactionOptions.ConvertOptions = redactionOptions;
            if (document != null)
            {
               documentRedactionOptions.ViewOptions = document.Annotations.RedactionOptions.ViewOptions;
               document.Annotations.RedactionOptions = documentRedactionOptions;
            }
            else
            {
               converter.LoadDocumentOptions.RedactionOptions = documentRedactionOptions;
            }
         }
      }

      private void ShowInfo(LEADDocument document)
      {
         Console.WriteLine("-----------------------");

         if (document == null)
         {
            Console.WriteLine("  InputDocumentFileName: " + InputDocumentFileName);
         }
         else
         {
            Console.WriteLine("  InputDocument: " + document.DocumentId);
            string documentPath;
            var documentUri = document.Uri;
            if (documentUri != null)
            {
               if (documentUri.IsFile)
                  documentPath = documentUri.LocalPath;
               else
                  documentPath = documentUri.ToString();
            }
            else
            {
               documentPath = "Virtual";
            }
            Console.WriteLine("  InputDocumentPath: " + documentPath);
         }

         Console.WriteLine("  InputDocumentPageCount: " + InputDocumentPageCount);
         Console.WriteLine("  InputFirstPage: " + InputFirstPage);
         Console.WriteLine("  InputLastPage: " + InputLastPage);

         if (document == null)
         {
            Console.WriteLine("  InputAnnotationsFileName: " + InputAnnotationsFileName);
            Console.WriteLine("  LoadEmbeddedAnnotation: " + LoadEmbeddedAnnotation);
         }

         Console.WriteLine("  DocumentFormat: " + DocumentFormat);
         Console.WriteLine("  RasterImageFormat: " + RasterImageFormat);
         Console.WriteLine("  RasterImageBitsPerPixel: " + RasterImageBitsPerPixel);
         Console.WriteLine("  OutputDocumentFileName: " + OutputDocumentFileName);
         Console.WriteLine("  OutputAnnotationsFileName: " + OutputAnnotationsFileName);
         Console.WriteLine("  OutputAnnotationsMode: " + OutputAnnotationsMode);
         Console.WriteLine("  EnableSvgConversion: " + EnableSvgConversion);
         Console.WriteLine("  SvgImagesRecognitionMode: " + SvgImagesRecognitionMode);
         Console.WriteLine("  EmptyPageMode: " + EmptyPageMode);
         Console.WriteLine("  UseThreads: " + UseThreads);
         Console.WriteLine("  PreprocessingDeskew: " + PreprocessingDeskew);
         Console.WriteLine("  PreprocessingInvert: " + PreprocessingInvert);
         Console.WriteLine("  PreprocessingOrient: " + PreprocessingOrient);
         Console.WriteLine("  ErrorMode: " + ErrorMode);
         Console.WriteLine("  EnableTrace: " + EnableTrace);
         Console.WriteLine("  JobName: " + JobName);
         Console.WriteLine("  OpenOutputDocument: " + OpenOutputDocument);
      }

      private void ViewOutputFile(DocumentConverterJob job)
      {
         if (job.Status == DocumentConverterJobStatus.Aborted || !this.OpenOutputDocument || job.JobData.DocumentFormat == DocumentFormat.Ltd)
            return;

         try
         {
            if (File.Exists(job.JobData.OutputDocumentFileName))
            {
               Process.Start(job.JobData.OutputDocumentFileName);
            }
            else
            {
               // Might be multiple files, try the directory
               var outputDocumentDir = Path.GetDirectoryName(job.JobData.OutputDocumentFileName);
               if (Directory.Exists(outputDocumentDir))
                  Process.Start(outputDocumentDir);
            }
         }
         catch (Exception ex)
         {
            this.ErrorMessage = ex.Message;
            throw;
         }
      }

      private static void DeleteAllFiles(IList<string> files)
      {
         if (files == null)
            return;

         foreach (var file in files)
         {
            if (File.Exists(file))
            {
               try
               {
                  File.Delete(file);
               }
               catch { }
            }
         }
      }
   }
}
