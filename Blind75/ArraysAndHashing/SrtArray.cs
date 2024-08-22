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
        MergeSort(nums, 0, nums.Length - 1);
        QuickSort(nums, 0, nums.Length - 1);
        BubbleSort(nums);
        return nums;
    }

    static void MergeSort(int[] array, int left, int right)
    {
        if (left < right)
        {
            int middle = left + (right - left) / 2;

            // Sort first half
            MergeSort(array, left, middle);
            // Sort second half
            MergeSort(array, middle + 1, right);

            // Merge the sorted halves
            Merge(array, left, middle, right);
        }
    }

    static void Merge(int[] array, int left, int middle, int right)
    {
        // Find sizes of two subarrays to be merged
        int n1 = middle - left + 1;
        int n2 = right - middle;

        // Create temp arrays
        int[] l = new int[n1];
        int[] r = new int[n2];

        // Copy data to temp arrays L[] and R[]
        Array.Copy(array, left, l, 0, n1);
        Array.Copy(array, middle + 1, r, 0, n2);

        // Merge the temp arrays

        int i = 0,
            j = 0;

        // Initial index of merged subarray
        int k = left;
        while (i < n1 && j < n2)
        {
            if (l[i] <= r[j])
            {
                array[k] = l[i];
                i++;
            }
            else
            {
                array[k] = r[j];
                j++;
            }
            k++;
        }

        // Copy the remaining elements of l[], if any
        while (i < n1)
        {
            array[k] = l[i];
            i++;
            k++;
        }

        // Copy the remaining elements of r[], if any
        while (j < n2)
        {
            array[k] = r[j];
            j++;
            k++;
        }
    }

    static void BubbleSort(int[] array)
    {
        int n = array.Length;
        for (int i = 0; i < n - 1; i++)
        {
            // Last i elements are already sorted
            for (int j = 0; j < n - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    // Swap array[j] and array[j+1]
                    (array[j + 1], array[j]) = (array[j], array[j + 1]);
                }
            }
        }
    }

    static void QuickSort(int[] array, int low, int high)
    {
        if (low < high)
        {
            // Partition the array and get the pivot index
            int pivotIndex = Partition(array, low, high);

            // Recursively sort elements before and after partition
            QuickSort(array, low, pivotIndex - 1);
            QuickSort(array, pivotIndex + 1, high);
        }
    }

    static int Partition(int[] array, int low, int high)
    {
        // Select the pivot element (we'll use the last element)
        int pivot = array[high];
        int i = low - 1; // Index of the smaller element

        for (int j = low; j < high; j++)
        {
            // If the current element is smaller than or equal to the pivot
            if (array[j] <= pivot)
            {
                i++;
                // Swap array[i] with array[j]
                (array[j], array[i]) = (array[i], array[j]);
            }
        }

        // Swap array[i+1] with the pivot element
        (array[high], array[i + 1]) = (array[i + 1], array[high]);
        return i + 1; // Return the partitioning index
    }
}
