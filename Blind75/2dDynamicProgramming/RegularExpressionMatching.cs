namespace Blind75.DynamicProgramming;

/*

Given an input string s and a pattern p, implement regular expression matching with support for '.' and '*' where:

'.' Matches any single character.​​​​
'*' Matches zero or more of the preceding element.
The matching should cover the entire input string (not partial).

Example 1:
Input: s = "aa", p = "a"
Output: false
Explanation: "a" does not match the entire string "aa".

Example 2:
Input: s = "aa", p = "a*"
Output: true
Explanation: '*' means zero or more of the preceding element, 'a'. Therefore, by repeating 'a' once, it becomes "aa".

Example 3:
Input: s = "ab", p = ".*"
Output: true
Explanation: ".*" means "zero or more (*) of any character (.)".

Constraints:
1 <= s.length <= 20
1 <= p.length <= 20
s contains only lowercase English letters.
p contains only lowercase English letters, '.', and '*'.
It is guaranteed for each appearance of the character '*', there will be a previous valid character to match.

*/

public class RegularExpressionMatching
{
    // T: O(M*N) | S: O(M*N)
    public static bool IsMatch(string s, string p)
    {
        // Top down
        Dictionary<(int, int), bool> cache = [];

        bool Dfs(int i, int j)
        {
            if (cache.TryGetValue((i, j), out bool result))
                return result;
            if (i >= s.Length && j >= p.Length)
                return true;
            if (j >= p.Length)
                return false;

            bool match = i < s.Length && (s[i] == p[j] || p[j] == '.');
            if (j + 1 < p.Length && p[j + 1] == '*')
            {
                cache.TryAdd((i, j), false);
                cache[(i, j)] =
                    (match && Dfs(i + 1, j))
                    || //use *
                    Dfs(i, j + 2); //dont use *
                return cache[(i, j)];
            }

            if (match)
            {
                cache.TryAdd((i, j), false);
                cache[(i, j)] = Dfs(i + 1, j + 1);
                return cache[(i, j)];
            }

            cache.TryAdd((i, j), false);
            cache[(i, j)] = false;
            return cache[(i, j)];
        }

        return Dfs(0, 0);
    }
}
