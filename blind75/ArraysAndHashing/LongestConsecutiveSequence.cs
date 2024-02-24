namespace blind75.ArraysAndHashing;

public static class LongestConsecutiveSequenceClass
{
    public static int LongestConsecutiveSequence(int[] nums)
    {
        HashSet<int> set = new(nums);
        int longestStreak = 0;
        foreach (int num in set)
        {
            if (!set.Contains(num - 1))
            {
                int currentNum = num;
                int currentStreak = 1;
                while (set.Contains(currentNum + 1))
                {
                    currentNum += 1;
                    currentStreak += 1;
                }
                longestStreak = Math.Max(longestStreak, currentStreak);
            }
        }
        return longestStreak;
    }
}
