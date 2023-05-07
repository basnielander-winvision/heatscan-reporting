namespace Heatscan.Report
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            GenerateReport = new Button();
            openHeatscanReport = new OpenFileDialog();
            openReportFrontPage = new OpenFileDialog();
            frontpageFilePath = new Label();
            heatscanReportFilePath = new Label();
            selectFrontPage = new Button();
            selectHeatscanReport = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            SaveReportAs = new Button();
            outputFilePath = new Label();
            saveOutputAs = new SaveFileDialog();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // GenerateReport
            // 
            GenerateReport.Dock = DockStyle.Fill;
            GenerateReport.Location = new Point(1675, 637);
            GenerateReport.Margin = new Padding(0);
            GenerateReport.Name = "GenerateReport";
            GenerateReport.Size = new Size(250, 75);
            GenerateReport.TabIndex = 0;
            GenerateReport.Text = "Rapport maken";
            GenerateReport.UseVisualStyleBackColor = true;
            GenerateReport.Click += GenerateReport_Click;
            // 
            // openHeatscanReport
            // 
            openHeatscanReport.DefaultExt = "*.pdf";
            openHeatscanReport.FileName = "heatscanReport";
            openHeatscanReport.Filter = "FLIR Rapport|*.pdf";
            openHeatscanReport.Title = "FLIR rapportage (.pdf)";
            // 
            // openReportFrontPage
            // 
            openReportFrontPage.DefaultExt = "*.docx";
            openReportFrontPage.FileName = "2023 Warmtescan rapportage - template.dotx";
            openReportFrontPage.Filter = "Word Voorblad|*.docx";
            // 
            // frontpageFilePath
            // 
            frontpageFilePath.AutoSize = true;
            frontpageFilePath.Dock = DockStyle.Fill;
            frontpageFilePath.Location = new Point(273, 30);
            frontpageFilePath.Margin = new Padding(3, 10, 3, 10);
            frontpageFilePath.Name = "frontpageFilePath";
            frontpageFilePath.Size = new Size(1399, 55);
            frontpageFilePath.TabIndex = 1;
            frontpageFilePath.Text = "Rapportage voorblad (.docx)";
            // 
            // heatscanReportFilePath
            // 
            heatscanReportFilePath.AutoSize = true;
            heatscanReportFilePath.Dock = DockStyle.Fill;
            heatscanReportFilePath.Location = new Point(273, 105);
            heatscanReportFilePath.Margin = new Padding(3, 10, 3, 10);
            heatscanReportFilePath.Name = "heatscanReportFilePath";
            heatscanReportFilePath.Size = new Size(1399, 55);
            heatscanReportFilePath.TabIndex = 2;
            heatscanReportFilePath.Text = "Warmtescan rapport (.pdf)";
            // 
            // selectFrontPage
            // 
            selectFrontPage.Dock = DockStyle.Fill;
            selectFrontPage.Location = new Point(23, 30);
            selectFrontPage.Margin = new Padding(3, 10, 3, 10);
            selectFrontPage.Name = "selectFrontPage";
            selectFrontPage.Size = new Size(244, 55);
            selectFrontPage.TabIndex = 3;
            selectFrontPage.Text = "Selecteer voorblad";
            selectFrontPage.UseVisualStyleBackColor = true;
            selectFrontPage.Click += selectFrontPage_Click;
            // 
            // selectHeatscanReport
            // 
            selectHeatscanReport.Dock = DockStyle.Fill;
            selectHeatscanReport.Location = new Point(23, 105);
            selectHeatscanReport.Margin = new Padding(3, 10, 3, 10);
            selectHeatscanReport.Name = "selectHeatscanReport";
            selectHeatscanReport.Size = new Size(244, 55);
            selectHeatscanReport.TabIndex = 4;
            selectHeatscanReport.Text = "Selecteer FLIR rapportage";
            selectHeatscanReport.UseVisualStyleBackColor = true;
            selectHeatscanReport.Click += selectHeatscanReport_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 250F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 250F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(selectHeatscanReport, 1, 2);
            tableLayoutPanel1.Controls.Add(heatscanReportFilePath, 2, 2);
            tableLayoutPanel1.Controls.Add(selectFrontPage, 1, 1);
            tableLayoutPanel1.Controls.Add(frontpageFilePath, 2, 1);
            tableLayoutPanel1.Controls.Add(GenerateReport, 3, 5);
            tableLayoutPanel1.Controls.Add(SaveReportAs, 1, 3);
            tableLayoutPanel1.Controls.Add(outputFilePath, 2, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1945, 732);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // SaveReportAs
            // 
            SaveReportAs.Dock = DockStyle.Fill;
            SaveReportAs.Location = new Point(23, 180);
            SaveReportAs.Margin = new Padding(3, 10, 3, 10);
            SaveReportAs.Name = "SaveReportAs";
            SaveReportAs.Size = new Size(244, 55);
            SaveReportAs.TabIndex = 5;
            SaveReportAs.Text = "Opslaan als";
            SaveReportAs.UseVisualStyleBackColor = true;
            SaveReportAs.Click += SaveReportAs_Click;
            // 
            // outputFilePath
            // 
            outputFilePath.AutoSize = true;
            outputFilePath.Dock = DockStyle.Fill;
            outputFilePath.Location = new Point(273, 180);
            outputFilePath.Margin = new Padding(3, 10, 3, 10);
            outputFilePath.Name = "outputFilePath";
            outputFilePath.Size = new Size(1399, 55);
            outputFilePath.TabIndex = 6;
            outputFilePath.Text = "Resultaat (voorblad en FLIR rapportage samengevoegd) (.pdf)";
            // 
            // saveOutputAs
            // 
            saveOutputAs.Filter = "Pdf|*.pdf";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1945, 732);
            Controls.Add(tableLayoutPanel1);
            Name = "MainForm";
            Text = "Warmtescan rapportage";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button GenerateReport;
        private OpenFileDialog openHeatscanReport;
        private OpenFileDialog openReportFrontPage;
        private Label frontpageFilePath;
        private Label heatscanReportFilePath;
        private Button selectFrontPage;
        private Button selectHeatscanReport;
        private TableLayoutPanel tableLayoutPanel1;
        private Button SaveReportAs;
        private Label outputFilePath;
        private SaveFileDialog saveOutputAs;
    }
}