namespace Blind75.ArraysAndHashing;

// Given a string s, return the length of the longest substring between two equal characters,
// excluding the two characters. If there is no such substring return -1.
// A substring is a contiguous sequence of characters within a string.
//
// Example 1:
// Input: s = "aa"
// Output: 0
// Explanation: The optimal substring here is an empty substring between the two 'a's.
//
// Example 2:
// Input: s = "abca"
// Output: 2
// Explanation: The optimal substring here is "bc".
//
// Example 3:
// Input: s = "cbzxy"
// Output: -1
// Explanation: There are no characters that appear twice in s.
//
// Constraints:
// 1 <= s.length <= 300
// s contains only lowercase English letters.

public static class LrgstSubstringBet2EqChar
{
    public static int MaxLengthBetweenEqualCharacters(string s)
    {
        int max = -1;
        Dictionary<char, int> dict = [];
        for (int i = 0; i < s.Length; i++)
        {
            if (!dict.TryAdd(s[i], i))
                max = Math.Max(max, i - dict[s[i]] - 1);
        }
        return max;
    }
}
