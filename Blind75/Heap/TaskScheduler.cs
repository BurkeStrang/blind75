using static System.Math;

namespace Blind75.Heap;

/*

You are given an array of CPU tasks, each represented by letters A to Z, and a cooling time, n.
Each cycle or interval allows the completion of one task.
Tasks can be completed in any order, but there's a constraint:
identical tasks must be separated by at least n intervals due to cooling time.
Return the minimum number of intervals required to complete all tasks.

Example 1:
Input: tasks = ["A","A","A","B","B","B"], n = 2
Output: 8
Explanation: A possible sequence is: A -> B -> idle -> A -> B -> idle -> A -> B.
After completing task A, you must wait two cycles before doing A again.
The same applies to task B. In the 3rd interval, neither A nor B can be done, so you idle.
By the 4th cycle, you can do A again as 2 intervals have passed.

Example 2:
Input: tasks = ["A","C","A","B","D","B"], n = 1
Output: 6
Explanation: A possible sequence is: A -> B -> C -> D -> A -> B.
With a cooling interval of 1, you can repeat a task after just one other task.

Example 3:
Input: tasks = ["A","A","A", "B","B","B"], n = 3
Output: 10
Explanation: A possible sequence is: A -> B -> idle -> idle -> A -> B -> idle -> idle -> A -> B.
There are only two types of tasks, A and B, which need to be separated by 3 intervals.
This leads to idling twice between repetitions of these tasks.

Constraints:
1 <= tasks.length <= 104
tasks[i] is an uppercase English letter.
0 <= n <= 100

*/

public static class TaskScheduler
{
    /// <summary>
    /// Calculates the least amount of time needed to execute all the tasks.
    /// </summary>
    /// <param name="tasks">
    /// An array of tasks that need to be executed.
    /// </param>
    /// <param name="n">The cooldown period between two identical tasks.
    /// </param>
    /// <returns>
    /// The least amount of time needed to execute all the tasks.
    /// </returns>
    public static int LeastInterval(char[] tasks, int n)
    {
        if (tasks == null || tasks.Length == 0)
            return 0;

        PriorityQueue<int, int> pq = new(tasks.GroupBy(c => c)
                .Select(c => (c.Count(), c.Count())),
                    Comparer<int>.Create((a, b) => b - a));

        int maxFreq = pq.Dequeue();
        int idleTime = (maxFreq - 1) * n;

        while (pq.Count > 0 && idleTime > 0)
        {
            int currenCount = pq.Dequeue();
            if (currenCount > 0)
                idleTime -= Min(maxFreq - 1, currenCount);
        }
        return tasks.Length + Max(0, idleTime);
    }
}
