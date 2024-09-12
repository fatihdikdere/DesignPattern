namespace Visitor;
/// <summary>
/// ConcreteVisitor class
/// </summary>
/// <seealso cref="Visitor.IReviewVisitor" />
public class PerformanceReviewer : IReviewVisitor
{
    public void Visit(Developer developer)
    {
        Console.WriteLine("Reviewing developer performance.");
    }
    public void Visit(Manager manager)
    {
        Console.WriteLine("Reviewing manager performance.");
    }
}
