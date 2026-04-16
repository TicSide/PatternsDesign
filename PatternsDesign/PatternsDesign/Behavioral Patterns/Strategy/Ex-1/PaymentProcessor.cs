using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsDesign.Behavioral_Patterns.Strategy.Ex_1
{
    class PaymentProcessor
    {
        private IPagoStrategy pagoStrategy;

        public PaymentProcessor(IPagoStrategy pagoStrategy)
        {
            this.pagoStrategy = pagoStrategy;
        }

        public void ProcessPayment(decimal monto)
        {
            pagoStrategy.Pagar(monto);
        }

    }
}
