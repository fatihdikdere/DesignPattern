namespace Visitor;
/// <summary>
/// ConcreteElement class A
/// </summary>
/// <seealso cref="Visitor.IEmployee" />
public class Developer : IEmployee
{
    public void Accept(IReviewVisitor visitor)
    {
        visitor.Visit(this);
    }
}
