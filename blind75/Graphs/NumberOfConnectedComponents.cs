namespace blind75.Graphs;

// You have a graph of n nodes.
// You are given an integer n and an array edges where edges[i] = [ai, bi]
// indicates that there is an edge between ai and bi in the graph.

// Return the number of connected components in the graph.

// Input: n = 5, edges = [[0,1],[1,2],[3,4]]
// Output: 2

public static class NumberOfConnectedComponents
{
    private static int noOfConnectedComponents = 0;

    // this is an array that handles finding
    private static int[]? rank;

    public static int CountComponents(int n, int[][] edges)
    {
        if (n == 0)
            return noOfConnectedComponents;

        noOfConnectedComponents = n;
        rank = new int[n];

        for (int i = 0; i < n; i++)
            rank[i] = i;

        foreach (int[] edge in edges)
            Union(edge[0], edge[1]);

        rank.Dump();
        return noOfConnectedComponents;
    }

    private static void Union(int x, int y)
    {
        int p1 = Find(x),
            p2 = Find(y);

        if (p1 != p2)
        {
            rank![p1] = p2;
            noOfConnectedComponents--;
        }
    }

    private static int Find(int n)
    {
        if (rank![n] != n)
            rank[n] = Find(rank[n]);

        return rank[n];
    }
}
