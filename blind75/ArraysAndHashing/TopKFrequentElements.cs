namespace Blind75.ArraysAndHashing;

/*

Given an integer array nums and an integer k,
return the k most frequent elements.
You may return the answer in any order.

Example 1:

Input: nums = [1,1,1,2,2,3], k = 2
Output: [1,2]
Example 2:

Input: nums = [1], k = 1
Output: [1]

*/

public static class TopKFrequentElementsClass
{
    public static int[] TopKFrequent(int[] nums, int k)
    {
        if (k == nums.Length)
            return nums;
        Dictionary<int, int> frequencyMap = [];
        for (int i = 0; i < nums.Length; i++)
        {
            frequencyMap.TryAdd(nums[i], 0);
            frequencyMap[nums[i]]++;
        }
        // need to make sure I remember how to use the priority queue
        // the default is min heap
        // Comparer<int>.Create((x, y) => y.CompareTo(x)) for max heap
        // Comparer<int>.Create((x, y) => x.CompareTo(y)) for min heap
        PriorityQueue<int, int> pq = new(Comparer<int>.Create((x, y) => y - x));

        foreach (KeyValuePair<int, int> map in frequencyMap)
        {
            pq.Enqueue(map.Key, map.Value);
        }

        int[] result = new int[k];
        for (int i = 0; i < k; i++)
        {
            result[i] = pq.Dequeue();
        }
        return result;
    }
}
