namespace Blind75.Tests.ArraysAndHashing;

public class FindDisappeardInArrayTests
{
    [Fact]
    public void Example1()
    {
        int[] nums = [4, 3, 2, 7, 8, 2, 3, 1];
        int[] expected = [5, 6];
        Assert.Equal(expected, FindDisappeardInArray.FindDisappearedNumbers(nums));
    }
    [Fact]
    public void Example()
    {
        int[] nums = [1, 1];
        int[] expected = [2];
        Assert.Equal(expected, FindDisappeardInArray.FindDisappearedNumbers(nums));
    }
}
