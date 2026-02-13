
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

    public static List<List<int>> FindPermutations(int[] nums)
    {
        List<List<int>> result = [];
        Queue<List<int>> permutations = new();
        permutations.Enqueue([]);
        foreach (int currentNumber in nums)
        {
            // we will take all existing permutations and add the current number to create
            // new permutations
            int n = permutations.Count;
            for (int i = 0; i < n; i++)
            {
                List<int> oldPermutation = permutations.Dequeue();
                // create a new permutation by adding the current number at every position
                for (int j = 0; j <= oldPermutation.Count; j++)
                {
                    List<int> newPermutation = [.. oldPermutation];
                    newPermutation.Insert(j, currentNumber);
                    if (newPermutation.Count == nums.Length)
                        result.Add(newPermutation);
                    else
                        permutations.Enqueue(newPermutation);
                }
            }
        }
        return result;

    }
}
