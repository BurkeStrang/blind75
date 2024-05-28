namespace Blind75.ArraysAndHashing;

// Given an array of strings strs, group the anagrams together.
// You can return the answer in any order.

// An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase,
// typically using all the original letters exactly once.

// Example 1:
// Input: strs = ["eat","tea","tan","ate","nat","bat"]
// Output: [["bat"],["nat","tan"],["ate","eat","tea"]]

public static class GroupAnagramsClass
{
    public static IList<IList<string>> GroupAnagrams(string[] strs)
    {
        Dictionary<string, List<string>> anagrams = [];
        foreach (string str in strs)
        {
            char[] charArr = str.ToCharArray();
            Array.Sort(charArr);
            string sortedStr = new(charArr);
            // try get value, if not present add new list
            if (!anagrams.TryGetValue(sortedStr, out List<string>? value))
            {
                value = [];
                anagrams.Add(sortedStr, value);
            }
            // add new string to list which is referenced in the out value
            value.Add(str);
        }
        return [.. anagrams.Values];
    }
}
