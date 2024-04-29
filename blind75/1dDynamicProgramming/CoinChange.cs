namespace Blind75.DynammicProgramming;

// You are given an integer array coins representing coins of different denominations
// and an integer amount representing a total amount of money.
// Return the fewest number of coins that you need to make up that amount.
// If that amount of money cannot be made up by any combination of the coins, return -1.
// You may assume that you have an infinite number of each kind of coin.

// Example 1:

// Input: coins = [1,2,5], amount = 11
// Output: 3
// Explanation: 11 = 5 + 5 + 1

public static class CoinChangeClass
{
    public static int CoinChange(int[] coins, int amount)
    {
        int[] dp = new int[amount + 1];
        Array.Fill(dp, amount + 1);
        dp[0] = 0;
        for (int i = 1; i <= amount; i++)
        {
            for (int j = 0; j < coins.Length; j++)
            {
                // only if the coin is less than the amount
                if (coins[j] <= i)
                {
                    // this is the most important line
                    // dp[i - coins[j]] + 1
                    // this is the number of coins we need to make the amount
                    // +1 is the current coin we are using
                    dp[i] = Math.Min(dp[i], dp[i - coins[j]] + 1);
                }
            }
        }
        return dp[amount] > amount ? -1 : dp[amount];
    }
}
