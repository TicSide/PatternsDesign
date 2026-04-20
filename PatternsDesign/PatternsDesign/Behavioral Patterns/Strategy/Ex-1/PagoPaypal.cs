using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsDesign.Behavioral_Patterns.Strategy.Ex_1
{
    //Implementar la estrategia concreta
    //Concrete Strategies
    class PagoPaypal : IPagoStrategy
    {
        public void Pagar(decimal monto)
        {
            Console.WriteLine("Pago con Paypal");
            Console.WriteLine(monto);
        }
    }
}
