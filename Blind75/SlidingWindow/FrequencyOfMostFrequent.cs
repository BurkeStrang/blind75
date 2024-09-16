namespace Blind75.SlidingWindow;

// The frequency of an element is the number of times it occurs in an array.
// You are given an integer array nums and an integer k.
// In one operation, you can choose an index of nums and increment the element at that index by 1.
// Return the maximum possible frequency of an element after performing at most k operations.
//
// Example 1:
// Input: nums = [1,2,4], k = 5
// Output: 3
// Explanation: Increment the first element three times and the second element two times to make nums = [4,4,4].
// 4 has a frequency of 3.
//
// Example 2:
// Input: nums = [1,4,8,13], k = 5
// Output: 2
// Explanation: There are multiple optimal solutions:
// - Increment the first element three times to make nums = [4,4,8,13]. 4 has a frequency of 2.
// - Increment the second element four times to make nums = [1,8,8,13]. 8 has a frequency of 2.
// - Increment the third element five times to make nums = [1,4,13,13]. 13 has a frequency of 2.
//
// Example 3:
// Input: nums = [3,9,6], k = 2
// Output: 1
//
// Constraints:
// 1 <= nums.length <= 105
// 1 <= nums[i] <= 105
// 1 <= k <= 105

public static class FrequencyOfMostFrequent
{
    public static int MaxFrequency(int[] nums, int k)
    {
        Array.Sort(nums);

        int maxFrequency = 0; // Maximum frequency of most frequent element
        int remainingDifference = 0; // The remaining difference that can be added to the elements
        int endIndex = nums.Length - 1; // The end index of the sliding window
        int startIndex = endIndex; // The start index of the sliding window

        while (startIndex >= 0)
        {
            int cost = nums[endIndex] - nums[startIndex]; // The cost to make all elements in the window equal

            if (remainingDifference + cost <= k)
            {
                remainingDifference += cost;
                maxFrequency = Math.Max(maxFrequency, endIndex - startIndex + 1); // Update the maximum frequency
                --startIndex; // Move the start index of the window
            }
            else
            {
                remainingDifference -= (endIndex - startIndex - 1) * (nums[endIndex] - nums[endIndex - 1]); // Update the remaining difference
                --endIndex; // Move the end index of the window
            }
        }
        return maxFrequency;
    }
}
