namespace FactoryMethod;
/// <summary>
/// ConcreteProduct class B
/// </summary>
/// <seealso cref="FactoryMethod.IFeeCalculator" />
public class PartTimeFeeCalculator : IFeeCalculator
{
    public decimal CalculateFee(int hoursWorked)
    {
        return hoursWorked * 50;
    }
}
