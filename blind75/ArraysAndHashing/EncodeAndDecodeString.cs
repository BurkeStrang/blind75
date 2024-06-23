namespace Blind75.ArraysAndHashing;

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
        return string.Join("", strs.Select(s => $"{s.Length}#{s}"));
    }

    public static IList<string> Decode(string s)
    {
        List<string> result = [];

        for(int i = 0; i < s.Length;)
        {
            int hashIndex = s.IndexOf('#', i);
            int length = int.Parse(s[i..hashIndex++]);
            i = hashIndex + length;
            result.Add(s[hashIndex..i]);
        }
        return result;
    }
}
