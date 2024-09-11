namespace FactoryMethod;
/// <summary>
/// Creator abstract class
/// </summary>
public abstract class Employee
{
    /// <summary>
    /// Factory method
    /// </summary>
    /// <returns></returns>
    public abstract IFeeCalculator CreateFeeCalculator();
    public decimal CalculateSalary(int hoursWorked)
    {
        var feeCalculator = CreateFeeCalculator();
        var fee = feeCalculator.CalculateFee(hoursWorked);

        return fee;
    }
}
