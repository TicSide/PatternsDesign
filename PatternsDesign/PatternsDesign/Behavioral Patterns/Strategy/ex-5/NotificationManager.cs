using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsDesign.Behavioral_Patterns.Strategy.Ex_5
{
    interface IReport
    {
        void Generate();
    }

    class PdfGenerator
    {
        public void CreatePdf() { }
    }


    class PdfAdapter:IReport
    {
        private readonly PdfGenerator pdfGenerator;
        public PdfAdapter(PdfGenerator pdfGenerator)
        {
            this.pdfGenerator = pdfGenerator;
        }

        public void Generate()
        {
            pdfGenerator.CreatePdf();
        }
    }

    class ReportService
    {
        private readonly IReport report;

        public ReportService(IReport report)
        {
            this.report = report;
        }

        public void Generate()
        {
            report.Generate();
        }
    }
}
