namespace Blind75.Intervals;

/*

You are given an array of non-overlapping intervals intervals
where intervals[i] = [starti, endi] represent the start and the end
of the ith interval and intervals is sorted in ascending order by starti.
You are also given an interval newInterval = [start, end] that represents the start and end of another interval.

Insert newInterval into intervals such that intervals is still sorted in ascending order
by starti and intervals still does not have any overlapping intervals (merge overlapping intervals if necessary).

Return intervals after the insertion.

Example 1:

Input: intervals = [[1,3],[6,9]], newInterval = [2,5]
Output: [[1,5],[6,9]]

*/

public static class InsertIntervals
{
    public static int[][] Insert(int[][] intervals, int[] newInterval)
    {
        List<int[]> resList = [];
        int i = 0;
        int n = intervals.Length;

        // Add all intervals before the new interval
        while (i < n && intervals[i][1] < newInterval[0])
        {
            resList.Add(intervals[i]);
            i++;
        }

        // Merge all overlapping intervals with the new interval
        while (i < n && intervals[i][0] <= newInterval[1])
        {
            newInterval[0] = Math.Min(newInterval[0], intervals[i][0]);
            newInterval[1] = Math.Max(newInterval[1], intervals[i][1]);
            i++;
        }
        resList.Add(newInterval);

        // Add all intervals after the new interval
        while (i < n)
        {
            resList.Add(intervals[i]);
            i++;
        }
        return [.. resList];
    }
}
