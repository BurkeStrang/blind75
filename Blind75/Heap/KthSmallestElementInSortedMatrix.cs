namespace Blind75.Heap;

public static class KthSmallestElementInSortedMatrix
{
    public static int KthSmallestNumber(int[][] matrix, int k)
    {
        int rowCount = matrix.Length;
        int numbersChecked = 0;
        PriorityQueue<(int, int), int> minNumbers = new();

        for (int row = 0; row < Min(rowCount, k); row++)
            minNumbers.Enqueue((row, 0), matrix[row][0]);

        while (minNumbers.Count > 0)
        {
            (int rowIndex, int colIndex) = minNumbers.Dequeue();

            if (++numbersChecked == k)
                return matrix[rowIndex][colIndex];

            if (colIndex + 1 < matrix[rowIndex].Length)
                minNumbers.Enqueue((rowIndex, colIndex + 1), matrix[rowIndex][colIndex + 1]);
        }

        return -1;
    }
}
