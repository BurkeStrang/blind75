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
        char[] current = new char[n * 2];
        // WriteLine($"n: {n}");
        Backtrack(result, current, 0, 0, 0, n);
        return result;
    }

    private static void Backtrack(
        List<string> result,
        char[] current,
        int index,
        int openCount,
        int closeCount,
        int n)
    {
        // WriteLine($"index: {index}, openCount: {openCount}, closeCount: {closeCount}");
        // WriteLine($"current: {new string(current)}");
        // If we've placed 2*n characters, we have a valid combination
        if (index == 2 * n)
        {
            result.Add(new string(current));
            return;
        }

        // If we can place an '(', do it
        if (openCount < n)
        {
            current[index] = '(';
            Backtrack(result, current, index + 1, openCount + 1, closeCount, n);
        }

        // If we can place a ')', do it
        if (closeCount < openCount)
        {
            current[index] = ')';
            Backtrack(result, current, index + 1, openCount, closeCount + 1, n);
        }
    }


    public static List<string> GenerateValidParentheses(int num)
    {
        List<string> result = [];
        Queue<Parentheses> queue = new();
        queue.Enqueue(new Parentheses("", 0, 0));
        while (queue.Count > 0)
        {
            Parentheses ps = queue.Dequeue();
            // if we've reached the maximum number of open and close parentheses, add to result
            if (ps.OpenCount == num && ps.CloseCount == num)
                result.Add(ps.Str);
            else
            {
                if (ps.OpenCount < num) // if we can add an open parentheses, add it
                    queue.Enqueue(new Parentheses(ps.Str + "(", ps.OpenCount + 1, ps.CloseCount));

                if (ps.OpenCount > ps.CloseCount) // if we can add a close parentheses, add it
                    queue.Enqueue(new Parentheses(ps.Str + ")", ps.OpenCount, ps.CloseCount + 1));
            }
        }
        return result;
    }
}

public record Parentheses(string Str, int OpenCount, int CloseCount);
