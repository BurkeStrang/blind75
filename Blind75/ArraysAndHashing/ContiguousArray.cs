namespace Blind75.ArraysAndHashing;

// Given a binary array nums, return the maximum length of a contiguous subarray with an equal number of 0 and 1.
//
// Example 1:
// Input: nums = [0,1]
// Output: 2
// Explanation: [0, 1] is the longest contiguous subarray with an equal number of 0 and 1.
//
// Example 2:
// Input: nums = [0,1,0]
// Output: 2
// Explanation: [0, 1] (or [1, 0]) is a longest contiguous subarray with equal number of 0 and 1.
//
// Example 3:
// Input: nums = [0,1,1,0,1,1,1,0]
// Output: 4

public static class ContiguousArray
{
    public static int FindMaxLength(int[] nums)
    {
        Dictionary<int, int> dict = [];
        dict.Add(0,-1);
        int zeros = 0;
        int ones = 0;
        int max = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0)
                zeros++;
            else
                ones++;
            int diff = zeros - ones;
            if (dict.TryGetValue(diff, out int value))
                max = Math.Max(max, i - value);
            else
                dict.Add(diff, i);
        }

        return max;
    }
}
