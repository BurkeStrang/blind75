namespace Blind75.DynamicProgramming;

public class BurstBalloonsTests
{
    [Theory]
    [InlineData(new int[] { 3, 1, 5, 8 }, 167)]
    [InlineData(new int[] { 1, 5 }, 10)]
    public void MaxCoins_ShouldPass(int[] nums, int expected)
    {
        // Arrange
        // Act
        int actual = BurstBalloons.MaxCoins(nums);
        // Assert
        Assert.Equal(expected, actual);
    }
}
