namespace Blind75.Backtracking;

// create all the permutations of a string
// example
// input: word = "abc"
// output: ["abc","acb","bac","bca","cab","cba"]

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
            PermuteRecurse(res, word, start + 1);
            (word[start], word[i]) = (word[i], word[start]);
        }
    }


    public static IList<string> PermuteIter(string word)
    {
        List<string> result = [];
        Stack<(char[], int)> stack = new();
        stack.Push((word.ToCharArray(), 0));

        while (stack.Count > 0)
        {
            (char[] currentWord, int start) = stack.Pop();

            if (start == currentWord.Length)
            {
                result.Add(new string(currentWord));
                continue;
            }

            for (int i = currentWord.Length - 1; i >= start; i--)
            {
                char[] swappedWord = (char[])currentWord.Clone();
                (swappedWord[start], swappedWord[i]) = (swappedWord[i], swappedWord[start]);
                stack.Push((swappedWord, start + 1));
            }
        }
        return result;
    }
}

