namespace Blind75.Graphs;

/*

You are given a m x n 2D grid initialized with these three possible values.

-1 - A wall or an obstacle.
0 - A gate.
INF - Infinity means an empty room.
We use the value 2^31 - 1 = 2147483647 to represent INF as you may assume that the distance to a gate is less than 2147483647.
Fill each empty room with the distance to its nearest gate.
If it is impossible to reach a Gate, that room should remain filled with INF

Example1
Input:
[[2147483647,-1,0,2147483647],[2147483647,2147483647,2147483647,-1],[2147483647,-1,2147483647,-1],[0,-1,2147483647,2147483647]]
Output:
[[3,-1,0,1],[2,2,1,-1],[1,-1,2,-1],[0,-1,3,4]]
Explanation:
the 2D grid is:
INF  -1  0  INF
INF INF INF  -1
INF  -1 INF  -1
  0  -1 INF INF
the answer is:
  3  -1   0   1
  2   2   1  -1
  1  -1   2  -1
  0  -1   3   4

Example2
Input:
[[0,-1],[2147483647,2147483647]]
Output:
[[0,-1],[1,2]]

 */
public static class WallsAndGatesClass
{
    private static readonly Queue<(int, int)> Queue = new();
    private static int s_rows;
    private static int s_cols;

    public static void WallsAndGates(int[][] rooms)
    {
        s_rows = rooms.Length;
        s_cols = rooms[0].Length;
        int[,] visited = new int[s_rows, s_cols];

        void AddRoom(int row, int col)
        {
            if (
                row < 0
                || col < 0
                || row == s_rows
                || col == s_cols
                || rooms[row][col] == -1
                || visited[row, col] == 1
            )
                return;

            visited[row, col] = 1;
            Queue.Enqueue((row, col));
        }

        for (int i = 0; i < s_rows; i++)
        {
            for (int j = 0; j < s_cols; j++)
            {
                if (rooms[i][j] == 0)
                {
                    Queue.Enqueue((i, j));
                    visited[i, j] = 1;
                }
            }
        }

        int currentDistance = 0;
        while (Queue.Count > 0)
        {
            int count = Queue.Count;
            for (int i = 0; i < count; i++)
            {
                (int row, int col) = Queue.Dequeue();
                rooms[row][col] = currentDistance;
                AddRoom(row + 1, col);
                AddRoom(row - 1, col);
                AddRoom(row, col + 1);
                AddRoom(row, col - 1);
            }

            currentDistance++;
        }
    }
}
