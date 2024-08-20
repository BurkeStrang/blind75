namespace Blind75.ArraysAndHashing;

// Given an array of integers nums, sort the array in ascending order and return it.
// You must solve the problem without using any built-in functions in O(nlog(n))
// time complexity and with the smallest space complexity possible.
//
// Example 1:
// Input: nums = [5,2,3,1]
// Output: [1,2,3,5]
// Explanation: After sorting the array, the positions of some numbers are not changed (for example, 2 and 3), while the positions of other numbers are changed (for example, 1 and 5).
//
// Example 2:
// Input: nums = [5,1,1,2,0,0]
// Output: [0,0,1,1,2,5]
// Explanation: Note that the values of nums are not necessairly unique.
//
// Constraints:
// 1 <= nums.length <= 5 * 104
// -5 * 104 <= nums[i] <= 5 * 104

public static class SrtArray
{
    public static int[] SortArray(int[] nums)
    {
        // this is using count sort but I need to understand when to use this or other sorting algorithms
        //
        // Intuition
        // Counting Sort is an efficient algorithm for sorting integers when the range of values (k)
        // is not significantly larger than the number of elements (n).
        //
        // Approach
        // First, it finds the minimum and maximum values in the input array to determine the range of the numbers.
        // It creates a count array to store the count of each unique number in the input array.
        // The size of the count array is determined by the range of numbers.
        // It fills the count array with the occurrences of each number.
        // It then modifies the count array such that each element at each index stores the sum of previous counts.
        // This modification helps to place the elements in the correct positions in the output array.
        // Finally, it builds the output array by placing each element at its correct position and decreases the count by one.

        int minValue = nums.Min();
        int maxValue = nums.Max();
        int range = maxValue - minValue + 1;
        int[] count = new int[range];
        int[] output = new int[nums.Length];

        // Count the occurrences of each number
        foreach (int num in nums)
        {
            count[num - minValue]++;
        }

        // Update the count array to hold the actual positions
        for (int i = 1; i < count.Length; i++)
        {
            count[i] += count[i - 1];
        }

        // Build the output array
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            output[count[nums[i] - minValue] - 1] = nums[i];
            count[nums[i] - minValue]--;
        }

        return output;
    }
}
