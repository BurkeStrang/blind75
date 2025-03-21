namespace Blind75.Backtracking;

// Given an m x n grid of characters board and a string word,
// return true if word exists in the grid.

// The word can be constructed from letters of sequentially adjacent cells,
// where adjacent cells are horizontally or vertically neighboring.
// The same letter cell may not be used more than once.

// Input: board = [["A","B","C","E"],["S","F","C","S"],["A","D","E","E"]], word = "ABCCED"
// Output: true

public static class WordSearchClass
{
    //T:O(N*M*4^LenOfWord), S: O(m+n+ L)
    //S: O(m+n) is for the visited array
    public static bool Exist(char[][] board, string word)
    {
        int rows = board.Length;
        int cols = board[0].Length;
        bool[,] visited = new bool[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (board[i][j] == word[0] && Search(i, j, 0, word, board, visited))
                    return true;
            }
        }

        return false;
    }

    public static bool Search(int r, int c, int index, string word, char[][] board, bool[,] visited)
    {
        int rows = board.Length;
        int cols = board[0].Length;

        if (index == word.Length)
            return true;
        if (r < 0 || c < 0 || r >= rows || c >= cols || word[index] != board[r][c] || visited[r, c])
            return false;

        visited[r, c] = true;
        bool result =
            Search(r + 1, c, index + 1, word, board, visited)
            || Search(r - 1, c, index + 1, word, board, visited)
            || Search(r, c + 1, index + 1, word, board, visited)
            || Search(r, c - 1, index + 1, word, board, visited);

        visited[r, c] = false;
        return result;
    }
}
