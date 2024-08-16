namespace Blind75.Tests.ArraysAndHashing;

public class MinChangesAltBinaryStringTests
{
    [Theory]
    [InlineData("0100", 1)]
    [InlineData("10", 0)]
    [InlineData("1111", 2)]
    public void MinOperations_ShouldReturn_MinimumNumberOfOperationsNeededToMakeStringAlternating(string s, int expected)
    {
        // Arrange
        // Act
        int actual = MinChangesAltBinaryString.MinOperations(s);
        // Assert
        actual.Should().Be(expected);
    }
}
