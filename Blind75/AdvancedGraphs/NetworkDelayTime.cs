namespace Blind75.Graphs;

/*

You are given a network of n nodes, labeled from 1 to n.
You are also given times, a list of travel times as directed edges
times[i] = (ui, vi, wi), where ui is the source node, vi is the target node,
and wi is the time it takes for a signal to travel from source to target.

We will send a signal from a given node k.
Return the minimum time it takes for all the n nodes to receive the signal.
If it is impossible for all the n nodes to receive the signal, return -1.

Example 1:
Input: times = [[2,1,1],[2,3,1],[3,4,1]], n = 4, k = 2
Output: 2

Example 2:
Input: times = [[1,2,1]], n = 2, k = 1
Output: 1

Example 3:
Input: times = [[1,2,1]], n = 2, k = 2
Output: -1

Constraints:
1 <= k <= n <= 100
1 <= times.length <= 6000
times[i].length == 3
1 <= ui, vi <= n
ui != vi
0 <= wi <= 100
All the pairs (ui, vi) are unique. (i.e., no multiple edges.)

*/

public static class NetworkDelayTimeClass
{
    public static int NetworkDelayTime(int[][] times, int n, int k)
    {
        // Initialize adjacency list for the graph
        List<(int node, int weight)>[] adjList = new List<(int node, int weight)>[n + 1];
        for (int i = 0; i <= n; i++)
        {
            adjList[i] = [];
        }

        // Populate the adjacency list with the given times
        foreach (int[] time in times)
        {
            adjList[time[0]].Add((time[1], time[2]));
        }

        // Initialize visited array to track visited nodes
        int[] visited = new int[n + 1];
        Array.Fill(visited, 0);

        // Priority queue to process nodes in order of their weights
        PriorityQueue<int, int> queue = new();
        queue.Enqueue(k, 0); // Enqueue the starting node with weight 0

        int res = 0;
        while (queue.TryDequeue(out int node, out int weight))
        {
            // Skip if the node has already been visited
            if (visited[node] == 1) continue;

            // Mark the node as visited
            visited[node] = 1;

            // Update the result with the maximum weight encountered
            res = Math.Max(res, weight);

            // Process adjacent nodes
            foreach ((int node, int weight) adj in adjList[node])
            {
                int totalWT = weight + adj.weight;
                queue.Enqueue(adj.node, totalWT);
            }
        }

        // Check if all nodes have been visited
        int visitedCount = visited.Count(e => e == 1);
        return visitedCount == n ? res : -1;
    }
}
