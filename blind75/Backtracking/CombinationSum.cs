namespace Blind75.Backtracking;

// Given an array of distinct integers candidates and a target integer target,
// return a list of all unique combinations of candidates where the chosen numbers sum to target.
// You may return the combinations in any order.

// The same number may be chosen from candidates an unlimited number of times.
// Two combinations are unique if the frequency of at least one of the chosen numbers is different.

// The test cases are generated such that the number of unique combinations that sum up to target
// is less than 150 combinations for the given input.


// Example 1:

// Input: candidates = [2,3,6,7], target = 7
// Output: [[2,2,3],[7]]
// Explanation:
// 2 and 3 are candidates, and 2 + 2 + 3 = 7. Note that 2 can be used multiple times.
// 7 is a candidate, and 7 = 7.
// These are the only two combinations.

public static class CombinationSumClass
{
    public static IList<IList<int>> CombinationSum(int[] candidates, int target)
    {
        IList<IList<int>> ans = new List<IList<int>>();
        Backtrack(new List<int>(), 0, 0, ans, candidates, target);
        return ans;
    }

    public static void Backtrack(
        IList<int> path,
        int start,
        int curr,
        IList<IList<int>> ans,
        int[] candidates,
        int target
    )
    {
        if (curr == target)
        {
            ans.Add(path.ToList());
            return;
        }

        for (int i = start; i < candidates.Length; i++)
        {
            int num = candidates[i];
            if (curr + num <= target)
            {
                path.Add(num);
                Backtrack(path, i, curr + num, ans, candidates, target);
                path.Remove(path.Last());
            }
        }
    }
}
