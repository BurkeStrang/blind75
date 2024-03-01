public class Trie
{

    private TrieNode root;
    public Trie()
    {
        root = new TrieNode();
    }

    public void Insert(string word)
    {
        var cur = root;
        foreach (var c in word)
        {
            if (!cur.childrenMap.ContainsKey(c))
            {
                cur.childrenMap[c] = new TrieNode();
            }
            cur = cur.childrenMap[c];
        }
        cur.isWord = true;
    }

    public bool Search(string word)
    {
        var node = traverse(word);
        return node != null && node.isWord;
    }

    public bool StartsWith(string prefix)
    {
        var node = traverse(prefix);
        return node != null;
    }

    private TrieNode? traverse(string path)
    {
        var cur = root;

        foreach (var c in path)
        {
            if (cur.childrenMap.ContainsKey(c))
            {
                cur = cur.childrenMap[c];
            }
            else
            {
                return null;
            }
        }
        return cur;
    }
}
