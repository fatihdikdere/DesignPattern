namespace Builder.Test;
public class MealTests
{
    [Fact]
    public void Meal_WhenCreated_ShouldInitializePropertiesCorrectly()
    {
        // Arrange
        var meal = new Meal(It.IsAny<MealType>());

        // Act
        meal.MainCourse = "Steak";
        meal.SideDish = "Salad";
        meal.Drink = "Wine";
        meal.Dessert = "Cake";

        // Assert
        meal.MainCourse.Should().Be("Steak");
        meal.SideDish.Should().Be("Salad");
        meal.Drink.Should().Be("Wine");
        meal.Dessert.Should().Be("Cake");
    }

    [Fact]
    public void Meal_WhenCreated_ShouldHaveCorrectMealType()
    {
        // Arrange
        var mealType = MealType.Vegetarian;
        var meal = new Meal(mealType);

        // Act 
        var result = typeof(Meal)!
            .GetField("mealType", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)!
            .GetValue(meal);

        //Arrange
        result.Should().Be(mealType);
    }
}
