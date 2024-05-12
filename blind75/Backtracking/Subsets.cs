namespace Blind75.Backtracking;

/*

Given an integer array nums of unique elements, return all possible subsets (the power set).
The solution set must not contain duplicate subsets. Return the solution in any order.

Example 1:
Input: nums = [1,2,3]
Output: [[],[1],[2],[1,2],[3],[1,3],[2,3],[1,2,3]]

Example 2:
Input: nums = [0]
Output: [[],[0]]

Constraints:
1 <= nums.length <= 10
-10 <= nums[i] <= 10
All the numbers of nums are unique.

*/

public class SubsetsClass
{
    private readonly List<int> _subset = [];
    private readonly List<IList<int>> _result = [];

    private void Backtrack(int i, int[] nums)
    {
        if (i >= nums.Length)
        {
            _result.Add(new List<int>(_subset));
            return;
        }
        _subset.Add(nums[i]);
        Backtrack(i + 1, nums);
        _subset.Remove(nums[i]);
        Backtrack(i + 1, nums);
    }

    public IList<IList<int>> Subsets(int[] nums)
    {
        Backtrack(0, nums);
        return _result;
    }
}
