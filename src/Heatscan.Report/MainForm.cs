// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MainForm.cs" company="Winvision bv">
//   Copyright (c) Winvision bv. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using DocXToPdfConverter;

using PdfSharp;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;

namespace Heatscan.Report
{
    public partial class MainForm : Form
    {
        private readonly string locationOfLibreOfficeSoffice =
            @"C:\Tools\LibreOfficePortable\App\libreoffice\program\soffice.exe";

        public MainForm()
        {
            this.InitializeComponent();
        }

        private void GenerateReport_Click(object sender, EventArgs e)
        {
            this.GenerateReport.Enabled = false;

            var reportFrontPageFilePath = this.openReportFrontPage.FileName;

            var test = new ReportGenerator(this.locationOfLibreOfficeSoffice);
            var tempFrontPagePdf = $"{Path.GetTempFileName()}.pdf";
            test.Convert(reportFrontPageFilePath, tempFrontPagePdf);

            var finalReportDocument = new PdfDocument();

            var inputDocuments = new List<PdfDocument>()
            {
                PdfReader.Open(tempFrontPagePdf, PdfDocumentOpenMode.Import),
                PdfReader.Open(this.openHeatscanReport.FileName, PdfDocumentOpenMode.Import)
            };

            foreach (var pdfFile in inputDocuments)
            {
                foreach (var page in pdfFile.Pages)
                {
                    page.Size = PageSize.A4;
                    finalReportDocument.AddPage(page);
                }
            }

            finalReportDocument.Save(@"c:\temp\report_output.pdf");

            this.GenerateReport.Enabled = true;
        }

        private void selectFrontPage_Click(object sender, EventArgs e)
        {
            this.openReportFrontPage.ShowDialog();
        }

        private void selectHeatscanReport_Click(object sender, EventArgs e)
        {
            this.openHeatscanReport.ShowDialog();
        }
    }
}