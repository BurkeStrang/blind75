namespace Blind75.Tests.ArraysAndHashing;

public class IntersectionOfTwoArraysTests
{

    [Fact]
    public void Example1()
    {
        int[] nums1 = [4, 9, 5];
        int[] nums2 = [9, 4, 9, 8, 4];
        int[] expected = [9, 4];
        int[] result = IntersectionOfTwoArrays.Intersect(nums1, nums2);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Example2()
    {
        int[] nums1 = [1, 2, 2, 1];
        int[] nums2 = [2, 2];
        int[] expected = [2];
        int[] result = IntersectionOfTwoArrays.Intersect(nums1, nums2);
        Assert.Equal(expected, result );
    }


    [Fact]
    public void Example3()
    {
        int[] nums1 = [1, 2, 3, 4];
        int[] nums2 = [2, 3, 4, 5];
        int[] expected = [2, 3, 4];
        int[] result = IntersectionOfTwoArrays.Intersect(nums1, nums2);
        Assert.Equal(expected, result);

    }
}
