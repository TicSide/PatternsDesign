using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsDesign.Structural_Patterns.Adapter.Ex_4
{
    class PaymentGateway
    {
        public bool MakePayment(decimal amount)
        {
            return true;
        }
    }
}
