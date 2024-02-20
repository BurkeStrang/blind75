namespace blind75.ArraysAndHashing;

public static class TwoSumClass
{
    public static int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> map = new();
        for (int i = 0; i < nums.Length; i++)
        {
            if (map.ContainsKey(target - nums[i]))
            {
                return [map[target - nums[i]], i];
            }
            map[nums[i]] = i;
        }
        return [];
    }
}
