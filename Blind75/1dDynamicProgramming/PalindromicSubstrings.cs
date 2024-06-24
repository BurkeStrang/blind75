namespace Blind75.DynammicProgramming;

// Given a string s, return the number of palindromic substrings in it.
// A string is a palindrome when it reads the same backward as forward.
// A substring is a contiguous sequence of characters within the string.

// Example 1:
// Input: s = "abc"
// Output: 3
// Explanation: Three palindromic strings: "a", "b", "c".

public static class PalindromicSubstringsClass
{
    public static int CountSubstrings(string s)
    {
        int count = 0;
        for (int i = 0; i < s.Length; i++)
        {
            // even length palindrome
            count += CountPalindromes(s, i, i);
            // odd length palindrome
            count += CountPalindromes(s, i, i + 1);
        }
        return count;
    }

    // expand around center
    public static int CountPalindromes(string s, int l, int h)
    {
        int count = 0;
        while (l >= 0 && h < s.Length && s[l] == s[h])
        {
            l--;
            h++;
            count++;
        }
        return count;
    }
}
