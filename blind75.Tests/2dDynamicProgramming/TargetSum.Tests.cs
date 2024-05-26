namespace Blind75.DynamicProgramming;

public class TargetSumTests
{
    [Fact]
    public void Example1()
    {
        // Arrange
        int[] nums = [1, 1, 1, 1, 1];
        int target = 3;
        int expected = 5;
        // Act
        int actual = TargetSum.FindTargetSumWays(nums, target);
        // Assert
        Assert.Equal(expected, actual);
    }
    [Fact]
    public void Example2()
    {
        // Arrange
        int[] nums = [1];
        int target = 1;
        int expected = 1;
        // Act
        int actual = TargetSum.FindTargetSumWays(nums, target);
        // Assert
        Assert.Equal(expected, actual);
    }
}
