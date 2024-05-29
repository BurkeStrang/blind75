namespace Blind75.Intervals;

/*

You are given a 2D integer array intervals, where intervals[i] = [left_i, right_i]
represents the ith interval starting at left_i and ending at right_i (inclusive).
You are also given an integer array of query points queries.
The result of query[j] is the length of the shortest interval i such that left_i <= queries[j] <= right_i.
If no such interval exists, the result of this query is -1.
Return an array output where output[j] is the result of query[j].
Note: The length of an interval is calculated as right_i - left_i + 1.

Example 1:
Input: intervals = [[1,3],[2,3],[3,7],[6,6]], queries = [2,3,1,7,6,8]
Output: [2,2,3,5,1,-1]

Explanation:
Query = 2: The interval [2,3] is the smallest one containing 2, it's length is 2.
Query = 3: The interval [2,3] is the smallest one containing 3, it's length is 2.
Query = 1: The interval [1,3] is the smallest one containing 1, it's length is 3.
Query = 7: The interval [3,7] is the smallest one containing 7, it's length is 5.
Query = 6: The interval [6,6] is the smallest one containing 6, it's length is 1.
Query = 8: There is no interval containing 8.

Constraints:
1 <= intervals.length <= 1000
1 <= queries.length <= 1000
1 <= left_i <= right_i <= 10000
1 <= queries[j] <= 10000

*/

public static class MinimumIntervalToIncludeEachQuery
{
    public static int[] MinInterval(int[][] intervals, int[] queries)
    {
        int queryCount = queries.Length;

        // Create an array to store queries with their original indices
        int[][] queryWithIndices = new int[queryCount][];
        for (int i = 0; i < queryCount; i++)
        {
            queryWithIndices[i] = [queries[i], i];
        }

        // Sort queries by the value
        Array.Sort(queryWithIndices, (a, b) => a[0].CompareTo(b[0]));

        // Sort intervals by their starting value
        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

        // Priority queue to store intervals with their sizes as the priority
        PriorityQueue<int[], int> minHeap = new();
        int[] results = new int[queryCount];

        int intervalIndex = 0;

        foreach (int[] query in queryWithIndices)
        {
            int queryValue = query[0];
            int originalIndex = query[1];

            // Add intervals to the priority queue if they start before or at the current query value
            while (intervalIndex < intervals.Length && intervals[intervalIndex][0] <= queryValue)
            {
                int start = intervals[intervalIndex][0];
                int end = intervals[intervalIndex][1];
                int size = end - start + 1;
                minHeap.Enqueue([size, end], size);
                intervalIndex++;
            }

            // Remove intervals from the priority queue if they end before the current query value
            while (minHeap.Count > 0 && minHeap.Peek()[1] < queryValue)
            {
                minHeap.Dequeue();
            }

            // The smallest valid interval size for the current query
            results[originalIndex] = minHeap.Count > 0 ? minHeap.Peek()[0] : -1;
        }

        return results;
    }
}
