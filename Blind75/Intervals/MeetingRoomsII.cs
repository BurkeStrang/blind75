/*
Given an array of meeting time intervals consisting of start and end times
[[s1,e1],[s2,e2],...] (si < ei), find the minimum number of conference rooms required.)
*/

namespace Blind75.Intervals;

public static class MeetingRoomsII
{
    public static int MinMeetingRooms(int[][] intervals)
    {
        int n = intervals.Length;
        int[] start = new int[n];
        int[] end = new int[n];
        for (int i = 0; i < n; i++)
        {
            start[i] = intervals[i][0];
            end[i] = intervals[i][1];
        }
        Array.Sort(start);
        Array.Sort(end);
        int rooms = 0;
        int endIdx = 0;
        for (int i = 0; i < n; i++)
        {
            if (start[i] < end[endIdx])
            {
                rooms++;
            }
            else
            {
                endIdx++;
            }
        }
        return rooms;
    }
}
