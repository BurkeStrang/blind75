namespace Blind75.Graphs;

/*

A transformation sequence from word beginWord to word endWord using a dictionary wordList is a sequence of words
beginWord -> s1 -> s2 -> ... -> sk such that:
Every adjacent pair of words differs by a single letter.
Every si for 1 <= i <= k is in wordList. Note that beginWord does not need to be in wordList.
sk == endWord
Given two words, beginWord and endWord, and a dictionary wordList,
return the number of words in the shortest transformation sequence from beginWord to endWord,
or 0 if no such sequence exists.

Example 1:
Input: beginWord = "hit", endWord = "cog", wordList = ["hot","dot","dog","lot","log","cog"]
Output: 5
Explanation: One shortest transformation sequence is "hit" -> "hot" -> "dot" -> "dog" -> cog", which is 5 words long.

Example 2:
Input: beginWord = "hit", endWord = "cog", wordList = ["hot","dot","dog","lot","log"]
Output: 0
Explanation: The endWord "cog" is not in wordList, therefore there is no valid transformation sequence.

Constraints:
1 <= beginWord.length <= 10
endWord.length == beginWord.length
1 <= wordList.length <= 5000
wordList[i].length == beginWord.length
beginWord, endWord, and wordList[i] consist of lowercase English letters.
beginWord != endWord
All the words in wordList are unique.

*/

public static class WordLadder
{
    // T: O(N^2*M) where N is the length of the word, M is total no. of words
    // S: O(N^2*M) where N is the length of the word, M is total no. of words
    public static int LadderLength(string beginWord, string endWord, IList<string> wordList)
    {
        if (!wordList.Contains(endWord))
        {
            return 0;
        }

        // Create a new list that can be modified
        List<string> modifiableWordList = new(wordList);

        Dictionary<string, HashSet<string>> nei = [];
        if (!modifiableWordList.Contains(beginWord))
            modifiableWordList.Add(beginWord);

        foreach (string word in modifiableWordList)
        {
            for (int j = 0; j < word.Length; j++)
            {
                string pattern = string.Concat(word.AsSpan(0, j), "*", word.AsSpan(j + 1));
                nei.TryAdd(pattern, []);
                nei[pattern].Add(word);
            }
        }

        HashSet<string> visited =
        [
            beginWord
        ];

        Queue<string> queue = new();
        queue.Enqueue(beginWord);

        int result = 1;

        while (queue.Count > 0)
        {
            int count = queue.Count;
            for (int i = 0; i < count; i++)
            {
                string item = queue.Dequeue();
                if (string.Equals(item, endWord))
                    return result;

                for (int j = 0; j < item.Length; j++)
                {
                    string pattern = string.Concat(item.AsSpan(0, j), "*", item.AsSpan(j + 1));
                    foreach (string neiWord in nei[pattern])
                    {
                        if (!visited.Contains(neiWord))
                        {
                            queue.Enqueue(neiWord);
                            visited.Add(neiWord);
                        }
                    }
                }
            }
            result++;
        }

        return 0;
    }
}
