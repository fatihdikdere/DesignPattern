namespace Facade;
/// <summary>
/// Facade class
/// Engines can be injected using DI
/// </summary>
public class HomeAutomationSystem(GraphicEngine graphicEngine, HeatingEngine heatingEngine, SecurityEngine securityEngine)
{
    private readonly GraphicEngine graphicEngine = graphicEngine;
    private readonly HeatingEngine heatingEngine = heatingEngine;
    private readonly SecurityEngine securityEngine = securityEngine;
    public bool IsHomeAbleToBeBuilt()
    {
        var graphicEngineResult = graphicEngine.IsGraphicEnough();

        if (!graphicEngineResult)
        {
            Console.WriteLine("GraphicEngine error");

            return false;
        }

        var heatingEngineResult = heatingEngine.IsHeatAverage();

        if (!heatingEngineResult)
        {
            Console.WriteLine("HeatingEngine error");

            return false;
        }

        var securityEngineResult = securityEngine.IsSystemHasVulnerability();

        if (securityEngineResult)
        {
            Console.WriteLine("SecurityEngine error");

            return false;
        }

        return true;
    }
}