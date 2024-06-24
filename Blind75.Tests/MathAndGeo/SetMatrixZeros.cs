public class SetMatrixZerosTests
{
    [Fact]
    public void SetZeroesWhenCalledReturnsSetZeroes()
    {
        // Arrange
        int[][] matrix = new int[][]
        {
            new int[] { 1, 1, 1 },
            new int[] { 1, 0, 1 },
            new int[] { 1, 1, 1 }
        };
        // Act
        SetMatrixZeros.SetZeroes(matrix);
        // Assert
        Assert.Equal(new int[] { 0, 0, 0 }, matrix[1]);
        Assert.Equal(new int[] { 1, 0, 1 }, matrix[0]);
        Assert.Equal(new int[] { 1, 0, 1 }, matrix[2]);
    }
}
