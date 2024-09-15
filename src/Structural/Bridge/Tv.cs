namespace Bridge;
/// <summary>
/// ConcreteImplementor class A
/// </summary>
/// <seealso cref="Bridge.IDevice" />
public class Tv : IDevice
{
    public void PowerOn()
    {
        Console.WriteLine("TV Power on");
    }
    public void PowerOff()
    {
        Console.WriteLine("TV Power off");
    }
    public void SetVolume(int volume)
    {
        Console.WriteLine($"TV Set volume to {volume}");
    }
}
