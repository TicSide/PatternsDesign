using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsDesign.Behavioral_Patterns.Strategy.Ex_1
{

    //Context
    //Clase que usa la estrategia
    class PaymentProcessor
    {
        //Referencia a la estrategia
        private IPagoStrategy pagoStrategy;
        //El constructor recibe una estrategia de pago, lo que permite cambiar la estrategia en tiempo de ejecución.
        public PaymentProcessor(IPagoStrategy pagoStrategy)
        {
            this.pagoStrategy = pagoStrategy;
        }
        //El método ProcessPayment delega el trabajo de realizar el pago a la estrategia concreta que se ha establecido.
        public void ProcessPayment(decimal monto)
        {
            pagoStrategy.Pagar(monto);
        }

    }
}
