namespace Blind75.DynammicProgramming;

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

        // go through the array from right to left
        // the first j will not be evaluated since it is greater than the length of the array
        // and compare the current element with the next elements
        // if the current element is less than the next element
        // then the current element is part of the increasing subsequence
        // and the length of the increasing subsequence is 1 + the length of the next element
        // if the current element is greater than the next element
        // then the current element is not part of the increasing subsequence
        // and the length of the increasing subsequence is the length of the next element
        // keep track of the maximum length of the increasing subsequence
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                //Console.WriteLine($"i: {i}, j: {j}, nums[i]: {nums[i]}, nums[j]: {nums[j]}, dp[i]: {dp[i]}, dp[j]: {dp[j]}");
                if (nums[i] < nums[j])
                {
                    dp[i] = Math.Max(dp[i], 1 + dp[j]);
                }
            }
        }
        return dp.Max();
    }
}
