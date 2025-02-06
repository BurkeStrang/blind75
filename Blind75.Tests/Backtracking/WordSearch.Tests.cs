namespace Blind75.Tests.Backtracking;

// Input: board = [["A","B","C","E"],["S","F","C","S"],["A","D","E","E"]], word = "ABCCED"
// Output: true

public class WordSearch
{
    [Fact]
    public void WordSearchCorrect()
    {
        char[][] board = [['A', 'B', 'C', 'E'], ['S', 'F', 'C', 'S'], ['A', 'D', 'E', 'E']];
        string word = "ABCCED";

        bool exp = true;
        Assert.Equal(exp, WordSearchClass.Exist(board, word));
    }
}
