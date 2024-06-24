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

        Dictionary<char, int> countT = [];
        Dictionary<char, int> window = [];

        foreach (char c in t)
        {
            AddCharToDictionary(c, countT);
        }

        int have = 0;
        int need = countT.Count;
        int left = 0;
        int[] res = [-1, -1];
        int resultLength = int.MaxValue;
        for (int right = 0; right < s.Length; right++)
        {
            char c = s[right];
            AddCharToDictionary(c, window);

            if (countT.TryGetValue(c, out int value) && window[c] == value)
                have++;

            while (have == need)
            {
                // update our result
                int windowSize = right - left + 1;
                if (windowSize < resultLength)
                {
                    res = [left, right];
                    resultLength = windowSize;
                }

                // pop from the left of our window
                window[s[left]]--;
                if (countT.TryGetValue(s[left], out int _) && window[s[left]] < countT[s[left]])
                {
                    have--;
                }

                left++;
            }
        }

        return resultLength == int.MaxValue
            ? string.Empty
            : s.Substring(res[0], res[1] - res[0] + 1);
    }

    private static void AddCharToDictionary(char c, Dictionary<char, int> dict)
    {
        if (dict.TryGetValue(c, out int value))
            dict[c] = ++value;
        else
            dict.Add(c, 1);
    }
}
