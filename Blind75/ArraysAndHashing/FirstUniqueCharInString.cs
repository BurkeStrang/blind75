namespace Blind75.ArraysAndHashing;

// Given a string s, find the first non-repeating character in it and return its index.
// If it does not exist, return -1.
//
// Example 1:
// Input: s = "leetcode"
// Output: 0
//
// Example 2:
// Input: s = "loveleetcode"
// Output: 2
//
// Example 3:
// Input: s = "aabb"
// Output: -1
//
// Constraints:
// 1 <= s.length <= 105
// s consists of only lowercase English letters.

public static class FirstUniqueCharInString
{
    public static int FirstUniqChar(string s)
    {
        Dictionary<char, int> charCount = [];
        for (int i = 0; i < s.Length; i++)
        {
            if (!charCount.TryAdd(s[i], 1))
                charCount[s[i]]++;
        }
        for (int i = 0; i < s.Length; i++)
        {
            if (charCount[s[i]] == 1)
                return i;
        }
        return -1;
    }
}
