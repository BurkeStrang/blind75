namespace Blind75.Tests.ArraysAndHashing;

public class CanPlaceFlowersTests
{
    [Fact]
    public void Test1()
    {
        // Arrange
        int[] flowerbed = [1, 0, 0, 0, 1];
        int n = 1;
        bool expected = true;
        // Act
        bool actual = CanPlaceFlowersClass.CanPlaceFlowers(flowerbed, n);
        // Assert
        Assert.Equal(expected, actual);
    }
    [Fact]
    public void Test2()
    {
        // Arrange
        int[] flowerbed = [1, 0, 0, 0, 1];
        int n = 2;
        bool expected = false;
        // Act
        bool actual = CanPlaceFlowersClass.CanPlaceFlowers(flowerbed, n);
        // Assert
        Assert.Equal(expected, actual);
    }
}
