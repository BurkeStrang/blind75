namespace Blind75.Tries;

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
            if (!cur.childrenMap.TryGetValue(c, out TrieNode? value))
            {
                value = new TrieNode();
                cur.childrenMap[c] = value;
            }
            cur = value;
        }
        cur.isWord = true;
    }

    public bool Search(string word)
    {
        var node = Traverse(word);
        return node != null && node.isWord;
    }

    public bool StartsWith(string prefix)
    {
        var node = Traverse(prefix);
        return node != null;
    }

    private TrieNode? Traverse(string path)
    {
        var cur = root;

        foreach (var c in path)
        {
            if (cur.childrenMap.TryGetValue(c, out TrieNode? value))
            {
                cur = value;
            }
            else
            {
                return null;
            }
        }
        return cur;
    }
}
