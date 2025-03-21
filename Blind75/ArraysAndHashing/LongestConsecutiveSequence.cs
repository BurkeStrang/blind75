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
        int max = 1;
        int iterator = 0;
        HashSet<int> set = [.. nums];

        while (iterator < nums.Length)
        {
            if (!set.Contains(nums[iterator] - 1))
            {
                int currentNum = nums[iterator];
                int currenSequence = 1;
                while (set.Contains(++currentNum))
                    currenSequence++;
                max = Max(max, currenSequence);
            }
            iterator++;
        }
        return max;
    }
}
