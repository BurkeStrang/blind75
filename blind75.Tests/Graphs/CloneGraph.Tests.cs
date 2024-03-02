public class CloneGraph
{
    public void CloneGraphCorrect()
    {

        // Input: adjList = [[2,4],[1,3],[2,4],[1,3]]
        // Output: [[2,4],[1,3],[2,4],[1,3]]
        // Explanation: There are 4 nodes in the graph.
        // 1st node (val = 1)'s neighbors are 2nd node (val = 2) and 4th node (val = 4).
        // 2nd node (val = 2)'s neighbors are 1st node (val = 1) and 3rd node (val = 3).
        // 3rd node (val = 3)'s neighbors are 2nd node (val = 2) and 4th node (val = 4).
        // 4th node (val = 4)'s neighbors are 1st node (val = 1) and 3rd node (val = 3).

        Node n1 = new Node(1);
        Node n2 = new Node(2);
        Node n3 = new Node(3);
        Node n4 = new Node(4);
        n1.neighbors.Add(n2);
        n1.neighbors.Add(n4);
        n2.neighbors.Add(n1);
        n2.neighbors.Add(n3);
        n3.neighbors.Add(n2);
        n3.neighbors.Add(n4);
        n4.neighbors.Add(n1);
        n4.neighbors.Add(n3);

        Node e1 = new Node(1);
        Node e2 = new Node(2);
        Node e3 = new Node(3);
        Node e4 = new Node(4);
        e1.neighbors.Add(e2);
        e1.neighbors.Add(e4);
        e2.neighbors.Add(e1);
        e2.neighbors.Add(e3);
        e3.neighbors.Add(e2);
        e3.neighbors.Add(e4);
        e4.neighbors.Add(e1);
        e4.neighbors.Add(e3);

        Assert.Equivalent(e1, CloneGraphClass.CloneGraph(n1));
    }
}
