public class DecodeWaysTests
{
    [Theory]
    [InlineData("12", 2)]
    [InlineData("226", 3)]
    [InlineData("0", 0)]
    [InlineData("06", 0)]
    public void NumDecodings_ShouldReturnCorrectResult(string s, int expected)
    {
        // Act
        int result = DecodeWays.NumDecodings(s);
        // Assert
        Assert.Equal(expected, result);
    }
}

