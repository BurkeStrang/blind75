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
            string sortedStr = string.Concat(str.Order());
            if (!anagrams.TryAdd(sortedStr, [str]))
                anagrams[sortedStr].Add(str);
        }
        return [.. anagrams.Values];
    }
}
