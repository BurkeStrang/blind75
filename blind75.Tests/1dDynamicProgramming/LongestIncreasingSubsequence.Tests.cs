public class LongestIncreasingSubsequenceTests
{
    [Fact]
    public void LongestIncreasingSubsequenceWhenCalledReturnsLengthOfLongestIncreasingSubsequence()
    {
        // Arrange
        int[] nums = [10, 9, 2, 5, 3, 7, 101, 18];
        // Act
        int result = LongestIncreasingSubsequence.LengthOfLIS(nums);
        // Assert
        Assert.Equal(4, result);
    }
}
