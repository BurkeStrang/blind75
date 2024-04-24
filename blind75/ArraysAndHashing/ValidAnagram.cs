namespace blind75.ArraysAndHashing;

/*

An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase,
typically using all the original letters exactly once.

Example:

Input: s = "anagram", t = "nagaram"
Output: true

*/

public static class ValidAnagramClass
{
    public static bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
            return false;
        int[] count = new int[26];
        for (int i = 0; i < s.Length; i++)
        {
            count[s[i] - 'a']++;
            count[t[i] - 'a']--;
        }
        for (int i = 0; i < 26; i++)
        {
            if (!(count[i] == 0))
                return false;
        }
        return true;
    }
}
