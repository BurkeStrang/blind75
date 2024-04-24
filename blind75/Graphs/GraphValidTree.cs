namespece blind75.Graphs;
// Given n nodes labeled from 0 to n - 1 and a list of undirected edges (each edge is a pair of nodes),
// write a function to check whether these edges make up a valid tree.

// Input: n = 5 edges = [[0, 1], [0, 2], [0, 3], [1, 4]]
// Output: true.

public static class GraphValidTree
{
    public static bool ValidTree(int n, int[][] edges)
    {
        if (n == 0)
            return true;

        HashSet<int>[] adj = new HashSet<int>[n];

        for (int i = 0; i < n; i++)
        {
            adj[i] = new();
        }
        foreach (var edge in edges)
        {
            var e1 = edge[0];
            var e2 = edge[1];
            adj[e1].Add(e2);
            adj[e2].Add(e1);
        }
        var visited = new bool[n];

        var res = DfsValidTree(adj, 0, visited);

        if (visited.Any(c => !c))
            return false;
        return res;
    }

    private static bool DfsValidTree(HashSet<int>[] adj, int current, bool[] visited)
    {
        if (visited[current])
            return false;
        visited[current] = true;

        HashSet<int> nextLevel = adj[current];
        foreach (int level in nextLevel)
        {
            adj[level].Remove(current);
            if (!DfsValidTree(adj, level, visited))
            {
                return false;
            }
        }
        return true;
    }
}
