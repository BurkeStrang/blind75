/*
Given an m x n integer matrix matrix, if an element is 0, set its entire row and column to 0's.
You must do it in place.

Example
Input: matrix = [[1,1,1],[1,0,1],[1,1,1]]
Output: [[1,0,1],[0,0,0],[1,0,1]]
*/
namespace blind75.MathAndGeo;

public static class SetMatrixZeros
{
    public static void SetZeroes(int[][] matrix)
    {
        int m = matrix.Length;
        int n = matrix[0].Length;
        bool firstRowZero = false;
        bool firstColZero = false;
        for (int i = 0; i < m; i++)
        {
            if (matrix[i][0] == 0)
            {
                firstColZero = true;
                break;
            }
        }
        for (int i = 0; i < n; i++)
        {
            if (matrix[0][i] == 0)
            {
                firstRowZero = true;
                break;
            }
        }
        for (int i = 1; i < m; i++)
        {
            for (int j = 1; j < n; j++)
            {
                if (matrix[i][j] == 0)
                {
                    matrix[i][0] = 0;
                    matrix[0][j] = 0;
                }
            }
        }
        for (int i = 1; i < m; i++)
        {
            for (int j = 1; j < n; j++)
            {
                if (matrix[i][0] == 0 || matrix[0][j] == 0)
                {
                    matrix[i][j] = 0;
                }
            }
        }
        if (firstColZero)
        {
            for (int i = 0; i < m; i++)
            {
                matrix[i][0] = 0;
            }
        }
        if (firstRowZero)
        {
            for (int i = 0; i < n; i++)
            {
                matrix[0][i] = 0;
            }
        }
    }
}
