namespace Mediator.Test;
public class ChatRoomTests
{
    [Fact]
    public void RegisterUser_WhenCalled_ShouldAddUserToChatRoom()
    {
        // Arrange
        var chatRoom = new ChatRoom();
        var user = new TestUser("User1", chatRoom);

        // Act
        chatRoom.RegisterUser(user);

        // Assert
        chatRoom.Users.Should().Contain(user);
    }

    [Fact]
    public void SendMessage_WhenCalled_ShouldDeliverMessageToAllOtherUsers()
    {
        // Arrange
        var chatRoom = new ChatRoom();
        var user1 = new TestUser("User1", chatRoom);
        var user2 = new TestUser("User2", chatRoom);

        chatRoom.RegisterUser(user1);
        chatRoom.RegisterUser(user2);

        // Act
        user1.Send("Hello, User2!");

        // Assert
        user2.LastReceivedMessage.Should().Be("Hello, User2!");
        user1.LastReceivedMessage.Should().BeNull(); 
    }

    [Fact]
    public void SendMessage_WhenSenderAndReceiverAreTheSame_ShouldNotReceiveMessage()
    {
        // Arrange
        var chatRoom = new ChatRoom();
        var user1 = new TestUser("User1", chatRoom);

        chatRoom.RegisterUser(user1);

        // Act
        user1.Send("Message to self");

        // Assert
        user1.LastReceivedMessage.Should().BeNull(); 
    }
}