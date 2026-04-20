using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternsDesign.Behavioral_Patterns.Strategy.Ex_1;
using PatternsDesign.Behavioral_Patterns.Strategy.Ex_2;
using PatternsDesign.Behavioral_Patterns.Strategy.Ex_3;
using PatternsDesign.Behavioral_Patterns.Strategy.Ex_4;
using PatternsDesign.Structural_Patterns.Adapter.Ex_1;

namespace PatternsDesign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPagoStrategy pagoTarjeta = new PagoTarjeta();
            PaymentProcessor paymentProcessor = new PaymentProcessor(pagoTarjeta);
            paymentProcessor.ProcessPayment(100m);


            IShippingStrategy shippingStrategy = new SeaShip();
            ShippingService shippingService = new ShippingService(shippingStrategy);
            shippingService.Ship();

            var paymentStrategy = new PaymentSystem(new PaypalAdapter(new PayPal()));
            var paymentStrategy2 = new PaymentSystem(new StripeAdapter(new Stripe()));

            paymentStrategy.ProcessPayment(3000);
            paymentStrategy2.ProcessPayment(5000);

            var products = new List<Product>();

            var expensiveFilter = new ProductFilter(new ExpensiveFilter());
            var expensiveProducts = expensiveFilter.Filter(products);

            var cheapFilter = new ProductFilter(new CheapFilter());
            var cheapProducts = cheapFilter.Filter(products);


            ICalculator calculator = new OldCalculatorAdapter(new OldCalculator());
            var op=calculator.Add(3,5);
            Console.WriteLine("Result of addition: " + op);

        }
    }
}
