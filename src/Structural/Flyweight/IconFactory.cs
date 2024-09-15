namespace Flyweight;
/// <summary>
/// FlyweightFactory class
/// </summary>
public class IconFactory
{
    private readonly Dictionary<string, IIcon> icons = [];
    public IIcon GetIcon(string iconType)
    {
        if (!icons.TryGetValue(iconType, out IIcon? value))
        {
            value = new Icon(iconType);

            icons.Add(iconType, value);
        }

        return value;
    }
}
