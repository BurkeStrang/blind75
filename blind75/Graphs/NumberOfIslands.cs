namespace blind75.Graphs;

// Given an m x n 2D binary grid grid which represents a map of '1's (land) and '0's (water),
// return the number of islands.

// An island is surrounded by water and is formed by connecting adjacent lands horizontally or vertically.
// You may assume all four edges of the grid are all surrounded by water.

// Example 1:
// Input: grid = [
// ["1","1","1","1","0"],
// ["1","1","0","1","0"],
// ["1","1","0","0","0"],
// ["0","0","0","0","0"]
// ]
// Output: 1

public static class NumerberOfIslandsClass
{
    public static int NumIslands(char[][] grid)
    {
        int m = grid.Length;
        int n = grid[0].Length;
        bool[,] visited = new bool[m, n];
        int numIslands = 0;

        void dfs(int i, int j, char[][] grid)
        {
            if (i < 0 || i >= m)
            {
                return;
            }
            if (j < 0 || j >= n)
            {
                return;
            }
            if (visited[i, j] || grid[i][j] == '0')
            {
                return;
            }
            visited[i, j] = true;

            dfs(i + 1, j, grid);
            dfs(i - 1, j, grid);
            dfs(i, j - 1, grid);
            dfs(i, j + 1, grid);
        }

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (visited[i, j] == false && grid[i][j] == '1')
                {
                    numIslands++;
                    dfs(i, j, grid);
                }
            }
        }
        return numIslands;
    }
}

