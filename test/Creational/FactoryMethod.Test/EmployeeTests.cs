namespace FactoryMethod;
public class EmployeeTests
{
    [Fact]
    public void FullTimeEmployee_WhenHoursWorkedIsProvided_ShouldReturnCorrectSalary()
    {
        // Arrange
        var fullTimeEmployee = new FullTimeEmployee();
        var hoursWorked = 40;
        decimal expectedSalary = 4000;

        // Act
        var result = fullTimeEmployee.CalculateSalary(hoursWorked);

        // Assert
        result.Should().Be(expectedSalary);
    }
    [Fact]
    public void PartTimeEmployee_WhenHoursWorkedIsProvided_ShouldReturnCorrectSalary()
    {
        // Arrange
        var partTimeEmployee = new PartTimeEmployee();
        var hoursWorked = 40;
        decimal expectedSalary = 2000;

        // Act
        var result = partTimeEmployee.CalculateSalary(hoursWorked);

        // Assert
        result.Should().Be(expectedSalary);
    }
}
