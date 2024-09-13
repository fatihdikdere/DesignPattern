namespace Proxy;
/// <summary>
/// ProxyObject class
/// </summary>
/// <seealso cref="Proxy.IBankAccount" />
public class BankAccountProxy(BankAccount bankAccount) : IBankAccount
{
    private readonly BankAccount bankAccount = bankAccount;
    public double Balance => bankAccount.Balance;
    public bool Withdraw(double amount)
    {
        return bankAccount.Withdraw(amount);
    }
}
