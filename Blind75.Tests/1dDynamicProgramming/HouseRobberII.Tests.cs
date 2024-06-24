namespace Blind75.DynamicProgramming;

public class HouseRobberIITests
{
    [Fact]
    public void Test1()
    {
        int[] nums = { 2, 3, 2 };
        Assert.Equal(3, HouseRobberII.Rob(nums));
    }
    [Fact]
    public void Test2()
    {
        int[] nums = { 1, 2, 3, 1 };
        Assert.Equal(4, HouseRobberII.Rob(nums));
    }
}
