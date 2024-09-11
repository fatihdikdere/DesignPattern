namespace FactoryMethod;
/// <summary>
/// ConcreteCreator class B
/// </summary>
/// <seealso cref="FactoryMethod.Employee" />
public class PartTimeEmployee : Employee
{
    public override IFeeCalculator CreateFeeCalculator()
    {
        return new PartTimeFeeCalculator();
    }
}
