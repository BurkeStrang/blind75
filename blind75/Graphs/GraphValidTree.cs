namespace Blind75.Graphs;

// Given n nodes labeled from 0 to n - 1 and a list of undirected edges (each edge is a pair of nodes),
// write a function to check whether these edges make up a valid tree.
// A valid tree is a connected graph with no cycle.

// Input: n = 5 edges = [[0, 1], [0, 2], [0, 3], [1, 4]]
// Output: true.

public static class GraphValidTree
{
    public static bool ValidTree(int n, int[][] edges)
    {
        if (n == 0)
            return true;

        // Create adjacency list
        HashSet<int>[] adj = new HashSet<int>[n];

        for (int i = 0; i < n; i++)
        {
            adj[i] = [];
        }
        foreach (int[] edge in edges)
        {
            int e1 = edge[0];
            int e2 = edge[1];
            adj[e1].Add(e2);
            adj[e2].Add(e1);
        }
        //
        // create a visited array that will keep track of visited nodes
        bool[] visited = new bool[n];

        return DfsValidTree(adj, 0, visited) && visited.All(c => c);
    }

    // this is checking for cycles
    // and setting the visited array
    private static bool DfsValidTree(HashSet<int>[] adj, int current, bool[] visited)
    {
        if (visited[current])
            return false;
        visited[current] = true;

        HashSet<int> nextLevel = adj[current];
        foreach (int level in nextLevel)
        {
            // remove visited node
            adj[level].Remove(current);
            if (!DfsValidTree(adj, level, visited))
            {
                return false;
            }
        }
        return true;
    }
}
