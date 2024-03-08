namespace blind75.DynammicProgramming;

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
        Array.Fill(dp, false);
        dp[s.Length] = true;

        for (int i = s.Length - 1; i >= 0; i--)
        {
            foreach (string w in wordDict)
            {
                if (i + w.Length <= s.Length && s.Substring(i, w.Length) == w)
                {
                    dp[i] = dp[i + w.Length];
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
