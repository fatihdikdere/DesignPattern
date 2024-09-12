namespace Observer;
/// <summary>
/// Subject interface
/// </summary>
public interface IStock
{
    decimal Price { get; set; }
    void Attach(IInvestor investor);
    void Detach(IInvestor investor);
    void Notify();
}
