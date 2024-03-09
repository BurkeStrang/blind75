public class JumpGameTests
{
    [Fact]
    public void CanJumpWhenCalledReturnsTrueIfCanReachLastIndex()
    {
        // Arrange
        int[] nums = { 2, 3, 1, 1, 4 };
        // Act
        bool result = JumpGame.CanJump(nums);
        // Assert
        Assert.True(result);
    }

    [Fact]
    public void CanJumpWhenCalledReturnsFalseIfCannotReachLastIndex()
    {
        // Arrange
        int[] nums = { 3, 2, 1, 0, 4 };
        // Act
        bool result = JumpGame.CanJump(nums);
        // Assert
        Assert.False(result);
    }
}
