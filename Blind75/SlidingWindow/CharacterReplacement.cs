namespace Blind75.SlidingWindow;

/*

You are given a string s and an integer k.
You can choose any character of the string and change it to any other uppercase English character.
You can perform this operation at most k times.

Return the length of the longest substring containing the same letter you can get after performing the above operations.

Example 1:

Input: s = "ABAB", k = 2
Output: 4
Explanation: Replace the two 'A's with two 'B's or vice versa.

*/
public static class CharacterReplacementClass
{
    public static int CharacterReplacement(string s, int k)
    {
        int left = 0;
        int maxLength = 0;
        int mostFrequentLetterCount = 0;
        int[] charCounts = new int[26];

        for (int right = 0; right < s.Length; right++)
        {
            charCounts[s[right] - 'A']++;
            mostFrequentLetterCount = Math.Max(mostFrequentLetterCount, charCounts[s[right] - 'A']);
            int lettersToChange = right - left + 1 - mostFrequentLetterCount;
            if (lettersToChange > k)
            {
                // Window is invalid, decrease char count and move left pointer
                charCounts[s[left] - 'A']--;
                left++;
            }

            maxLength = Math.Max(maxLength, right - left + 1);
        }
        return maxLength;
    }
}
