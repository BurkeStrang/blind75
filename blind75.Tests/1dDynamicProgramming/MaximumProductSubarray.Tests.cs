public class MaximumProductSubarrayTests
{
    [Theory]
    [InlineData(new[] { 2, 3, -2, 4 }, 6)]
    public void MaxProduct_ShouldReturnLargestProduct(int[] nums, int expected)
    {
        // Arrange
        // Act
        int result = MaximumProductSubarray.MaxProduct(nums);
        // Assert
        Assert.Equal(expected, result);
    }
}
