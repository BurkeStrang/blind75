namespace Blind75.Graphs;

public class SurroundedRegionsTest
{
    [Fact]
    public void Example1()
    {
        // Arrange
        char[][] board =
        [
            ['X', 'X', 'X', 'X'],
            ['X', 'O', 'O', 'X'],
            ['X', 'X', 'O', 'X'],
            ['X', 'O', 'X', 'X']
        ];
        char[][] expected =
        [
            ['X', 'X', 'X', 'X'],
            ['X', 'X', 'X', 'X'],
            ['X', 'X', 'X', 'X'],
            ['X', 'O', 'X', 'X']
        ];
        // Act
        SurroundedRegions.Solve(board);
        // Assert
        Assert.Equal(expected, board);
    }
    [Fact]
    public void Example2()
    {
        // Arrange
        char[][] board =
        [
            ['X']
        ];
        char[][] expected =
        [
            ['X']
        ];
        // Act
        SurroundedRegions.Solve(board);
        // Assert
        Assert.Equal(expected, board);
    }
}
