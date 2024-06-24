namespace Blind75.Tests.ArraysAndHashing;

public class TwoSumTests
{
    [Fact]
    public void ReturnsIndexesIfTargetSumFound()
    {
        int[] nums = [2, 7, 11, 15];
        int target = 9;
        int[] expected = [0, 1];
        Assert.Equal(expected, TwoSumClass.TwoSum(nums, target));
    }

    [Fact]
    public void ReturnsEmptyArrayIfTargetSumNotFound()
    {
        int[] nums = [2, 7, 11, 15];
        int target = 10;
        int[] expected = [];
        Assert.Equal(expected, TwoSumClass.TwoSum(nums, target));
    }

    [Fact]
    public void ReturnsEmptyArrayIfInputIsEmpty()
    {
        int[] nums = [];
        int target = 10;
        int[] expected = [];
        Assert.Equal(expected, TwoSumClass.TwoSum(nums, target));
    }

    [Fact]
    public void RetunsIndexesIfTargetSumFoundInNegativeNumbers()
    {
        int[] nums = [-1, -2, -3, -4, -5];
        int target = -8;
        int[] expected = [2, 4];
        Assert.Equal(expected, TwoSumClass.TwoSum(nums, target));
    }
}

