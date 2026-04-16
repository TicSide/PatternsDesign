using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsDesign.Behavioral_Patterns.Strategy.Ex_3
{
    class PaymentSystem
    {
        private IPaymentStrategy paymentStrategy;

        public PaymentSystem(IPaymentStrategy paymentStrategy)
        {
            this.paymentStrategy = paymentStrategy;
        }   

        public void ProcessPayment(decimal amount)
        {
            paymentStrategy.Pay(amount);
            Console.WriteLine(amount + " paid using " + paymentStrategy.GetType().Name);
        }
    }
}
