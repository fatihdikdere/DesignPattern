namespace ChainOfResponsibility;
/// <summary>
/// Handler abstract class
/// </summary>
/// <seealso cref="ChainOfResponsibility.ISupportHandler" />
public abstract class SupportHandler : ISupportHandler
{
    protected ISupportHandler nextHandler;
    public void SetNextSupportHandler(ISupportHandler supportHandler)
    {
        nextHandler = supportHandler;
    }
    public abstract void HandleRequest();
}
