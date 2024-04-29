namespace Blind75.Stack;

/*

Given a string s containing just the characters
'(', ')', '{', '}', '[' and ']', determine if the input string is valid.

An input string is valid if:

Open brackets must be closed by the same type of brackets.
Open brackets must be closed in the correct order.
Every close bracket has a corresponding open bracket of the same type.

*/

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
