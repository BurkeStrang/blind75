namespace Blind75.BinarySearch;

/*

Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays.

The overall run time complexity should be O(log (m+n)).

Example 1:
Input: nums1 = [1,3], nums2 = [2]
Output: 2.00000
Explanation: merged array = [1,2,3] and median is 2.

Example 2:
Input: nums1 = [1,2], nums2 = [3,4]
Output: 2.50000
Explanation: merged array = [1,2,3,4] and median is (2 + 3) / 2 = 2.5.

Constraints:

nums1.length == m
nums2.length == n
0 <= m <= 1000
0 <= n <= 1000
1 <= m + n <= 2000
-106 <= nums1[i], nums2[i] <= 106

*/

public static class MedianOfTwoSortedArrays
{
    public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        if (nums1.Length <= 0 && nums2.Length == 1)
        {
            return nums2[0];
        }
        if (nums2.Length <= 0 && nums1.Length == 1)
        {
            return nums1[0];
        }

        int m = nums1.Length;
        int n = nums2.Length;
        if (m > n)
        {
            return FindMedianSortedArrays(nums2, nums1);
        }
        int total = m + n;
        int half = (total + 1) / 2;
        int left = 0;
        int right = m;
        double result = 0.0;
        while (left <= right)
        {
            int i = left + (right - left) / 2;
            int j = half - i;
            int left1 = (i > 0) ? nums1[i - 1] : int.MinValue;
            int right1 = (i < m) ? nums1[i] : int.MaxValue;
            int left2 = (j > 0) ? nums2[j - 1] : int.MinValue;
            int right2 = (j < n) ? nums2[j] : int.MaxValue;

            if (left1 <= right2 && left2 <= right1)
            {
                result =
                    total % 2 == 0
                        ? (Math.Max(left1, left2) + Math.Min(right1, right2)) / 2.0
                        : Math.Max(left1, left2);
                break;
            }
            else if (left1 > right2)
            {
                right = i - 1;
            }
            else
            {
                left = i + 1;
            }
        }
        return result;
    }
}
