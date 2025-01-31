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
        Dictionary<char, int> charFreq = [];
        foreach (char c in s)
            if (!charFreq.TryAdd(c, 1))
                charFreq[c]++;

        PriorityQueue<char, int> maxHeap = new(charFreq
                .Select(c => (c.Key, c.Value)),
                    Comparer<int>.Create((a, b) => b.CompareTo(a)));

        StringBuilder sb = new();
        // null char to indicate no prev char
        char prev = '\0';

        while (maxHeap.Count > 0)
        {
            char curr = maxHeap.Dequeue();
            sb.Append(curr);

            if (prev > '\0' && charFreq[prev] > 0)
                maxHeap.Enqueue(prev, charFreq[prev]);

            // decrement frequency
            // set prev char
            // if freq > 0, add to heap
            // else, set prev to null char
            prev = --charFreq[curr] > 0 ? curr : '\0';
        }

        string res = sb.ToString();
        return sb.Length == s.Length ? res : "";
    }
}

