// Input: board = [["A","B","C","E"],["S","F","C","S"],["A","D","E","E"]], word = "ABCCED"
// Output: true

public class WordSearch
{
    [Fact]
    public void WordSearchCorrect()
    {
        char[][] board = new char[3][];
        board[0] = new char[] { 'A', 'B', 'C', 'E' };
        board[1] = new char[] { 'S', 'F', 'C', 'S' };
        board[2] = new char[] { 'A', 'D', 'E', 'E' };
        string word = "ABCCED";

        bool exp = true;
        Assert.Equal(exp, WordSearchClass.Exist(board, word));
    }
}
