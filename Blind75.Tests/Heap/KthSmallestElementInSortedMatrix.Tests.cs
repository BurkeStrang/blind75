namespace Blind75.Tests.Heap;

public class KthSmallestElementInSortedMatrixTests
{
    [Fact]
    public void Example1()
    {
        // Arrange
        int[][] matrix =
        [
            [1, 5, 9],
            [10, 11, 13],
            [12, 13, 15]
        ];
        int k = 8;

        // Act
        int result = KthSmallestElementInSortedMatrix.KthSmallestNumber(matrix, k);

        // Assert
        Assert.Equal(13, result);
    }

    [Fact]
    public void Example2()
    {
        // Arrange
        int[][] matrix =
        [
            [1, 3, 5],
            [6, 7, 12],
            [11, 14, 14]
        ];
        int k = 6;

        // Act
        int result = KthSmallestElementInSortedMatrix.KthSmallestNumber(matrix, k);

        // Assert
        Assert.Equal(11, result);
    }

    [Fact]
    public void Example3()
    {
        // Arrange
        int[][] matrix =
        [
            [2, 4, 8],
            [5, 6, 10],
            [6, 7, 18]
        ];
        int k = 4;

        // Act
        int result = KthSmallestElementInSortedMatrix.KthSmallestNumber(matrix, k);

        // Assert
        Assert.Equal(6, result);
    }
}


