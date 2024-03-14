namespace blind75.TwoPointers;

// a palindrome is a word, phrase, number, or other sequence of characters that reads the same forward and backward
// Given a string s, return true if the s can be rearranged in a palindrome, and false otherwise.
// Example 1:
// Input: s = 'race car'
// Output: true

public static class ValidPalindrome
{
    public static bool IsPalindrome(string s)
    {
        s = string.Concat(Array.FindAll(s.ToCharArray(), Char.IsLetterOrDigit)).ToLowerInvariant();
        int high = s.Length - 1;
        int low = 0;

        while (low <= high)
        {
            if (s[low] != s[high])
                return false;
            low++;
            high--;
        }
        return true;
    }
}
