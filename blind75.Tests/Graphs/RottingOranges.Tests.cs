namespace Blind75.Graphs;

public class RottingOrangesTests
{
    [Fact]
    public void Example1()
    {
        // Arrange
        int[][] grid =
        [
            [2, 1, 1],
            [1, 1, 0],
            [0, 1, 1]
        ];
        int expected = 4;
        // Act
        int actual = RottingOranges.OrangesRotting(grid);
        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Example2()
    {
        // Arrange
        int[][] grid =
        [
            [2, 1, 1],
            [0, 1, 1],
            [1, 0, 1]
        ];
        int expected = -1;
        // Act
        int actual = RottingOranges.OrangesRotting(grid);
        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Example3()
    {
        // Arrange
        int[][] grid =
        [
            [0, 2]
        ];
        int expected = 0;
        // Act
        int actual = RottingOranges.OrangesRotting(grid);
        // Assert
        Assert.Equal(expected, actual);
    }
}
