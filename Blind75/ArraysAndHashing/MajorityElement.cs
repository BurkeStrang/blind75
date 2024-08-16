namespace Blind75.ArraysAndHashing;


// Given an array nums of size n, return the majority element.
// The majority element is the element that appears more than ⌊n / 2⌋ times.
// You may assume that the majority element always exists in the array.
//
// Example 1:
// Input: nums = [3,2,3]
// Output: 3
//
// Example 2:
// Input: nums = [2,2,1,1,1,2,2]
// Output: 2
//
// Constraints:
// 1 <= n <= 5 * 104
// -109 <= nums[i] <= 109
//
// Follow-up: Could you solve the problem in linear time and in O(1) space?

public static class MajorityElementClass
{
    // this solutions does not confirm if the majority element exists
    // it assumes that the majority element always exists in the array
    // it uses Boyer-Moore Voting Algorithm
    public static int MajorityElement(int[] nums)
    {
        int majorityElement = 0;
        int count = 0;
        foreach (int num in nums)
        {
            if (count == 0)
            {
                majorityElement = num;
                count++;
            }
            else if (num == majorityElement)
            {
                count++;
            }
            else
            {
                count--;
            }
        }
        return majorityElement;
    }
}
