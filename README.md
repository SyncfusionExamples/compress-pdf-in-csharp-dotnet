# Compress PDF in C# and .NET

This repository contains a WinForms sample that compresses existing PDF documents with Syncfusion PDF.

The sample lets you reduce file size by:

- Shrinking images
- Optimizing fonts
- Removing metadata
- Optimizing page contents
- Using JPEG2000 encoding
- Downsampling images

## Sample

| Sample name | Description |
| --- | --- |
| WinForms PDF compression sample | Demonstrates how to open an existing PDF, apply compression options, and save a smaller copy. |

## Reducing PDF file size by shrinking images

Image compression is often the fastest way to reduce PDF size when the document contains large images.

When you enable image compression, you can also control how much the image quality is reduced. A lower image quality value usually creates a smaller file, but it can also reduce visual clarity.

You can also combine image compression with JPEG2000 encoding and downsampling. Downsampling lowers the image resolution before the file is saved. This helps reduce file size when the original images are much larger than they need to be for viewing or printing.

The sample exposes these image settings in the UI:

- Compress Images
- Image Quality
- Enable JPEG2000 Encoding
- Downsample Images
- Target DPI
- Downsample Algorithm

```csharp
PdfCompressionOptions options = new PdfCompressionOptions();
options.CompressImages = true;
options.ImageQuality = 50;
options.EnableJpxDecode = true;
options.DownsampleImages = true;
options.TargetDpi = 150;
options.DownsampleAlgorithm = DownsamplingAlgorithm.Bicubic;
```

## Reducing PDF file size by using JPEG2000 encoding

JPEG2000 encoding can help reduce the size of image-heavy PDFs when image compression is enabled.

```csharp
PdfCompressionOptions options = new PdfCompressionOptions();
options.CompressImages = true;
options.EnableJpxDecode = true;
```

## Reducing PDF file size by optimizing fonts

Optimizing fonts removes unused glyphs and unnecessary font data from embedded fonts.

```csharp
PdfCompressionOptions options = new PdfCompressionOptions();
options.OptimizeFont = true;
```

## Reducing PDF file size by optimizing page contents

Optimizing page contents removes extra spaces, converts end-of-line characters, and compresses uncompressed content streams.

```csharp
PdfCompressionOptions options = new PdfCompressionOptions();
options.OptimizePageContents = true;
```

## Reducing PDF file size by removing metadata

Removing metadata can reduce the size of PDF documents that contain document properties or embedded metadata.

```csharp
PdfCompressionOptions options = new PdfCompressionOptions();
options.RemoveMetadata = true;
```

## How to run the sample

- Open the `WinForms` folder.
- Build the project.
- Run the application with the framework you want to test.

```bash
dotnet run --framework net10.0-windows
dotnet run --framework net462
```

## Project targets

The WinForms sample targets:

- .NET Framework 4.6.2
- .NET 10.0 Windows

## User guide

For more information about compression options, see the [Syncfusion PDF compression guide](https://help.syncfusion.com/document-processing/pdf/pdf-library/net/working-with-compression).

## License

This is a commercial product and requires a paid license for use. Syncfusion licensed software is subject to the terms of the [Syncfusion EULA](https://www.syncfusion.com/eula/es/?utm_source=github&utm_medium=listing&utm_campaign=github-docio-examples). You can purchase a license [here](https://www.syncfusion.com/sales/products?utm_source=github&utm_medium=listing&utm_campaign=github-docio-examples) or start a free 30-day trial [here](https://www.syncfusion.com/account/manage-trials/start-trials?utm_source=github&utm_medium=listing&utm_campaign=github-docio-examples).
