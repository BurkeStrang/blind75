namespace Blind75.Graphs;

public class CycleIsland
{
    public static bool HasCycle(char[][] matrix)
    {
        int rows = matrix.Length;
        int cols = matrix[0].Length;
        bool[,] visited = new bool[rows,cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (!visited[i,j]) // only if the cell is not visited
                    if (ContainsCycleDFS(matrix, visited, matrix[i][j], i, j, -1, -1))
                        return true;
            }
        }
        return false;
    }

    private static bool ContainsCycleDFS(char[][] matrix, bool[,] visited,
        char startChar, int x, int y, int prevX, int prevY)
    {
        if (x < 0 || x >= matrix.Length || y < 0 || y >= matrix[0].Length)
            return false; // not a valid cell
        if (matrix[x][y] != startChar)
            return false; // different character which means a different island

        if (visited[x,y])
            return true; // found a cycle, as we are visiting an already visited valid cell

        visited[x,y] = true; // mark the cell visited

        // recursively visit all neighboring cells (horizontally & vertically)
        if (x + 1 != prevX && ContainsCycleDFS(matrix, visited, startChar, x + 1, y, x, y)) // down
            return true;
        if (x - 1 != prevX && ContainsCycleDFS(matrix, visited, startChar, x - 1, y, x, y)) // up
            return true;
        if (y + 1 != prevY && ContainsCycleDFS(matrix, visited, startChar, x, y + 1, x, y)) // right
            return true;
        if (y - 1 != prevY && ContainsCycleDFS(matrix, visited, startChar, x, y - 1, x, y)) // left
            return true;
        return false;
    }

}
