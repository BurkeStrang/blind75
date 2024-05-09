namespace Blind75.SlidingWindow;


public class SlidingWindowMaximumTests
{
    [Fact]
    public void ReturnsMaximumSlidingWindow()
    {
        int[] nums = { 1, 3, -1, -3, 5, 3, 6, 7 };
        int k = 3;
        int[] expected = { 3, 3, 5, 5, 6, 7 };
        int[] result = SlidingWindowMaximum.MaxSlidingWindow(nums, k);
        Assert.Equal(expected, result);
    }
    [Fact]
    public void ReturnsMaximumSlidingWindow2()
    {
        int[] nums = { 1 };
        int k = 1;
        int[] expected = { 1 };
        int[] result = SlidingWindowMaximum.MaxSlidingWindow(nums, k);
        Assert.Equal(expected, result);
    }
}
