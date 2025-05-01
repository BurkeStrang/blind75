namespace Blind75.Tests.Greedy;

public class JumpGameTests
{
    [Fact]
    public void Example1()
    {
        // Arrange
        int[] nums = [2, 3, 1, 1, 4];
        // Act
        bool result = JumpGame.CanJump(nums);
        // Assert
        Assert.True(result);
    }

    [Fact]
    public void Example2()
    {
        // Arrange
        int[] nums = [3, 2, 1, 0, 4];
        // Act
        bool result = JumpGame.CanJump(nums);
        // Assert
        Assert.False(result);
    }
}
