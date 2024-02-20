namespace blind75.ArraysAndHashing;

public static class TopKFrequentElementsClass
{
    public static int[] TopKFrequent(int[] nums, int k)
    {
        if (k == nums.Length)
            return nums;
        Dictionary<int, int> frequencyMap = new();
        for (int i = 0; i < nums.Length; i++)
        {
            if (!frequencyMap.ContainsKey(nums[i]))
                frequencyMap.Add(nums[i], 0);
            frequencyMap[nums[i]]++;
        }
        PriorityQueue<int, int> pq = new(Comparer<int>.Create((x, y) => y.CompareTo(x)));
        foreach (var key in frequencyMap.Keys)
            pq.Enqueue(key, frequencyMap[key]);

        // 3. return top k elements from Priority Queue
        var result = new int[k];
        for (var i = 0; i < k; i++)
            result[i] = pq.Dequeue();
        return result;
    }
}
