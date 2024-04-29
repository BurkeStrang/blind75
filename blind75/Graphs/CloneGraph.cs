namespace Blind75.Graphs;

// Given a reference of a node in a connected undirected graph.
// Return a deep copy (clone) of the graph.
// Each node in the graph contains a value (int) and a list (List[Node]) of its neighbors.

// Input: adjList = [[2,4],[1,3],[2,4],[1,3]]
// Output: [[2,4],[1,3],[2,4],[1,3]]
// Explanation: There are 4 nodes in the graph.
// 1st node (val = 1)'s neighbors are 2nd node (val = 2) and 4th node (val = 4).
// 2nd node (val = 2)'s neighbors are 1st node (val = 1) and 3rd node (val = 3).
// 3rd node (val = 3)'s neighbors are 2nd node (val = 2) and 4th node (val = 4).
// 4th node (val = 4)'s neighbors are 1st node (val = 1) and 3rd node (val = 3).

public static class CloneGraphClass
{
    private static readonly Dictionary<Node, Node> Map = [];

    public static Node? CloneGraph(Node? node)
    {
        if (node is null)
            return null;
        if (!Map.TryGetValue(node, out Node? value))
        {
            value = new Node(node.val);
            Map.Add(node, value);
            foreach (Node? n in node.neighbors)
            {
                Map[node].neighbors.Add(CloneGraph(n));
            }
        }
        return value;
    }
}
