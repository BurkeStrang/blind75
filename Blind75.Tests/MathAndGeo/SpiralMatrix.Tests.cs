public class SpiralMatrixTests
{
    [Fact]
    public void SpiralOrderWhenCalledReturnsSpiralOrder()
    {
        // Arrange
        int[][] matrix = new int[][]
        {
            new int[] { 1, 2, 3 },
            new int[] { 4, 5, 6 },
            new int[] { 7, 8, 9 }
        };
        // Act
        var result = SpiralMatrix.SpiralOrder(matrix);
        // Assert
        Assert.Equal(new int[] { 1, 2, 3, 6, 9, 8, 7, 4, 5 }, result);
    }

    [Fact]
    public void SpiralOrderWhenCalledReturnsSpiralOrder2()
    {
        // Arrange
        int[][] matrix = new int[][]
        {
            new int[] { 1, 2, 3, 4 },
            new int[] { 5, 6, 7, 8 },
            new int[] { 9, 10, 11, 12 }
        };
        // Act
        var result = SpiralMatrix.SpiralOrder(matrix);
        // Assert
        Assert.Equal(new int[] { 1, 2, 3, 4, 8, 12, 11, 10, 9, 5, 6, 7 }, result);
    }
}
