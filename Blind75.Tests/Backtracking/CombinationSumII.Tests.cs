namespace Blind75.Tests.Backtracking;

public class CombinationSumIITests
{
    [Fact]
    public void Example1()
    {
        int[] candidates = [10, 1, 2, 7, 6, 1, 5];
        int target = 8;
        ListComparer<int> listComparer = new();
        IList<IList<int>> expected =
        [
            [1, 1, 6],
            [1, 2, 5],
            [1, 7],
            [2, 6]
        ];
        IList<IList<int>> actual = CombinationSumII.CombinationSum2(candidates, target);
        Assert.True(expected.SequenceEqual(actual, listComparer));
    }
    [Fact]
    public void Example2()
    {
        int[] candidates = [2, 5, 2, 1, 2];
        int target = 5;
        ListComparer<int> listComparer = new();
        IList<IList<int>> expected =
        [
            [1, 2, 2],
            [5]
        ];
        IList<IList<int>> actual = CombinationSumII.CombinationSum2(candidates, target);
        Assert.True(expected.SequenceEqual(actual, listComparer));
    }
}
