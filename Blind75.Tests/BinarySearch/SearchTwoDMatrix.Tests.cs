namespace Blind75.BinarySearch;

public class SearchTwoDMatrixTest
{
    [Fact]
    public void Example1()
    {
        // Arrange
        int[][] matrix =
        [
            [1, 3, 5, 7],
            [10, 11, 16, 20],
            [23, 30, 34, 60]
        ];
        int target = 3;
        // Act
        bool result = SearchTwoDMatrix.SearchMatrix(matrix, target);
        // Assert
        Assert.True(result);
    }
    [Fact]
    public void Example2()
    {
        // Arrange
        int[][] matrix =
        [
            [1, 3, 5, 7],
            [10, 11, 16, 20],
            [23, 30, 34, 60]
        ];
        int target = 13;
        // Act
        bool result = SearchTwoDMatrix.SearchMatrix(matrix, target);
        // Assert
        Assert.False(result);
    }
}
