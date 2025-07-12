namespace Blind75.Tests.ArraysAndHashing;

public class NextGreaterElement1Tests
{
    [Fact]
    public void Example1()
    {
        // Arrange
        int[] nums1 = [4, 1, 2];
        int[] nums2 = [1, 3, 4, 2];
        int[] expected = [-1, 3, -1];
        // Act
        int[] actual = NextGreater.NextGreaterElement(nums1, nums2);
        // Assert
        actual.ShouldBeEquivalentTo(expected);
    }
    [Fact]
    public void Example2()
    {
        // Arrange
        int[] nums1 = [2, 4];
        int[] nums2 = [1, 2, 3, 4];
        int[] expected = [3, -1];
        // Act
        int[] actual = NextGreater.NextGreaterElement(nums1, nums2);
        // Assert
        actual.ShouldBeEquivalentTo(expected);
    }
}
