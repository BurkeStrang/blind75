namespace Blind75.Tests.TwoPointers;

public class SortEvenOddParityTests
{
    [Fact]
    public void Example1()
    {
        int[] nums = [3, 1, 2, 4];
        int[] expected = [4, 2, 1, 3];
        int[] result = SortEvenOddParity.SortArrayByParity(nums);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Example2()
    {
        int[] nums = [0];
        int[] expected = [0];
        int[] result = SortEvenOddParity.SortArrayByParity(nums);
        Assert.Equal(expected, result);
    }
}
