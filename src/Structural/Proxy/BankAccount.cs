namespace Proxy;
/// <summary>
/// RealSubject class
/// </summary>
/// <seealso cref="Proxy.IBankAccount" />
public class BankAccount(double balance) : IBankAccount
{
    private double balance = balance;
    public double Balance => balance;
    public bool Withdraw(double amount)
    {
        if (amount > balance)
        {
            Console.WriteLine("Insufficient balance");

            return false;
        }

        balance -= amount;

        Console.WriteLine($"New balance {balance}");

        return true;
    }
}
