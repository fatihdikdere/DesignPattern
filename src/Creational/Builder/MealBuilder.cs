namespace Builder;
/// <summary>
/// Builder abstract class
/// </summary>
/// <seealso cref="Builder.IMealBuilder" />
public abstract class MealBuilder(MealType mealType) : IMealBuilder
{
    public Meal Meal { get; init; } = new Meal(mealType);
    public abstract void BuildMainCourse();
    public abstract void BuildSideDish();
    public abstract void BuildDrink();
    public abstract void BuildDessert();
}
