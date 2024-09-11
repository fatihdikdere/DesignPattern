namespace ChainOfResponsibility;
/// <summary>
/// Handler interface
/// </summary>
public interface ISupportHandler
{
    void SetNextSupportHandler(ISupportHandler supportHandler);
    void HandleRequest();
}
