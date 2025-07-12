namespace Blind75.Tests.ArraysAndHashing;

public class SrtColorsTests
{
    [Fact]
    public void Example1()
    {
        // Arrange
        int[] nums = [2, 0, 2, 1, 1, 0];
        int[] expected = [0, 0, 1, 1, 2, 2];
        // Act
        SrtColors.SortColors(nums);
        // Assert
        nums.ShouldBeEquivalentTo(expected);
    }

    [Fact]
    public void Example2()
    {
        // Arrange
        int[] nums = [2, 0, 1];
        int[] expected = [0, 1, 2];
        // Act
        SrtColors.SortColors(nums);
        // Assert
        nums.ShouldBeEquivalentTo(expected);
    }
}
