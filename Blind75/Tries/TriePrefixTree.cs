namespace Blind75.Tries;

public class Trie
{

    private readonly TrieNode _root;
    public Trie()
    {
        _root = new TrieNode();
    }

    public void Insert(string word)
    {
        TrieNode cur = _root;
        foreach (char c in word)
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
        TrieNode? node = Traverse(word);
        return node != null && node.isWord;
    }

    public bool StartsWith(string prefix)
    {
        TrieNode? node = Traverse(prefix);
        return node != null;
    }

    private TrieNode? Traverse(string path)
    {
        TrieNode cur = _root;

        foreach (char c in path)
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
