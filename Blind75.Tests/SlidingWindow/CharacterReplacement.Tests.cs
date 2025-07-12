namespace Blind75.Tests.SlidingWindow;

public class CharacterReplacementTests
{
    [Fact]
    public void ABAB()
    {
        int k = 2;
        string s = "ABAB";
        int res = CharacterReplacementClass.CharacterReplacement(s, k);
        res.ShouldBe(4);
    }

    [Fact]
    public void AABABBA()
    {
        int k = 1;
        string s = "AABABBA";
        int res = CharacterReplacementClass.CharacterReplacement(s, k);
        res.ShouldBe(4);
    }
}
