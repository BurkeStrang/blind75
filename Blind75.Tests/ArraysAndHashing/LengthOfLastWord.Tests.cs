namespace Blind75.Tests.ArraysAndHashing;

public class LengthOfLastWordTests
{
    [Fact]
    public void Example1()
    {
        // Arrange
        string s = "Hello World";
        int expected = 5;
        // Act
        int actual = LengthOfLastWordClass.LengthOfLastWord(s);
        // Assert
        Assert.Equal(expected, actual);
    }
    [Fact]
    public void Example2()
    {
        // Arrange
        string s = " ";
        int expected = 0;
        // Act
        int actual = LengthOfLastWordClass.LengthOfLastWord(s);
        // Assert
        Assert.Equal(expected, actual);
    }
    [Fact]
    public void Example3()
    {
        // Arrange
        string s = "a ";
        int expected = 1;
        // Act
        int actual = LengthOfLastWordClass.LengthOfLastWord(s);
        // Assert
        Assert.Equal(expected, actual);
    }
}
