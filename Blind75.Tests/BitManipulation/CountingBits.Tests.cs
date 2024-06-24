public class CountingBitsTests
{
    [Fact]
    public void CountBitsWhenCalledReturnsCountBits()
    {
        // Arrange
        int n = 2;
        // Act
        int[] result = CountingBits.CountBits(n);
        // Assert
        Assert.Equal(new int[] { 0, 1, 1 }, result);
    }

    [Fact]
    public void CountBitsWhenCalledReturnsCountBits2()
    {
        // Arrange
        int n = 5;
        // Act
        int[] result = CountingBits.CountBits(n);
        // Assert
        Assert.Equal(new int[] { 0, 1, 1, 2, 1, 2 }, result);
    }
}
