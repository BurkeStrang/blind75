namespace Blind75.TwoPointers;

// a palindrome is a word, phrase, number, or other sequence of characters that reads the same forward and backward
// Given a string s, return true if the s can be rearranged in a palindrome, and false otherwise.
// Example 1:
// Input: s = 'race car'
// Output: true

public static partial class ValidPalindrome
{
    public static bool IsPalindrome(string s)
    {
        // s = NotCharacterOrNumber.Replace(s, "").ToLowerInvariant();
        s = string.Concat(s.Where(char.IsLetterOrDigit)).ToLowerInvariant();
        int left = 0;
        int right = s.Length - 1;

        while (left < right)
        {
            if (s[left++] != s[right--])
                return false;
        }
        return true;
    }

    // more flexible than IsLetterOrDigit
    // but comes at a performance cost
    // useful for more realworld scenarios
    // [GeneratedRegex("[^a-zA-Z0-9]")]
    // private static partial Regex NotCharacterOrNumber { get; }
}
