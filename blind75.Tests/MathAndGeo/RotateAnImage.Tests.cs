namespace Blind75.MathAndGeo;


public class RotateAnImageTests
{
    [Fact]
    public void Example1()
    {
        // Arrange
        int[][] matrix =
        [
            [1, 2, 3],
            [4, 5, 6],
            [7, 8, 9]
        ];
        int[][] expected =
        [
            [7, 4, 1],
            [8, 5, 2],
            [9, 6, 3]
        ];
        // Act
        RotateAnImage.Rotate(matrix);
        // Assert
        Assert.Equal(expected, matrix);
    }

    [Fact]
    public void Example2()
    {
        // Arrange
        int[][] matrix =
        [
            [5, 1, 9, 11],
            [2, 4, 8, 10],
            [13, 3, 6, 7],
            [15, 14, 12, 16]
        ];
        int[][] expected =
        [
            [15, 13, 2, 5],
            [14, 3, 4, 1],
            [12, 6, 8, 9],
            [16, 7, 10, 11]
        ];
        // Act
        RotateAnImage.Rotate(matrix);
        // Assert
        Assert.Equal(expected, matrix);
    }
    [Fact]
    public void Example3()
    {
        // Arrange
        int[][] matrix =
        [
            [1, 2],
            [3, 4]
        ];
        int[][] expected =
        [
            [3, 1],
            [4, 2]
        ];
        // Act
        RotateAnImage.Rotate(matrix);
        // Assert
        Assert.Equal(expected, matrix);
    }
    [Fact]
    public void Example4()
    {
        // Arrange
        int[][] matrix =
        [
            [1]
        ];
        int[][] expected =
        [
            [1]
        ];
        // Act
        RotateAnImage.Rotate(matrix);
        // Assert
        Assert.Equal(expected, matrix);
    }
    [Fact]
    public void Example5()
    {
        // Arrange
        int[][] matrix =
        [
            [1, 2, 3, 4, 5],
            [6, 7, 8, 9, 10],
            [11, 12, 13, 14, 15],
            [16, 17, 18, 19, 20],
            [21, 22, 23, 24, 25]
        ];
        int[][] expected =
        [
            [21, 16, 11, 6, 1],
            [22, 17, 12, 7, 2],
            [23, 18, 13, 8, 3],
            [24, 19, 14, 9, 4],
            [25, 20, 15, 10, 5]
        ];
        // Act
        RotateAnImage.Rotate(matrix);
        // Assert
        Assert.Equal(expected, matrix);
    }
}
