namespace Blind75.Tests.ArraysAndHashing;

public class PathCrossingTests
{
    [Theory]
    [InlineData("NES", false)]
    [InlineData("NESWW", true)]
    public void IsPathCrossing_ShouldReturnPathCrossing(string path, bool expected)
    {
        // Arrange
        // Act
        bool result = PathCrossing.IsPathCrossing(path);
        // Assert
        result.Should().Be(expected);
    }
}
