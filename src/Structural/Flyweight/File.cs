namespace Flyweight;
/// <summary>
/// Client class
/// </summary>
public class File(string name, IIcon icon)
{
    private readonly string name = name;
    private readonly IIcon icon = icon;
    public void DisplayIcon()
    {
        icon.Display(name);
    }
}
