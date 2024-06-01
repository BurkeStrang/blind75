namespace Blind75.Backtracking;

public class CombinationSum
{
    [Fact]
    public void Example1()
    {
        int[] candidates = [2, 3, 6, 7];
        int target = 7;
        List<List<int>> res = [[2, 2, 3], [7]];
        Assert.Equivalent(res, CombinationSumClass.CombinationSum(candidates, target));
    }
    [Fact]
    public void Example2()
    {
        int[] candidates = [5, 6, 10, 15];
        int target = 30;
        List<List<int>> res = [[5, 10, 15]];
        Assert.Equivalent(res, CombinationSumClass.CombinationSum(candidates, target));
    }
}
