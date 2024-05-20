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

    public static bool CanPartition(int[] nums)
    {
        int sum = nums.Sum();
        return sum % 2 == 0 && SubSetSum(nums, sum / 2);
    }

    private static bool SubSetSum(int[] nums, int target)
    {
        bool[,] dp = new bool[nums.Length + 1, target + 1];

        for (int i = 0; i < nums.Length + 1; i++)
        {
            for (int j = 0; j < target + 1; j++)
            {
                if (i == 0)
                {
                    dp[i, j] = false;
                }
                if (j == 0)
                {
                    dp[i, j] = true;
                }
            }
        }

        for (int i = 1; i < nums.Length + 1; i++)
        {
            for (int j = 1; j < target + 1; j++)
            {
                dp[i, j] = nums[i - 1] <= j ? dp[i - 1, j] || dp[i - 1, j - nums[i - 1]] : dp[i - 1, j];
            }
        }

        return dp[nums.Length, target];
    }
}
