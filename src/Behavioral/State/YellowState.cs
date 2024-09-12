namespace State;
/// <summary>
/// ConcreteState class
/// </summary>
/// <seealso cref="State.ITrafficLightState" />
public class YellowState : ITrafficLightState
{
    public void ChangeLight(TrafficLightContext context)
    {
        Console.WriteLine("Yellow");

        context.SetState(new RedState());
    }
}
