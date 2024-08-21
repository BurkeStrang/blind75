namespace Blind75.Tests.ArraysAndHashing;

public class BrickWallTests
{
    [Fact]
    public void Example1()
    {
        // Arrange
        IList<IList<int>> wall =
        [
            [1, 2, 2, 1],
            [3, 1, 2],
            [1, 3, 2],
            [2, 4],
            [3, 1, 2],
            [1, 3, 1, 1]
        ];
        int expected = 2;
        // Act
        int result = BrickWall.LeastBricks(wall);
        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Example2()
    {
        // Arrange
        IList<IList<int>> wall =
        [
            [1],
            [1],
            [1]
        ];
        int expected = 3;
        // Act
        int result = BrickWall.LeastBricks(wall);
        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Example3()
    {
        // Arrange
        IList<IList<int>> wall =
        [
            [1],
            [1],
            [1],
            [1]
        ];
        int expected = 4;
        // Act
        int result = BrickWall.LeastBricks(wall);
        // Assert
        Assert.Equal(expected, result);
    }
}
