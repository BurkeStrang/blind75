namespace Blind75.DynammicProgramming;

public class PartitionEqualSubsetSumTests
{
    [Fact]
    public void Example1()
    {
        int[] nums = [1, 2, 3, 4];
        Assert.True(PartitionEqualSubsetSum.CanPartition(nums));
    }
    [Fact]
    public void Example2()
    {
        int[] nums = [1, 2, 3, 4, 5];
        Assert.False(PartitionEqualSubsetSum.CanPartition(nums));
    }
}


