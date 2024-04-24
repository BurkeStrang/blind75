namespace blind75.Graphs;

// There is a new alien language which uses the latin alphabet.
// However, the order among letters are unknown to you.
// You receive a list of non-empty words from the dictionary,
// where words are sorted lexicographically by the rules of this new language.
// Derive the order of letters in this language.

// Input：["wrt","wrf","er","ett","rftt"]
// Output："wertf"
// Explanation：
// from "wrt"and"wrf" ,we can get 't'<'f'
// from "wrt"and"er" ,we can get 'w'<'e'
// from "er"and"ett" ,we can get 'r'<'t'
// from "ett"and"rftt" ,we can get 'e'<'r'
// So return "wertf"

public static class AlienDictionaryClass
{
    public static string AlienOrder(string[] words)
    {
        Dictionary<char, HashSet<char>> adj = [];

        //Add all the available characters to the adjacency list resolves all the edges
        foreach (string word in words)
        {
            foreach (char c in word)
            {
                if (adj.ContainsKey(c))
                {
                    continue;
                }
                adj[c] = [];
            }
        }

        for (int i = 0; i < words.Length - 1; i++)
        {
            string w1 = words[i];
            string w2 = words[i + 1];

            int minLen = Math.Min(w1.Length, w2.Length);
            if (w1.Length > w2.Length && w1.AsSpan(0, minLen) == w2.AsSpan(0, minLen))
            {
                return "";
            }

            for (int j = 0; j < minLen; j++)
            {
                if (w1[j] != w2[j])
                {
                    adj[w1[j]].Add(w2[j]);
                    break;
                }
            }
        }

        Dictionary<char, bool> visited = []; //false = visited, true = in the current path
        List<char> res = [];

        bool Dfs(char c)
        {
            if (visited.TryGetValue(c, out bool v))
            {
                return v; //true: there is a cycle - we are visiting this twice
            }
            visited.TryAdd(c, false);
            visited[c] = true;

            foreach (char neigh in adj[c])
            {
                if (Dfs(neigh))
                {
                    return true;
                }
            }

            visited[c] = false;
            res.Add(c);

            return visited[c];
        }

        foreach (char c in adj.Keys)
        {
            if (Dfs(c))
            {
                return "";
            }
        }

        res.Reverse();
        return string.Join("", res);
    }
}
