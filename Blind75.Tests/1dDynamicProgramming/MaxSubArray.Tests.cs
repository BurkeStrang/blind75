namespace Blind75.DynamicProgramming;

public class MaxSubArrayTests
{
    [Fact]
    public void Example1()
    {
        int[] nums = [-2, 1, -3, 4, -1, 2, 1, -5, 4];
        int expected = 6;
        int result = MaxSubArrayClass.MaxSubArray(nums);
        Assert.Equal(expected, result);
    }
    [Fact]
    public void Example2()
    {
        int[] nums = [1];
        int expected = 1;
        int result = MaxSubArrayClass.MaxSubArray(nums);
        Assert.Equal(expected, result);
    }
}
