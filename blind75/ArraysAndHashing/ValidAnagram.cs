namespace blind75.ArraysAndHashing;

public static class ValidAnagramClass
{
    public static bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
            return false;
        int[] Count = new int[26];
        for (int i = 0; i < s.Length; i++)
        {
            Count[s[i] - 'a']++;
            Count[t[i] - 'a']--;
        }
        for (int i = 0; i < 26; i++)
        {
            if (!(Count[i] == 0))
                return false;
        }
        return true;
    }
}
