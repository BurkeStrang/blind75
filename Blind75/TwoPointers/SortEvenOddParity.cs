namespace Blind75.TwoPointers;

// Given an integer array nums,
// move all the even integers at the beginning of the array followed by all the odd integers.
// Return any array that satisfies this condition.
//
// Example 1:
// Input: nums = [3,1,2,4]
// Output: [2,4,3,1]
// Explanation: The outputs [4,2,3,1], [2,4,1,3], and [4,2,1,3] would also be accepted.
//
// Example 2:
// Input: nums = [0]
// Output: [0]
//
// Constraints:
//
// 1 <= nums.length <= 5000
// 0 <= nums[i] <= 5000
public static class SortEvenOddParity
{
    public static int[] SortArrayByParity(int[] nums)
    {
        int left = 0;
        int right = nums.Length - 1;

        while (left < right)
        {
            if (nums[left] % 2 != 0 && nums[right] % 2 == 0)
                (nums[left], nums[right]) = (nums[right], nums[left]);
            if (nums[left] % 2 == 0)
                left++;
            if (nums[right] % 2 != 0)
                right--;
        }
        return nums;
    }
}
