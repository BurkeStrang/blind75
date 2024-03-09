/*
Given an integer array nums, find the subarray
with the largest sum, and return its sum.

Example 1:

Input: nums = [-2,1,-3,4,-1,2,1,-5,4]
Output: 6
Explanation: The subarray [4,-1,2,1] has the largest sum 6.
*/
namespace blind75.Greedy;

public static class MaximumSubarray
{
    public static int MaxSubArray(int[] nums)
    {
        int maxSum = nums[0];
        int currentSum = nums[0];
        foreach (int num in nums.Skip(1))
        {
            currentSum = Math.Max(num, currentSum + num);
            maxSum = Math.Max(maxSum, currentSum);
        }
        return maxSum;
    }
}
