namespace Blind75.ArraysAndHashing;

// You are given an array of strings words and a string chars.
// A string is good if it can be formed by characters from chars (each character can only be used once).
// Return the sum of lengths of all good strings in words.
//
// Example 1:
// Input: words = ["cat","bt","hat","tree"], chars = "atach"
// Output: 6
// Explanation: The strings that can be formed are "cat" and "hat" so the answer is 3 + 3 = 6.
//
// Example 2:
// Input: words = ["hello","world","leetcode"], chars = "welldonehoneyr"
// Output: 10
// Explanation: The strings that can be formed are "hello" and "world" so the answer is 5 + 5 = 10.
//
// Constraints:
// 1 <= words.length <= 1000
// 1 <= words[i].length, chars.length <= 100
// words[i] and chars consist of lowercase English letters.

public static class FindWordsCharacters
{
    public static int CountCharacters(string[] words, string chars)
    {
        int result = 0;
        Dictionary<char, int> dict = [];
        foreach (char c in chars)
        {
            if (!dict.TryAdd(c, 1))
                dict[c]++;
        }
        foreach (string word in words)
        {
            Dictionary<char, int> temp = [];
            bool good = true;
            foreach (char c in word)
            {
                if (dict.TryGetValue(c, out int value))
                {
                    if (temp.TryGetValue(c, out int count))
                    {
                        if (count == value)
                        {
                            good = false;
                            break;
                        }
                        temp[c]++;
                    }
                    else
                    {
                        temp[c] = 1;
                    }
                }
                else
                {
                    good = false;
                    break;
                }
            }
            if (good)
                result += word.Length;
        }
        return result;
    }
}
