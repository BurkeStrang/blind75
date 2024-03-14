namespace blind75.TwoPointers;

/*

Given an integer array nums, return all the triplets [nums[i], nums[j], nums[k]]
such that i != j, i != k, and j != k, and nums[i] + nums[j] + nums[k] == 0.

Notice that the solution set must not contain duplicate triplets.

Example :

Input: nums = [-1,0,1,2,-1,-4]
Output: [[-1,-1,2],[-1,0,1]]
Explanation:
nums[0] + nums[1] + nums[2] = (-1) + 0 + 1 = 0.
nums[1] + nums[2] + nums[4] = 0 + 1 + (-1) = 0.
nums[0] + nums[3] + nums[4] = (-1) + 2 + (-1) = 0.
The distinct triplets are [-1,0,1] and [-1,-1,2].
Notice that the order of the output and the order of the triplets does not matter.

*/

public static class ThreeSumClass
{
    public static IList<IList<int>> ThreeSum(int[] nums)
    {
        var res = new List<IList<int>>();

        Array.Sort(nums);

        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (i == 0 || nums[i - 1] != nums[i])
                TwoSum(nums, i, res);
        }
        return res;
    }

    private static void TwoSum(int[] nums, int i, List<IList<int>> res)
    {
        HashSet<int> set = new();

        for (int j = i + 1; j < nums.Length; j++)
        {
            var complement = -nums[i] - nums[j];
            if (set.Contains(complement))
            {
                res.Add(new List<int> { nums[i], nums[j], complement });
                while (j + 1 < nums.Length && nums[j] == nums[j + 1])
                    ++j;
            }
            set.Add(nums[j]);
        }
    }
}
