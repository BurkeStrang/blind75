namespace Blind75.BinarySearch;

public class KokoEatingBananasTests
{
    [Fact]
    public void Example1()
    {
        // Arrange
        int[] piles = { 3, 6, 7, 11 };
        int h = 8;
        // Act
        int result = KokoEatingBananas.MinEatingSpeed(piles, h);
        // Assert
        Assert.Equal(4, result);
    }
    [Fact]
    public void Example2()
    {
        // Arrange
        int[] piles = { 30, 11, 23, 4, 20 };
        int h = 5;
        // Act
        int result = KokoEatingBananas.MinEatingSpeed(piles, h);
        // Assert
        Assert.Equal(30, result);
    }
    [Fact]
    public void Example3()
    {
        // Arrange
        int[] piles = { 30, 11, 23, 4, 20 };
        int h = 6;
        // Act
        int result = KokoEatingBananas.MinEatingSpeed(piles, h);
        // Assert
        Assert.Equal(23, result);
    }
}
