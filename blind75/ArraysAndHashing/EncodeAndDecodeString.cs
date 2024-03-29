namespace blind75.ArraysAndHashing;

// Design an algorithm to encode a list of strings to a string.
// The encoded string is then sent over the network and is decoded back to the original list of strings.

// Input: ["lint","code","love","you"]
// Output: ["lint","code","love","you"]
// Explanation:
// One possible encode method is: "4#lint4#code4#love3#you"

public static class Codec
{
    public static string Encode(IList<string> strs)
    {
        // returns a single string with the length of the string followed
        // by the # symbol before the string in the list
        return string.Concat(strs.SelectMany(s => $"{s.Length}#{s}"));
    }

    public static IList<string> Decode(string s)
    {
        List<string> res = new();

        int i = 0;
        while (i < s.Length)
        {
            if (!int.TryParse(s[i].ToString(), out int length) || !(s[i + 1] == '#'))
            {
                throw new ArgumentException("Invalid Input");
            }
            i += 2;
            res.Add(s.Substring(i, length));
            i += length;
        }
        return res;
    }
}
