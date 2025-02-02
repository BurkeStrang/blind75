namespace Blind75.DynammicProgramming;

/* Given an integer array nums, find a
subarray
 that has the largest product, and return the product.

The test cases are generated so that the answer will fit in a 32-bit integer.

 

Example 1:

Input: nums = [2,3,-2,4]
Output: 6
Explanation: [2,3] has the largest product 6. */

public static class MaximumProductSubarray
{
    public static int MaxProduct(int[] nums)
    {
        int max = nums[0];
        int min = nums[0];
        int result = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            int temp = max;
            max = Max(Max(max * nums[i], min * nums[i]), nums[i]);
            min = Min(Min(temp * nums[i], min * nums[i]), nums[i]);
            result = Max(max, result);
        }
        return result;
    }
}

