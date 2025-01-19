namespace Blind75.Tests.Heap;

public class KClosestPointToOrginTests
{
    [Fact]
    public void Example1()
    {
        // Arrange
        int[][] points = [[1, 3], [-2, 2]];
        int k = 1;
        // Act
        int[][] result = KClosestPointToOrigin.KClosest(points, k);
        // Assert
        Assert.Equal([[-2, 2]], result);
    }
    [Fact]
    public void Example2()
    {
        // Arrange
        int[][] points = [[3, 3], [5, -1], [-2, 4]];
        int k = 2;
        // Act
        int[][] result = KClosestPointToOrigin.KClosest(points, k);
        // Assert
        Assert.Equal([[3, 3], [-2, 4]], result);
    }
}
