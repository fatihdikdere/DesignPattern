namespace Facade;
/// <summary>
/// Subsystem for securities
/// </summary>
public class SecurityEngine : Engine
{
    public virtual bool IsSystemHasVulnerability()
    {
        Console.WriteLine("IsSystemHasVulnerability method was called");

        return false;
    }
}
