namespace Strategy;
/// <summary>
/// Context class
/// </summary>
public class PaymentContext(IPaymentStrategy paymentStrategy)
{
    private readonly IPaymentStrategy paymentStrategy = paymentStrategy;
    public bool ExecutePayment(decimal amount)
    {
        return paymentStrategy.ProcessPayment(amount);
    }
}
