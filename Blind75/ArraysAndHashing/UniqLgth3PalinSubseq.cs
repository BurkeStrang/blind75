namespace Blind75.ArraysAndHashing;

// Given a string s, return the number of unique palindromes of length three that are a subsequence of s.
// Note that even if there are multiple ways to obtain the same subsequence, it is still only counted once.
// A palindrome is a string that reads the same forwards and backwards.
// A subsequence of a string is a new string generated from the original
// string with some characters (can be none)
// deleted without changing the relative order of the remaining characters.
//
// For example, "ace" is a subsequence of "abcde".
//
// Example 1:
// Input: s = "aabca"
// Output: 3
// Explanation: The 3 palindromic subsequences of length 3 are:
// - "aba" (subsequence of "aabca")
// - "aaa" (subsequence of "aabca")
// - "aca" (subsequence of "aabca")
//
// Example 2:
// Input: s = "adc"
// Output: 0
// Explanation: There are no palindromic subsequences of length 3 in "adc".
//
// Example 3:
// Input: s = "bbcbaba"
// Output: 4
// Explanation: The 4 palindromic subsequences of length 3 are:
// - "bbb" (subsequence of "bbcbaba")
// - "bcb" (subsequence of "bbcbaba")
// - "bab" (subsequence of "bbcbaba")
// - "aba" (subsequence of "bbcbaba")
//
// Constraints:
// 3 <= s.length <= 105
// s consists of only lowercase English letters.

public static class UniqLgth3PalinSubseq
{
    public static int CountPalindromicSubsequence(string s)
    {
        // intution is to find the first and last occurence of a character
        // then find the characters between them and add them to a set
        // then count the number of unique characters in the set
        // this will give the number of unique palindromes of length 3
        int count = 0;
        for (char ch = 'a'; ch <= 'z'; ch++)
        {
            int firstIndex = s.IndexOf(ch);
            if (firstIndex != -1)
            {
                int lastIndex = s.LastIndexOf(ch);
                if (lastIndex - firstIndex > 1)
                {
                    HashSet<char> set = [];
                    for (int i = firstIndex + 1; i < lastIndex; i++)
                    {
                        if (!set.Add(s[i]))
                            if (set.Count == 26)
                                break;
                    }
                    count += set.Count;
                }
            }
        }
        return count;
    }
}
