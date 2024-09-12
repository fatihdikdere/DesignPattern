namespace TemplateMethod;
/// <summary>
/// ConcreteClass class
/// </summary>
/// <seealso cref="TemplateMethod.CaffeineBeverage" />
public class Coffee : CaffeineBeverage
{
    protected override void BrewOrSteep()
    {
        Console.WriteLine("BrewOrSteep for coffee");
    }
    protected override void AddCondiments()
    {
        Console.WriteLine("AddCondiments for coffee");
    }
}
