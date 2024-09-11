namespace Prototype;
/// <summary>
/// Prototype abstract class
/// </summary>
/// <seealso cref="Prototype.IGameCharacter" />
public abstract class GameCharacter(string name, string description) : IGameCharacter
{
    public string Name { get; set; } = name;
    public string Description { get; set; } = description;
    public abstract IGameCharacter Clone();
    public virtual string GetDetail()
    {
        return $"Name: {Name} - Description: {Description}";
    }
}
