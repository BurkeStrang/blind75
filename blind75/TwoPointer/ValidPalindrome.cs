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
        s = s.Replace(" ", "").ToLowerInvariant();
        int left = 0;
        int right = s.Length - 1;

        while (left <= right)
        {
            if (s[left] != s[right])
                return false;
            left++;
            right--;
        }
        return true;
    }
}
