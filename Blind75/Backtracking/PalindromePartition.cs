namespace Blind75.Backtracking;

/*

Given a string s, partition s such that every substring of the partition is a palindrome.
Return all possible palindrome partitioning of s.
 
Example 1:
Input: s = "aab"
Output: [["a","a","b"],["aa","b"]]

Example 2:
Input: s = "a"
Output: [["a"]]

Constraints:
1 <= s.length <= 16
s contains only lowercase English letters.

*/

public static class PalindromePartition
{
    //O(N.2^N)
    public static IList<IList<string>> Partition(string s)
    {
        List<IList<string>> result = [];
        List<string> stack = [];

        void Dfs(int i)
        {
            if (i >= s.Length)
            {
                result.Add([.. stack]);
                return;
            }

            for (int j = i; j < s.Length; j++)
            {
                if (IsPalindrome(s, i, j))
                {
                    stack.Add(s.Substring(i, j - i + 1));
                    Dfs(j + 1);
                    stack.RemoveAt(stack.Count - 1);
                }
            }

        }

        Dfs(0);

        return result;
    }

    public static bool IsPalindrome(string s, int l, int r)
    {
        while (l < r)
        {
            if (s[l] != s[r])
                return false;
            l++;
            r--;
        }

        return true;
    }
}
