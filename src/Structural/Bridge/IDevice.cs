namespace Bridge;
/// <summary>
/// Implementor interface
/// </summary>
public interface IDevice
{
    void PowerOn();
    void PowerOff();
    void SetVolume(int volume);
}
