namespace Blind75.Tests.TwoPointers;

public class ReverseWordsInStringIIITests
{
    [Theory]
    [InlineData("Let's take LeetCode contest", "s'teL ekat edoCteeL tsetnoc")]
    [InlineData("Mr Ding", "rM gniD")]
    public void ReverseWords_ShouldReturnExpectedResult(string s, string expected)
    {
        // Arrange
        // Act
        string result = ReverseWordsInStringIII.ReverseWords(s);
        // Assert
        expected.ShouldBe(result);
    }
}
