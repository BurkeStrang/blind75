namespace Blind75.Shared;

// You can use this comparer to compare lists of any type that implements IComparable.
// It will sort the lists before comparing them to ensure that the order does not affect the comparison.
// It is only checking for the equality of the elements, not the order.
public class ListComparer<T> : IEqualityComparer<IList<T>> where T : IComparable<T>
{
    public bool Equals(IList<T>? x, IList<T>? y)
    {
        // If one is null, but not both, return false.
        if (x == null || y == null)
            return x == y;

        // Check if the lists have the same count
        if (x.Count != y.Count)
            return false;

        // Sort both lists to ensure sequence does not affect comparison
        List<T> sortedX = [.. x.OrderBy(n => n)];
        List<T> sortedY = [.. y.OrderBy(n => n)];

        // Check each element
        for (int i = 0; i < sortedX.Count; i++)
        {
            if (!sortedX[i].Equals(sortedY[i]))
                return false;
        }
        return true;
    }

    public int GetHashCode(IList<T> obj)
    {
        // Use a simple hash code strategy based on sorted elements to ensure that order does not affect hash code.
        unchecked // Overflow is fine, just wrap
        {
            int hash = 19;
            foreach (T? elem in obj.OrderBy(n => n))
            {
                hash = hash * 31 + elem.GetHashCode(); // Suitable for integers
            }
            return hash;
        }
    }
}
