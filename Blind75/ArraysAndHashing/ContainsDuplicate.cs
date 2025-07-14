namespace Blind75.ArraysAndHashing;

// Given an integer array nums, return true if any value appears at least twice in the array,
// and return false if every element is distinct.

// Example 1:
// Input: nums = [1,2,3,1]
// Output: true

public static class ContainsDuplicateClass
{
    public static bool ContainsDuplicate(int[] nums)
    {
        HashSet<int> set = [];
        foreach (int num in nums)
            if (!set.Add(num))
                return true;
        return false;
    }
}
