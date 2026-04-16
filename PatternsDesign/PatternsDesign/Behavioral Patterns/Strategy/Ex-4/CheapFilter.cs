using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsDesign.Behavioral_Patterns.Strategy.Ex_4
{
    class CheapFilter : IProductFilterStrategy
    {
        public List<Product> Filter(List<Product> products)
        {
            return products.Where(p => p.Price < 50).ToList();
        }
    }
}
