namespace Bridge;
/// <summary>
/// Abstraction abstract class
/// </summary>
public abstract class RemoteControl(IDevice device)
{
    protected readonly IDevice device = device;
    public abstract void TogglePower();
    public abstract void VolumeUp();
    public abstract void VolumeDown();
}
