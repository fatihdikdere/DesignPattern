namespace Mediator.Test;
public class ChatUserTests
{
    [Fact]
    public void Send_WhenCalled_ShouldSendMessageToChatRoom()
    {
        // Arrange
        var chatRoomMock = new MockChatRoom();
        var user = new ChatUser("User1", chatRoomMock);

        // Act
        user.Send("Hello");

        // Assert
        chatRoomMock.LastSender.Should().Be(user);
        chatRoomMock.LastMessage.Should().Be("Hello");
    }
}
