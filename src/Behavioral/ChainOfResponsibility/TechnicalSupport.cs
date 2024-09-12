namespace ChainOfResponsibility;
/// <summary>
/// Concrete handler class 1
/// </summary>
/// <seealso cref="ChainOfResponsibility.SupportHandler" />
public class TechnicalSupport : SupportHandler
{
    public override void HandleRequest()
    {
        Console.WriteLine("Couldn't handled by technical");

        nextHandler.HandleRequest();
    }
}
