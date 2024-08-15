namespace Blind75.ArraysAndHashing;

// You are given an array of strings words and a string chars.
// A string is good if it can be formed by characters from chars (each character can only be used once (per word)).
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
        int charMatchCount = 0;
        int[] charCount = new int[26];
        foreach (char c in chars)
            charCount[c - 'a']++;

        foreach (string word in words)
        {
            int[] tempCharCount = (int[])charCount.Clone();
            int charLength = 0;
            foreach (char c in word)
            {
                if (tempCharCount[c - 'a'] > 0)
                {
                    charLength++;
                    tempCharCount[c - 'a']--;
                }
            }
            if (charLength == word.Length)
                charMatchCount += charLength;
        }
        return charMatchCount;
    }
}
