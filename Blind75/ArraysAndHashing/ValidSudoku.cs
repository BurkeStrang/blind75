namespace Blind75.ArraysAndHashing;

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
public class ValidSudokuClass
{
    public static bool ValidSudoku(int[][] grid)
    {
        HashSet<string> set = [];
        for (int row = 0; row < grid.Length; row++)
        {
            for (int col = 0; col < grid[0].Length; col++)
            {
                if (grid[row][col] != 0)
                {
                    string rowCheck = $"row | {row} | {grid[row][col]}";
                    string colCheck = $"col | {col} | {grid[row][col]}";
                    string blockCheck = $"block | {row / 3}, {col / 3} | {grid[row][col]}";

                    if (!set.Add(rowCheck) || !set.Add(colCheck) || !set.Add(blockCheck))
                        return false;
                }
            }
        }
        return true;
    }
}
