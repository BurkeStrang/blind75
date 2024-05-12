namespace Blind75.Backtracking;

public class CombinationSum
{
    [Fact]
    public void CombinationSumCorrect()
    {
        // Input: candidates = [2,3,6,7], target = 7
        // Output: [[2,2,3],[7]]
        // Explanation:
        // 2 and 3 are candidates, and 2 + 2 + 3 = 7. Note that 2 can be used multiple times.
        // 7 is a candidate, and 7 = 7.
        // These are the only two combinations.
        int[] candidates = [2, 3, 6, 7];
        int target = 7;
        List<List<int>> res = [[2, 2, 3], [7]];
        Assert.Equivalent(res, CombinationSumClass.CombinationSum(candidates, target));
    }
}
