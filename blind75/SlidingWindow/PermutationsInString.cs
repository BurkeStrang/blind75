namespace Blind75.SlidingWindow;

/*

Given two strings s1 and s2, return true if s2 contains a permutation of s1, or false otherwise.

In other words, return true if one of s1's permutations is the substring of s2.

Example 1:
Input: s1 = "ab", s2 = "eidbaooo"
Output: true
Explanation: s2 contains one permutation of s1 ("ba").

Example 2:
Input: s1 = "ab", s2 = "eidboaoo"
Output: false


Constraints:

1 <= s1.length, s2.length <= 104
s1 and s2 consist of lowercase English letters.

*/

public static class PermutationsInString
{
    public static bool CheckInclusion(string s1, string s2)
    {
        {
            if (s1.Length > s2.Length) return false;

            int[] s1Count = Enumerable.Repeat(0, 26).ToArray();
            int[] s2Count = Enumerable.Repeat(0, 26).ToArray();

            for (int i = 0; i < s1.Length; i++)
            {
                s1Count[s1[i] - 'a']++;
                s2Count[s2[i] - 'a']++;
            }

            int matches = 0;
            for (int i = 0; i < 26; i++)
            {
                if (s1Count[i] == s2Count[i]) matches++;
            }

            int left = 0;
            for (int right = s1.Length; right < s2.Length; right++)
            {
                if (matches == 26) return true;

                int index = s2[right] - 'a';
                s2Count[index]++;
                if (s1Count[index] == s2Count[index])
                {
                    matches++;
                }
                else if (s1Count[index] + 1 == s2Count[index])
                {
                    matches--;
                }

                index = s2[left] - 'a';
                s2Count[index]--;
                if (s1Count[index] == s2Count[index])
                {
                    matches++;
                }
                else if (s1Count[index] - 1 == s2Count[index])
                {
                    matches--;
                }

                left++;
            }

            return matches == 26;
        }
    }
}
