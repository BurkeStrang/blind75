namespace Blind75.ArraysAndHashing;

// Description:
// Implement the function unique_in_order which takes as argument a sequence
// and returns a list of items without any elements with the same value
// next to each other and preserving the original order of elements.
//
// For example:
// uniqueInOrder("AAAABBBCCDAABBB") == {'A', 'B', 'C', 'D', 'A', 'B'}
// uniqueInOrder("ABBCcAD")         == {'A', 'B', 'C', 'c', 'A', 'D'}
// uniqueInOrder([1,2,2,3,3])       == {1,2,3}

public static class UniqueInOrderKata
{
    public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
    {
        using IEnumerator<T> enumerator = iterable.GetEnumerator();
        T? previous = default;

        while (enumerator.MoveNext())
        {
            if (!previous!.Equals(enumerator.Current))
                yield return enumerator.Current;
            previous = enumerator.Current;
        }
    }
}
