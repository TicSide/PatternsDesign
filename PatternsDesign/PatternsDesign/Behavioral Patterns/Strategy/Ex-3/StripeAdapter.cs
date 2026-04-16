using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsDesign.Behavioral_Patterns.Strategy.Ex_3
{
    class StripeAdapter : IPaymentStrategy
    {
        private readonly Stripe stripe;
        public StripeAdapter(Stripe stripe)
        {
            this.stripe = stripe;
        }

        public void Pay(decimal amount)
        {
            stripe.Charge(amount);
        }
    }
}
