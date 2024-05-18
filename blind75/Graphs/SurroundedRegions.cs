namespace Blind75.Graphs;

/*

Given an m x n matrix board containing 'X' and 'O', capture all regions that are 4-directionally surrounded by 'X'.
A region is captured by flipping all 'O's into 'X's in that surrounded region.

Example 1:
Input: board = [["X","X","X","X"],
                ["X","O","O","X"],
                ["X","X","O","X"],
                ["X","O","X","X"]]

Output: [["X","X","X","X"],
         ["X","X","X","X"],
         ["X","X","X","X"],
         ["X","O","X","X"]]
Explanation: Notice that an 'O' should not be flipped if:
- It is on the border, or
- It is adjacent to an 'O' that should not be flipped.
The bottom 'O' is on the border, so it is not flipped.
The other three 'O' form a surrounded region, so they are flipped.

Example 2:
Input: board = [["X"]]
Output: [["X"]]

Constraints:
m == board.length
n == board[i].length
1 <= m, n <= 200
board[i][j] is 'X' or 'O'.

*/

public static class SurroundedRegions
{
    public static void Solve(char[][] board)
    {
        int rows = board.Length;
        if (rows == 0)
            return;
        int cols = board[0].Length;

        // Step 1: Mark the 'O's on the border and connected to border with a temporary marker 'T'
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if ((i == 0 || j == 0 || i == rows - 1 || j == cols - 1) && board[i][j] == 'O')
                {
                    CaptureDfs(board, i, j);
                }
            }
        }

        // Step 2: Flip all remaining 'O's to 'X's
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (board[i][j] == 'O')
                {
                    board[i][j] = 'X';
                }
            }
        }

        // Step 3: Flip all 'T's back to 'O's
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (board[i][j] == 'T')
                {
                    board[i][j] = 'O';
                }
            }
        }
    }

    // Helper method to perform DFS and mark connected 'O's as 'T'
    private static void CaptureDfs(char[][] board, int x, int y)
    {
        int rows = board.Length;
        int cols = board[0].Length;

        if (x < 0 || x >= rows || y < 0 || y >= cols || board[x][y] != 'O')
        {
            return;
        }

        board[x][y] = 'T';

        CaptureDfs(board, x + 1, y); // Down
        CaptureDfs(board, x - 1, y); // Up
        CaptureDfs(board, x, y + 1); // Right
        CaptureDfs(board, x, y - 1); // Left
    }
}
