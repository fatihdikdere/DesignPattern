namespace Mediator.Test;
public class TestUser(string name, IChatRoomMediator chatRoom) : User(name, chatRoom)
{
    public string LastReceivedMessage { get; private set; }
    public override void Send(string message)
    {
        chatRoom.SendMessage(this, message);
    }
    public override void Receive(string message)
    {
        LastReceivedMessage = message;
    }
}
