namespace blind75.DynammicProgramming;

/*
Given an integer array nums, return the length of the longest strictly increasing subsequence

Example 1:

Input: nums = [10,9,2,5,3,7,101,18]
Output: 4
Explanation: The longest increasing subsequence is [2,3,7,101], therefore the length is 4. */

public static class LongestIncreasingSubsequence
{
    public static int LengthOfLIS(int[] nums)
    {
        int[] dp = new int[nums.Length];
        Array.Fill(dp, 1);

        for (int i = nums.Length - 1; i >= 0; i--)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] < nums[j])
                {
                    dp[i] = Math.Max(dp[i], 1 + dp[j]);
                }
            }
        }
        return dp.Max();
    }
}
