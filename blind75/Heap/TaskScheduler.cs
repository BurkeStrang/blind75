namespace Blind75.Heap;

/*

You are given an array of CPU tasks, each represented by letters A to Z, and a cooling time, n.
Each cycle or interval allows the completion of one task.
Tasks can be completed in any order, but there's a constraint:
identical tasks must be separated by at least n intervals due to cooling time.
​Return the minimum number of intervals required to complete all tasks.

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

public class TaskScheduler
{
    private PriorityQueue<FreqClass, int> _pq = new(new MaxHeap());
    private readonly Dictionary<char, int> _dictionary = [];

    public int LeastInterval(char[] tasks, int n)
    {
        // Count tasks in the array
        if (n == 0)
            return tasks.Length;
        foreach (char task in tasks)
        {
            if (_dictionary.TryGetValue(task, out int value))
            {
                _dictionary[task] = ++value;
            }
            else
                _dictionary.Add(task, 1);
        }

        _pq = new PriorityQueue<FreqClass, int>(new MaxHeap());

        int time = 0;

        AddItemsToPQ();

        while (_pq.Count > 0)
        {
            List<FreqClass> list = [];
            int cnt = 0;
            for (int i = 0; i < n + 1; i++)
            {
                if (_pq.Count > 0)
                {
                    FreqClass item = _pq.Dequeue();
                    cnt++;
                    //Console.WriteLine($"Dequeued {item.Task} with frequency : {item.Frequency}");
                    item.Frequency--;
                    if (item.Frequency > 0)
                        list.Add(item);
                }
            }

            for (int i = 0; i < list.Count; i++)
            {
                FreqClass item = list[i];
                //Console.WriteLine($"Enqueued {item.Task} with frequency : {item.Frequency}");
                _pq.Enqueue(item, item.Frequency);
            }

            time += _pq.Count == 0 ? cnt : n + 1;
            //Console.WriteLine($"Done with iteration, current time: {time}");
        }

        return time;
    }

    private void AddItemsToPQ()
    {
        foreach (KeyValuePair<char, int> keyValuePair in _dictionary)
        {
            _pq.Enqueue(new FreqClass(keyValuePair.Value, 0, keyValuePair.Key), keyValuePair.Value);
        }
    }

    public class MaxHeap : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            return y - x;
        }
    }

    public class FreqClass(int frequency, int idleTime, char task)
    {
        public int Frequency = frequency;
        public int IdleTime = idleTime;
        public char Task = task;
    }
}
