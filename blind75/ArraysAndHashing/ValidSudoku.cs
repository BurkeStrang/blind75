namespace blind75.ArraysAndHashing;

/*

Determine if a 9 x 9 Sudoku board is valid.
Only the filled cells need to be validated according to the following rules:

Each row must contain the digits 1-9 without repetition.
Each column must contain the digits 1-9 without repetition.
Each of the nine 3 x 3 sub-boxes of the grid must contain the digits 1-9 without repetition.

Note:
A Sudoku board (partially filled) could be valid but is not necessarily solvable.
Only the filled cells need to be validated according to the mentioned rules.

 */
public static class ValidSudokuClass
{
    public static bool ValidSudoku(int[][] grid)
    {
        int n = grid.Length;
        int m = grid[0].Length;
        HashSet<string> set = new();
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (grid[i][j] != 0)
                {
                    string row = "row" + i + " " + grid[i][j];
                    string col = "col" + j + " " + grid[i][j];
                    string box = "box" + i / 3 + " " + j / 3 + " " + grid[i][j];
                    if (set.Contains(row) || set.Contains(col) || set.Contains(box))
                    {
                        return false;
                    }
                    set.Add(row);
                    set.Add(col);
                    set.Add(box);
                }
            }
        }
        return true;
    }
}
