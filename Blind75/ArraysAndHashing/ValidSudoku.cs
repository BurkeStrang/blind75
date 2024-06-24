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
        HashSet<Cell> set = [];
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[0].Length; j++)
            {
                // don't check empty cells which are 0
                // they will cause false negatives
                if (grid[i][j] != 0)
                {
                    Cell row = new(CellType.Row, (i, 0), grid[i][j]);
                    Cell col = new(CellType.Col, (0, j), grid[i][j]);
                    Cell box = new(CellType.Box, (i / 3, j / 3), grid[i][j]);
                    if (!set.Add(row) || !set.Add(col) || !set.Add(box))
                        return false;
                }
            }
        }
        return true;
    }

    private enum CellType
    {
        Row,
        Col,
        Box
    }

    private record struct Cell(CellType Type, (int Row, int Col) Cord, int Value);
}
