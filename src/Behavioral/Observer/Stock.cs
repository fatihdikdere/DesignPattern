namespace Observer;
/// <summary>
/// ConcreteSubject class
/// </summary>
/// <seealso cref="Observer.IStock" />
public class Stock : IStock
{
    private readonly List<IInvestor> investors = [];
    private decimal price;
    public decimal Price
    {
        get => price;
        set
        {
            if (price == value)
            {
                return;
            }

            price = value;

            Notify();
        }
    }
    public void Attach(IInvestor investor)
    {
        investors.Add(investor);
    }
    public void Detach(IInvestor investor)
    {
        investors.Remove(investor);
    }
    public void Notify()
    {
        foreach (var investor in investors)
        {
            investor.Update(this);
        }
    }
}
