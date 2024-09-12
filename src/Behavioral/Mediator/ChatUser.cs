namespace Mediator;
/// <summary>
/// ConcreteColleague class
/// </summary>
/// <seealso cref="Mediator.User" />
public class ChatUser(string name, IChatRoomMediator chatRoom) : User(name, chatRoom)
{
    public override void Send(string message)
    {
        Console.WriteLine($"{name} sent message: {message}");
        chatRoom.SendMessage(this, message);
    }
    public override void Receive(string message)
    {
        Console.WriteLine($"{name} received message: {message}");
    }
}
