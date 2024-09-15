namespace Decorator.Test;
public class PushNotifierTests
{
    [Fact]
    public void Send_WhenCalled_ShouldSendBaseNotificationAndPushNotification()
    {
        // Arrange
        var mockNotifier = new Mock<INotifier>();
        var pushNotifier = new PushNotifier(mockNotifier.Object);

        // Act
        pushNotifier.Send("Test message");

        // Assert
        mockNotifier.Verify(n => n.Send("Test message"), Times.Once); 
    }
}
