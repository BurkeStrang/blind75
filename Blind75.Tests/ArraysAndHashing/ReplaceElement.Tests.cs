namespace Blind75.Tests.ArraysAndHashing;

public class ReplaceElementTests
{
    [Fact]
    public void Example1()
    {
        // Arrange
        int[] arr = [17, 18, 5, 4, 6, 1];
        int[] expected = [18, 6, 6, 6, 1, -1];
        // Act
        int[] actual = ReplaceElement.ReplaceElements(arr);
        // Assert
        actual.Should().BeEquivalentTo(expected);
    }
    [Fact]
    public void Example2()
    {
        // Arrange
        int[] arr = [400];
        int[] expected = [-1];
        // Act
        int[] actual = ReplaceElement.ReplaceElements(arr);
        // Assert
        actual.Should().BeEquivalentTo(expected);
    }
}
