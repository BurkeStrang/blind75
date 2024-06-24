namespace Blind75.BinarySearch;

public class MedianOfTwoSortedArraysTests
{
    [Fact]
    public void Example1()
    {
        // Arrange
        int[] nums1 = { 1, 3 };
        int[] nums2 = { 2 };
        // Act
        double result = MedianOfTwoSortedArrays.FindMedianSortedArrays(nums1, nums2);
        // Assert
        Assert.Equal(2.00000, result);
    }
    [Fact]
    public void Example2()
    {
        // Arrange
        int[] nums1 = { 1, 2 };
        int[] nums2 = { 3, 4 };
        // Act
        double result = MedianOfTwoSortedArrays.FindMedianSortedArrays(nums1, nums2);
        // Assert
        Assert.Equal(2.50000, result);
    }
    [Fact]
    public void Example3()
    {
        // Arrange
        int[] nums1 = { 0, 0 };
        int[] nums2 = { 0, 0 };
        // Act
        double result = MedianOfTwoSortedArrays.FindMedianSortedArrays(nums1, nums2);
        // Assert
        Assert.Equal(0.00000, result);
    }
}
