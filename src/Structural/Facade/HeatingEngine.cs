namespace Facade;
/// <summary>
/// Subsytem for heating
/// </summary>
public class HeatingEngine : Engine
{
    public virtual bool IsHeatAverage()
    {
        Console.WriteLine("IsHeatAverage method was called");

        return true;
    }
}
