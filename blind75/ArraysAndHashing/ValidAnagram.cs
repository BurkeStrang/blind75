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
        List<char> sList = [.. s];

        foreach (char c in t)
        {
            if (!sList.Contains(c))
                return false;
            sList.Remove(c);
        }
        return sList.Count == 0;
    }
}
