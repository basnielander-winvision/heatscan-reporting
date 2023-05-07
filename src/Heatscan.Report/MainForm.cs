using System.Diagnostics;

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
        // @"C:\Projects\Personal\heatscan-reporting\libre-office-portable\program\soffice.exe";

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

            if (string.IsNullOrWhiteSpace(this.openHeatscanReport.FileName))
            {
                finalReportDocument.Save(@"c:\temp\report_output.pdf");
            }
            else
            {
                finalReportDocument.Save(this.openHeatscanReport.FileName);

                var startInfo = new ProcessStartInfo()
                {
                    FileName = this.openHeatscanReport.FileName,
                    LoadUserProfile = true,
                    UseShellExecute = true
                };
                Process.Start(startInfo);
            }

            this.GenerateReport.Enabled = true;
        }

        private void selectFrontPage_Click(object sender, EventArgs e)
        {
            var dialogResult = this.openReportFrontPage.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                this.frontpageFilePath.Text = this.openReportFrontPage.FileName;
            }
            //if (!string.IsNullOrWhiteSpace(this.openReportFrontPage.FileName))
            //{
            //    var docx = WordprocessingDocument.Open(this.openReportFrontPage.FileName, true);
            //    var document = docx.MainDocumentPart?.Document;
            //    var body = document.Body;
            //    var para = body.AppendChild(new Paragraph());
            //    var run = para.AppendChild(new Run());

            //    run.AppendChild(new Text("Hello WORLD!!!!"));
            //    docx.Clone(@"c:\temp\hello world.docx");
            //}
        }

        private void selectHeatscanReport_Click(object sender, EventArgs e)
        {
            var dialogResult = this.openHeatscanReport.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                this.heatscanReportFilePath.Text = this.openHeatscanReport.FileName;
            }
        }

        private void SaveReportAs_Click(object sender, EventArgs e)
        {
            var dialogResult = this.saveOutputAs.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                this.outputFilePath.Text = this.saveOutputAs.FileName;
            }
        }
    }
}