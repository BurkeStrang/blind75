namespace blind75.DynammicProgramming;

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
            count += countPalindromes(s, i, i);
            count += countPalindromes(s, i, i + 1);
        }
        return count;
    }

    public static int countPalindromes(string s, int L, int H)
    {
        int count = 0;
        while (L >= 0 && H < s.Length && s[L] == s[H])
        {
            L--;
            H++;
            count++;
        }
        return count;
    }
}

