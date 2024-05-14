namespace Blind75.Graphs;

/*
https://leetcode.com/problems/max-area-of-island/description/

You are given an m x n binary matrix grid.
An island is a group of 1's (representing land) connected 4-directionally (horizontal or vertical.)
You may assume all four edges of the grid are surrounded by water.
The area of an island is the number of cells with a value 1 in the island.
Return the maximum area of an island in grid. If there is no island, return 0.

Example 1:
Input: grid = [[0,0,1,0,0,0,0,1,0,0,0,0,0],
               [0,0,0,0,0,0,0,1,1,1,0,0,0],
               [0,1,1,0,1,0,0,0,0,0,0,0,0],
               [0,1,0,0,1,1,0,0,1,0,1,0,0],
               [0,1,0,0,1,1,0,0,1,1,1,0,0],
               [0,0,0,0,0,0,0,0,0,0,1,0,0],
               [0,0,0,0,0,0,0,1,1,1,0,0,0],
               [0,0,0,0,0,0,0,1,1,0,0,0,0]]
Output: 6
Explanation: The answer is not 11, because the island must be connected 4-directionally.

Example 2:
Input: grid = [[0,0,0,0,0,0,0,0]]
Output: 0

Constraints:
m == grid.length
n == grid[i].length
1 <= m, n <= 50
grid[i][j] is either 0 or 1.

*/

public static class MaxAreaOfIslandClass
{
    public static int MaxAreaOfIsland(int[][] grid)
    {
        int r = grid.Length, c = grid[0].Length, area = 0;

        bool[,] visits = new bool[r, c];
        for (int i = 0; i < r; i++)
        {
            for (int j = 0; j < c; j++)
            {
                area = Math.Max(area, DFSMaxAreaOfIsland(i, j, grid, visits));
            }
        }

        return area;
    }

    private static int DFSMaxAreaOfIsland(int row, int col, int[][] grid, bool[,] visits)
    {
        int m = grid.Length, n = grid[0].Length;
        if (row < 0 || row >= m || col < 0 || col >= n || visits[row, col] || grid[row][col] == 0)
            return 0;
        visits[row, col] = true;
        return (1 + DFSMaxAreaOfIsland(row, col + 1, grid, visits) +
         DFSMaxAreaOfIsland(row, col - 1, grid, visits) +
         DFSMaxAreaOfIsland(row + 1, col, grid, visits) +
         DFSMaxAreaOfIsland(row - 1, col, grid, visits));
    }
}
