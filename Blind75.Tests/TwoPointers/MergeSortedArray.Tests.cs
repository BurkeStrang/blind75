namespace Blind75.Tests.TwoPointers;

public class MergeSortedArrayTests
{
    [Fact]
    public void Example1()
    {
        // Arrange
        int[] nums1 = [1, 2, 3, 0, 0, 0];
        int m = 3;
        int[] nums2 = [2, 5, 6];
        int n = 3;
        int[] expected = [1, 2, 2, 3, 5, 6];
        // Act
        MergeSortedArray.Merge(nums1, m, nums2, n);
        // Assert
        nums1.ShouldBeEquivalentTo(expected);
    }

    [Fact]
    public void Example2()
    {
        // Arrange
        int[] nums1 = [1];
        int m = 1;
        int[] nums2 = [];
        int n = 0;
        int[] expected = [1];
        // Act
        MergeSortedArray.Merge(nums1, m, nums2, n);
        // Assert
        nums1.ShouldBeEquivalentTo(expected);
    }
}
