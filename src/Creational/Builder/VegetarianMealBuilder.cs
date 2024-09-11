namespace Builder;
/// <summary>
/// ConcreteBuilder1 classs
/// </summary>
/// <seealso cref="Builder.MealBuilder" />
public class VegetarianMealBuilder : MealBuilder
{
    public VegetarianMealBuilder()
        : base(MealType.Vegetarian)
    {

    }
    public override void BuildMainCourse()
    {
        Meal.MainCourse = "Vegetarian Burger";
    }
    public override void BuildSideDish()
    {
        Meal.SideDish = "French Fries";
    }
    public override void BuildDrink()
    {
        Meal.Drink = "Lemonade";
    }
    public override void BuildDessert()
    {
        Meal.Dessert = "Fruit Salad";
    }
}
