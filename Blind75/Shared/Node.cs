namespace Blind75.Shared;

public class Node
{
#pragma warning disable IDE1006 // Naming Styles
    public int val;
    public IList<Node?> neighbors;

    public Node()
    {
        val = 0;
        neighbors = [];
    }

    public Node(int _val)
    {
        val = _val;
        neighbors = [];
    }

    public Node(int _val, List<Node?> _neighbors)
#pragma warning restore IDE1006 // Naming Styles
    {
        val = _val;
        neighbors = _neighbors;
    }
}
