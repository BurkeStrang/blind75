namespace Blind75.Graphs;


public class NetworkDelayTimeTests
{
    [Fact]
    public void Example1()
    {
        // Arrange
        int[][] input = new int[][]
        {
            new int[] { 2, 1, 1 },
            new int[] { 2, 3, 1 },
            new int[] { 3, 4, 1 }
        };
        int n = 4;
        int k = 2;
        // Act
        int result = NetworkDelayTimeClass.NetworkDelayTime(input, n, k);
        // Assert
        Assert.Equal(2, result);
    }
    [Fact]
    public void Example2()
    {
        // Arrange
        int[][] input = new int[][]
        {
            new int[] { 1, 2, 1 }
        };
        int n = 2;
        int k = 1;
        // Act
        int result = NetworkDelayTimeClass.NetworkDelayTime(input, n, k);
        // Assert
        Assert.Equal(1, result);
    }
    [Fact]
    public void Example3()
    {
        // Arrange
        int[][] input = new int[][]
        {
            new int[] { 1, 2, 1 }
        };
        int n = 2;
        int k = 2;
        // Act
        int result = NetworkDelayTimeClass.NetworkDelayTime(input, n, k);
        // Assert
        Assert.Equal(-1, result);
    }
}
