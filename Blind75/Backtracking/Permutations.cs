
namespace Blind75.Backtracking;

/*

Given an array nums of distinct integers, return all the possible permutations.
You can return the answer in any order.

Example 1:
Input: nums = [1,2,3]
Output: [[1,2,3],[1,3,2],[2,1,3],[2,3,1],[3,1,2],[3,2,1]]

Example 2:
Input: nums = [0,1]
Output: [[0,1],[1,0]]

Example 3:
Input: nums = [1]
Output: [[1]]

Constraints:

1 <= nums.length <= 6
-10 <= nums[i] <= 10
All the integers of nums are unique.

*/

public static class Permutations
{
    public static IList<IList<int>> Permute(int[] nums)
    {
        List<IList<int>> res = [];
        PermuteRecurse(res, nums, 0);
        return res;
    }

    private static void PermuteRecurse(List<IList<int>> res, int[] nums, int start)
    {
        if (start == nums.Length)
        {
            List<int> list = [.. nums.Select(t => t)];
            res.Add(list);
            return;
        }

        for (int i = start; i < nums.Length; i++)
        {
            (nums[start], nums[i]) = (nums[i], nums[start]);
            PermuteRecurse(res, nums, start + 1);
            (nums[start], nums[i]) = (nums[i], nums[start]);
        }
    }
}
