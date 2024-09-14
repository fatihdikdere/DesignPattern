namespace Decorator;
/// <summary>
/// ConcreteDecorator class A
/// </summary>
/// <seealso cref="Decorator.NotifierDecorator" />
public class SmsNotifier(INotifier notifier) : NotifierDecorator(notifier)
{
    public override void Send(string message)
    {
        base.Send(message);
        Console.WriteLine("Sending sms");
    }
}
