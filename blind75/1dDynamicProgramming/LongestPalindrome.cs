namespace blind75.DynammicProgramming;
// Given a string s, return the longest palindromic substring in s.

// Example 1:

// Input: s = "babad"
// Output: "bab"
// Explanation: "aba" is also a valid answer.

public static class LongestPalindromeClass
{
    public static string LongestPalindrome(string s)
    {
        var l = 0;
        var h = 0;
        var len1 = 0;
        for (var i = 0; i < s.Length; i++)
        {
            len1 = Math.Max(lengthOfPalindrome(s, i, i), lengthOfPalindrome(s, i, i + 1));

            if (len1 > h - l)
            {
                l = i - (len1 - 1) / 2;
                h = i + len1 / 2;
            }
        }
        return s.Substring(l, h - l + 1);

    }

    public static int lengthOfPalindrome(String s, int L, int H)
    {

        while (L >= 0 && H < s.Length && s[L] == s[H])
        {
            L--;
            H++;
        }
        return H - L - 1;

    }
}
