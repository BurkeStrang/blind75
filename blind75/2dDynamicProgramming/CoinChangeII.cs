namespace Blind75.DynamicProgramming;

/*

You are given an integer array coins representing coins of different denominations
and an integer amount representing a total amount of money.
Return the number of combinations that make up that amount.
If that amount of money cannot be made up by any combination of the coins, return 0.
You may assume that you have an infinite number of each kind of coin.
The answer is guaranteed to fit into a signed 32-bit integer.

Example 1:
Input: amount = 5, coins = [1,2,5]
Output: 4
Explanation: there are four ways to make up the amount:
5=5
5=2+2+1
5=2+1+1+1
5=1+1+1+1+1

Example 2:
Input: amount = 3, coins = [2]
Output: 0
Explanation: the amount of 3 cannot be made up just with coins of 2.

Example 3:
Input: amount = 10, coins = [10]
Output: 1

Constraints:
1 <= coins.length <= 300
1 <= coins[i] <= 5000
All the values of coins are unique.
0 <= amount <= 5000

*/

public static class CoinChangeII
{
    // This method calculates the number of ways to make change for a given amount using the provided coins.
    public static int Change(int amount, int[] coins)
    {
        // Dictionary to store intermediate results (memoization)
        Dictionary<(int index, int currentAmount), int> mem = [];

        // Depth-First Search (DFS) helper function
        int Dfs(int index, int currentAmount)
        {
            // If the current amount matches the target amount, we've found a valid combination
            if (currentAmount == amount)
                return 1;

            // If the current amount exceeds the target amount, this path is not valid
            if (currentAmount > amount)
                return 0;

            // If we've used all coins without reaching the target amount, this path is not valid
            if (index == coins.Length)
                return 0;

            // If we have already computed the result for this state, return it
            if (mem.TryGetValue((index, currentAmount), out int amountOfWays))
                return amountOfWays;

            // Calculate the number of ways by including the current coin or skipping it
            mem[(index, currentAmount)] = Dfs(index, currentAmount + coins[index]) + Dfs(index + 1, currentAmount);

            // Return the computed result for this state
            return mem[(index, currentAmount)];
        }

        // Start the DFS from the first coin and an initial amount of 0
        return Dfs(0, 0);
    }
}
