namespace Builder;
/// <summary>
/// ConcreteBuilder2 classs
/// </summary>
/// <seealso cref="Builder.MealBuilder" />
public class NonVegetarianMealBuilder : MealBuilder
{
    public NonVegetarianMealBuilder()
        : base(MealType.NonVegetarian)
    {

    }
    public override void BuildMainCourse()
    {
        Meal.MainCourse = "Chicken Burger";
    }
    public override void BuildSideDish()
    {
        Meal.SideDish = "Onion Rings";
    }
    public override void BuildDrink()
    {
        Meal.Drink = "Coke";
    }
    public override void BuildDessert()
    {
        Meal.Dessert = "Ice Cream";
    }
}
