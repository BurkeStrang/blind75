namespace Blind75.Greedy;

public class JumpGameIITests
{
    [Theory]
    [InlineData(new int[] { 2, 3, 1, 1, 4 }, 2)]
    [InlineData(new int[] { 2, 3, 0, 1, 4 }, 2)]
    public void Jump_ShouldReturnMinimumNumberOfJumps(int[] nums, int expected)
    {
        // Arrange
        // Act
        int actual = JumpGameII.Jump(nums);
        // Assert
        Assert.Equal(expected, actual);
    }
}
