using System.Collections;

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
        Dictionary<int, int> frequency = [];

        foreach (int num in nums)
        {
            if (!frequency.TryAdd(num, 1))
                frequency[num]++;
        }

        PriorityQueue<int, int> pq = new(Comparer<int>.Create((x, y) => y - x));

        foreach (KeyValuePair<int, int> item in frequency)
        {
            pq.Enqueue(item.Key, item.Value);
        }

        int[] res = new int[k];

        for(int i = 0; i < k; i++)
        {
            res[i] = pq.Dequeue();
        }
        return res;
    }
}
