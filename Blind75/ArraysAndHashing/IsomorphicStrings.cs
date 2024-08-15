namespace Blind75.ArraysAndHashing;

// Given two strings s and t, determine if they are isomorphic.
// Two strings s and t are isomorphic if the characters in s can be replaced to get t.
// All occurrences of a character must be replaced with another character while preserving the order of characters.
// No two characters may map to the same character, but a character may map to itself.
//
// Example 1:
// Input: s = "egg", t = "add"
// Output: true
//
// Example 2:
// Input: s = "foo", t = "bar"
// Output: false
//
// Example 3:
// Input: s = "paper", t = "title"
// Output: true
//
// Constraints:
// 1 <= s.length <= 5 * 104
// t.length == s.length
// s and t consist of any valid ascii character.

public class IsomorphicStrings
{
    public static bool IsIsomorphic(string s, string t)
    {
        if (s.Length != t.Length)
            return false;

        Dictionary<char, char> sToT = [];
        Dictionary<char, char> tToS = [];

        for (int i = 0; i < s.Length; i++)
        {
            if (!sToT.TryAdd(s[i], t[i]))
                if (sToT[s[i]] != t[i])
                    return false;
            if (!tToS.TryAdd(t[i], s[i]))
                if (tToS[t[i]] != s[i])
                    return false;
        }

        return true;
    }
}
