namespace Blind75.Backtracking;

public static class Combination
{

    public static IList<IList<int>> Combine(int n, int k)
    {
        IList<IList<int>> res = [];
        List<int> current = [];
        Backtrack(1, n, k, current, res);
        return res;
    }

    private static void Backtrack
    (
      int start,
      int n,
      int k,
      List<int> current,
      IList<IList<int>> res
    )
    {
        // only add to res if we have k amount
        if (current.Count == k)
        {
            // create copy and add so we
            // don't mess with the ref
            res.Add([.. current]);
            return;
        }

        for (int i = start; i <= n; i++)
        {
            current.Add(i);

            // WriteLine($"start: {start}, add i:{i} -> [{string.Join(',', current)}]");

            string resString = $"[{string.Join(", ", res.Select(x => $"[{string.Join(',', x)}]"))}]";
            // WriteLine($"Backtrack({i + 1}, {n}, {k}, [{string.Join(',', current)}], {resString})");

            Backtrack(i + 1, n, k, current, res);

            current.RemoveAt(current.Count - 1);
            // WriteLine($"start: {start}, remove i:{i} -> [{string.Join(',', current)}]");
            // start: 1, add i:1 -> [1]
            // Backtrack(2, 4, 2, [1], [])
            // start: 2, add i:2 -> [1,2]
            // Backtrack(3, 4, 2, [1,2], [])
            // start: 2, remove i:2 -> [1]
            // start: 2, add i:3 -> [1,3]
            // Backtrack(4, 4, 2, [1,3], [[1,2]])
            // start: 2, remove i:3 -> [1]
            // start: 2, add i:4 -> [1,4]
            // Backtrack(5, 4, 2, [1,4], [[1,2], [1,3]])
            // start: 2, remove i:4 -> [1]
            // start: 1, remove i:1 -> []
            // start: 1, add i:2 -> [2]
            // Backtrack(3, 4, 2, [2], [[1,2], [1,3], [1,4]])
            // start: 3, add i:3 -> [2,3]
            // Backtrack(4, 4, 2, [2,3], [[1,2], [1,3], [1,4]])
            // start: 3, remove i:3 -> [2]
            // start: 3, add i:4 -> [2,4]
            // Backtrack(5, 4, 2, [2,4], [[1,2], [1,3], [1,4], [2,3]])
            // start: 3, remove i:4 -> [2]
            // start: 1, remove i:2 -> []
            // start: 1, add i:3 -> [3]
            // Backtrack(4, 4, 2, [3], [[1,2], [1,3], [1,4], [2,3], [2,4]])
            // start: 4, add i:4 -> [3,4]
            // Backtrack(5, 4, 2, [3,4], [[1,2], [1,3], [1,4], [2,3], [2,4]])
            // start: 4, remove i:4 -> [3]
            // start: 1, remove i:3 -> []
            // start: 1, add i:4 -> [4]
            // Backtrack(5, 4, 2, [4], [[1,2], [1,3], [1,4], [2,3], [2,4], [3,4]])
            // start: 1, remove i:4 -> []
        }
    }
}
