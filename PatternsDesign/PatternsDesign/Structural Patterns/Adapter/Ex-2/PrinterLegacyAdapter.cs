using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsDesign.Structural_Patterns.Adapter.Ex_2
{
    class PrinterLegacyAdapter:IPrinter
    {
        private readonly PrinterLegacy printerLegacy;

        public PrinterLegacyAdapter(PrinterLegacy printerLegacy)
        {
            this.printerLegacy = printerLegacy;
        }

        public void Print(string message)
        {
            printerLegacy.PrintText(message);
        }
    }
}
