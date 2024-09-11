namespace ChainOfResponsibility;
/// <summary>
/// Concrete handler class 2
/// </summary>
/// <seealso cref="ChainOfResponsibility.SupportHandler" />
public class ManagerSupport : SupportHandler
{
    /// <summary>
    /// Top level support.
    /// No need next handle.
    /// </summary>
    public override void HandleRequest()
    {
        Console.WriteLine("Handled by manager");
    }
}
