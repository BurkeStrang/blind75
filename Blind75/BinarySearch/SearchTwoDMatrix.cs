namespace Blind75.BinarySearch;

/*

You are given an m x n integer matrix matrix with the following two properties:

Each row is sorted in non-decreasing order.
The first integer of each row is greater than the last integer of the previous row.
Given an integer target, return true if target is in matrix or false otherwise.

You must write a solution in O(log(m * n)) time complexity.

Example 1:
Input: matrix = [[1,3,5,7],[10,11,16,20],[23,30,34,60]], target = 3
Output: true

Example 2:
Input: matrix = [[1,3,5,7],[10,11,16,20],[23,30,34,60]], target = 13
Output: false

Constraints:

m == matrix.length
n == matrix[i].length
1 <= m, n <= 100
-104 <= matrix[i][j], target <= 104

*/

public static class SearchTwoDMatrix
{
    public static bool SearchMatrix(int[][] matrix, int target)
    {
        int rows = matrix.Length;
        int cols = matrix[0].Length;
        int top = 0;
        int bot = rows - 1;
        int row = 0;

        while (top <= bot)
        {
            row = (top + bot) / 2;
            if (target > matrix[row][cols - 1])
                top = row + 1;
            else if (target < matrix[row][0])
                bot = row - 1;
            else
                break;
        }

        if (top > bot)
            return false;

        int l = 0,
            r = cols - 1;

        while (l <= r)
        {
            int m = (l + r) / 2;
            if (target > matrix[row][m])
                l = m + 1;
            else if (target < matrix[row][m])
                r = m - 1;
            else
                return true;
        }
        return false;
    }
}
