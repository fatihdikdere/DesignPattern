namespace Command;
/// <summary>
/// Receiver class
/// </summary>
public class MySystem
{
    public bool StartSystem(string systemName)
    {
        Console.WriteLine($"{systemName} is starting");

        return true;
    }
    public bool StopSystem(string systemName)
    {
        Console.WriteLine($"{systemName} is stopping");

        return true;
    }
}
