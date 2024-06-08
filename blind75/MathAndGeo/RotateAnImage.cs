namespace Blind75.MathAndGeo;

/*
You are given an n x n 2D matrix representing an image, rotate the image by 90 degrees (clockwise).
You have to rotate the image in-place, which means you have to modify the input 2D matrix directly.
DO NOT allocate another 2D matrix and do the rotation.

        Example 1:
        int[][] matrix =
        [
            [1, 2, 3],
            [4, 5, 6],
            [7, 8, 9]
        ];
        int[][] expected =
        [
            [7, 4, 1],
            [8, 5, 2],
            [9, 6, 3]
        ];

        Example 2:
        int[][] matrix =
        [
            [5, 1, 9, 11],
            [2, 4, 8, 10],
            [13,3, 6, 7],
            [15,14,12,16]
        ];
        int[][] expected =
        [
            [15, 13,2, 5],
            [14, 3, 4, 1],
            [12, 6, 8, 9],
            [16, 7, 10,11]
        ];
 

*/

public static class RotateAnImage
{
    public static void Rotate(int[][] matrix)
    {
        Console.WriteLine($"  Start Matrix:");
        matrix.ToList().ForEach(row => Console.WriteLine("  " + string.Join(",", row)));
        int n = matrix.Length;
        for (int i = 0; i < n / 2; i++)
        {
            for (int j = i; j < n - i - 1; j++)
            {
                Console.WriteLine($"  ---------------------------------");
                Console.WriteLine($"  Inner For loop i: {i}, j: {j}");
                Console.WriteLine($"  ---------------------------------");
                int temp = matrix[i][j];
                Console.WriteLine($" 1.  setting matrix[{i}][{j}] <== matrix[{n - j - 1}][{i}] so {temp} <== {matrix[n - j - 1][i]}");
                Console.WriteLine($" 2.  setting matrix[{n - j - 1}][{i}] <== matrix[{n - i - 1}][{n - j - 1}] so {matrix[n - j - 1][i]} <== {matrix[n - i - 1][n - j - 1]}");
                Console.WriteLine($" 3.  setting matrix[{n - i - 1}][{n - j - 1}] <== matrix[{j}][{n - i - 1}] so {matrix[n - i - 1][n - j - 1]} <== {matrix[j][n - i - 1]}");
                Console.WriteLine($" 4.  setting matrix[{j}][{n - i - 1}] <== matrix[{i}][{j}] so {matrix[j][n - i - 1]} <== {temp}");
                matrix[i][j] = matrix[n - j - 1][i];
                matrix[n - j - 1][i] = matrix[n - i - 1][n - j - 1];
                matrix[n - i - 1][n - j - 1] = matrix[j][n - i - 1];
                matrix[j][n - i - 1] = temp;

                Console.WriteLine();
                Console.WriteLine($"      Current Inner Loop Matrix:");
                matrix.ToList().ForEach(row => Console.WriteLine("                " + string.Join(",", row)));
                Console.WriteLine();
            }
        }
    }
}
