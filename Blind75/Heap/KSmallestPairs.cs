namespace Blind75.Heap;

public static class FindKPairsWithSum
{
    /// <summary>
    /// Find K Pairs with Smallest Sums
    /// </summary>
    /// <param name="list1"> the first list</param>
    /// <param name="list2"> the second list</param>
    /// <returns> int[][] with the k smallest pairs </returns>
    /// <example>
    ///     Input: list1 = [1,2,3], list2=[1,2,3], k = 2
    ///     Ouput: [[1,1],[1,2]]
    /// </example>
    public static int[][] KSmallestPairs(int[] list1, int[] list2, int k)
    {
        List<int[]> result = [];
        PriorityQueue<(int row, int col), int> minQueue = new();

        for (int row = 0; row < Min(k, list1.Length); row++)
            minQueue.Enqueue((row, 0), list1[row] + list2[0]);

        while (minQueue.Count > 0 && result.Count < k)
        {
            (int row, int col) = minQueue.Dequeue();
            result.Add([list1[row], list2[col]]);

            if (col + 1 < list2.Length)
                minQueue.Enqueue((row, col + 1), list1[row] + list2[col + 1]);
        }
        return [.. result];
    }
}
