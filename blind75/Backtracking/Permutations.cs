
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
        List<IList<int>> result = [];
        PermuteRecurse(result, nums, 0);
        return result;
    }

    private static void PermuteRecurse(List<IList<int>> res, int[] arr, int start)
    {
        if (start == arr.Length)
        {
            List<int> list = arr.Select(t => t).ToList();
            res.Add(list);
            return;
        }

        for (int i = start; i < arr.Length; i++)
        {
            (arr[start], arr[i]) = (arr[i], arr[start]);
            PermuteRecurse(res, arr, start + 1);
            (arr[start], arr[i]) = (arr[i], arr[start]);
        }
    }
}
