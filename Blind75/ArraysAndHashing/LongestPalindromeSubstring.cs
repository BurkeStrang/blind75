namespace Blind75.ArraysAndHashing;

public static class LongestPalindromeSubstring
{
    // naive brute force solution
    // still returns early if a palindrome is found
    // so it is only bad when there is no palindrome or the palindrome is at the end
    // this runs in O(n^3) time
    // which is not ideal but it is a little more straightforward
    public static string LongestPalindrome(string s)
    {
        for (int length = s.Length; length > 0; length--)
        {
            for (int start = 0; start + length <= s.Length; start++)
            {
                string substring = s.Substring(start, length);
                if (IsPalindrome(substring))
                    return substring;
            }
        }
        return "";
    }

    public static bool IsPalindrome(string s)
    {
        int front = 0;
        int back = s.Length - 1;

        while (front <= back)
        {
            if (s[front] != s[back])
                return false;
            front++;
            back--;
        }
        return true;
    }

    // basically for every character in the string we expand around it
    // as far as we can go and it's still a palindrome
    // we do this for both odd and even length palindromes
    // because the logic is different for each
    // An odd-length palindrome has a single central character with
    // a symmetric structure around it. For example: "racecar"
    // An even-length palindrome has two central characters with
    // a symmetric structure around them. For example: "noon"
    // hence the i+1 in the even length palindrome
    public static string LongestPalindromeExpandAround(string s)
    {
        ReadOnlySpan<char> max = [];
        if (s is null || s.Length < 1)
            return max.ToString();
        for (int i = 0; i < s.Length; i++)
        {
            ReadOnlySpan<char> odd = ExpandAroundCenter(s, i, i);
            ReadOnlySpan<char> even = ExpandAroundCenter(s, i, i + 1);
            ReadOnlySpan<char> currentMax = odd.Length > even.Length ? odd : even;
            max = currentMax.Length > max.Length ? currentMax : max;
        }
        return max.ToString();
    }

    public static ReadOnlySpan<char> ExpandAroundCenter(ReadOnlySpan<char> s, int left, int right)
    {
        while (left >= 0 && right < s.Length && s[left] == s[right])
        {
            left--;
            right++;
        }
        return s.Slice(left + 1, right - left - 1);
    }

    public static string LongestPalindromeParallel(string s)
    {
        for (int length = s.Length; length > 0; length--)
        {
            string result = "";
            Parallel.For(
                0,
                s.Length - length + 1,
                (start, state) =>
                {
                    string substring = s.Substring(start, length);
                    if (IsPalindrome(substring))
                    {
                        result = substring;
                        state.Stop(); // Stop further parallel processing
                    }
                }
            );

            if (result != "")
                return result; // If we found a palindrome, return it
        }

        return "";
    }
}
