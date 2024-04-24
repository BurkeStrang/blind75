namespace blind75.Graphs;

// There is an m x n rectangular island that borders both the Pacific Ocean and Atlantic Ocean. 
// The Pacific Ocean touches the island's left and top edges, 
// and the Atlantic Ocean touches the island's right and bottom edges.

// The island is partitioned into a grid of square cells. 
// You are given an m x n integer matrix heights where heights[r][c] represents 
// the height above sea level of the cell at coordinate (r, c).

// The island receives a lot of rain, and the rain water can flow to neighboring cells directly north, 
// south, east, and west if the neighboring cell's height is less than or equal to the current cell's height. 
// Water can flow from any cell adjacent to an ocean into the ocean.

// Return a 2D list of grid coordinates result where result[i] = [ri, ci] 
// denotes that rain water can flow from cell (ri, ci) to both the Pacific and Atlantic oceans.

// Input: heights = [[1,2,2,3,5],[3,2,3,4,4],[2,4,5,3,1],[6,7,1,4,5],[5,1,1,2,4]]
// Output: [[0,4],[1,3],[1,4],[2,2],[3,0],[3,1],[4,0]]
// Explanation: The following cells can flow to the Pacific and Atlantic oceans, as shown below:
// [0,4]: [0,4] -> Pacific Ocean 
//        [0,4] -> Atlantic Ocean
// [1,3]: [1,3] -> [0,3] -> Pacific Ocean 
//        [1,3] -> [1,4] -> Atlantic Ocean
// [1,4]: [1,4] -> [1,3] -> [0,3] -> Pacific Ocean 
//        [1,4] -> Atlantic Ocean
// [2,2]: [2,2] -> [1,2] -> [0,2] -> Pacific Ocean 
//        [2,2] -> [2,3] -> [2,4] -> Atlantic Ocean
// [3,0]: [3,0] -> Pacific Ocean 
//        [3,0] -> [4,0] -> Atlantic Ocean
// [3,1]: [3,1] -> [3,0] -> Pacific Ocean 
//        [3,1] -> [4,1] -> Atlantic Ocean
// [4,0]: [4,0] -> Pacific Ocean 
//        [4,0] -> Atlantic Ocean
// Note that there are other possible paths for these cells to flow to the Pacific and Atlantic oceans.

public static class WaterFlowClass
{

    public static IList<IList<int>> PacificAtlantic(int[][] heights)
    {
        List<IList<int>> res = [];
        int m = heights.Length, n = heights[0].Length;
        bool[,] isPacific = new bool[m, n];
        bool[,] isAtlantic = new bool[m, n];
        for (int row = 0; row < m; row++)
        {
            DFSPacificAtlantic(row, 0, heights, isPacific, heights[row][0]);
            DFSPacificAtlantic(row, n - 1, heights, isAtlantic, heights[row][n - 1]);
        }

        for (int col = 0; col < n; col++)
        {
            DFSPacificAtlantic(0, col, heights, isPacific, heights[0][col]);
            DFSPacificAtlantic(m - 1, col, heights, isAtlantic, heights[m - 1][col]);
        }
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (isAtlantic[i, j] && isPacific[i, j])
                {
                    res.Add(new List<int> { i, j });
                }
            }
        }

        return res;
    }

    private static void DFSPacificAtlantic(int row, int col, int[][] heights, bool[,] visits, int prev)
    {
        int m = heights.Length, n = heights[0].Length;
        if (row < 0 || row >= m || col < 0 || col >= n || visits[row, col] || heights[row][col] < prev)
            return;
        visits[row, col] = true;
        DFSPacificAtlantic(row, col + 1, heights, visits, heights[row][col]);
        DFSPacificAtlantic(row, col - 1, heights, visits, heights[row][col]);
        DFSPacificAtlantic(row + 1, col, heights, visits, heights[row][col]);
        DFSPacificAtlantic(row - 1, col, heights, visits, heights[row][col]);
    }
}