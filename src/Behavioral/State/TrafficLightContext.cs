namespace State;
/// <summary>
/// Context class
/// </summary>
public class TrafficLightContext
{
    private ITrafficLightState state;
    public ITrafficLightState State => state;
    public TrafficLightContext()
    {
        state = new RedState();
    }
    public void SetState(ITrafficLightState state)
    {
        this.state = state;
    }
    public void ChangeLight()
    {
        state.ChangeLight(this);
    }
}
