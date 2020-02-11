# LEADTOOLS Document Viewer Demo for .NET Framework

This demo falls under the [license located here.](./LICENSE.md)

Powered by patented artificial intelligence and machine learning algorithms, [LEADTOOLS is a collection of award-winning document, medical, multimedia, and imaging SDKs](https://www.leadtools.com)

This.NET WinForms demo showcases the [LEADTOOLS Document Viewer SDK](https://www.leadtools.com/sdk/document/document-viewer-dotnet) and allows users to: 

- View document, vector, and raster formats in one viewer:
  - Adobe Acrobat PDF and PDF/A
  - Microsoft Office DOC/DOCX, XLS/XLSX, PPT/PPTX, PST, EML, MSG, and XPS formats
  - CAD formats such as DXF, DWG, and DWF
  - TIFF, JPEG, PNG, EXIF, BMP, and hundreds more raster image formats
  - Plain Text, RTF, HTML, MOBI, ePUB, and more
  - IBM AFP, MO:DCA, IOCA, and PTOCA
  - Automatically OCR raster images to document formats
- Load and save files from SharePoint™, OneDrive™, and Google Drive™
- View and edit complex document objects such as:
  - Annotations (LEAD proprietary, Adobe PDF, IBM FileNet P8, and IBM Daeja)
  - Hyperlinks
  - Unicode text, including Japanese, Chinese, Arabic, and Hebrew
  - Fonts and styles
  - Embedded images with compression
  - Table of Contents
  - Metadata
  - Bookmarks

With the Document Converter Demo, you can view raster and document formats. This makes it ideal for Enterprise Content Management (ECM), document retrieval, and document normalization development.

## Set Up

In order to use any LEADTOOLS functionality, you must have a valid license. You can obtain a fully functional 30-day license [from our website](https://www.leadtools.com/downloads).

Locate the `RasterSupport.SetLicense(licenseFilePath, developerKey);` line in the application and modify the code to point to use your new license and key.

Open the csproj file in Visual Studio.  Build the project to restore the [LEADTOOLS NuGet packages](https://www.leadtools.com/downloads/nuget).

## Use

To view documents with the Document Viewer Demo simply open the file you want to view in the file open menu. You can annotate the document using the toolbar on the right and export the anntoations via the Save dialog. 

## Resources

Website: <https://www.leadtools.com/>

Download Full Evaluation: <https://www.leadtools.com/downloads>

Documentation: <https://www.leadtools.com/help/leadtools/v20/dh/to/introduction.html>

Technical Support: <https://www.leadtools.com/support/chat>

[nuget-profile]: https://www.nuget.org/profiles/LEADTOOLS
