namespace Flyweight;
/// <summary>
/// ConcreteFlyweight class
/// </summary>
/// <seealso cref="Flyweight.IIcon" />
public class Icon(string iconType) : IIcon
{
    private readonly string iconType = iconType;
    public void Display(string fileName)
    {
        Console.WriteLine($"File: {fileName} icon type is {iconType}");
    }
}
