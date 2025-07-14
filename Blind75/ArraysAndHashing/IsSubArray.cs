namespace Blind75.ArraysAndHashing;

public static class IsSubArray
{
    public static bool IsSubArraySegment(ReadOnlySpan<int> mainArray, ReadOnlySpan<int> subArray)
    {
        int front = 0;
        int subLength = subArray.Length;
        while (front + subLength < mainArray.Length)
        {
            if (subArray.SequenceEqual(mainArray.Slice(front, subLength)))
                return true;
            front++;
        }
        return false;
    }

    public static bool IsSubArrayCheckEachElementInArray(int[] mainArray, int[] subArray)
    {
        int front = 0;
        int subLength = subArray.Length;

        while (front + subLength < mainArray.Length)
        {
            int i = 0;
            while (subArray[i] == mainArray[i + front])
            {
                i++;
                if (i == subLength)
                    return true;
            }
            front++;
        }
        return false;
    }

    public static bool IsSubArrayLinq(int[] mainArray, int[] subArray)
    {
        return Enumerable
            .Range(0, mainArray.Length - subArray.Length + 1)
            .Any(start => subArray.SequenceEqual(mainArray.Skip(start).Take(subArray.Length)));
    }

    public static bool IsSubArrayStringJoin(int[] mainArray, int[] subArray)
    {
        // this could probably work for many other types of problems
        // keep this in mind
        return string.Join(",", mainArray).Contains(string.Join(",", subArray));
    }

    public static bool IsSubArrayHashSet(int[] mainArray, int[] subArray)
    {
        // will not work for duplicates
        HashSet<int> mainSet = new(mainArray);
        HashSet<int> subSet = new(subArray);
        return subSet.IsSubsetOf(mainSet);
    }

    public static bool IsSubArrayHashing(int[] mainArray, Span<int> subArray)
    {
        Dictionary<int, int> dict = mainArray
            .GroupBy(num => num)
            .ToDictionary(group => group.Key, group => group.Count());
        foreach (int num in subArray)
        {
            if (!dict.TryGetValue(num, out int value) || value == 0)
                return false;
            dict[num] = --value;
        }
        return true;
    }

    public static bool IsSubArrayDoubleyLinkedList(int[] mainArray, int[] subArray)
    {
        // Initialize the sliding window
        int subLen = subArray.Length;
        LinkedList<int> slidingWindow = new(mainArray.Take(subLen));

        // Check if the first window is the subArray
        if (slidingWindow.SequenceEqual(subArray))
            return true;

        // Slide the window across the mainArray
        // Already starts with the next element in the mainArray
        while (subLen < mainArray.Length)
        {
            slidingWindow.RemoveFirst();
            slidingWindow.AddLast(mainArray[subLen]);

            if (slidingWindow.SequenceEqual(subArray))
                return true;
            subLen++;
        }

        return false;
    }

    public static bool IsSubArrayTwoPointer(int[] mainArray, int[] subArray)
    {
        // Two pointers to traverse the arrays
        int i = 0,
            j = 0;

        // Traverse both arrays simultaneously
        while (i < mainArray.Length && j < subArray.Length)
        {
            // If element matches
            // increment both pointers
            if (mainArray[i] == subArray[j])
            {
                i++;
                j++;

                // If array B is completely
                // traversed
                if (j == subArray.Length)
                    return true;
            }
            // If not,
            // increment i and reset j
            else
            {
                i = i - j + 1;
                j = 0;
            }
        }

        return false;
    }
}
