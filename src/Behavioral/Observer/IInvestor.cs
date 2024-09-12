namespace Observer;
/// <summary>
/// Observer interface
/// </summary>
public interface IInvestor
{
    void Update(IStock stock);
}
