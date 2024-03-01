
public class TriePrefixTree
{
    [Fact]
    public void TriePrefixTreeCorrect()
    {
        var trie = new Trie();
        trie.Insert("Test");

        bool exp = true;
        bool res = trie.Search("Test");

        Assert.Equal(exp, res);

        bool pre = trie.StartsWith("Te");
        Assert.Equal(exp, pre);
    }
}
