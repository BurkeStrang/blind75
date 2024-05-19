namespace Blind75.Graphs;

public class MinCostToConnectAllPointsTests
{
    [Fact]
    public void Example1()
    {
        // Arrange
        int[][] input = new int[][]
        {
            new int[] { 0, 0 },
            new int[] { 2, 2 },
            new int[] { 3, 10 },
            new int[] { 5, 2 },
            new int[] { 7, 0 }
        };
        // Act
        int result = MinCostToConnectAllPoints.MinCostConnectPoints(input);
        // Assert
        Assert.Equal(20, result);
    }
    [Fact]
    public void Example2()
    {
        // Arrange
        int[][] input = new int[][]
        {
            new int[] { 3, 12 },
            new int[] { -2, 5 },
            new int[] { -4, 1 }
        };
        // Act
        int result = MinCostToConnectAllPoints.MinCostConnectPoints(input);
        // Assert
        Assert.Equal(18, result);
    }
}
