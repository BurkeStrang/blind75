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

    public static List<List<int>> FindSubsets(int[] nums)
    {
        // sort the numbers to handle duplicates
        Array.Sort(nums);
        List<List<int>> subsets = [[]];
        int endIndex = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            int startIndex = 0;
            // if current and the previous elements are same, create new subsets only from the
            // subsets added in the previous step
            if (i > 0 && nums[i] == nums[i - 1])
                startIndex = endIndex + 1;
            endIndex = subsets.Count - 1;
            for (int j = startIndex; j <= endIndex; j++)
            {
                // create a new subset from the existing subset and add the current element to it
                List<int> set = [.. subsets[j]];
                set.Add(nums[i]);
                subsets.Add(set);
            }
        }
        return subsets;

    }
}
