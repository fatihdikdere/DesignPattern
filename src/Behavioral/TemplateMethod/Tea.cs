namespace TemplateMethod;
/// <summary>
/// ConcreteClass class
/// </summary>
/// <seealso cref="TemplateMethod.CaffeineBeverage" />
public class Tea : CaffeineBeverage
{
    protected override void BrewOrSteep()
    {
        Console.WriteLine("BrewOrSteep for tea");
    }
    protected override void AddCondiments()
    {
        Console.WriteLine("AddCondiments for tea");
    }
}
