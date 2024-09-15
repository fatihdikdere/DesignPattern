namespace Facade.Test;
public class SecurityEngineTests
{
    [Fact]
    public void IsSystemHasVulnerability_WhenCalled_ShouldReturnFalse()
    {
        // Arrange
        var securityEngine = new SecurityEngine();

        // Act
        var result = securityEngine.IsSystemHasVulnerability();

        // Assert
        result.Should().BeFalse();
    }
}
