namespace State;
/// <summary>
/// State interface
/// </summary>
public interface ITrafficLightState
{
    void ChangeLight(TrafficLightContext context);
}
