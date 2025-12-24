namespace Blind75.Tests.TwoPointers;

public class LongestSubArrayTests
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 7, 5 }, 12, new int[] { 2, 3, 7 })]
    [InlineData(new int[] { 1, 2, 3, 4, 5 }, 9, new int[] { 2, 3, 4 })]
    [InlineData(new int[] { 1, 2, 3, 4, 5 }, 15, new int[] { 1, 2, 3, 4, 5 })]
    [InlineData(new int[] { 1, 2, 3, 4, 5 }, 100, new int[] { })]
    [InlineData(new int[] { 5, 1, 2, 3, 4 }, 6, new int[] { 1, 2, 3 })]
    [InlineData(new int[] { 1, 1, 1, 1, 1 }, 2, new int[] { 1, 1 })]
    [InlineData(new int[] { }, 0, new int[] { })]
    public void GetLongestSubarray_ReturnsExpected(int[] array, int k, int[] expected)
    {
        List<int> result = LongestSubArray.GetLongestSubarray(array, k);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void GetLongestSubarray_MultiplePossible_ReturnsFirst()
    {
        int[] array = [1, 2, 3, 2, 3, 2, 3];
        int k = 5;
        List<int> result = LongestSubArray.GetLongestSubarray(array, k);
        Assert.Equal([2, 3], result);
    }
}
