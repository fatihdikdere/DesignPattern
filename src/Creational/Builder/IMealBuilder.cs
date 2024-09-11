namespace Builder;
/// <summary>
/// Builder interface
/// </summary>
public interface IMealBuilder
{
    public Meal Meal { get; init; }
    void BuildMainCourse();
    void BuildSideDish();
    void BuildDrink();
    void BuildDessert();
}
