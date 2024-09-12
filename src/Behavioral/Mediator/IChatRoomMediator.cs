namespace Mediator;
/// <summary>
/// Mediator interface
/// </summary>
public interface IChatRoomMediator
{
    void RegisterUser(User user);
    void SendMessage(User user, string message);
}
