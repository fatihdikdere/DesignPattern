namespace State;
/// <summary>
/// ConcreteState class
/// </summary>
/// <seealso cref="State.ITrafficLightState" />
public class GreenState : ITrafficLightState
{
    public void ChangeLight(TrafficLightContext context)
    {
        Console.WriteLine("Light");

        context.SetState(new YellowState());
    }
}