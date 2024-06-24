namespace Blind75.Stack;

public class CarFleetTest
{
    [Fact]
    public void Example1()
    {
        // Arrange
        int target = 12;
        int[] position = [10, 8, 0, 5, 3];
        int[] speed = [2, 4, 1, 1, 3];
        // Act
        int result = CarFleetClass.CarFleet(target, position, speed);
        // Assert
        Assert.Equal(3, result);
    }
    [Fact]
    public void Example2()
    {
        // Arrange
        int target = 10;
        int[] position = [6, 8];
        int[] speed = [3, 2];
        // Act
        int result = CarFleetClass.CarFleet(target, position, speed);
        // Assert
        Assert.Equal(2, result);
    }
    [Fact]
    public void Example3()
    {
        // Arrange
        int target = 100;
        int[] position = [0, 2, 4];
        int[] speed = [4, 2, 1];
        // Act
        int result = CarFleetClass.CarFleet(target, position, speed);
        // Assert
        Assert.Equal(1, result);
    }
}
