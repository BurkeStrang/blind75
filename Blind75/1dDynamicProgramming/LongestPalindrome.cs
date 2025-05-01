namespace Blind75.DynammicProgramming;

// Given a string s, return the longest palindromic substring in s.

// Example 1:

// Input: s = "babad"
// Output: "bab"
// Explanation: "aba" is also a valid answer.

public static class LongestPalindromeClass
{
    public static string LongestPalindrome(string s)
    {
        int l = 0;
        int r = 0;
        for (int i = 0; i < s.Length; i++)
        {
            int len1 = Max(LengthOfPalindrome(s, i, i), LengthOfPalindrome(s, i, i + 1));

            if (len1 > r - l)
            {
                l = i - ((len1 - 1) / 2);
                r = i + (len1 / 2);
            }
        }
        return s.Substring(l, r - l + 1);
    }

    public static int LengthOfPalindrome(string s, int l, int r)
    {
        while (l >= 0 && r < s.Length && s[l] == s[r])
        {
            l--;
            r++;
        }
        return r - l - 1;
    }
}


