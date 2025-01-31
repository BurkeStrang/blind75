namespace Blind75.Heap;

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
        Dictionary<int, int> dict = [];
        foreach (int num in nums)
            if (!dict.TryAdd(num, 1))
                dict[num]++;

        PriorityQueue<int, int> minHeap = new();

        foreach (KeyValuePair<int, int> dic in dict)
            minHeap.Enqueue(dic.Key, dic.Value * -1);

        int[] res = new int[k];
        int i = 0;
        while (i < k)
            res[i++] = minHeap.Dequeue();
        return res;
    }
}
