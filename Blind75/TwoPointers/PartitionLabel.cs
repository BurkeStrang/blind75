namespace Blind75.TwoPointers;

// Given a string s, partition it into as many parts as possible so that each letter appears in at most one part.
// Return a list of integers representing the size of these parts.
//
// **Constraints:**
// - Each letter should appear in only one part.
// - The concatenation of all parts should be equal to s.
//
// **Example:**
// Input: s = "ababcbacadefegdehijhklij"  
// Output: [9,7,8]  
// Explanation:  
// The partitions are "ababcbaca", "defegde", "hijhklij". Each letter appears in at most one part.

public static class PartitionLabel
{
    public static List<int> PartitionLabels(string s)
    {
        List<int> result = [];
        // Step 1: last occurrence of each character
        int[] last = new int[26];
        for (int i = 0; i < s.Length; i++)
            last[s[i] - 'a'] = i;

        int start = 0;
        int end = 0;

        // Step 2: walk and expand partition
        for (int i = 0; i < s.Length; i++)
        {
            end = Max(end, last[s[i] - 'a']);

            // Step 3: close partition
            if (i == end)
            {
                result.Add(end - start + 1);
                start = i + 1;
            }
        }

        return result;
    }
}
