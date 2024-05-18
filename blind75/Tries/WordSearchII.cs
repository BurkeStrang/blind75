namespace Blind75.Tries;
// Given an m x n board of characters and a list of strings words, return all words on the board.
// Each word must be constructed from letters of sequentially adjacent cells,
// where adjacent cells are horizontally or vertically neighboring.
// The same letter cell may not be used more than once in a word.

public class WordSearchIIClass
{
    public TrieNode Root = new();

    public void AddWord(string word)
    {
        TrieNode current = Root;
        for (int i = 0; i < word.Length; i++)
        {
            if (!current.childrenMap.TryGetValue(word[i], out TrieNode? value))
            {
                TrieNode child = new();
                value = child;
                current.childrenMap.Add(word[i], value);
            }
            current = value;
        }
        current.EndOfWord = true;

    }

    public IList<string> FindWords(char[][] board, string[] words)
    {
        foreach (string word in words)
            AddWord(word);

        int rows = board.Length;
        int cols = board[0].Length;

        HashSet<string> result = [];
        HashSet<(int, int)> visited = [];

        void Dfs(int row, int col, TrieNode node, string word)
        {

            if (row < 0 || col < 0 || row >= rows || col >= cols ||
              visited.Contains((row, col)) ||
              !node.childrenMap.TryGetValue(board[row][col], out TrieNode? value))
                return;

            visited.Add((row, col));
            node = value;
            word += board[row][col];

            if (node.EndOfWord)
                result.Add(word);

            Dfs(row - 1, col, node, word);
            Dfs(row + 1, col, node, word);
            Dfs(row, col - 1, node, word);
            Dfs(row, col + 1, node, word);

            visited.Remove((row, col));
        }

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {

                Dfs(row, col, Root, "");
            }
        }

        return result.ToList();
    }
}
