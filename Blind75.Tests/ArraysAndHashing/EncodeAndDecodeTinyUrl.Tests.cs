namespace Blind75.Tests.ArraysAndHashing;

public class EncodeAndDecodeTinyUrlTests
{
    [Fact]
    public void Example1()
    {
        // Arrange
        string url = "https://leetcode.com/problems/design-tinyurl";
        // Act
        EncodeAndDecodeTinyUrl obj = new();
        string tiny = obj.Encode(url);
        string ans = obj.Decode(tiny);
        // Assert
        ans.Should().Be(url);
    }

    [Fact]
    public void Example2()
    {
        // Arrange
        string url = "https://leetcode.com/longer-url";
        // Act
        EncodeAndDecodeTinyUrl obj = new();
        string tiny = obj.Encode(url);
        string ans = obj.Decode(tiny);
        // Assert
        ans.Should().Be(url);
    }
}
