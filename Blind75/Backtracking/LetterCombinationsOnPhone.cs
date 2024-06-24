namespace Blind75.Backtracking;

/*

Given a string containing digits from 2-9 inclusive, return all possible letter combinations that the number could represent.
Return the answer in any order. A mapping of digits to letters (just like on the telephone buttons) is given below.
Note that 1 does not map to any letters.

Example 1:
Input: digits = "23"
Output: ["ad","ae","af","bd","be","bf","cd","ce","cf"]

Example 2:
Input: digits = ""
Output: []

Example 3:
Input: digits = "2"
Output: ["a","b","c"]

Constraints:
0 <= digits.length <= 4
digits[i] is a digit in the range ['2', '9'].

*/

public static class LetterCombinationsOnPhone
{
    public static IList<string> LetterCombinations(string digits)
    {
        Dictionary<char, string> lettersMap =
            new()
            {
                { '2', "abc" },
                { '3', "def" },
                { '4', "ghi" },
                { '5', "jkl" },
                { '6', "mno" },
                { '7', "pqrs" },
                { '8', "tuv" },
                { '9', "wxyz" }
            };

        List<string> result = [];

        if (!string.IsNullOrEmpty(digits))
            Backtrack(result, digits, lettersMap, "", 0);

        return result;
    }

    static void Backtrack(
        List<string> result,
        string digits,
        Dictionary<char, string> lettersMap,
        string curString,
        int start
    )
    {
        if (curString.Length == digits.Length)
        {
            result.Add(curString);
            return;
        }

        foreach (char c in lettersMap[digits[start]])
        {
            Backtrack(result, digits, lettersMap, curString + c, start + 1);
        }
    }
}
