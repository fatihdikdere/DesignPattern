namespace Observer;
/// <summary>
/// ConcreteObserver class
/// </summary>
/// <seealso cref="Observer.IInvestor" />
public class Investor(string name) : IInvestor
{
    private readonly string name = name;
    public void Update(IStock stock)
    {
        Console.WriteLine($"Investor {name} notified of price change: {stock?.Price}");
    }
}
