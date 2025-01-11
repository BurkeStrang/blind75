namespace Blind75.Heap;

// We are given an input array, tasksList, which contains the start and end times of tasks.
// Your task is to find the minimum number of machines required to complete these tasks.


public static class ScheduleTaskOnMinMachine
{
    public static int Tasks(int[][] tasksList)
    {
        int optimalMachines = 0;
        // Min heap for tasks sorted by start time.
        PriorityQueue<int[], int> tasks = new(tasksList.Select(x => (x, x[0])));
        // Min heap for machines sorted by end time.
        PriorityQueue<int, int> machinesAvailable = new();

        while (tasks.Count > 0)
        {
            // Get the next task.
            int[] task = tasks.Dequeue();
            int taskStart = task[0];
            int taskEnd = task[1];

            // Check if a machine is available before the task starts.
            if (machinesAvailable.Count > 0 && machinesAvailable.Peek() <= taskStart)
                machinesAvailable.Dequeue(); // Reuse the machine.
            else // If no machine is available, allocate a new one.
                optimalMachines++;
            // Add the machine back with the new end time.
            machinesAvailable.Enqueue(taskEnd, taskEnd);
        }

        return optimalMachines;
    }
}
