namespace Strategy;
/// <summary>
/// Strategy interface
/// </summary>
public interface IPaymentStrategy
{
    bool ProcessPayment(decimal amount);
}
