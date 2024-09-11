namespace FactoryMethod;
/// <summary>
/// ConcreteProduct class A
/// </summary>
/// <seealso cref="FactoryMethod.IFeeCalculator" />
public class FullTimeFeeCalculator : IFeeCalculator
{
    public decimal CalculateFee(int hoursWorked)
    {
        return hoursWorked * 100;
    }
}
