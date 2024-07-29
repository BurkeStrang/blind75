namespace Blind75.ArraysAndHashing;

// Given an array of integers nums and an integer k, return the total number of subarrays whose sum equals to k.
// A subarray is a contiguous non-empty sequence of elements within an array.
//
// Example 1:
// Input: nums = [1,1,1], k = 2
// Output: 2
//
// Example 2:
// Input: nums = [1,2,3], k = 3
// Output: 2
//
// Constraints:
// 1 <= nums.length <= 2 * 104
// -1000 <= nums[i] <= 1000
// -107 <= k <= 107

public static class SubarraySumEqualsK
{
    public static int SubarraySum(int[] nums, int k)
    {
        int count = 0;
        int sum = 0;

        Dictionary<int, int> map = [];
        map.Add(0, 1);

        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            if (map.TryGetValue(sum - k, out int value))
                count += value;
            if (!map.TryAdd(sum, 1))
                map[sum]++;
        }
        return count;
    }
}
