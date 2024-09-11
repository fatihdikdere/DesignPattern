namespace Prototype;
/// <summary>
/// ConcretePrototype class
/// </summary>
/// <seealso cref="Prototype.GameCharacter" />
public class Warrior(string name, string description) : GameCharacter(name, description)
{
    public override IGameCharacter Clone()
    {
        return (Warrior)MemberwiseClone();
    }
    public override string GetDetail()
    {
        return $"Warrior => Name: {Name} - Description: {Description}";
    }
}
