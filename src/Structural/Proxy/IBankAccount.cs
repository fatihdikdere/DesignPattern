namespace Proxy;
/// <summary>
/// Subject interface
/// </summary>
public interface IBankAccount
{
    double Balance { get; }
    bool Withdraw(double amount);
}
