using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsDesign.Behavioral_Patterns.Strategy.Ex_4
{
    class ProductFilter
    {
        private readonly IProductFilterStrategy _strategy;

        public ProductFilter(IProductFilterStrategy strategy)
        {
            _strategy = strategy;
        }

        public List<Product> Filter(List<Product> products)
        {
            return _strategy.Filter(products);
        }
    }
}
