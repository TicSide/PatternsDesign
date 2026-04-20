using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsDesign.Structural_Patterns.Adapter.Ex_1
{
    public class OldCalculatorAdapter :ICalculator
    {
        private readonly OldCalculator oldCalculator;
        public OldCalculatorAdapter(OldCalculator oldCalculator)
        {
            this.oldCalculator = oldCalculator;
        }

        public int Add(int a, int b)
        {
            return oldCalculator.AddNumbers(a, b);
        }

    }
}

