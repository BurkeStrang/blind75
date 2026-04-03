
namespace Blind75.Tests.Backtracking;

public class CombinationTest
{
    [Fact]
    public void Example1()
    {
        int n = 4;
        int k = 2;
        List<List<int>> res = [[1, 2], [1, 3], [1, 4], [2, 3], [2, 4], [3, 4]];
        Assert.Equivalent(res, Combination.Combine(n, k));
    }
    [Fact]
    public void Example2()
    {
        int n = 1;
        int k = 1;
        List<List<int>> res = [[1]];
        Assert.Equivalent(res, Combination.Combine(n, k));
    }
}
