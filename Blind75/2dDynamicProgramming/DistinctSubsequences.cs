namespace Blind75.DynamicProgramming;

/*

Given two strings s and t, return the number of distinct subsequences of s which equals t.
The test cases are generated so that the answer fits on a 32-bit signed integer.

Example 1:
Input: s = "rabbbit", t = "rabbit"
Output: 3
Explanation:
As shown below, there are 3 ways you can generate "rabbit" from s.
rabbbit
rabbbit
rabbbit

Example 2:
Input: s = "babgbag", t = "bag"
Output: 5
Explanation:
As shown below, there are 5 ways you can generate "bag" from s.
babgbag
babgbag
babgbag
babgbag
babgbag

Constraints:
1 <= s.length, t.length <= 1000
s and t consist of English letters.

*/

public static class DistinctSubsequences
{
    public static int NumDistinct(string source, string target)
    {
        int sourceLength = source.Length;
        int targetLength = target.Length;

        // If the source string is shorter than the target string, no subsequence can match.
        if (sourceLength < targetLength)
            return 0;

        // Create a 2D array to store the number of distinct subsequences.
        int[,] dp = new int[sourceLength + 1, targetLength + 1];

        // Initialize the dp array. An empty target can always be matched by any prefix of the source.
        for (int i = 0; i <= sourceLength; i++)
        {
            dp[i, 0] = 1;
        }

        // Fill the dp array.
        for (int i = 1; i <= sourceLength; i++)
        {
            for (int j = 1; j <= targetLength; j++)
            {
                if (source[i - 1] == target[j - 1])
                {
                    // If the current characters match, the result is the sum of two cases:
                    // 1. Exclude both current characters.
                    // 2. Exclude the current character of the source only.
                    dp[i, j] = dp[i - 1, j - 1] + dp[i - 1, j];
                }
                else
                {
                    // If the current characters don't match, we only consider excluding the current character of the source.
                    dp[i, j] = dp[i - 1, j];
                }
            }
        }

        // The result is the number of distinct subsequences of the source that match the target.
        return dp[sourceLength, targetLength];
    }
}
