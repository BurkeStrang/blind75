namespace Blind75.Backtracking;

/*

Given a collection of candidate numbers (candidates) and a target number (target),
find all unique combinations in candidates where the candidate numbers sum to target.
Each number in candidates may only be used once in the combination.
Note: The solution set must not contain duplicate combinations.

Example 1:
Input: candidates = [10,1,2,7,6,1,5], target = 8
Output:
[
[1,1,6],
[1,2,5],
[1,7],
[2,6]
]

Example 2:
Input: candidates = [2,5,2,1,2], target = 5
Output:
[
[1,2,2],
[5]
]

Constraints:
1 <= candidates.length <= 100
1 <= candidates[i] <= 50
1 <= target <= 30

*/

public class CombinationSumII
{
    //T: O(2^T), where T is target
    public static IList<IList<int>> CombinationSum2(int[] candidates, int target)
    {
        List<IList<int>> result = [];
        Array.Sort(candidates);
        Dfs(0, new Stack<int>(), target, candidates, result);
        return result;
    }

    private static void Dfs(
        int pos,
        Stack<int> current,
        int target,
        int[] candidates,
        IList<IList<int>> result
    )
    {
        if (target == 0)
            result.Add([.. current]);
        if (target <= 0)
            return;

        int prev = -1;

        for (int i = pos; i < candidates.Length; i++)
        {
            if (candidates[i] == prev)
                continue;

            current.Push(candidates[i]);
            Dfs(i + 1, current, target - candidates[i], candidates, result);
            current.Pop();
            prev = candidates[i];
        }
    }
}
