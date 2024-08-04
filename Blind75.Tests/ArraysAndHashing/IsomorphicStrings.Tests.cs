namespace Blind75.Tests.ArraysAndHashing;

public class IsomorphicStringsTests
{
    [Fact]
    public void Example1()
    {
        // Arrange
        string s = "egg";
        string t = "add";
        bool expected = true;
        // Act
        bool actual = IsomorphicStrings.IsIsomorphic(s, t);
        // Assert
        Assert.Equal(expected, actual);
    }
    [Fact]
    public void Example2()
    {
        // Arrange
        string s = "foo";
        string t = "bar";
        bool expected = false;
        // Act
        bool actual = IsomorphicStrings.IsIsomorphic(s, t);
        // Assert
        Assert.Equal(expected, actual);
    }
    [Fact]
    public void Example3()
    {
        // Arrange
        string s = "paper";
        string t = "title";
        bool expected = true;
        // Act
        bool actual = IsomorphicStrings.IsIsomorphic(s, t);
        // Assert
        Assert.Equal(expected, actual);
    }
}
