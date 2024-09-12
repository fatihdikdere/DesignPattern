using Visitor;

List<IEmployee> employees = [new Developer(), new Manager()];
IReviewVisitor reviewer = new PerformanceReviewer();

foreach (var employee in employees)
{
    employee.Accept(reviewer);
}

Console.ReadKey();