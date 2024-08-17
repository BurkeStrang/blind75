namespace Blind75.Tests.ArraysAndHashing;

public class RedistributeCharToMakeEqualTests
{
    [Theory]
#pragma warning disable CA1861 // Avoid constant arrays as arguments
    [InlineData(new string[] { "abc", "aabc", "bc" }, true)]
    [InlineData(new string[] { "ab", "a" }, false)]
#pragma warning restore CA1861 // Avoid constant arrays as arguments
    public void MakeEqual_ShouldReturn_IfAllStringsCanBeMadeEqual(string[] words, bool expected)
    {
        // Arrange
        // Act
        bool actual = RedistributeCharToMakeEqual.MakeEqual(words);
        // Assert
        actual.Should().Be(expected);
    }
}
