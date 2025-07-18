namespace Blind75.ArraysAndHashing;

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

        Dictionary<char, int> sMap = s.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());

        foreach (char c in t)
        {
            if (!sMap.TryGetValue(c, out int count) || count == 0)
                return false;
            sMap[c]--;
        }
        return sMap.Values.All(v => v == 0);
    }

    public static bool IsAnagramArray(string s, string t)
    {
        // assumes only lowercase letters
        // default value of int is 0
        int[] chars = new int[26];

        for (int i = 0; i < s.Length; i++)
        {
            chars[s[i] - 'a']++;
            chars[t[i] - 'a']--;
        }

        return chars.All(c => c == 0);
    }
}
