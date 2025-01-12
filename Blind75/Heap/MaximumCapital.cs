namespace Blind75.Heap;

// Example 1.
// capitals: [ 1, 1, 2 ]
// profits: [ 1, 2, 3 ]
// Number of projects k: 1
// Start-up capital c: 0
// Maximum capital earned: 0
//
// Example 2.
// capitals: [ 1, 2, 2, 3 ]
// profits: [ 2, 4, 6, 8 ]
// Number of projects k: 2
// Start-up capital c: 1
// Maximum capital earned: 11

public static class StartupCapital
{
    /// <summary>
    /// Finds the maximum capital earned after completing up to k projects.
    /// </summary>
    /// <param name="c">Initial start-up capital.</param>
    /// <param name="k">Number of projects that can be completed.</param>
    /// <param name="capitals">Array of required capitals for projects.</param>
    /// <param name="profits">Array of profits for projects.</param>
    /// <returns>The maximum capital earned.</returns>
    public static int MaximumCapital(int c, int k, int[] capitals, int[] profits)
    {
        // Using a min-heap for capitals: projects with the smallest capital requirements come first.
        // The priority is simply the required capital.
        PriorityQueue<(int RequiredCapital, int Index), int> capitalsMinHeap = new();

        // Using a max-heap for profits: we use negative profits to simulate a max-heap.
        // The priority is the negative profit.
        PriorityQueue<int, int> profitsMaxHeap = new(Comparer<int>.Create((a, b) => b - a));

        // Populate the min-heap with all projects (store their required capital and original index)
        for (int i = 0; i < capitals.Length; i++)
        {
            capitalsMinHeap.Enqueue((capitals[i], i), capitals[i]);
        }

        int currentCapital = c;

        // Perform up to k rounds of project selections
        for (int counter = 0; counter < k; counter++)
        {
            // Transfer all projects we can afford into the profits max-heap
            while (capitalsMinHeap.Count > 0 && capitalsMinHeap.Peek().RequiredCapital <= currentCapital)
            {
                (int RequiredCapital, int Index) project = capitalsMinHeap.Dequeue();
                int projectIndex = project.Index;
                // Enqueue into the max-heap with negative profit for max ordering
                profitsMaxHeap.Enqueue(profits[projectIndex], profits[projectIndex]);
            }

            // If no projects can be done, break early.
            if (profitsMaxHeap.Count == 0)
            {
                break;
            }

            // Select the project with the highest profit.
            int bestProject = profitsMaxHeap.Dequeue();
            currentCapital += bestProject;
        }

        return currentCapital;
    }
}
