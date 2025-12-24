

public class Solution
{
    public static Dictionary<string, int> CalculateMinDistances(string[] wordList)
    {
        // Stores last index and current min distance for each word
        Dictionary<string, (int lastIndex, int? minDist)> wordInfo = [];
        Dictionary<string, int> result = [];

        for (int i = 0; i < wordList.Length; i++)
        {
            string word = wordList[i];
            if (wordInfo.TryGetValue(word, out (int lastIndex, int? minDist) info))
            {
                int distance = i - info.lastIndex;
                int minDist = info.minDist.HasValue ? Min(distance, info.minDist.Value) : distance;
                wordInfo[word] = (i, minDist);
            }
            else
                wordInfo[word] = (i, null);
        }

        // Only include words that have a min distance (i.e., appeared more than once)
        foreach (KeyValuePair<string, (int lastIndex, int? minDist)> kv in wordInfo)
        {
            if (kv.Value.minDist.HasValue)
                result.Add(kv.Key, kv.Value.minDist.Value);
        }

        return result;
    }
}
