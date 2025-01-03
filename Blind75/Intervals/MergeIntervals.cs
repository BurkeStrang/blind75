namespace Blind75.Intervals;

/*

Given an array of intervals where intervals[i] = [starti, endi],
merge all overlapping intervals,
and return an array of the non-overlapping intervals that cover all the intervals in the input.
Assume intervals are not sorted.

Example 1:
Input: intervals = [[1,3],[2,6],[8,10],[15,18]]
Output: [[1,6],[8,10],[15,18]]
Explanation: Since intervals [1,3] and [2,6] overlap, merge them into [1,6].

*/

public static class MergeIntervals
{
    public static int[][] Merge(int[][] intervals)
    {
        // Intuition
        // sort array in place
        // now that array is sorted get the first smallest interval
        // look at the next interval first element and see if it is less than the second element in
        // the current if it is update it to the second element in the next element
        // else add the next interval to the array

        Array.Sort(intervals, (a, b) => a[0] - b[0]);
        List<int[]> resList = [];
        int[] current = intervals[0];
        resList.Add(current);
        for (int i = 1; i < intervals.Length; i++)
        {
            if (intervals[i][0] <= current[1])
                current[1] = intervals[i][1];
            else
            {
                current = intervals[i];
                resList.Add(current);
            }
        }
        return [.. resList];
    }
}
