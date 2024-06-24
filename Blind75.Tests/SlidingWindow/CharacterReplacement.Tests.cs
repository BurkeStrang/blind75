namespace Blind75.SlidingWindow;

public class CharacterReplacementTests
{
    [Fact]
    public void ABAB()
    {
        int k = 2;
        string s = "ABAB";
        int res = CharacterReplacementClass.CharacterReplacement(s, k);
        Assert.Equal(4, res);
    }

    [Fact]
    public void AABABBA()
    {
        int k = 1;
        string s = "AABABBA";
        int res = CharacterReplacementClass.CharacterReplacement(s, k);
        Assert.Equal(4, res);
    }
}
