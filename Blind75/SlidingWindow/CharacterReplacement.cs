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

Example 2:
Input: s = "AABABBA", k = 1
Output: 4
Explanation: Replace the 'B' in the 2 index with 'A' and form "AAAABBA"
or one 'A' in the middle with 'B' and form "AABBBBA".

*/
public static class CharacterReplacementClass
{
    public static int CharacterReplacement(string s, int k)
    {
        int left = 0;
        int[] characters = new int[26];
        int maxCharacter = 0; 
        int maxWithReplacment = 0;

        for(int right = 0; right < s.Length; right++)
        {
            maxCharacter = Math.Max(maxCharacter, ++characters[s[right]-'A']);
            int numOfChanges = right - left + 1 - maxCharacter;

            if(numOfChanges > k)
            {
                // remove characters that are out of window
                characters[s[left]-'A']--;
                left++;
            }
            maxWithReplacment = Math.Max(maxWithReplacment, right - left + 1);
        }
        return maxWithReplacment;
    }
}
