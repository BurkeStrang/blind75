namespace Blind75.Tests.ArraysAndHashing;

public class SetMismatchTests
{
    [Fact]
    public void Example1()
    {
        // Arrange
        int[] nums = [1, 2, 2, 4];
        int[] expected = [2, 3];
        // Act
        int[] result = SetMismatch.FindErrorNums(nums);
        // Assert
        result.Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void Example2()
    {
        // Arrange
        int[] nums = [1, 1];
        int[] expected = [1, 2];
        // Act
        int[] result = SetMismatch.FindErrorNums(nums);
        // Assert
        result.Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void Example3()
    {
        // Arrange
        int[] nums = [3, 2, 3, 4, 6, 5];
        int[] expected = [3, 1];
        // Act
        int[] result = SetMismatch.FindErrorNums(nums);
        // Assert
        result.Should().BeEquivalentTo(expected);
    }
}
