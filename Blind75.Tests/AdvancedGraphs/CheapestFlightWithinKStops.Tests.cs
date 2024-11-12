namespace Blind75.Tests.AdvancedGraphs;

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
        int n = 3;
        int[][] flights =
        [
            [0, 1, 100],
            [1, 2, 100],
            [0, 2, 500]
        ];
        int src = 0;
        int dst = 2;
        int k = 0;
        // Act
        int result = CheapestFlightsWithinKStops.FindCheapestPrice(n, flights, src, dst, k);
        // Assert
        Assert.Equal(500, result);
    }
}
