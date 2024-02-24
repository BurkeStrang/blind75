public class CharcterReplacementTests
{
    [Fact]
    public void ReturnValidCharacterReplacement()
    {
        int k = 2;
        string s = "ABAB";
        int res = CharacterReplacementClass.CharacterReplacement(s, k);
        Assert.Equal(4, res);
    }
}
