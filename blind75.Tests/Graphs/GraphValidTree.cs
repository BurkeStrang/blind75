// Input: n = 5 edges = [[0, 1], [0, 2], [0, 3], [1, 4]]
// Output: true.
public class GraphValid
{
    [Fact]
    public void GraphValidCorrect()
    {
        int n = 5;
        int[][] edges = new int[4][];
        edges[0] = new int[] { 0, 1 };
        edges[1] = new int[] { 0, 2 };
        edges[2] = new int[] { 0, 3 };
        edges[3] = new int[] { 1, 4 };

        Assert.True(GraphValidTree.ValidTree(n, edges));
    }
}
