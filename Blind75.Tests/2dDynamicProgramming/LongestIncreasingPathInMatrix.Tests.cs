namespace Blind75.DynamicProgramming;

public class LongestIncreasingPathInMatrixTests
{
    [Fact]
    public void Example1()
    {
        // Arrange
        int[][] matrix =
        [
            [9, 9, 4],
            [6, 6, 8],
            [2, 1, 1]
        ];
        // Act
        int result = LongestIncreasingPathInMatrix.LongestIncreasingPath(matrix);

        // Assert
        Assert.Equal(4, result);
    }

    [Fact]
    public void Example2()
    {
        // Arrange
        int[][] matrix =
        [
            [3, 4, 5],
            [3, 2, 6],
            [2, 2, 1]
        ];
        // Act
        int result = LongestIncreasingPathInMatrix.LongestIncreasingPath(matrix);
        // Assert
        Assert.Equal(4, result);
    }

    [Fact]
    public void Example3()
    {
        // Arrange
        int[][] matrix = [[1]];
        // Act
        int result = LongestIncreasingPathInMatrix.LongestIncreasingPath(matrix);
        // Assert
        Assert.Equal(1, result);
    }
}
