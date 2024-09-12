namespace Strategy;
/// <summary>
/// ConcreteStrategy class
/// </summary>
/// <seealso cref="Strategy.IPaymentStrategy" />
public class BitcoinPayment : IPaymentStrategy
{
    public bool ProcessPayment(decimal amount)
    {
        Console.WriteLine("Bitcoin payment");

        return true;
    }
}
