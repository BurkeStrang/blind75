namespace Blind75.ArraysAndHashing;

// Given a string text, you want to use the characters of text to form as many instances of the word "balloon" as possible.
// You can use each character in text at most once. Return the maximum number of instances that can be formed.
//
// Example 1:
// Input: text = "nlaebolko"
// Output: 1
//
// Example 2:
// Input: text = "loonbalxballpoon"
// Output: 2
//
// Example 3:
// Input: text = "leetcode"
// Output: 0
//
// Constraints:
// 1 <= text.length <= 104
// text consists of lower case English letters only.

public static class MaximumNumberOfBalloons
{
    public static int MaxNumberOfBalloons(string text)
    {
        Dictionary<char, int> dict = [];
        foreach (char c in text)
        {
            if(!dict.TryAdd(c, 1))
                dict[c]++;
        }
        int min = int.MaxValue;
        min = Math.Min(min, dict.GetValueOrDefault('b', 0));
        min = Math.Min(min, dict.GetValueOrDefault('a', 0));
        min = Math.Min(min, dict.GetValueOrDefault('l', 0) / 2);
        min = Math.Min(min, dict.GetValueOrDefault('o', 0) / 2);
        min = Math.Min(min, dict.GetValueOrDefault('n', 0));
        return min;
    }
}
