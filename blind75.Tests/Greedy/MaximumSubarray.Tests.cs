public class MaximumSubarrayTests
{
    [Fact]
    public void CorrectMaxSubArray()
    {
        int[] nums = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
        int expected = 6;
        Assert.Equal(expected, MaximumSubarray.MaxSubArray(nums));
    }

    [Fact]
    public void CorrectMaxSubArray2()
    {
        int[] nums = { 1 };
        int expected = 1;
        Assert.Equal(expected, MaximumSubarray.MaxSubArray(nums));
    }

    [Fact]
    public void CorrectMaxSubArray3()
    {
        int[] nums = { 5, 4, -1, 7, 8 };
        int expected = 23;
        Assert.Equal(expected, MaximumSubarray.MaxSubArray(nums));
    }
}
