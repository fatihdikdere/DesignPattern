namespace Prototype;
/// <summary>
/// Prototype interface
/// </summary>
public interface IGameCharacter
{
    IGameCharacter Clone();
    string GetDetail();
}
