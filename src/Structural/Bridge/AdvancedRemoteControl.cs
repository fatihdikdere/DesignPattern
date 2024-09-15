namespace Bridge;
/// <summary>
/// RefinedAbstraction class
/// </summary>
/// <seealso cref="Bridge.RemoteControl" />
public class AdvancedRemoteControl(IDevice device) : RemoteControl(device)
{
    private int volume = 10;
    private bool isPoweredOn;
    public override void TogglePower()
    {
        if (!isPoweredOn)
        {
            device.PowerOn();
            isPoweredOn = true;

            return;
        }

        device.PowerOff();
        isPoweredOn = false;
    }
    public override void VolumeUp()
    {
        volume++;

        device.SetVolume(volume);
    }
    public override void VolumeDown()
    {
        volume--;

        device.SetVolume(volume);
    }
}
