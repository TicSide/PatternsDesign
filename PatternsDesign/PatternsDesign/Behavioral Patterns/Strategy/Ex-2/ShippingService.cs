using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsDesign.Behavioral_Patterns.Strategy.Ex_2
{
    class ShippingService
    {
        private IShippingStrategy shippingStrategy;

        public ShippingService(IShippingStrategy shippingStrategy)
        {
            this.shippingStrategy = shippingStrategy;
        }

        public void Ship()
        {
            shippingStrategy.Ship();
        }

    }
}
