namespace FactoryMethod.Test;
public class PartTimeEmployeeTests
{
    [Fact]
    public void CreateFeeCalculator_WhenCalled_ShouldReturnPartTimeFeeCalculatorInstance()
    {
        // Arrange
        var partTimeEmployee = new PartTimeEmployee();

        // Act
        var feeCalculator = partTimeEmployee.CreateFeeCalculator();

        // Assert
        feeCalculator.Should().BeOfType<PartTimeFeeCalculator>();
    }
}
