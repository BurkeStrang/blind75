namespace blind75.TwoPointers;

public static class ThreeSumClass
{
    public static IList<IList<int>> ThreeSum(int[] nums)
    {
        var res = new List<IList<int>>();

        Array.Sort(nums);

        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (i == 0 || nums[i - 1] != nums[i])
                TwoSum(nums, i, res);
        }
        return res;
    }

    private static void TwoSum(int[] nums, int i, List<IList<int>> res)
    {
        HashSet<int> set = new();

        for (int j = i + 1; j < nums.Length; j++)
        {
            var complement = -nums[i] - nums[j];
            if (set.Contains(complement))
            {
                res.Add(new List<int> { nums[i], nums[j], complement });
                while (j + 1 < nums.Length && nums[j] == nums[j + 1])
                    ++j;
            }
            set.Add(nums[j]);
        }
    }
}
