namespace blind75.Stack;

public static class ValidParenthesesClass
{
    public static bool ValidParentheses(string s)
    {
        Dictionary<char, char> par =
            new()
            {
                { '[', ']' },
                { '(', ')' },
                { '{', '}' }
            };
        Stack<char> stack = new();

        for (int i = 0; i < s.Length; i++)
        {
            if (par.TryGetValue(s[i], out char val))
                stack.Push(val);
            else if (stack.Count == 0 || stack.Peek() != s[i])
                return false;
            else
                stack.Pop();
        }
        return stack.Count == 0;
    }
}
