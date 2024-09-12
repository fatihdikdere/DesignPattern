namespace Mediator;
/// <summary>
/// ConcreteMediator class
/// </summary>
/// <seealso cref="Mediator.IChatRoomMediator" />
public class ChatRoom : IChatRoomMediator
{
    private readonly List<User> users = [];
    public IReadOnlyCollection<User> Users => users;
    public void RegisterUser(User user)
    {
        users.Add(user);
    }
    public void SendMessage(User sender, string message)
    {
        foreach (var user in users)
        {
            if (user != sender)
            {
                user.Receive(message);
            }
        }
    }
}
