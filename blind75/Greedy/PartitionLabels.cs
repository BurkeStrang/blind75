namespace Blind75.Greedy;

/*

You are given a string s. We want to partition the string into as many parts as possible
so that each letter appears in at most one part.
Note that the partition is done so that after concatenating all the parts in order,
the resultant string should be s.
Return a list of integers representing the size of these parts.

Example 1:
Input: s = "ababcbacadefegdehijhklij"
Output: [9,7,8]
Explanation:
The partition is "ababcbaca", "defegde", "hijhklij".
This is a partition so that each letter appears in at most one part.
A partition like "ababcbacadefegde", "hijhklij" is incorrect, because it splits s into less parts.

Example 2:
Input: s = "eccbbbbdec"
Output: [10]

Constraints:
1 <= s.length <= 500
s consists of lowercase English letters.

*/

public static class PartitionLabelsClass
{
    public static IList<int> PartitionLabels(string s)
    {

        int[] chars = new int[26];
        for (int ch = 0; ch < s.Length; ch++)
        {
            chars[s[ch] - 'a'] = ch;
        }

        List<int> result = [];
        int end = 0;
        int size = 0;
        for (int i = 0; i < s.Length; i++)
        {
            end = Math.Max(chars[s[i] - 'a'], end);
            size++;
            if (i == end)
            {
                result.Add(size);
                size = 0;
            }
        }
        return result;
    }
}
