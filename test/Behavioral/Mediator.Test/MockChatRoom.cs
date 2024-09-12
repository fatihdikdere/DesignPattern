namespace Mediator.Test;
public class MockChatRoom : IChatRoomMediator
{
    public User LastSender { get; private set; }
    public string LastMessage { get; private set; }
    public void RegisterUser(User user)
    {

    }
    public void SendMessage(User sender, string message)
    {
        LastSender = sender;
        LastMessage = message;
    }
}
