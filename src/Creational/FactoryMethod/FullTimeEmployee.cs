namespace FactoryMethod;
/// <summary>
/// ConcreteCreator class A 
/// </summary>
/// <seealso cref="FactoryMethod.Employee" />
public class FullTimeEmployee : Employee
{
    public override IFeeCalculator CreateFeeCalculator()
    {
        return new FullTimeFeeCalculator();
    }
}
