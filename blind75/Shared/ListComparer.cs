namespace Blind75.Shared;

// You can use this comparer to compare lists of integers. 
// It will sort the lists before comparing them to ensure that the order does not affect the comparison.
// It is only checking for the equality of the elements, not the order.
public class ListComparer : IEqualityComparer<IList<int>>
{
    public bool Equals(IList<int>? x, IList<int>? y)
    {
        // If one is null, but not both, return false.
        if (x == null || y == null)
            return false;

        // Check if the lists have the same count
        if (x.Count != y.Count)
            return false;

        // Sort both lists to ensure sequence does not affect comparison
        List<int> sortedX = [.. x.OrderBy(n => n)];
        List<int> sortedY = [.. y.OrderBy(n => n)];

        // Check each element
        for (int i = 0; i < sortedX.Count; i++)
        {
            if (!sortedX[i].Equals(sortedY[i]))
                return false;
        }
        return true;
    }

    public int GetHashCode(IList<int> obj)
    {
        // You can use any hashing algorithm here. For simplicity, just summing the elements after sorting.
        // Ensure to sort so that the order does not affect the hash code.
        return obj.OrderBy(n => n).Sum();
    }
}
