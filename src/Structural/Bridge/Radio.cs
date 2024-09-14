namespace Bridge;
/// <summary>
/// ConcreteImplementor class B
/// </summary>
/// <seealso cref="Bridge.IDevice" />
public class Radio : IDevice
{
    public void PowerOn()
    {
        Console.WriteLine("Radio Power on");
    }
    public void PowerOff()
    {
        Console.WriteLine("Radio Power off");
    }
    public void SetVolume(int volume)
    {
        Console.WriteLine($"Radio Set volume to {volume}");
    }
}
