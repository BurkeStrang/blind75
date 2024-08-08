namespace Blind75.Tests.ArraysAndHashing;

public class NumberOfGoodPairsTests
{
    [Fact]
    public void Example1()
    {
        int[] nums = [1, 2, 3, 1, 1, 3];
        int expected = 4;
        Assert.Equal(expected, NumberOfGoodPairs.NumIdenticalPairs(nums));
    }
    [Fact]
    public void Example2()
    {
        int[] nums = [1, 1, 1, 1];
        int expected = 6;
        Assert.Equal(expected, NumberOfGoodPairs.NumIdenticalPairs(nums));
    }
    [Fact]
    public void Example3()
    {
        int[] nums = [1, 2, 3];
        int expected = 0;
        Assert.Equal(expected, NumberOfGoodPairs.NumIdenticalPairs(nums));
    }
}
