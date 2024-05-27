namespace Blind75.DynamicProgramming;

/*

Given an m x n integers matrix, return the length of the longest increasing path in matrix.
From each cell, you can either move in four directions: left, right, up, or down.
You may not move diagonally or move outside the boundary (i.e., wrap-around is not allowed).

Example 1:
Input: matrix = [[9,9,4],[6,6,8],[2,1,1]]
Output: 4
Explanation: The longest increasing path is [1, 2, 6, 9].

Example 2:
Input: matrix = [[3,4,5],[3,2,6],[2,2,1]]
Output: 4
Explanation: The longest increasing path is [3, 4, 5, 6]. Moving diagonally is not allowed.

Example 3:
Input: matrix = [[1]]
Output: 1

Constraints:
m == matrix.length
n == matrix[i].length
1 <= m, n <= 200
0 <= matrix[i][j] <= 231 - 1

*/

public class LongestIncreasingPathInMatrix
{
    //T: O(N*M) | S: O(N*M) || has complex topological sort order and hence memoization.
    public static int LongestIncreasingPath(int[][] matrix)
    {
        int rows = matrix.Length;
        int cols = matrix[0].Length;
        int maxValue = int.MinValue;

        Dictionary<(int, int), int> dictionary = [];

        int Dfs(int i, int j, int previous)
        {
            if (
                i >= matrix.Length
                || j >= matrix[0].Length
                || i < 0
                || j < 0
                || matrix[i][j] <= previous
            )
                return 0;

            if (dictionary.ContainsKey((i, j)))
                return dictionary[(i, j)];

            int value =
                1
                + Math.Max(
                    Math.Max(
                        Math.Max(Dfs(i + 1, j, matrix[i][j]), Dfs(i - 1, j, matrix[i][j])),
                        Dfs(i, j - 1, matrix[i][j])
                    ),
                    Dfs(i, j + 1, matrix[i][j])
                );

            dictionary.TryAdd((i, j), 0);
            dictionary[(i, j)] = value;

            maxValue = Math.Max(maxValue, value);
            return value;
        }

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Dfs(i, j, -1);
            }
        }
        return maxValue;
    }
}
