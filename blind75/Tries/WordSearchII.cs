// Given an m x n board of characters and a list of strings words, return all words on the board.
// Each word must be constructed from letters of sequentially adjacent cells,
// where adjacent cells are horizontally or vertically neighboring.
// The same letter cell may not be used more than once in a word.

public class WordSearchIIClass
{
    public TrieNode root = new TrieNode();

    public void AddWord(string word)
    {
        var current = root;
        for (var i = 0; i < word.Length; i++)
        {
            if (!current.childrenMap.ContainsKey(word[i]))
            {
                var child = new TrieNode();
                current.childrenMap.Add(word[i], child);
            }
            current = current.childrenMap[word[i]];
        }
        current.EndOfWord = true;

    }

    public IList<string> FindWords(char[][] board, string[] words)
    {
        foreach (var word in words)
            AddWord(word);

        var rows = board.Length;
        var cols = board[0].Length;

        var result = new HashSet<string>();
        var visited = new HashSet<(int, int)>();

        void dfs(int row, int col, TrieNode node, string word)
        {

            if (row < 0 || col < 0 || row >= rows || col >= cols ||
              visited.Contains((row, col)) ||
              !node.childrenMap.ContainsKey(board[row][col]))
                return;

            visited.Add((row, col));
            node = node.childrenMap[board[row][col]];
            word += board[row][col];

            if (node.EndOfWord)
                result.Add(word);

            dfs(row - 1, col, node, word);
            dfs(row + 1, col, node, word);
            dfs(row, col - 1, node, word);
            dfs(row, col + 1, node, word);

            visited.Remove((row, col));
        }

        for (var row = 0; row < rows; row++)
        {
            for (var col = 0; col < cols; col++)
            {

                dfs(row, col, root, "");
            }
        }

        return result.ToList();
    }
}
