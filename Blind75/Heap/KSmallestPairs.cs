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
        PriorityQueue<(int i, int j), int> minQueue = new();

        for (int i = 0; i < Min(k, list1.Length); i++)
            minQueue.Enqueue((i, 0), list1[i] + list2[0]);

        while (minQueue.Count > 0 && result.Count < k)
        {
            (int i, int j) = minQueue.Dequeue();
            result.Add([list1[i], list2[j]]);

            if (j + 1 < list2.Length)
                minQueue.Enqueue((i, j + 1), list1[i] + list2[j + 1]);
        }
        return [.. result];
    }
}
