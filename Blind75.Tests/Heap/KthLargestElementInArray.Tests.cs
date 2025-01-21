namespace Blind75.Tests.Heap;

public class KthLargestElementInArrayTests
{
    [Fact]
    public void Example1()
    {
        // Arrange
        int[] nums = [3, 2, 1, 5, 6, 4];
        int k = 2;
        // Act
        int result = KthLargestElementInArray.FindKthLargest(nums, k);
        // Assert
        Assert.Equal(5, result);
    }
    [Fact]
    public void Example2()
    {
        // Arrange
        int[] nums = [3, 2, 3, 1, 2, 4, 5, 5, 6];
        int k = 4;
        // Act
        int result = KthLargestElementInArray.FindKthLargest(nums, k);
        // Assert
        Assert.Equal(4, result);
    }
}
