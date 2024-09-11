namespace FactoryMethod;
/// <summary>
/// Product interface
/// </summary>
public interface IFeeCalculator
{
    decimal CalculateFee(int hoursWorked);
}
