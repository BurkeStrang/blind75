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
        Dictionary<string, IList<string>> map = [];
        foreach (string word in strs)
        {
            string ordered = string.Concat(word.Order());
            if (!map.TryAdd(ordered, [word]))
                map[ordered].Add(word);
        }
        return map.Select(x => x.Value).ToList();
    }
}
