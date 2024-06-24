namespace Blind75.DynamicProgramming;

/*

Given two strings word1 and word2, return the minimum number of operations required to convert word1 to word2.
You have the following three operations permitted on a word:
Insert a character
Delete a character
Replace a character

Example 1:
Input: word1 = "horse", word2 = "ros"
Output: 3
Explanation: 
horse -> rorse (replace 'h' with 'r')
rorse -> rose (remove 'r')
rose -> ros (remove 'e')

Example 2:
Input: word1 = "intention", word2 = "execution"
Output: 5
Explanation: 
intention -> inention (remove 't')
inention -> enention (replace 'i' with 'e')
enention -> exention (replace 'n' with 'x')
exention -> exection (replace 'n' with 'c')
exection -> execution (insert 'u')

Constraints:
0 <= word1.length, word2.length <= 500
word1 and word2 consist of lowercase English letters.

*/

public class EditDistance
{
    //T: O(N^2), S: O(N^2)
    public static int MinDistance(string word1, string word2)
    {
        //Bottom up
        int m = word1.Length;
        int n = word2.Length;
        int[,] dp = new int[m + 1, n + 1];

        for (int i = 0; i < m + 1; i++)
        {
            dp[i, n] = m - i;
        }
        for (int j = 0; j < n + 1; j++)
        {
            dp[m, j] = n - j;
        }

        for (int i = m - 1; i >= 0; i--)
        {
            for (int j = n - 1; j >= 0; j--)
            {
                if (word1[i] == word2[j])
                    dp[i, j] = dp[i + 1, j + 1];
                else
                    dp[i, j] = 1 + Math.Min(Math.Min(dp[i + 1, j + 1], dp[i + 1, j]), dp[i, j + 1]); //Replace, Delete, Insert
            }
        }

        return dp[0, 0];
    }
}
