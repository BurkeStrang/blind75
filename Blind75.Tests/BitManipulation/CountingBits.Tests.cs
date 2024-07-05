namespace Blind75.Tests.BitManipulation;

public class CountingBitsTests
{
    [Fact]
    public void Example1()
    {
        // Arrange
        int n = 2;
        // Act
        int[] result = CountingBits.CountBits(n);
        // Assert
        result.Should().Equal([0, 1, 1]);
    }

    [Fact]
    public void Example2()
    {
        // Arrange
        int n = 5;
        // Act
        int[] result = CountingBits.CountBits(n);
        // Assert
        result.Should().Equal([0, 1, 1, 2, 1, 2]);
    }
}
