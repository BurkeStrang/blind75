namespace Blind75.Tests.Greedy;

public class JumpGameIITests
{
    [Fact]
    public void Example1()
    {
        // Arrange
        int[] nums = [2, 3, 1, 1, 4];
        int expected = 2;
        // Act
        int actual = JumpGameII.Jump(nums);
        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Example2()
    {
        // Arrange
        int[] nums = [2, 3, 0, 1, 4];
        int expected = 2;
        // Act
        int actual = JumpGameII.Jump(nums);
        // Assert
        Assert.Equal(expected, actual);
    }
}
