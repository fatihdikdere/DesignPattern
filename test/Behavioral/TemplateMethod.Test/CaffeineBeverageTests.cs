namespace TemplateMethod.Test;
public class CaffeineBeverageTests
{
    [Fact]
    public void PrepareRecipe_WhenCalled_ShouldCallMethodsInCorrectOrder()
    {
        // Arrange
        var beverage = new TestCaffeineBeverage();

        // Act
        beverage.PrepareRecipe();
        beverage.VerifySequence();

        // Assert
        beverage.BoilWaterCalled.Should().BeTrue();
        beverage.PourInCupCalled.Should().BeTrue();
        beverage.BrewOrSteepCalled.Should().BeTrue();
        beverage.AddCondimentsCalled.Should().BeTrue();
    }
}
