#pragma warning disable WFO3002

namespace WinForms;

partial class Form1
{
    private System.ComponentModel.IContainer components = null!;
    private TableLayoutPanel mainLayoutPanel = null!;
    private Panel headerPanel = null!;
    private Label titleLabel = null!;
    private GroupBox sourceGroupBox = null!;
    private TableLayoutPanel sourceLayoutPanel = null!;
    private Label sourceLabel = null!;
    private TextBox sourceTextBox = null!;
    private Button browseButton = null!;
    private GroupBox optionsGroupBox = null!;
    private TableLayoutPanel optionsLayoutPanel = null!;
    private CheckBox compressImagesCheckBox = null!;
    private Panel imageOptionsPanel = null!;
    private TableLayoutPanel imageOptionsLayoutPanel = null!;
    private Label imageQualityLabel = null!;
    private NumericUpDown imageQualityNumericUpDown = null!;
    private CheckBox enableJpeg2000CheckBox = null!;
    private CheckBox downsampleImagesCheckBox = null!;
    private Label targetDpiLabel = null!;
    private NumericUpDown targetDpiNumericUpDown = null!;
    private Label algorithmLabel = null!;
    private ComboBox algorithmComboBox = null!;
    private CheckBox optimizeFontsCheckBox = null!;
    private CheckBox optimizePageContentsCheckBox = null!;
    private CheckBox removeMetadataCheckBox = null!;
    private FlowLayoutPanel actionPanel = null!;
    private Button compressButton = null!;
    private Label statusLabel = null!;
    private GroupBox resultGroupBox = null!;
    private TableLayoutPanel resultLayoutPanel = null!;
    private Label originalSizeLabel = null!;
    private Label originalSizeValueLabel = null!;
    private Label compressedSizeLabel = null!;
    private Label compressedSizeValueLabel = null!;
    private OpenFileDialog openFileDialog = null!;
    private SaveFileDialog saveFileDialog = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        mainLayoutPanel = new TableLayoutPanel();
        headerPanel = new Panel();
        titleLabel = new Label();
        sourceGroupBox = new GroupBox();
        sourceLayoutPanel = new TableLayoutPanel();
        sourceLabel = new Label();
        sourceTextBox = new TextBox();
        browseButton = new Button();
        optionsGroupBox = new GroupBox();
        optionsLayoutPanel = new TableLayoutPanel();
        compressImagesCheckBox = new CheckBox();
        imageOptionsPanel = new Panel();
        imageOptionsLayoutPanel = new TableLayoutPanel();
        imageQualityLabel = new Label();
        imageQualityNumericUpDown = new NumericUpDown();
        enableJpeg2000CheckBox = new CheckBox();
        downsampleImagesCheckBox = new CheckBox();
        targetDpiLabel = new Label();
        targetDpiNumericUpDown = new NumericUpDown();
        algorithmLabel = new Label();
        algorithmComboBox = new ComboBox();
        optimizeFontsCheckBox = new CheckBox();
        optimizePageContentsCheckBox = new CheckBox();
        removeMetadataCheckBox = new CheckBox();
        actionPanel = new FlowLayoutPanel();
        compressButton = new Button();
        statusLabel = new Label();
        resultGroupBox = new GroupBox();
        resultLayoutPanel = new TableLayoutPanel();
        originalSizeLabel = new Label();
        originalSizeValueLabel = new Label();
        compressedSizeLabel = new Label();
        compressedSizeValueLabel = new Label();
        openFileDialog = new OpenFileDialog();
        saveFileDialog = new SaveFileDialog();
        ((System.ComponentModel.ISupportInitialize)imageQualityNumericUpDown).BeginInit();
        ((System.ComponentModel.ISupportInitialize)targetDpiNumericUpDown).BeginInit();
        SuspendLayout();
        // 
        // mainLayoutPanel
        // 
        mainLayoutPanel.ColumnCount = 1;
        mainLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        mainLayoutPanel.Controls.Add(headerPanel, 0, 0);
        mainLayoutPanel.Controls.Add(sourceGroupBox, 0, 1);
        mainLayoutPanel.Controls.Add(optionsGroupBox, 0, 2);
        mainLayoutPanel.Controls.Add(actionPanel, 0, 3);
        mainLayoutPanel.Controls.Add(resultGroupBox, 0, 4);
        mainLayoutPanel.Dock = DockStyle.Fill;
        mainLayoutPanel.Location = new Point(0, 0);
        mainLayoutPanel.Margin = new Padding(0);
        mainLayoutPanel.Name = "mainLayoutPanel";
        mainLayoutPanel.RowCount = 5;
        mainLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
        mainLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
        mainLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 336F));
        mainLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
        mainLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
        mainLayoutPanel.Size = new Size(860, 598);
        mainLayoutPanel.TabIndex = 0;
        // 
        // headerPanel
        // 
        headerPanel.BackColor = Color.White;
        headerPanel.Controls.Add(titleLabel);
        headerPanel.Dock = DockStyle.Fill;
        headerPanel.Location = new Point(10, 10);
        headerPanel.Margin = new Padding(10, 10, 10, 6);
        headerPanel.Name = "headerPanel";
        headerPanel.Padding = new Padding(14, 10, 14, 8);
        headerPanel.Size = new Size(840, 44);
        headerPanel.TabIndex = 0;
        // 
        // titleLabel
        // 
        titleLabel.AutoSize = true;
        titleLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
        titleLabel.ForeColor = Color.FromArgb(32, 39, 52);
        titleLabel.Location = new Point(14, 6);
        titleLabel.Name = "titleLabel";
        titleLabel.Size = new Size(201, 25);
        titleLabel.TabIndex = 0;
        titleLabel.Text = "Compress Existing PDF";
        // 
        // sourceGroupBox
        // 
        sourceGroupBox.BackColor = Color.White;
        sourceGroupBox.Controls.Add(sourceLayoutPanel);
        sourceGroupBox.Dock = DockStyle.Fill;
        sourceGroupBox.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
        sourceGroupBox.ForeColor = Color.FromArgb(32, 39, 52);
        sourceGroupBox.Location = new Point(10, 72);
        sourceGroupBox.Margin = new Padding(10, 0, 10, 6);
        sourceGroupBox.Name = "sourceGroupBox";
        sourceGroupBox.Padding = new Padding(10, 6, 10, 8);
        sourceGroupBox.Size = new Size(840, 68);
        sourceGroupBox.TabIndex = 1;
        sourceGroupBox.TabStop = false;
        sourceGroupBox.Text = "Source PDF";
        // 
        // sourceLayoutPanel
        // 
        sourceLayoutPanel.ColumnCount = 3;
        sourceLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 92F));
        sourceLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        sourceLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 92F));
        sourceLayoutPanel.Controls.Add(sourceLabel, 0, 0);
        sourceLayoutPanel.Controls.Add(sourceTextBox, 1, 0);
        sourceLayoutPanel.Controls.Add(browseButton, 2, 0);
        sourceLayoutPanel.Dock = DockStyle.Fill;
        sourceLayoutPanel.Location = new Point(10, 26);
        sourceLayoutPanel.Margin = new Padding(0);
        sourceLayoutPanel.Name = "sourceLayoutPanel";
        sourceLayoutPanel.RowCount = 1;
        sourceLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        sourceLayoutPanel.Size = new Size(820, 34);
        sourceLayoutPanel.TabIndex = 0;
        // 
        // sourceLabel
        // 
        sourceLabel.Anchor = AnchorStyles.Left;
        sourceLabel.AutoSize = true;
        sourceLabel.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
        sourceLabel.ForeColor = Color.FromArgb(64, 72, 88);
        sourceLabel.Location = new Point(3, 8);
        sourceLabel.Name = "sourceLabel";
        sourceLabel.Size = new Size(67, 17);
        sourceLabel.TabIndex = 0;
        sourceLabel.Text = "Source PDF";
        // 
        // sourceTextBox
        // 
        sourceTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        sourceTextBox.BackColor = Color.White;
        sourceTextBox.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
        sourceTextBox.Location = new Point(95, 4);
        sourceTextBox.Margin = new Padding(3, 0, 8, 0);
        sourceTextBox.Name = "sourceTextBox";
        sourceTextBox.ReadOnly = true;
        sourceTextBox.Size = new Size(622, 24);
        sourceTextBox.TabIndex = 1;
        // 
        // browseButton
        // 
        browseButton.Anchor = AnchorStyles.Right;
        browseButton.BackColor = Color.FromArgb(0, 120, 215);
        browseButton.FlatStyle = FlatStyle.Flat;
        browseButton.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
        browseButton.ForeColor = Color.White;
        browseButton.Location = new Point(737, 2);
        browseButton.Name = "browseButton";
        browseButton.Size = new Size(80, 30);
        browseButton.TabIndex = 2;
        browseButton.Text = "Browse";
        browseButton.UseVisualStyleBackColor = false;
        browseButton.Click += BrowseButton_Click;
        // 
        // optionsGroupBox
        // 
        optionsGroupBox.BackColor = Color.White;
        optionsGroupBox.Controls.Add(optionsLayoutPanel);
        optionsGroupBox.Dock = DockStyle.Fill;
        optionsGroupBox.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
        optionsGroupBox.ForeColor = Color.FromArgb(32, 39, 52);
        optionsGroupBox.Location = new Point(10, 146);
        optionsGroupBox.Margin = new Padding(10, 0, 10, 6);
        optionsGroupBox.Name = "optionsGroupBox";
        optionsGroupBox.Padding = new Padding(10, 6, 10, 8);
        optionsGroupBox.Size = new Size(840, 324);
        optionsGroupBox.TabIndex = 2;
        optionsGroupBox.TabStop = false;
        optionsGroupBox.Text = "Compression Options";
        // 
        // optionsLayoutPanel
        // 
        optionsLayoutPanel.ColumnCount = 2;
        optionsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 210F));
        optionsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        optionsLayoutPanel.Controls.Add(compressImagesCheckBox, 0, 0);
        optionsLayoutPanel.Controls.Add(imageOptionsPanel, 0, 1);
        optionsLayoutPanel.Controls.Add(optimizeFontsCheckBox, 0, 2);
        optionsLayoutPanel.Controls.Add(optimizePageContentsCheckBox, 0, 3);
        optionsLayoutPanel.Controls.Add(removeMetadataCheckBox, 0, 4);
        optionsLayoutPanel.Dock = DockStyle.Fill;
        optionsLayoutPanel.Location = new Point(10, 26);
        optionsLayoutPanel.Margin = new Padding(0);
        optionsLayoutPanel.Name = "optionsLayoutPanel";
        optionsLayoutPanel.RowCount = 5;
        optionsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
        optionsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 186F));
        optionsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
        optionsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
        optionsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
        optionsLayoutPanel.Size = new Size(820, 258);
        optionsLayoutPanel.TabIndex = 0;
        // 
        // compressImagesCheckBox
        // 
        compressImagesCheckBox.AutoSize = true;
        optionsLayoutPanel.SetColumnSpan(compressImagesCheckBox, 2);
        compressImagesCheckBox.Dock = DockStyle.Fill;
        compressImagesCheckBox.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        compressImagesCheckBox.Location = new Point(3, 3);
        compressImagesCheckBox.Margin = new Padding(3, 0, 3, 0);
        compressImagesCheckBox.Name = "compressImagesCheckBox";
        compressImagesCheckBox.Size = new Size(814, 25);
        compressImagesCheckBox.TabIndex = 0;
        compressImagesCheckBox.Text = "Compress Images";
        compressImagesCheckBox.UseVisualStyleBackColor = true;
        compressImagesCheckBox.CheckedChanged += CompressImagesCheckBox_CheckedChanged;
        // 
        // imageOptionsPanel
        // 
        imageOptionsPanel.BackColor = Color.FromArgb(248, 250, 252);
        optionsLayoutPanel.SetColumnSpan(imageOptionsPanel, 2);
        imageOptionsPanel.Controls.Add(imageOptionsLayoutPanel);
        imageOptionsPanel.Dock = DockStyle.Fill;
        imageOptionsPanel.Location = new Point(22, 31);
        imageOptionsPanel.Margin = new Padding(22, 0, 0, 0);
        imageOptionsPanel.Name = "imageOptionsPanel";
        imageOptionsPanel.Padding = new Padding(12, 10, 12, 10);
        imageOptionsPanel.Size = new Size(798, 186);
        imageOptionsPanel.TabIndex = 1;
        // 
        // imageOptionsLayoutPanel
        // 
        imageOptionsLayoutPanel.ColumnCount = 2;
        imageOptionsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 170F));
        imageOptionsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        imageOptionsLayoutPanel.Controls.Add(imageQualityLabel, 0, 0);
        imageOptionsLayoutPanel.Controls.Add(imageQualityNumericUpDown, 1, 0);
        imageOptionsLayoutPanel.Controls.Add(enableJpeg2000CheckBox, 0, 1);
        imageOptionsLayoutPanel.Controls.Add(downsampleImagesCheckBox, 0, 2);
        imageOptionsLayoutPanel.Controls.Add(targetDpiLabel, 0, 3);
        imageOptionsLayoutPanel.Controls.Add(targetDpiNumericUpDown, 1, 3);
        imageOptionsLayoutPanel.Controls.Add(algorithmLabel, 0, 4);
        imageOptionsLayoutPanel.Controls.Add(algorithmComboBox, 1, 4);
        imageOptionsLayoutPanel.Dock = DockStyle.Fill;
        imageOptionsLayoutPanel.Location = new Point(12, 10);
        imageOptionsLayoutPanel.Margin = new Padding(0);
        imageOptionsLayoutPanel.Name = "imageOptionsLayoutPanel";
        imageOptionsLayoutPanel.RowCount = 5;
        imageOptionsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
        imageOptionsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        imageOptionsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        imageOptionsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
        imageOptionsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
        imageOptionsLayoutPanel.Size = new Size(774, 166);
        imageOptionsLayoutPanel.TabIndex = 0;
        // 
        // imageQualityLabel
        // 
        imageQualityLabel.Anchor = AnchorStyles.Left;
        imageQualityLabel.AutoSize = true;
        imageQualityLabel.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
        imageQualityLabel.ForeColor = Color.FromArgb(64, 72, 88);
        imageQualityLabel.Location = new Point(18, 7);
        imageQualityLabel.Margin = new Padding(18, 0, 3, 0);
        imageQualityLabel.Name = "imageQualityLabel";
        imageQualityLabel.Size = new Size(84, 17);
        imageQualityLabel.TabIndex = 0;
        imageQualityLabel.Text = "Image Quality";
        // 
        // imageQualityNumericUpDown
        // 
        imageQualityNumericUpDown.Anchor = AnchorStyles.Left;
        imageQualityNumericUpDown.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
        imageQualityNumericUpDown.Location = new Point(173, 3);
        imageQualityNumericUpDown.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
        imageQualityNumericUpDown.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
        imageQualityNumericUpDown.Name = "imageQualityNumericUpDown";
        imageQualityNumericUpDown.Size = new Size(104, 24);
        imageQualityNumericUpDown.TabIndex = 1;
        imageQualityNumericUpDown.TextAlign = HorizontalAlignment.Right;
        imageQualityNumericUpDown.Value = new decimal(new int[] { 50, 0, 0, 0 });
        // 
        // enableJpeg2000CheckBox
        // 
        enableJpeg2000CheckBox.AutoSize = true;
        optionsLayoutPanel.SetColumnSpan(enableJpeg2000CheckBox, 2);
        enableJpeg2000CheckBox.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
        enableJpeg2000CheckBox.Location = new Point(17, 37);
        enableJpeg2000CheckBox.Margin = new Padding(17, 0, 3, 0);
        enableJpeg2000CheckBox.Name = "enableJpeg2000CheckBox";
        enableJpeg2000CheckBox.Size = new Size(184, 24);
        enableJpeg2000CheckBox.TabIndex = 2;
        enableJpeg2000CheckBox.Text = "Enable JPEG2000 Encoding";
        enableJpeg2000CheckBox.UseVisualStyleBackColor = true;
        // 
        // downsampleImagesCheckBox
        // 
        downsampleImagesCheckBox.AutoSize = true;
        optionsLayoutPanel.SetColumnSpan(downsampleImagesCheckBox, 2);
        downsampleImagesCheckBox.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
        downsampleImagesCheckBox.Location = new Point(17, 67);
        downsampleImagesCheckBox.Margin = new Padding(17, 0, 3, 0);
        downsampleImagesCheckBox.Name = "downsampleImagesCheckBox";
        downsampleImagesCheckBox.Size = new Size(167, 24);
        downsampleImagesCheckBox.TabIndex = 3;
        downsampleImagesCheckBox.Text = "Downsample Images";
        downsampleImagesCheckBox.UseVisualStyleBackColor = true;
        downsampleImagesCheckBox.CheckedChanged += DownsampleImagesCheckBox_CheckedChanged;
        // 
        // targetDpiLabel
        // 
        targetDpiLabel.Anchor = AnchorStyles.Left;
        targetDpiLabel.AutoSize = true;
        targetDpiLabel.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
        targetDpiLabel.ForeColor = Color.FromArgb(64, 72, 88);
        targetDpiLabel.Location = new Point(18, 103);
        targetDpiLabel.Margin = new Padding(18, 0, 3, 0);
        targetDpiLabel.Name = "targetDpiLabel";
        targetDpiLabel.Size = new Size(65, 17);
        targetDpiLabel.TabIndex = 4;
        targetDpiLabel.Text = "Target DPI";
        // 
        // targetDpiNumericUpDown
        // 
        targetDpiNumericUpDown.Anchor = AnchorStyles.Left;
        targetDpiNumericUpDown.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
        targetDpiNumericUpDown.Location = new Point(173, 99);
        targetDpiNumericUpDown.Maximum = new decimal(new int[] { 2400, 0, 0, 0 });
        targetDpiNumericUpDown.Minimum = new decimal(new int[] { 36, 0, 0, 0 });
        targetDpiNumericUpDown.Name = "targetDpiNumericUpDown";
        targetDpiNumericUpDown.Size = new Size(104, 24);
        targetDpiNumericUpDown.TabIndex = 5;
        targetDpiNumericUpDown.TextAlign = HorizontalAlignment.Right;
        targetDpiNumericUpDown.Value = new decimal(new int[] { 150, 0, 0, 0 });
        // 
        // algorithmLabel
        // 
        algorithmLabel.Anchor = AnchorStyles.Left;
        algorithmLabel.AutoSize = true;
        algorithmLabel.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
        algorithmLabel.ForeColor = Color.FromArgb(64, 72, 88);
        algorithmLabel.Location = new Point(18, 135);
        algorithmLabel.Margin = new Padding(18, 0, 3, 0);
        algorithmLabel.Name = "algorithmLabel";
        algorithmLabel.Size = new Size(132, 17);
        algorithmLabel.TabIndex = 6;
        algorithmLabel.Text = "Downsample Algorithm";
        // 
        // algorithmComboBox
        // 
        algorithmComboBox.Anchor = AnchorStyles.Left;
        algorithmComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        algorithmComboBox.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
        algorithmComboBox.FormattingEnabled = true;
        algorithmComboBox.Items.AddRange(new object[] { "Bicubic", "Bilinear", "NearestNeighbor" });
        algorithmComboBox.Location = new Point(173, 130);
        algorithmComboBox.Name = "algorithmComboBox";
        algorithmComboBox.Size = new Size(150, 25);
        algorithmComboBox.TabIndex = 7;
        // 
        // optimizeFontsCheckBox
        // 
        optimizeFontsCheckBox.AutoSize = true;
        optimizeFontsCheckBox.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
        optimizeFontsCheckBox.Location = new Point(3, 221);
        optimizeFontsCheckBox.Margin = new Padding(3, 0, 3, 0);
        optimizeFontsCheckBox.Name = "optimizeFontsCheckBox";
        optimizeFontsCheckBox.Size = new Size(120, 22);
        optimizeFontsCheckBox.TabIndex = 2;
        optimizeFontsCheckBox.Text = "Optimize Fonts";
        optimizeFontsCheckBox.UseVisualStyleBackColor = true;
        // 
        // optimizePageContentsCheckBox
        // 
        optimizePageContentsCheckBox.AutoSize = true;
        optimizePageContentsCheckBox.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
        optimizePageContentsCheckBox.Location = new Point(3, 249);
        optimizePageContentsCheckBox.Margin = new Padding(3, 0, 3, 0);
        optimizePageContentsCheckBox.Name = "optimizePageContentsCheckBox";
        optimizePageContentsCheckBox.Size = new Size(176, 22);
        optimizePageContentsCheckBox.TabIndex = 3;
        optimizePageContentsCheckBox.Text = "Optimize Page Contents";
        optimizePageContentsCheckBox.UseVisualStyleBackColor = true;
        // 
        // removeMetadataCheckBox
        // 
        removeMetadataCheckBox.AutoSize = true;
        removeMetadataCheckBox.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
        removeMetadataCheckBox.Location = new Point(3, 277);
        removeMetadataCheckBox.Margin = new Padding(3, 0, 3, 0);
        removeMetadataCheckBox.Name = "removeMetadataCheckBox";
        removeMetadataCheckBox.Size = new Size(140, 22);
        removeMetadataCheckBox.TabIndex = 4;
        removeMetadataCheckBox.Text = "Remove Metadata";
        removeMetadataCheckBox.UseVisualStyleBackColor = true;
        // 
        // actionPanel
        // 
        actionPanel.Controls.Add(compressButton);
        actionPanel.Controls.Add(statusLabel);
        actionPanel.Dock = DockStyle.Fill;
        actionPanel.FlowDirection = FlowDirection.LeftToRight;
        actionPanel.Location = new Point(10, 438);
        actionPanel.Margin = new Padding(10, 0, 10, 2);
        actionPanel.Name = "actionPanel";
        actionPanel.Padding = new Padding(0);
        actionPanel.Size = new Size(840, 46);
        actionPanel.TabIndex = 3;
        actionPanel.WrapContents = false;
        // 
        // compressButton
        // 
        compressButton.BackColor = Color.FromArgb(0, 120, 215);
        compressButton.FlatStyle = FlatStyle.Flat;
        compressButton.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
        compressButton.ForeColor = Color.White;
        compressButton.Location = new Point(0, 4);
        compressButton.Name = "compressButton";
        compressButton.Size = new Size(118, 32);
        compressButton.TabIndex = 0;
        compressButton.Text = "Compress PDF";
        compressButton.UseVisualStyleBackColor = false;
        compressButton.Click += CompressButton_Click;
        // 
        // statusLabel
        // 
        statusLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        statusLabel.AutoEllipsis = true;
        statusLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
        statusLabel.ForeColor = Color.FromArgb(91, 104, 126);
        statusLabel.Location = new Point(124, 10);
        statusLabel.Margin = new Padding(6, 0, 0, 0);
        statusLabel.Name = "statusLabel";
        statusLabel.Size = new Size(716, 20);
        statusLabel.TabIndex = 1;
        statusLabel.Text = "Select a PDF to begin.";
        statusLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // resultGroupBox
        // 
        resultGroupBox.BackColor = Color.White;
        resultGroupBox.Controls.Add(resultLayoutPanel);
        resultGroupBox.Dock = DockStyle.Fill;
        resultGroupBox.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
        resultGroupBox.ForeColor = Color.FromArgb(32, 39, 52);
        resultGroupBox.Location = new Point(10, 510);
        resultGroupBox.Margin = new Padding(10, 0, 10, 10);
        resultGroupBox.Name = "resultGroupBox";
        resultGroupBox.Padding = new Padding(10, 6, 10, 8);
        resultGroupBox.Size = new Size(840, 70);
        resultGroupBox.TabIndex = 4;
        resultGroupBox.TabStop = false;
        resultGroupBox.Text = "Result";
        // 
        // resultLayoutPanel
        // 
        resultLayoutPanel.ColumnCount = 2;
        resultLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 160F));
        resultLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        resultLayoutPanel.Controls.Add(originalSizeLabel, 0, 0);
        resultLayoutPanel.Controls.Add(originalSizeValueLabel, 1, 0);
        resultLayoutPanel.Controls.Add(compressedSizeLabel, 0, 1);
        resultLayoutPanel.Controls.Add(compressedSizeValueLabel, 1, 1);
        resultLayoutPanel.Dock = DockStyle.Fill;
        resultLayoutPanel.Location = new Point(10, 26);
        resultLayoutPanel.Margin = new Padding(0);
        resultLayoutPanel.Name = "resultLayoutPanel";
        resultLayoutPanel.RowCount = 2;
        resultLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
        resultLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
        resultLayoutPanel.Size = new Size(820, 44);
        resultLayoutPanel.TabIndex = 0;
        // 
        // originalSizeLabel
        // 
        originalSizeLabel.Anchor = AnchorStyles.Left;
        originalSizeLabel.AutoSize = true;
        originalSizeLabel.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
        originalSizeLabel.ForeColor = Color.FromArgb(64, 72, 88);
        originalSizeLabel.Location = new Point(3, 2);
        originalSizeLabel.Name = "originalSizeLabel";
        originalSizeLabel.Size = new Size(78, 17);
        originalSizeLabel.TabIndex = 0;
        originalSizeLabel.Text = "Original Size :";
        // 
        // originalSizeValueLabel
        // 
        originalSizeValueLabel.Anchor = AnchorStyles.Left;
        originalSizeValueLabel.AutoSize = true;
        originalSizeValueLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        originalSizeValueLabel.ForeColor = Color.FromArgb(32, 39, 52);
        originalSizeValueLabel.Location = new Point(163, 1);
        originalSizeValueLabel.Name = "originalSizeValueLabel";
        originalSizeValueLabel.Size = new Size(17, 19);
        originalSizeValueLabel.TabIndex = 1;
        originalSizeValueLabel.Text = "—";
        // 
        // compressedSizeLabel
        // 
        compressedSizeLabel.Anchor = AnchorStyles.Left;
        compressedSizeLabel.AutoSize = true;
        compressedSizeLabel.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
        compressedSizeLabel.ForeColor = Color.FromArgb(64, 72, 88);
        compressedSizeLabel.Location = new Point(3, 24);
        compressedSizeLabel.Name = "compressedSizeLabel";
        compressedSizeLabel.Size = new Size(102, 17);
        compressedSizeLabel.TabIndex = 2;
        compressedSizeLabel.Text = "Compressed Size :";
        // 
        // compressedSizeValueLabel
        // 
        compressedSizeValueLabel.Anchor = AnchorStyles.Left;
        compressedSizeValueLabel.AutoSize = true;
        compressedSizeValueLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        compressedSizeValueLabel.ForeColor = Color.FromArgb(32, 39, 52);
        compressedSizeValueLabel.Location = new Point(163, 23);
        compressedSizeValueLabel.Name = "compressedSizeValueLabel";
        compressedSizeValueLabel.Size = new Size(17, 19);
        compressedSizeValueLabel.TabIndex = 3;
        compressedSizeValueLabel.Text = "—";
        // 
        // openFileDialog
        // 
        openFileDialog.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
        openFileDialog.Title = "Select a PDF file";
        // 
        // saveFileDialog
        // 
        saveFileDialog.DefaultExt = "pdf";
        saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
        saveFileDialog.Title = "Save compressed PDF";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(245, 247, 250);
        ClientSize = new Size(860, 598);
        Controls.Add(mainLayoutPanel);
        Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
        MinimumSize = new Size(876, 637);
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Compress Existing PDF";
        ((System.ComponentModel.ISupportInitialize)imageQualityNumericUpDown).EndInit();
        ((System.ComponentModel.ISupportInitialize)targetDpiNumericUpDown).EndInit();
        ResumeLayout(false);
    }
}

#pragma warning restore WFO3002
