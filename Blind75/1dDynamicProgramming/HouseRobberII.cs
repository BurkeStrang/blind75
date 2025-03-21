namespace Blind75.DynammicProgramming;

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
        return Max(
            nums[0],
            Max(
                GetMaxRobAmount(nums, 0, nums.Length - 1),
                GetMaxRobAmount(nums, 1, nums.Length)
            )
        );
    }

    public static int GetMaxRobAmount(int[] nums, int start, int end)
    {
        int rob1 = 0, rob2 = 0;

        for (int i = start; i < end; i++)
        {
            int temp = Max(nums[i] + rob1, rob2);
            rob1 = rob2;
            rob2 = temp;
        }

        return rob2;
    }
}

