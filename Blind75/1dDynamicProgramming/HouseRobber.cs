namespace Blind75.DynammicProgramming;

// You are a professional robber planning to rob houses along a street.
// Each house has a certain amount of money stashed,
// the only constraint stopping you from robbing each of them is that adjacent houses
// have security systems connected and it will automatically contact
// the police if two adjacent houses were broken into on the same night.

// Given an integer array nums representing the amount of money of each house,
// return the maximum amount of money you can rob tonight without alerting the police.

// Example 1:

// Input: nums = [1,2,3,1]
// Output: 4
// Explanation: Rob house 1 (money = 1) and then rob house 3 (money = 3).
// Total amount you can rob = 1 + 3 = 4.

public static class HouseRobber
{
    public static int Rob(int[] nums)
    {
        int rob1 = 0, rob2 = 0;


        // Loop through the array of houses
        foreach (int num in nums)
        {
            // Get the max amount of money you can rob
            int temp = Math.Max(num + rob1, rob2);
            rob1 = rob2;
            rob2 = temp;
        }

        return rob2;
    }
}
// Walkthrough:
// We can solve this problem using dynamic programming.
// We will use two variables to keep track of the maximum amount of money we can rob.
// We will loop through the array of houses and for each house, we will calculate the maximum amount of money we can rob.
// We will then return the maximum amount of money we can rob.
// Space complexity: O(1)
// Time complexity: O(n)
// example foreach loop:
// rob1 = 0, rob2 = 0
// num = 1, temp = Max(num + 0, 0) = 1, rob1 = 0, rob2 = 1
// num = 2, temp = Max(num + 0, 1) = 2, rob1 = 1, rob2 = 2
// num = 3, temp = Max(num + 1, 2) = 4, rob1 = 2, rob2 = 4
// num = 1, temp = Max(num + 2, 4) = 4, rob1 = 4, rob2 = 4
// return rob2 = 4
