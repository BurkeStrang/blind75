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
// Example 4:
// Input: pattern = "ab", s = "dog dog"
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
        string[] words = s.Split(" ");
        if (pattern.Length != words.Length)
            return false;
        Dictionary<char, string> charToWord = [];
        Dictionary<string, char> wordToChar = [];
        for (int i = 0; i < pattern.Length; i++)
        {
            if (!charToWord.TryAdd(pattern[i], words[i]))
            {
                if (charToWord[pattern[i]] != words[i])
                    return false;
            }
            if (!wordToChar.TryAdd(words[i], pattern[i]))
            {
                if (wordToChar[words[i]] != pattern[i])
                    return false;
            }
        }
        return true;
    }
}
