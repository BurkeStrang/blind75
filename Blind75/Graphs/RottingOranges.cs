namespace Blind75.Graphs;

/*

You are given an m x n grid where each cell can have one of three values:

0 representing an empty cell,
1 representing a fresh orange, or
2 representing a rotten orange.
Every minute, any fresh orange that is 4-directionally adjacent to a rotten orange becomes rotten.

Return the minimum number of minutes that must elapse until no cell has a fresh orange. If this is impossible, return -1.

Example 1:
Input: grid = [[2,1,1],
               [1,1,0],
               [0,1,1]]
Output: 4

Example 2:
Input: grid = [[2,1,1],
               [0,1,1],
               [1,0,1]]
Output: -1
Explanation: The orange in the bottom left corner (row 2, column 0) is never rotten, because rotting only happens 4-directionally.

Example 3:
Input: grid = [[0,2]]
Output: 0
Explanation: Since there are already no fresh oranges at minute 0, the answer is just 0.

Constraints:
m == grid.length
n == grid[i].length
1 <= m, n <= 10
grid[i][j] is 0, 1, or 2.

*/
public static class RottingOranges
{
    public static int OrangesRotting(int[][] grid)
    {
        // Check for an empty grid
        if (grid == null || grid.Length == 0 || grid[0].Length == 0)
            return 0;

        int rowLength = grid.Length;
        int colLength = grid[0].Length;
        int freshOranges = 0;
        int minutes = 0;
        Queue<(int row, int col)> rottenQueue = new();

        // Initialize the queue with all initially rotten oranges and count fresh oranges
        for (int i = 0; i < rowLength; i++)
        {
            for (int j = 0; j < colLength; j++)
            {
                if (grid[i][j] == 1)
                    freshOranges++;
                else if (grid[i][j] == 2)
                    rottenQueue.Enqueue((i, j));
            }
        }

        // If there are no fresh oranges, return 0
        if (freshOranges == 0)
            return 0;

        // Directions for the adjacent cells (up, down, left, right)
        int[][] directions =
        [
            [-1, 0],
            [1, 0],
            [0, -1],
            [0, 1]
        ];

        // BFS to rot the adjacent fresh oranges
        while (rottenQueue.Count > 0)
        {
            minutes++;
            int currentLevelSize = rottenQueue.Count;

            for (int i = 0; i < currentLevelSize; i++)
            {
                (int row, int col) = rottenQueue.Dequeue();

                for (int j = 0; j < 4; j++)
                {
                    int newRow = row + directions[j][0];
                    int newCol = col + directions[j][1];

                    // If the adjacent cell is a fresh orange, rot it and enqueue the new rotten orange
                    if (
                        newRow >= 0
                        && newRow < rowLength
                        && newCol >= 0
                        && newCol < colLength
                        && grid[newRow][newCol] == 1
                    )
                    {
                        grid[newRow][newCol] = 2;
                        rottenQueue.Enqueue((newRow, newCol));
                        freshOranges--;
                    }
                }
            }
        }

        // If there are still fresh oranges left, return -1, otherwise return the time taken
        return freshOranges == 0 ? minutes - 1 : -1;
    }
}
