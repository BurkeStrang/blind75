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
        // WriteLine($"[{string.Join(",", chars)}]");
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


    public static List<string> FindLetterCaseStringPermutations(string str)
    {
        List<string> permutations = [];
        if (str == null)
            return permutations;

        // permutations = [ab1]
        permutations.Add(str);
        // process every character of the string one by one
        for (int i = 0; i < str.Length; i++)
        {
            // iteration 1: i=0, permutations = [ab1] -> [ab1, Ab1]
            // iteration 2: i=1, permutations = [ab1, Ab1] -> [ab1, Ab1, aB1, AB1]
            if (char.IsLetter(str[i]))
            { // only process characters, skip digits
              // we'll take all existing permutations and change the letter case appropriately
                int n = permutations.Count;
                for (int j = 0; j < n; j++)
                {
                    char[] chs = permutations[j].ToCharArray();
                    // if the current char is in upper case change it to lower case or vice versa
                    chs[i] = char.IsUpper(chs[i]) ?
                             char.ToLower(chs[i]) : char.ToUpper(chs[i]);
                    permutations.Add(new string(chs));
                }
            }
        }
        return permutations;
    }
}
