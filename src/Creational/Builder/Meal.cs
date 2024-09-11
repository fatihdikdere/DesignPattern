namespace Builder;
/// <summary>
/// Product class
/// </summary>
public class Meal(MealType mealType)
{
    private readonly MealType mealType = mealType;
    public string MainCourse { get; set; }
    public string SideDish { get; set; }
    public string Drink { get; set; }
    public string Dessert { get; set; }
    public virtual void Show()
    {
        Console.WriteLine(Environment.NewLine);
        Console.WriteLine($"MealType: {mealType}");
        Console.WriteLine($"MainCourse: {MainCourse}");
        Console.WriteLine($"SideDish: {SideDish}");
        Console.WriteLine($"Drink: {Drink}");
        Console.WriteLine($"Dessert: {Dessert}");
    }
}