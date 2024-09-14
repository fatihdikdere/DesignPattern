namespace Decorator.Test;
public class SmsNotifierTests
{
    [Fact]
    public void Send_WhenCalled_ShouldSendBaseNotificationAndSmsNotification()
    {
        // Arrange
        var mockNotifier = new Mock<INotifier>();
        var smsNotifier = new SmsNotifier(mockNotifier.Object);

        // Act
        smsNotifier.Send("Test message");

        // Assert
        mockNotifier.Verify(n => n.Send("Test message"), Times.Once); 
    }
}
