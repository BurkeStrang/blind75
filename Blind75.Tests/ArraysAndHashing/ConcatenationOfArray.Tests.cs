namespace Blind75.Tests.ArraysAndHashing;

public class ConcetenationOfArrayTests
{
    [Fact]
    public void Example1()
    {
        // Arrange
        int[] nums = [1, 2, 1];
        int[] expected = [1, 2, 1, 1, 2, 1];
        // Act
        int[] actual = ConcatenationOfArray.GetConcatenation(nums);
        // Assert
        actual.Should().BeEquivalentTo(expected);
    }
    [Fact]
    public void Example2()
    {
        // Arrange
        int[] nums = [1, 3, 2, 1];
        int[] expected = [1, 3, 2, 1, 1, 3, 2, 1];
        // Act
        int[] actual = ConcatenationOfArray.GetConcatenation(nums);
        // Assert
        actual.Should().BeEquivalentTo(expected);
    }
}
