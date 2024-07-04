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
    public static int LeastInterval(char[] tasks, int n)
    {
        // Count tasks in the array
        if (n == 0)
            return tasks.Length;

        IEnumerable<(FreqClass, int)> frequencies = tasks
            .GroupBy(x => x)
            .Select(x => (new FreqClass(x.Count(), n, x.First()), x.Count()));

        PriorityQueue<FreqClass, int> pq = new(frequencies, Comparer<int>.Create((a, b) => b - a));

        int time = 0;

        while (pq.Count > 0)
        {
            List<FreqClass> list = [];
            int cnt = 0;
            for (int i = 0; i < n + 1; i++)
            {
                if (pq.Count > 0)
                {
                    FreqClass item = pq.Dequeue(); // Dequeue returns a reference to the existing object
                    cnt++;
                    //Console.WriteLine($"Dequeued {item.Task} with frequency : {item.Frequency}");
                    item.Frequency--; // Modify the Frequency property directly
                    if (item.Frequency > 0)
                        list.Add(item);
                }
            }

            for (int i = 0; i < list.Count; i++)
            {
                FreqClass item = list[i];
                //Console.WriteLine($"Enqueued {item.Task} with frequency : {item.Frequency}");
                pq.Enqueue(item, item.Frequency); // Re-enqueue the modified object
            }

            time += pq.Count == 0 ? cnt : n + 1;
            //Console.WriteLine($"Done with iteration, current time: {time}");
        }

        return time;
    }

    private class FreqClass(int frequency, int idleTime, char task)
    {
        public int Frequency = frequency;
        public int IdleTime  = idleTime;
        public char Task  = task;
    }
}
