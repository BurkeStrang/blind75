/*
Given an array of intervals intervals where intervals[i] = [starti, endi],
return the minimum number of intervals you need to remove to
make the rest of the intervals non-overlapping.

Example 1:

Input: intervals = [[1,2],[2,3],[3,4],[1,3]]
Output: 1
Explanation: [1,3] can be removed and the rest of the intervals are non-overlapping.
*/

namespace Blind75.Intervals;

public class NonOverlappingIntervals
{
    public static int EraseOverlapIntervals(int[][] intervals)
    {
        if (intervals.Length == 0)
        {
            return 0;
        }
        Array.Sort(intervals, (a, b) => a[1] - b[1]);
        int end = intervals[0][1];
        int count = 1;
        for (int i = 1; i < intervals.Length; i++)
        {
            if (intervals[i][0] < end)
            {
                continue;
            }
            end = intervals[i][1];
            count++;
        }
        return intervals.Length - count;
    }
}
