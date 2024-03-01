public class TrieNode
{
    public TrieNode()
    {
        childrenMap = new Dictionary<char, TrieNode>();
    }
    public Dictionary<char, TrieNode> childrenMap { get; set; }
    public bool isWord { get; set; }
}
