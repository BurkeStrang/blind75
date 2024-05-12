namespace Blind75.Backtracking;

public class CombinationSumIITests
{
    [Fact]
    public void Example1()
    {
        int[] candidates = [10, 1, 2, 7, 6, 1, 5];
        int target = 8;
        IList<IList<int>> expected = new List<IList<int>>
        {
            new List<int> { 1, 1, 6 },
            new List<int> { 1, 2, 5 },
            new List<int> { 1, 7 },
            new List<int> { 2, 6 }
        };
        IList<IList<int>> actual = CombinationSumII.CombinationSum2(candidates, target);
        Assert.True(expected.SequenceEqual(actual, new ListComparer()));
    }
    [Fact]
    public void Example2()
    {
        int[] candidates = [2, 5, 2, 1, 2];
        int target = 5;
        IList<IList<int>> expected = new List<IList<int>>
        {
            new List<int> { 1, 2, 2 },
            new List<int> { 5 }
        };
        IList<IList<int>> actual = CombinationSumII.CombinationSum2(candidates, target);
        Assert.True(expected.SequenceEqual(actual, new ListComparer()));
    }
}
