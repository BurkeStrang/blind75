namespace Blind75.Backtracking;

/*

Given an integer array nums that may contain duplicates, return all possible subsets (the power set).
The solution set must not contain duplicate subsets. Return the solution in any order.

Example 1:
Input: nums = [1,2,2]
Output: [[],[1],[1,2],[1,2,2],[2],[2,2]]

Example 2:
Input: nums = [0]
Output: [[],[0]]

Constraints:

1 <= nums.length <= 10
-10 <= nums[i] <= 10

*/

public static class SubsetsII
{
    //T: O(N*2^N)
    public static IList<IList<int>> Subsets(int[] nums)
    {
        Array.Sort(nums);
        List<IList<int>> res = [];
        List<int> path = [];

        void Backtrack(int start)
        {
            res.Add([.. path]);
            for (int i = start; i < nums.Length; i++)
            {
                if (i > start && nums[i] == nums[i - 1])
                    continue;
                path.Add(nums[i]);
                Backtrack(i + 1);
                path.RemoveAt(path.Count - 1);
            }
        }
        Backtrack(0);
        return res;
    }
}
