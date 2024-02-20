public class TwoSumTests
{
    [Fact]
    public void ReturnsIndexesIfTargetSumFound()
    {
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;
        int[] expected = { 0, 1 };
        Assert.Equal(expected, TwoSumClass.TwoSum(nums, target));
    }

    [Fact]
    public void ReturnsEmptyArrayIfTargetSumNotFound()
    {
        int[] nums = { 2, 7, 11, 15 };
        int target = 10;
        int[] expected = Array.Empty<int>();
        Assert.Equal(expected, TwoSumClass.TwoSum(nums, target));
    }
}

