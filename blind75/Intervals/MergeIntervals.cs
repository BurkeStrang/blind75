namespace blind75.Intervals;

/*
Given an array of intervals where intervals[i] = [starti, endi],
merge all overlapping intervals,
and return an array of the non-overlapping intervals that cover all the intervals in the input.

Example 1:

Input: intervals = [[1,3],[2,6],[8,10],[15,18]]
Output: [[1,6],[8,10],[15,18]]
Explanation: Since intervals [1,3] and [2,6] overlap, merge them into [1,6].
*/
public static class MergeIntervals
{
    public static int[][] Merge(int[][] intervals)
    {
        if (intervals.Length == 0)
        {
            return [];
        }
        Array.Sort(intervals, (a, b) => a[0] - b[0]);
        List<int[]> result = [];
        int[] currentInterval = intervals[0];
        result.Add(currentInterval);
        foreach (int[] interval in intervals)
        {
            int currentEnd = currentInterval[1];
            int nextBegin = interval[0];
            int nextEnd = interval[1];
            if (currentEnd >= nextBegin)
            {
                currentInterval[1] = Math.Max(currentEnd, nextEnd);
            }
            else
            {
                currentInterval = interval;
                result.Add(currentInterval);
            }
        }
        return [.. result];
    }
}
