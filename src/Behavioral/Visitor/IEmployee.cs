namespace Visitor;
/// <summary>
/// Element interface
/// </summary>
public interface IEmployee
{
    void Accept(IReviewVisitor visitor);
}
