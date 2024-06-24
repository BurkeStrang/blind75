namespace Blind75.DynamicProgramming;

/*

You are given an integer array nums and an integer target.
You want to build an expression out of nums by adding one of the symbols
'+' and '-' before each integer in nums and then concatenate all the integers.
For example, if nums = [2, 1],
you can add a '+' before 2 and a '-' before 1 and concatenate them to build the expression "+2-1".
Return the number of different expressions that you can build, which evaluates to target.

Example 1:
Input: nums = [1,1,1,1,1], target = 3
Output: 5
Explanation: There are 5 ways to assign symbols to make the sum of nums be target 3.
-1 + 1 + 1 + 1 + 1 = 3
+1 - 1 + 1 + 1 + 1 = 3
+1 + 1 - 1 + 1 + 1 = 3
+1 + 1 + 1 - 1 + 1 = 3
+1 + 1 + 1 + 1 - 1 = 3

Example 2:
Input: nums = [1], target = 1
Output: 1

Constraints:
1 <= nums.length <= 20
0 <= nums[i] <= 1000
0 <= sum(nums[i]) <= 1000
-1000 <= target <= 1000

*/

public static class TargetSum
{
    // This method calculates the number of ways to make change for a given amount using the provided coins.
    public static int FindTargetSumWays(int[] nums, int target)
    {
        // Dictionary to store intermediate results (memoization)
        Dictionary<(int index, int currentSum), int> mem = [];
        // Depth-First Search (DFS) helper function
        int Dfs(int index, int currentSum)
        {
            // If the current sum matches the target sum, we've found a valid combination
            if (index == nums.Length)
                return currentSum == target ? 1 : 0;
            // If we've already calculated the number of ways to reach the current sum at this index, return the result
            if (mem.TryGetValue((index, currentSum), out int memWays))
                return memWays;
            // Calculate the number of ways to reach the target sum by adding or subtracting the current number
            int ways = Dfs(index + 1, currentSum + nums[index]) + Dfs(index + 1, currentSum - nums[index]);
            // Store the result in the memoization dictionary
            mem[(index, currentSum)] = ways;
            return ways;
        }
        // Start the Depth-First Search (DFS) from the first number with a current sum of 0
        return Dfs(0, 0);
    }
}
