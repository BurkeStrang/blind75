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
}
