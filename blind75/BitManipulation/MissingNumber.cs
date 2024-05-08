/*
Given an array nums containing n distinct numbers in the range [0, n],
return the only number in the range that is missing from the array.

Example

Input: nums = [3,0,1]
Output: 2
Explanation: n = 3 since there are 3 numbers,
so all numbers are in the range [0,3].
2 is the missing number in the range since it does not appear in nums.

*/

namespace Blind75.BitManipulation;

public static class MissingNumberClass
{
    public static int MissingNumber(int[] nums)
    {
        int n = nums.Length;
        int expectedSum = n * (n + 1) / 2;
        int actualSum = nums.Sum();
        return expectedSum - actualSum;
    }
}
