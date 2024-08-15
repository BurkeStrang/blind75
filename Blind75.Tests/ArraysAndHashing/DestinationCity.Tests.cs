namespace Blind75.Tests.ArraysAndHashing;

public class DestinationCityTests
{
    [Fact]
    public void Example1()
    {
        // Arrange
        IList<IList<string>> paths =
        [
            ["London", "New York"],
            ["New York", "Lima"],
            ["Lima", "Sao Paulo"]
        ];
        // Act
        string result = DestinationCity.DestCity(paths);
        // Assert
        result.Should().Be("Sao Paulo");
    }
    [Fact]
    public void Example2()
    {
        // Arrange
        IList<IList<string>> paths =
        [
            ["B", "C"],
            ["D", "B"],
            ["C", "A"]
        ];
        // Act
        string result = DestinationCity.DestCity(paths);
        // Assert
        result.Should().Be("A");
    }
    [Fact]
    public void Example3()
    {
        // Arrange
        IList<IList<string>> paths =
        [
            ["A", "Z"]
        ];
        // Act
        string result = DestinationCity.DestCity(paths);
        // Assert
        result.Should().Be("Z");
    }
}
