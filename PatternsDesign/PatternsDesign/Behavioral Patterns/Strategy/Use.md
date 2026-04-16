# This is a markdown that you put in the main class to show how to use the strategy pattern in this example.

### Example 1
```            
IPagoStrategy pagoTarjeta = new PagoTarjeta();
PaymentProcessor paymentProcessor = new PaymentProcessor(pagoTarjeta);
paymentProcessor.ProcessPayment(100m);
```
### Example 2
```            
IShippingStrategy shippingStrategy = new SeaShip();
ShippingService shippingService = new ShippingService(shippingStrategy);
shippingService.Ship();
```

### Example 3
```            
var paymentStrategy = new PaymentSystem(new PaypalAdapter(new PayPal()));
var paymentStrategy2 = new PaymentSystem(new StripeAdapter(new Stripe()));

paymentStrategy.ProcessPayment(3000);
paymentStrategy2.ProcessPayment(5000);
```
