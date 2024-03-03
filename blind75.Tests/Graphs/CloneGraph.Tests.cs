public class CloneGraph
{
    [Fact]
    public void TestCloneGraph()
    {
        // Arrange
        var node1 = new Node(1);
        var node2 = new Node(2);
        var node3 = new Node(3);
        var node4 = new Node(4);

        node1.neighbors.Add(node2);
        node1.neighbors.Add(node4);
        node2.neighbors.Add(node1);
        node2.neighbors.Add(node3);
        node3.neighbors.Add(node2);
        node3.neighbors.Add(node4);
        node4.neighbors.Add(node1);
        node4.neighbors.Add(node3);

        // Act
        var clonedNode1 = CloneGraphClass.CloneGraph(node1);

        // Assert
        Assert.NotSame(node1, clonedNode1);
        Assert.Equal(node1.val, clonedNode1!.val);
        Assert.NotSame(node1.neighbors, clonedNode1.neighbors);
        Assert.Equal(node1.neighbors.Count, clonedNode1.neighbors.Count);
        for (int i = 0; i < node1.neighbors.Count; i++)
        {
            Assert.NotSame(node1.neighbors[i], clonedNode1.neighbors[i]);
            Assert.Equal(node1.neighbors[i]!.val, clonedNode1.neighbors[i]!.val);
        }
    }
}
