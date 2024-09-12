using Strategy;

PaymentContext paymentContext;

var creditCardPayment = new CreditCardPayment();
paymentContext = new PaymentContext(creditCardPayment);
paymentContext.ExecutePayment(100);

var bitcoinPayment = new BitcoinPayment();
paymentContext = new PaymentContext(bitcoinPayment);
paymentContext.ExecutePayment(100);

Console.ReadKey();