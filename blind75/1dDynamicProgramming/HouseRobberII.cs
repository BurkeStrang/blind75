// You are a professional robber planning to rob houses along a street.
// Each house has a certain amount of money stashed.
// All houses at this place are arranged in a circle.
// That means the first house is the neighbor of the last one.
// Meanwhile, adjacent houses have a security system connected,
// and it will automatically contact the police if two adjacent houses were broken into on the same night.

// Given an integer array nums representing the amount of money of each house,
// return the maximum amount of money you can rob tonight without alerting the police.

// Example 1:

// Input: nums = [2,3,2]
// Output: 3
// Explanation: You cannot rob house 1 (money = 2) and then rob house 3 (money = 2), because they are adjacent houses.

public static class HouseRobberII
{
    public static int Rob(int[] nums)
    {
        if (nums.Length == 1)
        {
            return nums[0];
        }
        return Math.Max(Rob(nums, 0, nums.Length - 2), Rob(nums, 1, nums.Length - 1));
    }
    private static int Rob(int[] nums, int start, int end)
    {
        int prev = 0;
        int curr = 0;
        for (int i = start; i <= end; i++)
        {
            int temp = Math.Max(prev + nums[i], curr);
            prev = curr;
            curr = temp;
        }
        return curr;
    }
}
