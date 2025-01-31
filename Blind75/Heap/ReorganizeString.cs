namespace Blind75.Heap;

public static class ReorganizeString
{
    /// <summary>
    /// Reorganizes the input string so that no two adjacent characters are the same.
    /// Returns an empty string if such an arrangement is not possible.
    /// </summary>
    /// <param name="s">The input string to reorganize.</param>
    /// <returns>The reorganized string or an empty string if not possible.</returns>
    public static string Reorganize(string s)
    {
        Dictionary<char, int> charFrequency = [];
        foreach (char c in s)
            if (!charFrequency.TryAdd(c, 1))
                charFrequency[c]++;

        PriorityQueue<char, int> maxHeap = new(charFrequency
                .Select(c => (c.Key, c.Value)),
                    Comparer<int>.Create((a, b) => b.CompareTo(a)));

        StringBuilder sb = new();
        // null character to indicate no previous character
        char previousChar = '\0';

        while (maxHeap.Count > 0)
        {
            char currentChar = maxHeap.Dequeue();
            sb.Append(currentChar);

            if (previousChar > '\0' && charFrequency[previousChar] > 0)
                maxHeap.Enqueue(previousChar, charFrequency[previousChar]);

            charFrequency[currentChar]--;
            previousChar = charFrequency[currentChar] > 0 ? currentChar : '\0';
        }

        string res = sb.ToString();
        return sb.Length == s.Length ? res : "";
    }
}

