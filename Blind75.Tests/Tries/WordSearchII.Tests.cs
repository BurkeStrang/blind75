public class WordSearchII
{
    // Input: board = [["o","a","a","n"],["e","t","a","e"],["i","h","k","r"],["i","f","l","v"]], 
    // words = ["oath","pea","eat","rain"]
    // Output: ["eat","oath"]

    [Fact]
    public void WordSearchCorrect()
    {
        WordSearchIIClass wsc = new();
        string[] words = { "oath", "pea", "eat", "rain" };
        char[][] board = {
            new char[] { 'o', 'a', 'a', 'n' },
            new char[] { 'e', 't', 'a', 'e' },
            new char[] { 'i', 'h', 'k', 'r' },
            new char[] { 'i', 'f', 'l', 'v' }
        };


        List<string> exp = new() { "eat", "oath" };
        IList<string> res = wsc.FindWords(board, words);

        Assert.Equivalent(exp, res);

    }
}
