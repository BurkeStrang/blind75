
namespace Blind75.Tests.ArraysAndHashing;

public class MinimalMaxBrokenWordsTests
{
    [Theory]
    [InlineData("Hello, World!", 'l', 2)]
    public void TestMinimalMaxBrokenWords(string input, char expectedChar, int expectedCount)
    {
        Tuple<char, int> result = MinimalMaxBrokenWordsSolution.MinimalMaxBrokenWords(input);
        Assert.Equal(new Tuple<char,int>(expectedChar,expectedCount), result);
    }
}
