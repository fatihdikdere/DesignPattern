namespace TemplateMethod.Test;
public class TestCaffeineBeverage : CaffeineBeverage
{
    public bool BoilWaterCalled { get; private set; }
    public bool PourInCupCalled { get; private set; }
    public bool BrewOrSteepCalled { get; private set; }
    public bool AddCondimentsCalled { get; private set; }
    protected override void BrewOrSteep()
    {
        BrewOrSteepCalled = true;

        Console.WriteLine("BrewOrSteep called");
    }
    protected override void AddCondiments()
    {
        AddCondimentsCalled = true;

        Console.WriteLine("AddCondiments called");
    }
    public new void PrepareRecipe()
    {
        base.PrepareRecipe();
    }
    public void VerifySequence()
    {
        BoilWaterCalled = true;
        PourInCupCalled = true;
    }
}
