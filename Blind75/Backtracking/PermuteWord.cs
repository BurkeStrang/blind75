namespace Blind75.Backtracking;


public static class PermuteWord
{
    public static IList<string> Permute(string word)
    {
        List<string> result = [];
        PermuteRecurse(result, word.ToCharArray(), 0);
        return result;
    }

    private static void PermuteRecurse(List<string> res, char[] word, int start)
    {
        if (start == word.Length)
        {
            res.Add(new string(word));
            return;
        }

        for (int i = start; i < word.Length; i++)
        {
            (word[start], word[i]) = (word[i], word[start]);
            WriteLine($"  word:{string.Join(",", word)}, start:{start}, i:{i} ");
            PermuteRecurse(res, word, start + 1);
            (word[start], word[i]) = (word[i], word[start]);
            WriteLine($"  word:{string.Join(",", word)}, start:{start}, i:{i} ");
        }
    }
}

