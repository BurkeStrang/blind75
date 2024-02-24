namespace blind75.ArraysAndHashing;

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
