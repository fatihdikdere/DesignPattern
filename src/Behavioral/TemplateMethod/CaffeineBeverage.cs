namespace TemplateMethod;
/// <summary>
/// AbstractClass abstract class
/// </summary>
public abstract class CaffeineBeverage
{
    /// <summary>
    /// Template method
    /// </summary>
    public void PrepareRecipe()
    {
        BoilWater();
        BrewOrSteep();
        PourInCup();
        AddCondiments();
    }
    protected abstract void BrewOrSteep();
    protected abstract void AddCondiments();
    private void BoilWater()
    {
        Console.WriteLine("Boiling water");
    }
    private void PourInCup()
    {
        Console.WriteLine("Pouring into cup");
    }
}
