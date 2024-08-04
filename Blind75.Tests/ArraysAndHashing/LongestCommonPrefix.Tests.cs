namespace Blind75.Tests.ArraysAndHashing;

public class LongestCommonPrefixTests
{
    [Fact]
    public void Example1()
    {
        // Arrange
        string[] strs = ["flower", "flow", "flight"];
        string expected = "fl";
        // Act
        string actual = LongestCommonPrefixClass.LongestCommonPrefix(strs);
        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Example2()
    {
        // Arrange
        string[] strs = ["dog", "racecar", "car"];
        string expected = "";
        // Act
        string actual = LongestCommonPrefixClass.LongestCommonPrefix(strs);
        // Assert
        Assert.Equal(expected, actual);
    }
}
