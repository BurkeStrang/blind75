namespace Blind75.Tests.BitManipulation;

public class ReverseBitsTests
{
    [Fact]
    public void Example1()
    {
        // Arrange
        // 00000010100101000001111010011100
        uint n = 43261596;
        // Act
        uint result = ReverseBitsClass.ReverseBits(n);
        // Assert
        // 00111001011110000010100101000000
        uint expected = 964176192;
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Example2()
    {
        // Arrange
        uint n = 4294967293;
        // Act
        uint result = ReverseBitsClass.ReverseBits(n);
        // Assert
        uint expected = 3221225471;
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Example3()
    {
        // Arrange
        uint n = 1;
        // Act
        uint result = ReverseBitsClass.ReverseBits(n);
        // Assert
        uint expected = 2147483648;
        Assert.Equal(expected, result);
    }
}
