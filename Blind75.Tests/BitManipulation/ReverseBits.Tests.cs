public class ReverseBitsTests
{
    [Fact]
    public void ReverseBitsWhenCalledReturnsReverseBits()
    {
        // Arrange
        uint n = 43261596;
        // Act
        uint result = ReverseBitsClass.ReverseBits(n);
        // Assert
        uint expected = 964176192;
        Assert.Equal(expected, result);
    }

    [Fact]
    public void ReverseBitsWhenCalledReturnsReverseBits2()
    {
        // Arrange
        uint n = 4294967293;
        // Act
        uint result = ReverseBitsClass.ReverseBits(n);
        // Assert
        uint expected = 3221225471;
        Assert.Equal(expected, result);
    }
}
