namespace Blind75.Shared;

public class TrieNode
{
    public TrieNode()
    {
        childrenMap = [];
    }
#pragma warning disable IDE1006 // Naming Styles
    public Dictionary<char, TrieNode> childrenMap { get; set; }
    public bool isWord { get; set; }
#pragma warning restore IDE1006 // Naming Styles
    public bool EndOfWord { get; set; }
}
