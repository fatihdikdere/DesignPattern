namespace Builder.Test;
public class VegetarianMealBuilderTests
{
    [Fact]
    public void VegetarianMealBuilder_WhenCreated_ShouldCreateMealWithCorrectComponents()
    {
        // Arrange
        Meal meal;
        var vegetarianMealBuilder = new VegetarianMealBuilder();

        // Act
        vegetarianMealBuilder.BuildMainCourse();
        vegetarianMealBuilder.BuildSideDish();
        vegetarianMealBuilder.BuildDrink();
        vegetarianMealBuilder.BuildDessert();

        meal = vegetarianMealBuilder.Meal;

        // Assert
        meal.MainCourse.Should().Be("Vegetarian Burger");
        meal.SideDish.Should().Be("French Fries");
        meal.Drink.Should().Be("Lemonade");
        meal.Dessert.Should().Be("Fruit Salad");
    }

    [Fact]
    public void VegetarianMealBuilder_WhenCreated_ShouldInitializeMealWithCorrectMealType()
    {
        // Arrange
        Meal meal;
        var vegetarianMealBuilder = new VegetarianMealBuilder();

        // Act
        meal = vegetarianMealBuilder.Meal;
        var result = typeof(Meal)!
            .GetField("mealType", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)!
            .GetValue(meal);

        // Assert        
        result.Should().Be(MealType.Vegetarian);
    }
}
