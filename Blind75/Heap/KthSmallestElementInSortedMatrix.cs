namespace Blind75.Heap;

/*

input:  int[][] matrix =
        [
            [1, 5, 9],
            [10, 11, 13],
            [12, 13, 15]
        ];
        int k = 8;

output: 13

*/

public static class KthSmallestElementInSortedMatrix
{
    public static int KthSmallestNumber(int[][] matrix, int k)
    {
        int rowCount = matrix.Length;
        int numbersChecked = 0;
        PriorityQueue<(int row, int col), int> minNumbers = new();

        for (int row = 0; row < Min(rowCount, k); row++)
            minNumbers.Enqueue((row, 0), matrix[row][0]);

        while (minNumbers.Count > 0)
        {
            (int row, int col) = minNumbers.Dequeue();

            if (++numbersChecked == k)
                return matrix[row][col];

            if (col + 1 < matrix[row].Length)
                minNumbers.Enqueue((row, col + 1), matrix[row][col + 1]);
        }

        return -1;
    }
}
