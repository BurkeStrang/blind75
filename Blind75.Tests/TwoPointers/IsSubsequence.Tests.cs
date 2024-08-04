namespace Blind75.Tests.TwoPointers;

public class IsSubsequenceTests
{
    [Fact]
    public void Example1()
    {
        // Arrange
        string s = "abc";
        string t = "ahbgdc";
        bool expected = true;
        // Act
        bool actual = IsSubsequenceClass.IsSubsequence(s, t);
        // Assert
        Assert.Equal(expected, actual);
    }
    [Fact]
    public void Example2()
    {
        // Arrange
        string s = "axc";
        string t = "ahbgdc";
        bool expected = false;
        // Act
        bool actual = IsSubsequenceClass.IsSubsequence(s, t);
        // Assert
        Assert.Equal(expected, actual);
    }
}
