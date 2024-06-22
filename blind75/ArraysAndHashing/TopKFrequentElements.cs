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

        IEnumerable<(int Key, int Count)> frequencyMap = nums.GroupBy(x => x).Select(x => (x.Key, x.Count()));
        PriorityQueue<int, int> pq = new(frequencyMap, Comparer<int>.Create((x, y) => y - x));
        IEnumerable<int> res = Enumerable.Range(0, k).Select(x => pq.Dequeue());

        return [.. res];
    }
}
