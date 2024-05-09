namespace Blind75.BinarySearch;

public class BinarySearchTests
{
    [Fact]
    public void Example1()
    {
        // Arrange
        int[] nums = { -1, 0, 3, 5, 9, 12 };
        int target = 9;
        // Act
        int result = BinarySearch.Search(nums, target);
        // Assert
        Assert.Equal(4, result);
    }
    [Fact]
    public void Example2()
    {
        // Arrange
        int[] nums = { -1, 0, 3, 5, 9, 12 };
        int target = 2;
        // Act
        int result = BinarySearch.Search(nums, target);
        // Assert
        Assert.Equal(-1, result);
    }
}
