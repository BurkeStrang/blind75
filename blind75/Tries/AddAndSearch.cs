namespace Blind75.Tries;

public class WordDictionary
{
    public TrieNode Root;

    public WordDictionary()
    {
        Root = new TrieNode();
    }

    public void AddWord(string word)
    {
        TrieNode current = Root;
        for (int i = 0; i < word.Length; i++)
        {
            if (!current.childrenMap.TryGetValue(word[i], out TrieNode? value))
            {
                TrieNode newNode = new();
                value = newNode;
                current.childrenMap.Add(word[i], value);
            }
            current = value;
        }
        current.EndOfWord = true;
    }

    public bool Search(string word)
    {
        return Dfs(0, Root, word);
    }

    private static bool Dfs(int index, TrieNode root, string word)
    {
        TrieNode currentNode = root;

        for (int i = index; i < word.Length; i++)
        {
            char letter = word[i];
            if (letter == '.')
            {
                foreach ((char key, TrieNode value) in currentNode.childrenMap)
                {
                    if (Dfs(i + 1, value, word))
                    {
                        return true;
                    }
                }

                return false;
            }
            else
            {
                if (!currentNode.childrenMap.TryGetValue(letter, out TrieNode? value))
                {
                    return false;
                }
                currentNode = value;
            }
        }
        return currentNode.EndOfWord;
    }
}
