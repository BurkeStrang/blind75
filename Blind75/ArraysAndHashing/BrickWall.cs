namespace Blind75.ArraysAndHashing;

// There is a rectangular brick wall in front of you with n rows of bricks.
// The ith row has some number of bricks each of the same height (i.e., one unit)
// but they can be of different widths. The total width of each row is the same.
// Draw a vertical line from the top to the bottom and cross the least bricks.
// If your line goes through the edge of a brick, then the brick is not considered as crossed.
// You cannot draw a line just along one of the two vertical edges of the wall,
// in which case the line will obviously cross no bricks.
//
// Given the 2D array wall that contains the information about the wall,
// return the minimum number of crossed bricks after drawing such a vertical line.
//
// Example 1:
// Input: wall = [[1,2,2,1],[3,1,2],[1,3,2],[2,4],[3,1,2],[1,3,1,1]]
// [][__][__][]
// [____][][__]
// [][____][__]
// [__][______]
// [____][][__]
// [][____][][]
// Output: 2
//
// Example 2:
// Input: wall = [[1],[1],[1]]
// []
// []
// []
// Output: 3
//
// Constraints:
// n == wall.length
// 1 <= n <= 104
// 1 <= wall[i].length <= 104
// 1 <= sum(wall[i].length) <= 2 * 104
// sum(wall[i]) is the same for each row i.
// 1 <= wall[i][j] <= 231 - 1

public static class BrickWall
{
    public static int LeastBricks(IList<IList<int>> wall)
    {
        // The idea is to find the edge with the most common occurrence.
        // The edge with the most common occurrence will have the least number of bricks crossed.
        //
        // Approach
        // 1. Create a dictionary to store the edge position and the number of occurrences.
        // 2. Iterate over each row of the wall.
        // 3. For each row, calculate the edge position by adding the width of each brick.
        // 4. Increment the count of the edge position in the dictionary.
        // 5. Find the edge position with the most common occurrence.
        // 6. Return the number of rows minus the number of occurrences of the most common edge position.
        //
        // Time complexity: O(n) - The algorithm processes each brick in the wall.
        // Space complexity: O(n) - The algorithm uses a dictionary to store the edge positions.
        Dictionary<int, int> edgeCount = [];
        int maxCount = 0;
        foreach (IList<int> row in wall)
        {
            int edge = 0;
            for (int i = 0; i < row.Count - 1; i++)
            {
                edge += row[i];
                // edge.Dump();
                edgeCount[edge] = edgeCount.GetValueOrDefault(edge) + 1;
                maxCount = Math.Max(maxCount, edgeCount[edge]);
            }
        }
        return wall.Count - (maxCount == 0 ? 0 : edgeCount.Values.Max());
    }
}
