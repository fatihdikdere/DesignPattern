namespace Decorator;
/// <summary>
/// Decorator abstract class
/// </summary>
/// <seealso cref="Decorator.INotifier" />
public abstract class NotifierDecorator(INotifier notifier) : INotifier
{
    private readonly INotifier notifier = notifier;
    public virtual void Send(string message)
    {
        notifier.Send(message);
    }
}
