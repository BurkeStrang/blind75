namespace Blind75.TwoPointers;

// Given an array of strings words, return the first palindromic string in the array.
// If there is no such string, return an empty string "".
// A string is palindromic if it reads the same forward and backward.
//
// Example 1:
// Input: words = ["abc","car","ada","racecar","cool"]
// Output: "ada"
// Explanation: The first string that is palindromic is "ada".
// Note that "racecar" is also palindromic, but it is not the first.
//
// Example 2:
// Input: words = ["notapalindrome","racecar"]
// Output: "racecar"
// Explanation: The first and only string that is palindromic is "racecar".
//
// Example 3:
// Input: words = ["def","ghi"]
// Output: ""
// Explanation: There are no palindromic strings, so the empty string is returned.
//
// Constraints:
// 1 <= words.length <= 100
// 1 <= words[i].length <= 100
// words[i] consists only of lowercase English letters.

public static class FindFirstPalindrome
{
    public static string FirstPalindrome(string[] words)
    {
        foreach (string word in words)
            if (word.IsPalindrome())
                return word;
        return "";
    }

    private static bool IsPalindrome(this string word)
    {
        int low = 0;
        int high = word.Length - 1;

        while (low < high)
        {
            if (word[low] != word[high])
                return false;
            low++;
            high--;
        }
        return true;
    }
}
