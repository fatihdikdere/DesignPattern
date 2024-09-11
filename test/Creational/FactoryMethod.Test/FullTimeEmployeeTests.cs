namespace FactoryMethod.Test;
public class FullTimeEmployeeTests
{
    [Fact]
    public void CreateFeeCalculator_WhenCalled_ShouldReturnFullTimeFeeCalculatorInstance()
    {
        // Arrange
        var fullTimeEmployee = new FullTimeEmployee();

        // Act
        var feeCalculator = fullTimeEmployee.CreateFeeCalculator();

        // Assert
        feeCalculator.Should().BeOfType<FullTimeFeeCalculator>();
    }
}
