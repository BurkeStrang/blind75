namespace Blind75.Tests.TwoPointers;

public class BackspaceStringCompareTests
{
    [Theory]
    [InlineData("ab#c", "ad#c", true)]
    [InlineData("ab##", "c#d#", true)]
    [InlineData("a#c", "b", false)]
    public void Example(string s, string t, bool expected)
    {
        // Arrange
        // Act
        bool actual = BackspaceStringCompare.BackspaceCompare(s,t);
        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Extra()
    {
        // Arrange
        // Act
        bool actual = BackspaceStringCompare.BackspaceCompare("xywrrmp", "xywrrmu#p");
        // Assert
        Assert.True(actual);
    }
}
