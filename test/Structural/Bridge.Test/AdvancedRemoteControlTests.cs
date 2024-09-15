namespace Bridge.Test;
public class AdvancedRemoteControlTests
{
    private readonly Mock<IDevice> mockDevice;
    private readonly AdvancedRemoteControl remoteControl;
    public AdvancedRemoteControlTests()
    {
        mockDevice = new Mock<IDevice>();
        remoteControl = new AdvancedRemoteControl(mockDevice.Object);
    }

    [Fact]
    public void TogglePower_WhenDeviceIsOff_ShouldTurnOn()
    {
        //Arrange

        // Act
        remoteControl.TogglePower();

        // Assert
        mockDevice.Verify(d => d.PowerOn(), Times.Once);
    }

    [Fact]
    public void TogglePower_WhenDeviceIsOn_ShouldTurnOff()
    {
        // Arrange
        remoteControl.TogglePower();

        // Act
        remoteControl.TogglePower();

        // Assert
        mockDevice.Verify(d => d.PowerOff(), Times.Once);
    }

    [Fact]
    public void VolumeUp_WhenCalled_ShouldIncreaseVolume()
    {
        // Arrange

        // Act
        remoteControl.VolumeUp();

        // Assert
        mockDevice.Verify(d => d.SetVolume(It.Is<int>(v => v == 11)), Times.Once);
    }

    [Fact]
    public void VolumeDown_WhenCalled_ShouldDecreaseVolume()
    {
        // Arrange

        // Act
        remoteControl.VolumeDown();

        // Assert
        mockDevice.Verify(d => d.SetVolume(It.Is<int>(v => v == 9)), Times.Once);
    }
}
