namespace Builder.Test;
public class NonVegetarianMealBuilderTests
{
    [Fact]
    public void NonVegetarianMealBuilder_WhenCreated_ShouldCreateMealWithCorrectComponents()
    {
        // Arrange
        Meal meal;
        var nonVegetarianMealBuilder = new NonVegetarianMealBuilder();

        // Act
        nonVegetarianMealBuilder.BuildMainCourse();
        nonVegetarianMealBuilder.BuildSideDish();
        nonVegetarianMealBuilder.BuildDrink();
        nonVegetarianMealBuilder.BuildDessert();

        meal = nonVegetarianMealBuilder.Meal;

        // Assert
        meal.MainCourse.Should().Be("Chicken Burger");
        meal.SideDish.Should().Be("Onion Rings");
        meal.Drink.Should().Be("Coke");
        meal.Dessert.Should().Be("Ice Cream");
    }

    [Fact]
    public void NonVegetarianMealBuilder_WhenCreated_ShouldInitializeMealWithCorrectMealType()
    {
        // Arrange
        Meal meal;
        var nonVegetarianMealBuilder = new NonVegetarianMealBuilder();

        // Act
        meal = nonVegetarianMealBuilder.Meal;
        var result = typeof(Meal)!
            .GetField("mealType", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)!
            .GetValue(meal);

        // Assert        
        result.Should().Be(MealType.NonVegetarian);
    }
}
