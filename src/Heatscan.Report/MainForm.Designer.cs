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
            SuspendLayout();
            // 
            // GenerateReport
            // 
            GenerateReport.Location = new Point(1159, 603);
            GenerateReport.Name = "GenerateReport";
            GenerateReport.Size = new Size(245, 92);
            GenerateReport.TabIndex = 0;
            GenerateReport.Text = "Rapport maken";
            GenerateReport.UseVisualStyleBackColor = true;
            GenerateReport.Click += GenerateReport_Click;
            // 
            // openHeatscanReport
            // 
            openHeatscanReport.FileName = "heatscanReport";
            // 
            // openReportFrontPage
            // 
            openReportFrontPage.FileName = "reportFrontPage";
            // 
            // frontpageFilePath
            // 
            frontpageFilePath.AutoSize = true;
            frontpageFilePath.Location = new Point(505, 65);
            frontpageFilePath.Name = "frontpageFilePath";
            frontpageFilePath.Size = new Size(314, 32);
            frontpageFilePath.TabIndex = 1;
            frontpageFilePath.Text = "Rapportage voorblad (.docx)";
            // 
            // heatscanReportFilePath
            // 
            heatscanReportFilePath.AutoSize = true;
            heatscanReportFilePath.Location = new Point(505, 157);
            heatscanReportFilePath.Name = "heatscanReportFilePath";
            heatscanReportFilePath.Size = new Size(291, 32);
            heatscanReportFilePath.TabIndex = 2;
            heatscanReportFilePath.Text = "Warmtescan rapport (.pdf)";
            // 
            // selectFrontPage
            // 
            selectFrontPage.Location = new Point(35, 58);
            selectFrontPage.Name = "selectFrontPage";
            selectFrontPage.Size = new Size(332, 46);
            selectFrontPage.TabIndex = 3;
            selectFrontPage.Text = "Selecteer voorblad";
            selectFrontPage.UseVisualStyleBackColor = true;
            selectFrontPage.Click += selectFrontPage_Click;
            // 
            // selectHeatscanReport
            // 
            selectHeatscanReport.Location = new Point(35, 150);
            selectHeatscanReport.Name = "selectHeatscanReport";
            selectHeatscanReport.Size = new Size(332, 46);
            selectHeatscanReport.TabIndex = 4;
            selectHeatscanReport.Text = "Selecteer FLIR rapportage";
            selectHeatscanReport.UseVisualStyleBackColor = true;
            selectHeatscanReport.Click += selectHeatscanReport_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1435, 740);
            Controls.Add(selectHeatscanReport);
            Controls.Add(selectFrontPage);
            Controls.Add(heatscanReportFilePath);
            Controls.Add(frontpageFilePath);
            Controls.Add(GenerateReport);
            Name = "MainForm";
            Text = "Warmtescan rapportage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button GenerateReport;
        private OpenFileDialog openHeatscanReport;
        private OpenFileDialog openReportFrontPage;
        private Label frontpageFilePath;
        private Label heatscanReportFilePath;
        private Button selectFrontPage;
        private Button selectHeatscanReport;
    }
}