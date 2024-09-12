namespace Mediator;
/// <summary>
/// Colleague abstract class
/// </summary>
public abstract class User(string name, IChatRoomMediator chatRoom)
{
    protected string name = name;
    protected IChatRoomMediator chatRoom = chatRoom;
    public abstract void Send(string message);
    public abstract void Receive(string message);
}