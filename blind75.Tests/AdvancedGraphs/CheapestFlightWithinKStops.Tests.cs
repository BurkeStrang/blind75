namespace Blind75.Graphs;

public class CheapestFlightWithinKStopsTests
{
    [Fact]
    public void Example1()
    {
        // Arrange
        int n = 4;
        int[][] flights =
        [
            [0, 1, 100],
            [1, 2, 100],
            [2, 0, 100],
            [1, 3, 600],
            [2, 3, 200]
        ];
        int src = 0;
        int dst = 3;
        int k = 1;
        // Act
        int result = CheapestFlightsWithinKStops.FindCheapestPrice(n, flights, src, dst, k);
        // Assert
        Assert.Equal(700, result);
    }

    [Fact]
    public void Example2()
    {
        // Arrange
        int n = 3;
        int[][] flights =
        [
            [0, 1, 100],
            [1, 2, 100],
            [0, 2, 500]
        ];
        int src = 0;
        int dst = 2;
        int k = 1;
        // Act
        int result = CheapestFlightsWithinKStops.FindCheapestPrice(n, flights, src, dst, k);
        // Assert
        Assert.Equal(200, result);
    }
    [Fact]
    public void Example3()
    {
        // Arrange
        int n = 5;
        int[][] flights =
        [
            [0, 1, 5],
            [1, 2, 5],
            [0, 3, 2],
            [3, 1, 2],
            [1, 4, 1],
            [4, 2, 1]
        ];
        int src = 0;
        int dst = 2;
        int k = 2;
        // Act
        int result = CheapestFlightsWithinKStops.FindCheapestPrice(n, flights, src, dst, k);
        // Assert
        Assert.Equal(7, result);
    }
}
