using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsDesign.Structural_Patterns.Adapter.Ex_2
{
    class PrinterLegacy
    {
        public void PrintText(string text)
        {
            Console.WriteLine(text);
        }
    }
}
