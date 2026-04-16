using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsDesign.Behavioral_Patterns.Strategy.Ex_2
{
    class SeaShip : IShippingStrategy
    {
        public void Ship()
        {
            Console.WriteLine("Enviando por Mar");
        }
    }
}
