namespace Blind75.Greedy;

/*

Given a string s containing only three types of characters: '(', ')' and '*', return true if s is valid.
The following rules define a valid string:
Any left parenthesis '(' must have a corresponding right parenthesis ')'.
Any right parenthesis ')' must have a corresponding left parenthesis '('.
Left parenthesis '(' must go before the corresponding right parenthesis ')'.
'*' could be treated as a single right parenthesis ')' or a single left parenthesis '(' or an empty string "".

Example 1:
Input: s = "()"
Output: true

Example 2:
Input: s = "(*)"
Output: true

Example 3:
Input: s = "(*))"
Output: true

Constraints:
1 <= s.length <= 100
s[i] is '(', ')' or '*'.

*/

public static class ValidParenthesesString
{
    // T: O(N) , S: O(1)
    public static bool CheckValidString(string s)
    {
        int leftMax = 0; // Maximum possible open parentheses '('
        int leftMin = 0; // Minimum possible open parentheses '('

        foreach (char ch in s)
        {
            if (ch == '(')
            {
                // Increase both min and max for '('
                leftMin++;
                leftMax++;
            }
            else if (ch == ')')
            {
                // Decrease both min and max for ')'
                leftMin--;
                leftMax--;
            }
            else
            {
                // '*' can be '(' or ')' or ''
                // Decrease min (if '*' is ')') and increase max (if '*' is '(')
                leftMin--;
                leftMax++;
            }

            // If at any point max open parentheses is negative, it's invalid
            if (leftMax < 0)
                return false;

            // Ensure min open parentheses doesn't go negative
            if (leftMin < 0)
                leftMin = 0;
        }

        // If min open parentheses is zero, it's valid
        return leftMin == 0;
    }
}
