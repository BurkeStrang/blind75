namespace Blind75.DynammicProgramming;

/*

You are given an array of positive integers nums.
Return true if you can partition the array into two subsets, subset1 and subset2 where sum(subset1) == sum(subset2).
Otherwise, return false.

Example 1:
Input: nums = [1,2,3,4]
Output: true
Explanation: The array can be partitioned as [1, 4] and [2, 3].

Example 2:
Input: nums = [1,2,3,4,5]
Output: false

Constraints:
1 <= nums.length <= 100
1 <= nums[i] <= 50
Accepted: 0  |  Submitted: 1  |  Ac

*/

public class PartitionEqualSubsetSum
{
    // Main function to check if the array can be partitioned into two subsets with equal sum
    public static bool CanPartition(int[] nums)
    {
        // Calculate the sum of all elements
        int sum = nums.Sum();

        // If the sum is odd, it can't be partitioned into two equal subsets
        if (sum % 2 != 0)
        {
            return false;
        }

        // Check if there is a subset with sum equal to half of the total sum
        return SubsetSum(nums, sum / 2);
    }

    // Helper function to check if there is a subset with the given target sum
    private static bool SubsetSum(int[] nums, int target)
    {
        // Create a 2D array to store results of subproblems
        bool[,] dp = new bool[nums.Length + 1, target + 1];

        // Initialize the dp array
        for (int i = 0; i <= nums.Length; i++)
        {
            for (int j = 0; j <= target; j++)
            {
                if (i == 0)
                {
                    dp[i, j] = false; // No elements to form any subset
                }
                if (j == 0)
                {
                    dp[i, j] = true; // Empty subset has sum 0
                }
            }
        }

        // Fill the dp array
        for (int i = 1; i <= nums.Length; i++)
        {
            for (int j = 1; j <= target; j++)
            {
                // If the current element is less than or equal to the target sum
                if (nums[i - 1] <= j)
                {
                    // Include the current element or exclude it
                    dp[i, j] = dp[i - 1, j] || dp[i - 1, j - nums[i - 1]];
                }
                else
                {
                    // Exclude the current element
                    dp[i, j] = dp[i - 1, j];
                }
            }
        }

        // Return the result
        return dp[nums.Length, target];
    }
}
