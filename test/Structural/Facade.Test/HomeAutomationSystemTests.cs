namespace Facade.Test;
public class HomeAutomationSystemTests
{
    [Fact]
    public void IsHomeAbleToBeBuilt_WhenAllEnginesPass_ShouldReturnTrue()
    {
        // Arrange
        var graphicEngineMock = new Mock<GraphicEngine>();
        var heatingEngineMock = new Mock<HeatingEngine>();
        var securityEngineMock = new Mock<SecurityEngine>();

        graphicEngineMock.Setup(g => g.IsGraphicEnough()).Returns(true);
        heatingEngineMock.Setup(h => h.IsHeatAverage()).Returns(true);
        securityEngineMock.Setup(s => s.IsSystemHasVulnerability()).Returns(false);

        var homeAutomationSystem = new HomeAutomationSystem(
            graphicEngineMock.Object,
            heatingEngineMock.Object,
            securityEngineMock.Object
        );

        // Act
        var result = homeAutomationSystem.IsHomeAbleToBeBuilt();

        // Assert
        result.Should().BeTrue("Home is able to be built");
    }

    [Fact]
    public void IsHomeAbleToBeBuilt_WhenGraphicEngineFails_ShouldReturnFalse()
    {
        // Arrange
        var graphicEngineMock = new Mock<GraphicEngine>();
        var heatingEngineMock = new Mock<HeatingEngine>();
        var securityEngineMock = new Mock<SecurityEngine>();

        graphicEngineMock.Setup(g => g.IsGraphicEnough()).Returns(false);
        heatingEngineMock.Setup(h => h.IsHeatAverage()).Returns(true);
        securityEngineMock.Setup(s => s.IsSystemHasVulnerability()).Returns(false);

        var homeAutomationSystem = new HomeAutomationSystem(
            graphicEngineMock.Object,
            heatingEngineMock.Object,
            securityEngineMock.Object
        );

        // Act
        var result = homeAutomationSystem.IsHomeAbleToBeBuilt();

        // Assert
        result.Should().BeFalse("GraphicEngine error");
    }

    [Fact]
    public void IsHomeAbleToBeBuilt_WhemHeatingEngineFails_ShouldReturnFalse()
    {
        // Arrange
        var graphicEngineMock = new Mock<GraphicEngine>();
        var heatingEngineMock = new Mock<HeatingEngine>();
        var securityEngineMock = new Mock<SecurityEngine>();

        graphicEngineMock.Setup(g => g.IsGraphicEnough()).Returns(true);
        heatingEngineMock.Setup(h => h.IsHeatAverage()).Returns(false);
        securityEngineMock.Setup(s => s.IsSystemHasVulnerability()).Returns(false);

        var homeAutomationSystem = new HomeAutomationSystem(
            graphicEngineMock.Object,
            heatingEngineMock.Object,
            securityEngineMock.Object
        );

        // Act
        var result = homeAutomationSystem.IsHomeAbleToBeBuilt();

        // Assert
        result.Should().BeFalse("HeatingEngine error");
    }

    [Fact]
    public void IsHomeAbleToBeBuilt_WhenSecurityEngineFails_ShouldReturnFalse()
    {
        // Arrange
        var graphicEngineMock = new Mock<GraphicEngine>();
        var heatingEngineMock = new Mock<HeatingEngine>();
        var securityEngineMock = new Mock<SecurityEngine>();

        graphicEngineMock.Setup(g => g.IsGraphicEnough()).Returns(true);
        heatingEngineMock.Setup(h => h.IsHeatAverage()).Returns(true);
        securityEngineMock.Setup(s => s.IsSystemHasVulnerability()).Returns(true);

        var homeAutomationSystem = new HomeAutomationSystem(
            graphicEngineMock.Object,
            heatingEngineMock.Object,
            securityEngineMock.Object
        );

        // Act
        var result = homeAutomationSystem.IsHomeAbleToBeBuilt();

        // Assert
        result.Should().BeFalse("SecurityEngine error");
    }
}
