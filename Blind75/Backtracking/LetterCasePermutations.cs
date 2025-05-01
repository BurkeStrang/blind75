namespace Blind75.Backtracking;

// find all the combinations of a string given that each charcter can be uppercase or lowercase
//
// example
// input: s = "Ad2"
// output: ["Ad2","ad2","aD2","AD2"]
public static class LetterCasePermutations
{
    public static IList<string> LetterCasePermutation(string s)
    {
        IList<string> res = [];
        BackTrack(s.ToCharArray(), 0, res);
        return res;
    }

    private static void BackTrack(char[] chars, int index, IList<string> res)
    {
        WriteLine($"[{string.Join(",", chars)}]");
        if (index == chars.Length)
        {
            res.Add(new string(chars));
            return;
        }

        BackTrack(chars, index + 1, res);

        if (char.IsLetter(chars[index]))
        {
            chars[index] ^= (char)32; // Toggle case
            BackTrack(chars, index + 1, res);
            chars[index] ^= (char)32; // Revert case
        }
    }

    public static IList<string> LetterCasePermutationIter(string s)
    {
        Queue<string> queue = new();
        queue.Enqueue(s);

        for (int i = 0; i < s.Length; i++)
        {
            if (char.IsLetter(s[i]))
            {
                int size = queue.Count;
                for (int j = 0; j < size; j++)
                {
                    string current = queue.Dequeue();
                    char[] chars = current.ToCharArray();

                    chars[i] = char.ToLower(chars[i]);
                    queue.Enqueue(new string(chars));

                    chars[i] = char.ToUpper(chars[i]);
                    queue.Enqueue(new string(chars));
                }
            }
        }
        return [.. queue];
    }
}
