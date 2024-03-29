namespace blind75.ArraysAndHashing;

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
        Dictionary<string, List<string>> anagrams = new();
        foreach (string str in strs)
        {
            char[] charArr = str.ToCharArray();
            Array.Sort(charArr);
            string sortedStr = new(charArr);
            if (!anagrams.ContainsKey(sortedStr))
            {
                anagrams.Add(sortedStr, new List<string>());
            }
            anagrams[sortedStr].Add(str);
        }
        return anagrams.Values.ToList<IList<string>>();
    }
}
