namespace Blind75.Greedy;
/*
You are given an integer array nums.
You are initially positioned at the array's first index,
and each element in the array represents your maximum jump length at that position.

Return true if you can reach the last index, or false otherwise.

Example 1:

Input: nums = [2,3,1,1,4]
Output: true
Explanation: Jump 1 step from index 0 to 1, then 3 steps to the last index.
*/

public static class JumpGame
{
    public static bool CanJump(int[] nums)
    {
        int lastPos = nums.Length - 1;
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            if (i + nums[i] >= lastPos)
            {
                lastPos = i;
            }
        }
        return lastPos == 0;
    }
}
