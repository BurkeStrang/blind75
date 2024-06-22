namespace Blind75.ArraysAndHashing;

/*

Given an array of integers nums and an integer target,
return indices of the two numbers such that they add up to target.

You may assume that each input would have exactly one solution,
and you may not use the same element twice.

You can return the answer in any order.

Example :

Input: nums = [2,7,11,15], target = 9
Output: [0,1]
Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].

*/
public static class TwoSumClass
{
    public static int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int,int> dict = [];

        for(int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if(dict.TryGetValue(complement, out int index))
                return [index, i];
            dict.Add(nums[i],i);
        }
        return [];
    }
}
