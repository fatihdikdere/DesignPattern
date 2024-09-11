namespace Prototype.Test;
public class TestCharacter(string name, string description) : GameCharacter(name, description)
{
    public override IGameCharacter Clone()
    {
        return (TestCharacter)MemberwiseClone();
    }
}