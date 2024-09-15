namespace Facade;
/// <summary>
/// Subsystem for graphics
/// </summary>
public class GraphicEngine : Engine
{
    public virtual bool IsGraphicEnough()
    {
        Console.WriteLine("IsGraphicEnough method was called");

        return true;
    }
}
