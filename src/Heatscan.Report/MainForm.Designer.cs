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
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // GenerateReport
            // 
            GenerateReport.Dock = DockStyle.Fill;
            GenerateReport.Location = new Point(1182, 640);
            GenerateReport.Margin = new Padding(30);
            GenerateReport.Name = "GenerateReport";
            GenerateReport.Size = new Size(223, 70);
            GenerateReport.TabIndex = 0;
            GenerateReport.Text = "Rapport maken";
            GenerateReport.UseVisualStyleBackColor = true;
            GenerateReport.Click += GenerateReport_Click;
            // 
            // openHeatscanReport
            // 
            openHeatscanReport.DefaultExt = "*.pdf";
            openHeatscanReport.FileName = "heatscanReport";
            openHeatscanReport.Title = "FLIR rapportage (.pdf)";
            // 
            // openReportFrontPage
            // 
            openReportFrontPage.DefaultExt = "*.docx";
            openReportFrontPage.FileName = "2023 Warmtescan rapportage - template.dotx";
            // 
            // frontpageFilePath
            // 
            frontpageFilePath.AutoSize = true;
            frontpageFilePath.Location = new Point(579, 0);
            frontpageFilePath.Name = "frontpageFilePath";
            frontpageFilePath.Size = new Size(314, 32);
            frontpageFilePath.TabIndex = 1;
            frontpageFilePath.Text = "Rapportage voorblad (.docx)";
            // 
            // heatscanReportFilePath
            // 
            heatscanReportFilePath.AutoSize = true;
            heatscanReportFilePath.Location = new Point(579, 305);
            heatscanReportFilePath.Name = "heatscanReportFilePath";
            heatscanReportFilePath.Size = new Size(291, 32);
            heatscanReportFilePath.TabIndex = 2;
            heatscanReportFilePath.Text = "Warmtescan rapport (.pdf)";
            // 
            // selectFrontPage
            // 
            selectFrontPage.Location = new Point(3, 3);
            selectFrontPage.Name = "selectFrontPage";
            selectFrontPage.Size = new Size(332, 46);
            selectFrontPage.TabIndex = 3;
            selectFrontPage.Text = "Selecteer voorblad";
            selectFrontPage.UseVisualStyleBackColor = true;
            selectFrontPage.Click += selectFrontPage_Click;
            // 
            // selectHeatscanReport
            // 
            selectHeatscanReport.Location = new Point(3, 308);
            selectHeatscanReport.Name = "selectHeatscanReport";
            selectHeatscanReport.Size = new Size(332, 46);
            selectHeatscanReport.TabIndex = 4;
            selectHeatscanReport.Text = "Selecteer FLIR rapportage";
            selectHeatscanReport.UseVisualStyleBackColor = true;
            selectHeatscanReport.Click += selectHeatscanReport_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 282F));
            tableLayoutPanel1.Controls.Add(selectHeatscanReport, 0, 1);
            tableLayoutPanel1.Controls.Add(heatscanReportFilePath, 1, 1);
            tableLayoutPanel1.Controls.Add(selectFrontPage, 0, 0);
            tableLayoutPanel1.Controls.Add(frontpageFilePath, 1, 0);
            tableLayoutPanel1.Controls.Add(GenerateReport, 2, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 129F));
            tableLayoutPanel1.Size = new Size(1435, 740);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1435, 740);
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
    }
}