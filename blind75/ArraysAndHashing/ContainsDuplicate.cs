namespace blind75.ArraysAndHashing;

// Given an integer array nums, return true if any value appears at least twice in the array,
// and return false if every element is distinct.

// Example 1:
// Input: nums = [1,2,3,1]
// Output: true

public static class ContainsDuplicateClass
{
    public static bool ContainsDuplicate(int[] nums)
    {
        HashSet<int> set = new();
        foreach (int num in nums)
        {
            if (set.Contains(num))
                return true;
            set.Add(num);
        }
        return false;
    }
}
