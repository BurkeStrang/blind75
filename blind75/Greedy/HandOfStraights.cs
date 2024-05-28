namespace Blind75.Greedy;

/*

Alice has some number of cards and she wants to rearrange the cards into groups so that each group is of size groupSize,
and consists of groupSize consecutive cards.
Given an integer array hand where hand[i] is the value written on the ith card and an integer groupSize,
return true if she can rearrange the cards, or false otherwise.

Example 1:
Input: hand = [1,2,3,6,2,3,4,7,8], groupSize = 3
Output: true
Explanation: Alice's hand can be rearranged as [1,2,3],[2,3,4],[6,7,8]

Example 2:
Input: hand = [1,2,3,4,5], groupSize = 4
Output: false
Explanation: Alice's hand can not be rearranged into groups of 4.

Constraints:
1 <= hand.length <= 104
0 <= hand[i] <= 109
1 <= groupSize <= hand.length

*/

public class HandOfStraights
{
    //Same problem as #1296. Divide Array in Sets of K Consecutive Numbers
    //T: O(logN) for min heap, N is for all the items-> so overall O(NlogN)
    public static bool IsNStraightHand(int[] hand, int groupSize)
    {
        if (hand.Length % groupSize != 0)
            return false;

        Dictionary<int, int> dictionary = [];
        PriorityQueue<int, int> minHeap = new();
        foreach (int item in hand)
        {
            dictionary.TryAdd(item, 0);
            dictionary[item]++;
        }

        // heapify is linear algorithm
        foreach (int key in dictionary.Keys)
            minHeap.Enqueue(key, key);

        while (minHeap.Count > 0)
        {
            int first = minHeap.Peek();

            for (int i = first; i < first + groupSize; i++)
            {
                if (!dictionary.TryGetValue(i, out int value))
                    return false;

                dictionary[i] = --value;
                if (value == 0)
                    if (i != minHeap.Peek())
                        return false;
                    else
                        minHeap.Dequeue();
            }
        }

        return true;
    }
}
