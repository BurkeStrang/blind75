namespace Blind75.DynammicProgramming;

/*
Given a string s and a dictionary of strings wordDict,
return true if s can be segmented into a space-separated sequence of one or more dictionary words.
Note that the same word in the dictionary may be reused multiple times in the segmentation.

Example 1:

Input: s = "leetcode", wordDict = ["leet","code"]
Output: true
Explanation: Return true because "leetcode" can be segmented as "leet code". */

public static class WordBreakClass
{
    public static bool WordBreak(string s, string[] wordDict)
    {
        bool[] dp = new bool[s.Length + 1];
        dp[s.Length] = true;

        for (int i = s.Length - 1; i >= 0; i--)
        {
            foreach (string word in wordDict)
            {
                if (i + word.Length <= s.Length && s.Substring(i, word.Length) == word)
                {
                    dp[i] = dp[i + word.Length];
                }
                if (dp[i])
                {
                    break;
                }
            }
        }
        return dp[0];
    }
}

