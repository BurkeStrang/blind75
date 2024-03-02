namespace blind75.ArraysAndHashing;


// Design an algorithm to encode a list of strings to a string.
// The encoded string is then sent over the network and is decoded back to the original list of strings.

// Input: ["lint","code","love","you"]
// Output: ["lint","code","love","you"]
// Explanation:
// One possible encode method is: "lint:;code:;love:;you"

public static class Codec
{
    public static string Encode(IList<string> strs)
    {
        return string.Concat(strs.SelectMany(s => $"{s.Length}#{s}"));
    }

    public static IList<string> Decode(string s)
    {
        List<string> res = new();
        int i = 0;
        while (i < s.Length)
        {
            int j = i;
            while (s[j] != '#')
            {
                ++j;
            }
            int.TryParse(s.AsSpan(i, j - i), out int len);
            j++;
            res.Add(s.Substring(j, len));
            i = j + len;
        }
        return res;
    }
}
