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
        if (string.IsNullOrEmpty(s))
            return s;

        // Step 1: Count character frequencies
        Dictionary<char, int> charFrequency = [];
        PriorityQueue<char, int> maxHeap = new(Comparer<int>.Create((a, b) => b.CompareTo(a)));

        foreach (char c in s)
            if (!charFrequency.TryAdd(c, 1))
                charFrequency[c]++;

        foreach (KeyValuePair<char, int> kvp in charFrequency)
            maxHeap.Enqueue(kvp.Key, kvp.Value);

        StringBuilder result = new();
        // To store the previous character and its remaining frequency
        char? previousChar = null;
        int previousFreq = 0;

        // Step 3: Process the heap
        while (maxHeap.Count > 0)
        {
            char currentChar = maxHeap.Dequeue();
            result.Append(currentChar);

            // If there's a previous character to re-add to the heap, do so
            if (previousChar.HasValue && previousFreq > 0)
            {
                maxHeap.Enqueue(previousChar.Value, previousFreq);
            }

            // Decrease the frequency of the current character
            charFrequency[currentChar]--;

            // Set the previous character to current if it still has remaining count
            if (charFrequency[currentChar] > 0)
            {
                previousChar = currentChar;
                previousFreq = charFrequency[currentChar];
            }
            else
            {
                previousChar = null;
                previousFreq = 0;
            }
        }

        // Step 4: Validate the result
        return result.Length == s.Length ? result.ToString() : string.Empty;
    }
}

