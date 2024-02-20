namespace blind75.ArraysAndHashing
{
    public static class GroupAnagramsClass
    {
        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, List<string>> anagrams = new Dictionary<string, List<string>>();
            foreach (string str in strs)
            {
                char[] charArr = str.ToCharArray();
                Array.Sort(charArr);
                string sortedStr = new string(charArr);
                if (!anagrams.ContainsKey(sortedStr))
                {
                    anagrams.Add(sortedStr, new List<string>());
                }
                anagrams[sortedStr].Add(str);
            }
            return anagrams.Values.ToList<IList<string>>();
        }
    }
}
