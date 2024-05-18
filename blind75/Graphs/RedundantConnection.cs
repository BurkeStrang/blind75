namespace Blind75.Graphs;

/*

In this problem, a tree is an undirected graph that is connected and has no cycles.
You are given a graph that started as a tree with n nodes labeled from 1 to n, with one additional edge added.
The added edge has two different vertices chosen from 1 to n, and was not an edge that already existed.
The graph is represented as an array edges of length n where edges[i] = [ai, bi]
indicates that there is an edge between nodes ai and bi in the graph.
Return an edge that can be removed so that the resulting graph is a tree of n nodes.
If there are multiple answers, return the answer that occurs last in the input.

Example 1:
Input: edges = [[1,2],[1,3],[2,3]]
Output: [2,3]

Example 2:
Input: edges = [[1,2],[2,3],[3,4],[1,4],[1,5]]
Output: [1,4]

Constraints:
n == edges.length
3 <= n <= 1000
edges[i].length == 2
1 <= ai < bi <= edges.length
ai != bi
There are no repeated edges.
The given graph is connected.

*/

public static class RedundantConnection
{
    public static int[] FindRedundantConnection(int[][] edges)
    {
        int numberOfEdges = edges.Length;
        int[] parent = new int[numberOfEdges + 1];
        int[] rank = new int[numberOfEdges + 1];

        // Initialize parent and rank arrays
        for (int i = 0; i < numberOfEdges; i++)
        {
            parent[i] = i;
            rank[i] = 1;
        }

        // Find the root parent of a node with path compression
        int FindParent(int node)
        {
            int root = parent[node];

            while (root != parent[root])
            {
                parent[root] = parent[parent[root]]; // Path compression
                root = parent[root];
            }

            return root;
        }

        // Union by rank
        bool Union(int node1, int node2)
        {
            int parent1 = FindParent(node1);
            int parent2 = FindParent(node2);

            // If both nodes have the same root parent, a cycle is detected
            if (parent1 == parent2)
                return false;

            // Union by rank
            if (rank[parent1] > rank[parent2])
            {
                parent[parent2] = parent1;
                rank[parent1] += rank[parent2];
            }
            else
            {
                parent[parent1] = parent2;
                rank[parent2] += rank[parent1];
            }

            return true;
        }

        // Iterate through each edge and apply union-find
        foreach (int[] edge in edges)
        {
            if (!Union(edge[0], edge[1]))
                return edge; // Return the edge that forms a cycle
        }

        // No redundant connection found (shouldn't happen in valid input)
        return new int[2];
    }
}
