namespace Blind75.ArraysAndHashing;

// Given a pattern and a string s, find if s follows the same pattern.
// Here follow means a full match, such that there is a bijection between a letter in pattern and a non-empty word in s.
//
// Example 1:
// Input: pattern = "abba", s = "dog cat cat dog"
// Output: true
//
// Example 2:
// Input: pattern = "abba", s = "dog cat cat fish"
// Output: false
//
// Example 3:
// Input: pattern = "aaaa", s = "dog cat cat dog"
// Output: false
//
// Constraints:
// 1 <= pattern.length <= 300
// pattern contains only lower-case English letters.
// 1 <= s.length <= 3000
// s contains only lowercase English letters and spaces ' '.
// s does not contain any leading or trailing spaces.
// All the words in s are separated by a single space.

public static class WordPatternClass
{
    public static bool WordPattern(string pattern, string s)
    {
        string[] words = s.Split(' ');
        if (pattern.Length != words.Length)
            return false;
        Dictionary<char, string> dict = [];
        HashSet<string> set = [];
        for (int i = 0; i < pattern.Length; i++)
        {
            char c = pattern[i];
            if (dict.TryGetValue(c, out string? value))
            {
                if (value != words[i])
                    return false;
            }
            else
            {
                if (!set.Add(words[i]))
                    return false;
                dict[c] = words[i];
            }
        }
        return true;
    }
}
