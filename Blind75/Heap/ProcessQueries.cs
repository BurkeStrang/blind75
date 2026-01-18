namespace Blind75.Heap;

// You are provided with a list of queries consisting of operations to be performed on a sorted set.
// Your task is to implement a C# function, ProcessQueries(), that processes these queries.
// After each add or remove operation, the function returns the number of elements in the set.
// For each search operation,
// it should return the largest integer less than or equal to the specified value in the set,
// or -1 if such an integer does not exist.
// Additionally, for the new operation,
// the function should return the smallest integer greater than or equal to the specified value in the set,
// or -1 if such an integer does not exist.
//
// The function is defined as public static List<int> ProcessQueries(List<int[]> queries), where queries is a list of query operations.
// Each operation is represented by an array of two integers, the operation type and the operand.
//
// Operation types:
//
// 0: Add the integer to the set.
// 1: Remove the integer from the set (the integer is guaranteed to exist).
// 2: Find the largest integer less than or equal to the given operand.
// 3: Find the smallest integer greater than or equal to the given operand.
// Constraints:
//
// queries contains a series of operations to be processed.
// Ensure that operations are processed efficiently using the SortedSet of C#.
// Example: For the input queries [[0, 10], [2, 10], [0, 20], [1, 10], [2, 10], [3, 15], [3, 21]],
// the output should be [1, 10, 2, 0, -1, 20, -1].
//
// Explanation:
//
// After adding 10, the set size is 1.
// The largest number <= 10 is 10 itself.
// After adding 20, the set size is 2.
// After removing 10, the set size is 1.
// There is no number <= 10, thus returning -1.
// The smallest number >= 15 is 20.
// There is no number >= 21, thus returning -1.

public static class QueryProcessor
{
    public static List<int> ProcessQueries(List<int[]> queries)
    {
        List<int> res = [];
        SortedSet<int> set = [];

        foreach (int[] query in queries)
        {
            int type = query[0];
            int operand = query[1];
            switch (type)
            {
                case 0: // Add
                    set.Add(operand);
                    res.Add(set.Count);
                    break;
                case 1: // Remove
                    set.Remove(operand);
                    res.Add(set.Count);
                    break;
                case 2: // Largest <= operand
                    if (set.Count > 0 && set.Min <= operand)
                        res.Add(set.GetViewBetween(set.Min, operand).Max);
                    else
                        res.Add(-1);
                    break;
                case 3: // Smallest >= operand
                    if (set.Count > 0 && set.Max >= operand)
                        res.Add(set.GetViewBetween(operand, set.Max).Min);
                    else
                        res.Add(-1);
                    break;
            }
        }
        return res;
    }
}
