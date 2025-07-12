namespace Blind75.Tests.ArraysAndHashing;

public class FirstUniqueCharInStringTests
{
    [Fact]
    public void Example1()
    {
        // Arrange
        string s = "leetcode";
        int expected = 0;
        // Act
        int result = FirstUniqueCharInString.FirstUniqChar(s);
        // Assert
        result.ShouldBe(expected);
    }

    [Fact]
    public void Example2()
    {
        // Arrange
        string s = "loveleetcode";
        int expected = 2;
        // Act
        int result = FirstUniqueCharInString.FirstUniqChar(s);
        // Assert
        result.ShouldBe(expected);
    }

    [Fact]
    public void Example3()
    {
        // Arrange
        string s = "aabb";
        int expected = -1;
        // Act
        int result = FirstUniqueCharInString.FirstUniqChar(s);
        // Assert
        result.ShouldBe(expected);
    }
}
