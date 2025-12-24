namespace Blind75.ArraysAndHashing;

// Given a string s consisting of words separated by spaces, find the character that "breaks" the most words.
// A character is considered to "break" a word if it appears at least twice in the word and splitting the word at
// every occurrence of that character results in at least two non-empty substrings 
// (i.e., the character divides the word into multiple parts).
//
// Return a tuple containing:
// - The character that breaks the most words.
// - The number of words it breaks.
//
// If multiple characters break the same maximum number of words, return the one that appears earliest in the string s.
//
// **Example:**
// Input: "apple banana bandana"
// Output: ('a', 2)
// Explanation: 'a' breaks "banana" and "bandana" into multiple parts.

public static class MinimalMaxBrokenWordsSolution
{
    public static Tuple<char, int> MinimalMaxBrokenWords(string s)
    {
        string[] words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        Dictionary<char, int> brokenCounts = [];
        Dictionary<char, int> firstIndex = [];

        for (int i = 0; i < s.Length; i++)
        {
            if (!firstIndex.ContainsKey(s[i]))
                firstIndex[s[i]] = i;
        }

        foreach (string word in words)
        {
            HashSet<char> countedInWord = [];

            foreach (char c in word)
            {
                if (countedInWord.Contains(c))
                    continue;
                string[] parts = word.Split(c, StringSplitOptions.RemoveEmptyEntries);

                if (parts.Length >= 2)
                {
                    brokenCounts[c] = brokenCounts.GetValueOrDefault(c) + 1;
                    countedInWord.Add(c);
                }
            }
        }

        char bestChar = '\0';
        int maxBroken = 0;
        int bestIndex = int.MaxValue;

        foreach (KeyValuePair<char, int> kv in brokenCounts)
        {
            char c = kv.Key;
            int count = kv.Value;
            int idx = firstIndex[c];

            if (count > maxBroken || (count == maxBroken && idx < bestIndex))
            {
                bestChar = c;
                maxBroken = count;
                bestIndex = idx;
            }
        }
        return new Tuple<char, int>(bestChar, maxBroken);
    }
}
