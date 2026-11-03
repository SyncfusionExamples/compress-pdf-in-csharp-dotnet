using Syncfusion.Pdf;
using Syncfusion.Pdf.Parsing;

namespace WinForms;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        ConfigureDefaults();
        UpdateOptionAvailability();
    }

    private void ConfigureDefaults()
    {
        compressImagesCheckBox.Checked = true;
        enableJpeg2000CheckBox.Checked = true;
        downsampleImagesCheckBox.Checked = true;
        optimizeFontsCheckBox.Checked = true;
        optimizePageContentsCheckBox.Checked = true;
        removeMetadataCheckBox.Checked = true;
        algorithmComboBox.SelectedIndex = 0;
        imageQualityNumericUpDown.Value = 50;
        targetDpiNumericUpDown.Value = 150;
    }

    private void BrowseButton_Click(object? sender, EventArgs e)
    {
        if (openFileDialog.ShowDialog(this) != DialogResult.OK)
        {
            return;
        }

        sourceTextBox.Text = openFileDialog.FileName;
        statusLabel.Text = "PDF selected. Review the compression options and click Compress PDF.";
    }

    private void CompressImagesCheckBox_CheckedChanged(object? sender, EventArgs e)
    {
        UpdateOptionAvailability();
    }

    private void DownsampleImagesCheckBox_CheckedChanged(object? sender, EventArgs e)
    {
        UpdateOptionAvailability();
    }

    private void UpdateOptionAvailability()
    {
        var compressImages = compressImagesCheckBox.Checked;
        imageOptionsPanel.Enabled = compressImages;
        downsampleImagesCheckBox.Enabled = compressImages;

        var downsampleImages = compressImages && downsampleImagesCheckBox.Checked;
        targetDpiLabel.Enabled = downsampleImages;
        targetDpiNumericUpDown.Enabled = downsampleImages;
        algorithmLabel.Enabled = downsampleImages;
        algorithmComboBox.Enabled = downsampleImages;
    }

    private void CompressButton_Click(object? sender, EventArgs e)
    {
        var inputFile = sourceTextBox.Text.Trim();
        if (string.IsNullOrWhiteSpace(inputFile) || !File.Exists(inputFile))
        {
            MessageBox.Show(this, "Please select a valid PDF file first.", "Compress PDF", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        var defaultOutputName = Path.GetFileNameWithoutExtension(inputFile) + "_compressed.pdf";
        saveFileDialog.FileName = defaultOutputName;
        saveFileDialog.InitialDirectory = Path.GetDirectoryName(inputFile);

        if (saveFileDialog.ShowDialog(this) != DialogResult.OK)
        {
            return;
        }

        var outputFile = saveFileDialog.FileName;
        var originalSize = new FileInfo(inputFile).Length;

        try
        {
            using (PdfLoadedDocument loadedDocument = new PdfLoadedDocument(File.OpenRead(inputFile)))
            {
                PdfCompressionOptions options = new PdfCompressionOptions
                {
                    CompressImages = compressImagesCheckBox.Checked,
                    ImageQuality = Clamp((int)imageQualityNumericUpDown.Value, 10, 100),
                    EnableJpxDecode = compressImagesCheckBox.Checked && enableJpeg2000CheckBox.Checked,
                    DownsampleImages = compressImagesCheckBox.Checked && downsampleImagesCheckBox.Checked,
                    TargetDpi = Clamp((int)targetDpiNumericUpDown.Value, 36, 2400),
                    DownsampleAlgorithm = Enum.TryParse<DownsamplingAlgorithm>(algorithmComboBox.SelectedItem?.ToString(), true, out var algo)
                        ? algo
                        : DownsamplingAlgorithm.Bicubic,
                    OptimizeFont = optimizeFontsCheckBox.Checked,
                    OptimizePageContents = optimizePageContentsCheckBox.Checked,
                    RemoveMetadata = removeMetadataCheckBox.Checked
                };

                loadedDocument.CompressionOptions = options;

                using MemoryStream ms = new MemoryStream();
                loadedDocument.Save(ms);

                ms.Position = 0;
                loadedDocument.Close(true);

                using FileStream outputStream = File.Create(outputFile);
                ms.CopyTo(outputStream);
            }

            var compressedSize = new FileInfo(outputFile).Length;
            originalSizeValueLabel.Text = FormatSize(originalSize);
            compressedSizeValueLabel.Text = FormatSize(compressedSize);
            statusLabel.Text = $"Compressed PDF saved to {outputFile}.";
        }
        catch (Exception ex)
        {
            MessageBox.Show(this, $"Compression failed.\n\n{ex.Message}", "Compress PDF", MessageBoxButtons.OK, MessageBoxIcon.Error);
            statusLabel.Text = "Compression failed. Please review the source PDF and try again.";
        }
    }

    private static int Clamp(int value, int min, int max)
    {
        if (value < min)
        {
            return min;
        }

        if (value > max)
        {
            return max;
        }

        return value;
    }

    private static string FormatSize(long bytes)
    {
        return $"{bytes / 1024d / 1024d:0.00} MB";
    }
}
