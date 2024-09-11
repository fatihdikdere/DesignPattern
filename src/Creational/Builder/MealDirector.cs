namespace Builder;
/// <summary>
/// Director class
/// </summary>
public class MealDirector(IMealBuilder mealBuilder)
{
    private readonly IMealBuilder mealBuilder = mealBuilder;
    public void Construct()
    {
        mealBuilder.BuildMainCourse();
        mealBuilder.BuildSideDish();
        mealBuilder.BuildDrink();
        mealBuilder.BuildDessert();
    }
    public void Show()
    {
        mealBuilder?.Meal.Show();
    }
}
