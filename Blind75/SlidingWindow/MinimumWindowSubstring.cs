namespace Blind75.SlidingWindow;

/*

Given two strings s and t of lengths m and n respectively, return the minimum window
substring of s such that every character in t (including duplicates) is included in the window.
If there is no such substring, return the empty string "".

The testcases will be generated such that the answer is unique.

Example:

Input: s = "ADOBECODEBANC", t = "ABC"
Output: "BANC"
Explanation: The minimum window substring "BANC" includes 'A', 'B', and 'C' from string t.

*/

public static class MinimumWindowSubstringClass
{
    public static string MinWindow(string s, string t)
    {
        if (string.IsNullOrEmpty(t))
            return string.Empty;

        // Initialize dictionaries to count characters in t and the current window in s
        Dictionary<char, int> targetCharCount = [];
        Dictionary<char, int> windowCharCount = [];

        // Populate targetCharCount with characters from t
        foreach (char c in t)
        {
            if (!targetCharCount.TryAdd(c, 1))
                targetCharCount[c]++;
        }

        int matchedChars = 0;
        int requiredChars = targetCharCount.Count;
        int left = 0;
        int[] result = [-1, -1];
        int minLength = int.MaxValue;

        // Expand the window by moving the right pointer
        for (int right = 0; right < s.Length; right++)
        {
            char currentChar = s[right];

            if (!windowCharCount.TryAdd(currentChar, 1))
                windowCharCount[currentChar]++;

            // Check if the current character matches the required count in t
            if (
                targetCharCount.TryGetValue(currentChar, out int targetCount)
                && windowCharCount[currentChar] == targetCount
            )
            {
                matchedChars++;
            }

            // Contract the window from the left as long as it contains all characters from t
            while (matchedChars == requiredChars)
            {
                // Update the result if the current window is smaller
                int windowSize = right - left + 1;
                if (windowSize < minLength)
                {
                    result[0] = left;
                    result[1] = right;
                    minLength = windowSize;
                }

                // Remove the leftmost character from the window
                windowCharCount[s[left]]--;
                if (
                    targetCharCount.TryGetValue(s[left], out int _)
                    && windowCharCount[s[left]] < targetCharCount[s[left]]
                )
                {
                    matchedChars--;
                }

                left++;
            }
        }

        return minLength == int.MaxValue ? string.Empty : s.Substring(result[0], result[1] - result[0] + 1);
    }
}
