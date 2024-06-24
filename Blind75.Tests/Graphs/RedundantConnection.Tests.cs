namespace Blind75.Graphs;

public class RedundantConnectionTests
{
    [Fact]
    public void Example1()
    {
        // Arrange
        int[][] edges =
        [
            [1, 2],
            [1, 3],
            [2, 3]
        ];
        int[] expected = [2, 3];
        // Act
        int[] actual = RedundantConnection.FindRedundantConnection(edges);
        // Assert
        Assert.Equal(expected, actual);
    }
    [Fact]
    public void Example2()
    {
        // Arrange
        int[][] edges =
        [
            [1, 2],
            [2, 3],
            [3, 4],
            [1, 4],
            [1, 5]
        ];
        int[] expected = [1, 4];
        // Act
        int[] actual = RedundantConnection.FindRedundantConnection(edges);
        // Assert
        Assert.Equal(expected, actual);
    }
}
