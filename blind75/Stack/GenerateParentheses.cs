namespace Blind75.Stack;

/*

Given n pairs of parentheses, write a function to generate all combinations of well-formed parentheses.

Example 1:
Input: n = 3
Output: ["((()))","(()())","(())()","()(())","()()()"]

Example 2:
Input: n = 1
Output: ["()"]

Constraints:

1 <= n <= 8

*/

public static class GenerateParentheses
{
    public static IList<string> GenerateParenthesis(int n)
    {
        List<string> result = [];
        StringBuilder seq = new();

        void Backtrack(int open, int close)
        {
            if (seq.Length == n * 2)
            {
                result.Add(seq.ToString());
                return;
            }

            if (open < n)
            {
                seq.Append('(');
                Backtrack(open + 1, close);
                seq.Remove(seq.Length - 1, 1);
            }
            if (close < open)
            {
                seq.Append(')');
                Backtrack(open, close + 1);
                seq.Remove(seq.Length - 1, 1);
            }
        }

        Backtrack(0, 0);

        return result;
    }
}
