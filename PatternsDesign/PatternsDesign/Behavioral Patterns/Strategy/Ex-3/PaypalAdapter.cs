using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsDesign.Behavioral_Patterns.Strategy.Ex_3
{
    class PaypalAdapter:IPaymentStrategy
    {
        private readonly PayPal payPal;

        public PaypalAdapter(PayPal payPal)
        {
            this.payPal = payPal;
        }

        public void Pay(decimal amount)
        {
            payPal.Pay(amount);
        }

    }
}
