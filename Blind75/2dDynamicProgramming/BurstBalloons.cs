namespace Blind75.DynamicProgramming;

/*

You are given n balloons, indexed from 0 to n - 1.
Each balloon is painted with a number on it represented by an array nums.
You are asked to burst all the balloons.
If you burst the ith balloon, you will get nums[i - 1] * nums[i] * nums[i + 1] coins.
If i - 1 or i + 1 goes out of bounds of the array, then treat it as if there is a balloon with a 1 painted on it.
Return the maximum coins you can collect by bursting the balloons wisely.

Example 1:
Input: nums = [3,1,5,8]
Output: 167
Explanation:
nums = [3,1,5,8] --> [3,5,8] --> [3,8] --> [8] --> []
coins =  3*1*5    +   3*5*8   +  1*3*8  + 1*8*1 = 167

Example 2:
Input: nums = [1,5]
Output: 10

Constraints:
n == nums.length
1 <= n <= 300
0 <= nums[i] <= 100

*/

public static class BurstBalloons
{
    // T: O(N^3) | S: O(N^2)
    public static int MaxCoins(int[] nums)
    {
        int n = nums.Length + 2;
        int[,] memo = new int[n, n];
        //Array.Fill(memo, -1);
        int[] arr = new int[n];
        arr[0] = 1;
        arr[^1] = 1;
        for (int i = 1; i < n - 1; i++)
            arr[i] = nums[i - 1];

        return MaxCoins(arr, memo, 1, n - 2);
    }

    private static int MaxCoins(int[] arr, int[,] memo, int start, int end)
    {
        if (start > end)
            return 0;

        if (memo[start, end] != 0)
            return memo[start, end];

        memo[start, end] = 0;
        for (var i = start; i < end + 1; i++)
        {
            var coins = arr[start - 1] * arr[i] * arr[end + 1];
            coins += MaxCoins(arr, memo, start, i - 1) + MaxCoins(arr, memo, i + 1, end);
            memo[start, end] = Math.Max(memo[start, end], coins);
        }

        return memo[start, end];
    }
}
