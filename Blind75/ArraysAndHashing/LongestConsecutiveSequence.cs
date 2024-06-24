namespace Blind75.ArraysAndHashing;

/*
Given an unsorted array of integers nums, return the length of the longest consecutive elements sequence.
You must write an algorithm that runs in O(n) time.

Example:

Input: nums = [100,4,200,1,3,2]
Output: 4
Explanation: The longest consecutive elements sequence is [1, 2, 3, 4]. Therefore its length is 4.

*/
public static class LongestConsecutiveSequenceClass
{
    public static int LongestConsecutiveSequence(int[] nums)
    {
        HashSet<int> set = new(nums);
        int longestStreak = 1;
        foreach (int num in set)
        {
            if (!set.Contains(num - 1))
            {
                int currStreak = 1;
                int currentNum = num;
                while (set.Contains(currentNum + 1))
                {
                    currentNum++;
                    currStreak++;
                }
                longestStreak = Math.Max(longestStreak, currStreak);
            }
        }
        return longestStreak;
    }
}
