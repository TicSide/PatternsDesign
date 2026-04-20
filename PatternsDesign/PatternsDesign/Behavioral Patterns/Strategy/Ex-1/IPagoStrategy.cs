using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsDesign.Behavioral_Patterns.Strategy.Ex_1
{
    //Strategy (Interfaz)
    //La estrategia es una interfaz común para todas las estrategias de pago.
    //Define un método que todas las estrategias de pago deben implementar.
    public interface IPagoStrategy
    {
        //Metodo para realizar el pago, cada estrategia de pago implementará este método de manera diferente.
        void Pagar(decimal monto);
    }
}
