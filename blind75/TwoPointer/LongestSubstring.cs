namespace blind75.TwoPointers;

/*

Given a string s, find the length of the longest substring without repeating characters.

Example 1:

Input: s = "abcabcbb"
Output: 3
Explanation: The answer is "abc", with the length of 3.
Example 2:

*/

public static class LongestSubstringClass
{
    public static int LengthOfLongestSubstring(string s)
    {
        int leftPointer = 0,
            rightPointer = 0,
            maxLength = 0;
        HashSet<int> chars = new();

        while (rightPointer < s.Length)
        {
            char currChar = s[rightPointer];
            if (chars.Contains(currChar))
            { // Move left pointer until all duplicate chars removed
                chars.Remove(s[leftPointer]);
                leftPointer++;
            }
            else
            {
                chars.Add(currChar);
                maxLength = Math.Max(maxLength, rightPointer - leftPointer + 1);
                rightPointer++;
            }
        }
        return maxLength;
    }
}
