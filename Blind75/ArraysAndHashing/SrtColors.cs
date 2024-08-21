namespace Blind75.ArraysAndHashing;

// Given an array nums with n objects colored red, white, or blue,
// sort them in-place so that objects of the same color are adjacent,
// with the colors in the order red, white, and blue.
// We will use the integers 0, 1, and 2 to represent the color red, white, and blue, respectively.
// You must solve this problem without using the library's sort function.
//
// Example 1:
// Input: nums = [2,0,2,1,1,0]
// Output: [0,0,1,1,2,2]
//
// Example 2:
// Input: nums = [2,0,1]
// Output: [0,1,2]
//
// Constraints:
// n == nums.length
// 1 <= n <= 300
// nums[i] is either 0, 1, or 2.
//
// Follow up: Could you come up with a one-pass algorithm using only constant extra space?

public static class SrtColors
{
    public static void SortColors(int[] nums)
    {
        // Dutch National Flag Algorithm
        //
        // The Dutch National Flag algorithm is used to sort an array of 0s, 1s, and 2s in linear time and constant space.
        // It is named after the flag of the Netherlands, which consists of three colors: red, white, and blue.
        //
        // The algorithm uses three pointers to divide the array into four sections:
        // 1. The low pointer points to the beginning of the unsorted array.
        // 2. The mid pointer points to the current element being processed.
        // 3. The high pointer points to the end of the unsorted array.
        // 4. The high pointer moves from right to left, and the low pointer moves from left to right.
        //
        // The algorithm sorts the array in place by iterating over the elements of the array.
        // If the current element is 0, it is swapped with the element at the low pointer, and the low pointer is incremented.
        // If the current element is 1, it is already in the correct position, and the mid pointer is incremented.
        // If the current element is 2, it is swapped with the element at the high pointer, and the high pointer is decremented.
        //
        // The algorithm terminates when the mid pointer crosses the high pointer.
        //
        // Time complexity: O(n) - The algorithm processes each element of the array once.
        // Space complexity: O(1) - The algorithm uses a constant amount of extra space.
        int low = 0;
        int mid = 0;
        int high = nums.Length - 1;
        while (mid <= high)
        {
            if (nums[mid] == 0)
            {
                // swap nums[low] and nums[mid]
                int temp = nums[low];
                nums[low] = nums[mid];
                nums[mid] = temp;
                low++;
                mid++;
            }
            else if (nums[mid] == 1)
            {
                // element is already in the correct position
                mid++;
            }
            else
            {
                // swap nums[mid] and nums[high]
                int temp = nums[mid];
                nums[mid] = nums[high];
                nums[high] = temp;
                high--;
            }
        }
    }
}
