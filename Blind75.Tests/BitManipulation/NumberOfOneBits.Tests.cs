namespace Blind75.Tests.BitManipulation;

public class NumberOfOneBitsTest
{
    [Fact]
    public void HammingWeightWhenCalledReturnsNumberOfOneBits()
    {
        // Arrange
        uint n = 0b00000000000000000000000000001011;
        // Act
        int result = NumberOfOneBits.HammingWeight(n);
        // Assert
        Assert.Equal(3, result);
    }

    [Fact]
    public void HammingWeightWhenCalledReturnsNumberOfOneBits2()
    {
        // Arrange
        uint n = 0b00000000000000000000000010000000;
        // Act
        int result = NumberOfOneBits.HammingWeight(n);
        // Assert
        Assert.Equal(1, result);
    }


    [Fact]
    public void HammingWeight_WithLargeUintValue_ReturnsCorrectCount()
    {
        uint n = 3_000_000_000; // 1011 0010 1101 0000 0101 1110 0000 0000
        int result = NumberOfOneBits.HammingWeight(n);
        Assert.Equal(12, result);
    }

    [Fact]
    public void AltTest()
    {
        // Arrange
        uint n = 0b00000000000000000000000010000000;
        // Act
        int result = NumberOfOneBits.AlterNateHammingWeight(n);
        // Assert
        Assert.Equal(1, result);
    }

    [Fact]
    public void AltTest_LargeValue()
    {
        uint n = 3_000_000_000; // 1011 0010 1101 0000 0101 1110 0000 0000
        int result = NumberOfOneBits.AlterNateHammingWeight(n);
        Assert.Equal(12, result);
    }

    [Fact]
    public void NetWayTest_LargeValue()
    {
        uint n = 3_000_000_000; // 1011 0010 1101 0000 0101 1110 0000 0000
        int result = NumberOfOneBits.NetWay(n);
        Assert.Equal(12, result);
    }
}
