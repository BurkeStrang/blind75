namespace Blind75.TwoPointers;

// Given an array nums of n integers,
// return an array of all the unique quadruplets
// [nums[a], nums[b], nums[c], nums[d]] such that:
//
// 0 <= a, b, c, d < n
// a, b, c, and d are distinct.
// nums[a] + nums[b] + nums[c] + nums[d] == target
// You may return the answer in any order.
//
// Example 1:
// Input: nums = [1,0,-1,0,-2,2], target = 0
// Output: [[-2,-1,1,2],[-2,0,0,2],[-1,0,0,1]]
//
// Example 2:
// Input: nums = [2,2,2,2,2], target = 8
// Output: [[2,2,2,2]]
//
// Constraints:
// 1 <= nums.length <= 200
// -109 <= nums[i] <= 109
// -109 <= target <= 109

public static class FourSumClass
{
    public static IList<IList<int>> FourSum(int[] nums, int target)
    {
        IList<IList<int>> ans = [];
        int n = nums.Length;
        Array.Sort(nums);
        for (int i = 0; i < n; i++)
        {
            if (i > 0 && nums[i - 1] == nums[i])
                continue;
            for (int j = i + 1; j < n; j++)
            {
                if (j > i + 1 && nums[j - 1] == nums[j])
                    continue;
                int k = j + 1;
                int l = n - 1;
                while (k < l)
                {
                    long sum = (long)nums[i] + nums[j] + nums[k] + nums[l];
                    if (sum > target)
                        l--;
                    else if (sum < target)
                        k++;
                    else
                    {
                        IList<int> temp = [nums[i], nums[j], nums[k], nums[l]];
                        ans.Add(temp);
                        k++;
                        l--;
                        while (k < l && nums[k] == nums[k - 1])
                            k++;
                        while (k < l && nums[l] == nums[l + 1])
                            l--;
                    }
                }
            }
        }
        return ans;
    }
}
