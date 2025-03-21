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
        List<IList<int>> list = [];
        Array.Sort(nums);
        BackTrack(list, [], nums, 0);
        return list;
    }

    private static void BackTrack(List<IList<int>> list, List<int> curr, int[] nums, int start)
    {
        list.Add([.. curr]);
        for (int i = start; i < nums.Length; i++)
        {
            if (i > start && nums[i] == nums[i - 1])
                continue;
            curr.Add(nums[i]);
            BackTrack(list, curr, nums, i + 1);
            curr.RemoveAt(curr.Count - 1);
        }
    }
}
