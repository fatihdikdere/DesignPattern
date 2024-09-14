namespace Decorator;
/// <summary>
/// ConcreteDecorator class B
/// </summary>
/// <seealso cref="Decorator.NotifierDecorator" />
public class PushNotifier(INotifier notifier) : NotifierDecorator(notifier)
{
    public override void Send(string message)
    {
        base.Send(message);
        Console.WriteLine("Sending push notification");
    }
}
