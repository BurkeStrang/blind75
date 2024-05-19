namespace Blind75.Graphs;

/*

You are given an n x n integer matrix grid where each value grid[i][j] represents the elevation at that point (i, j).
The rain starts to fall. At time t, the depth of the water everywhere is t.
You can swim from a square to another 4-directionally adjacent square if and only if
the elevation of both squares individually are at most t.
You can swim infinite distances in zero time.
Of course, you must stay within the boundaries of the grid during your swim.

Return the least time until you can reach the bottom right square (n - 1, n - 1)
if you start at the top left square (0, 0).

Example 1:
Input: grid = [[0,2],[1,3]]
Output: 3
Explanation:
At time 0, you are in grid location (0, 0).
You cannot go anywhere else because 4-directionally adjacent neighbors have a higher elevation than t = 0.
You cannot reach point (1, 1) until time 3.
When the depth of water is 3, we can swim anywhere inside the grid.

Example 2:
Input: grid = [[0,1,2,3,4],[24,23,22,21,5],[12,13,14,15,16],[11,17,18,19,20],[10,9,8,7,6]]
Output: 16
Explanation: The final route is shown.
We need to wait until time 16 so that (0, 0) and (4, 4) are connected.

Constraints:
n == grid.length
n == grid[i].length
1 <= n <= 50
0 <= grid[i][j] < n2
Each value grid[i][j] is unique.

*/

public class SwimInRisingWater
{
    private readonly PriorityQueue<(int, int), int> _pq = new();
    private readonly HashSet<(int, int)> _visited = [];

    public int SwimInWater(int[][] grid)
    {
        // Clear the priority queue and visited set for multiple test cases with the same class instance
        _pq.Clear();
        _visited.Clear();

        int n = grid.Length;
        _pq.Enqueue((0, 0), grid[0][0]);

        while (_pq.TryDequeue(out (int, int) current, out int priority))
        {
            int r = current.Item1;
            int c = current.Item2;
            _visited.Add((r, c));

            // If we have reached the bottom-right corner, return the priority
            if (r == n - 1 && c == n - 1)
                return priority;

            // Try to enqueue the neighboring cells
            EnqueueIfValid(r + 1, c, grid, priority);
            EnqueueIfValid(r - 1, c, grid, priority);
            EnqueueIfValid(r, c + 1, grid, priority);
            EnqueueIfValid(r, c - 1, grid, priority);
        }

        return -1; // Should never reach here if input is valid
    }

    private void EnqueueIfValid(int r, int c, int[][] grid, int preCost)
    {
        // Check if the cell is within the grid boundaries
        if (r < 0 || r >= grid.Length || c < 0 || c >= grid.Length)
            return;

        // Check if the cell has already been visited
        if (_visited.Contains((r, c)))
            return;

        // Enqueue the cell with the maximum cost encountered so far
        _pq.Enqueue((r, c), Math.Max(preCost, grid[r][c]));
    }
}
