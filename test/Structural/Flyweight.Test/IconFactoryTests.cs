namespace Flyweight.Test;
public class IconFactoryTests
{
    [Fact]
    public void GetIcon_WhenIconTypeDoesNotExist_ShouldCreateAndReturnNewIcon()
    {
        // Arrange
        var iconFactory = new IconFactory();

        // Act
        var icon = iconFactory.GetIcon("Text File");

        // Assert
        icon.Should().NotBeNull();
        icon.Should().BeOfType<Icon>();
    }

    [Fact]
    public void GetIcon_WhenIconTypeAlreadyExists_ShouldReturnExistingIcon()
    {
        // Arrange
        var iconFactory = new IconFactory();
        var firstIcon = iconFactory.GetIcon("Text File");

        // Act
        var secondIcon = iconFactory.GetIcon("Text File");

        // Assert
        secondIcon.Should().BeSameAs(firstIcon);
    }

    [Fact]
    public void GetIcon_WhenMultipleIconTypesExist_ShouldReturnCorrectIcons()
    {
        // Arrange
        var iconFactory = new IconFactory();
        var textIcon = iconFactory.GetIcon("Text File");
        var imageIcon = iconFactory.GetIcon("Image File");

        // Act
        var retrievedTextIcon = iconFactory.GetIcon("Text File");
        var retrievedImageIcon = iconFactory.GetIcon("Image File");

        // Assert
        retrievedTextIcon.Should().BeSameAs(textIcon);
        retrievedImageIcon.Should().BeSameAs(imageIcon);
    }
}
