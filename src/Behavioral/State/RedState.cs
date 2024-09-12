namespace State;
/// <summary>
/// ConcreteState class
/// </summary>
/// <seealso cref="State.ITrafficLightState" />
public class RedState : ITrafficLightState
{
    public void ChangeLight(TrafficLightContext context)
    {
        Console.WriteLine("Red");

        context.SetState(new GreenState());
    }
}
