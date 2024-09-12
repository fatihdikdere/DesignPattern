namespace Visitor;
/// <summary>
/// ConcreteElement class B 
/// </summary>
/// <seealso cref="Visitor.IEmployee" />
public class Manager : IEmployee
{
    public void Accept(IReviewVisitor visitor)
    {
        visitor.Visit(this);
    }
}
