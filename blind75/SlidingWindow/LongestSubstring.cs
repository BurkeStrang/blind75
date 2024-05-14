namespace Blind75.SlidingWindow;

/*

Given a string s, find the length of the longest substring without repeating characters.

Example 1:

Input: s = "abcabcbb"
Output: 3
Explanation: The answer is "abc", with the length of 3.

Example 2:

Input: s = "au"
Output: 2

*/

public record LongestSubstringClass
{
    public static int LengthOfLongestSubstring(string s)
    {
        HashSet<char> charSet = [];
        int left = 0;
        int right = 0;
        int maxLength = 0;
        while (right < s.Length)
        {
            if (!charSet.Contains(s[right]))
            {
                charSet.Add(s[right]);
                right++;
                maxLength = Math.Max(maxLength, charSet.Count);
            }
            else
            {
                charSet.Remove(s[left]);
                left++;
            }
        }
        return maxLength;
    }
}
