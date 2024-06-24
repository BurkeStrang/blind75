/*

Given an array of meeting time intervals consisting of start and end times
[[s1,e1],[s2,e2],...] (si < ei),
determine if a person could attend all meetings.

*/

namespace Blind75.Intervals;

public static class MeetingRooms
{
    public static bool CanAttendMeetings(int[][] intervals)
    {
        Array.Sort(intervals, (a, b) => a[0] - b[0]);
        for (int i = 1; i < intervals.Length; i++)
        {
            // if the start time of the next meeting
            // is less than the end time of the previous meeting
            if (intervals[i][0] < intervals[i - 1][1])
                return false;
        }
        return true;
    }
}
