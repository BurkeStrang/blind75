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

public static class SubsetsClass
{
    public static IList<IList<int>> Subsets(int[] nums)
    {
        int totalSubsets = 1 << nums.Length; // 2^n subsets
        List<IList<int>> res = new(totalSubsets);
        int[] path = new int[nums.Length]; // Fixed-size array
        int pathLength = 0;

        void Backtrack(int start)
        {
            res.Add([.. path[..pathLength]]);
            // convert path to a list and add to result
            // only add elements up to pathLength
            for (int i = start; i < nums.Length; i++)
            {
                path[pathLength++] = nums[i]; // Add element and increment length
                Backtrack(i + 1);
                pathLength--; // Decrement length to backtrack
            }
        }

        Backtrack(0);
        return res;
    }
}
