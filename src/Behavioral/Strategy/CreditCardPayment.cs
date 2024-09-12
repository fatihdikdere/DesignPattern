namespace Strategy;
/// <summary>
/// ConcreteStrategy classs 
/// </summary>
/// <seealso cref="Strategy.IPaymentStrategy" />
public class CreditCardPayment : IPaymentStrategy
{
    public bool ProcessPayment(decimal amount)
    {
        Console.WriteLine("Credit card payment");

        return true;
    }
}
