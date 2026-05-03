using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsDesign.Structural_Patterns.Adapter.Ex_4
{
    class PaymentGatewayAdapter:IPayment
    {
        private readonly PaymentGateway paymentGateway;

        public PaymentGatewayAdapter(PaymentGateway paymentGateway)
        {
            this.paymentGateway = paymentGateway;
        }

        public void Pay(decimal amount)
        {
            paymentGateway.MakePayment(amount);
        }
    }
}
