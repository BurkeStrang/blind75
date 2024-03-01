public class AddAndSearch
{
    [Fact]
    public void AddAndSearchCorrect()
    {
        var wd = new WordDictionary();
        wd.AddWord("test");
        var res = wd.Search("test");

        var exp = true;

        Assert.Equal(exp, res);

    }
}
