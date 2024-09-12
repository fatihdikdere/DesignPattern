namespace Visitor;
/// <summary>
/// Visitor interface
/// </summary>
public interface IReviewVisitor
{
    void Visit(Developer developer);
    void Visit(Manager manager);
}
