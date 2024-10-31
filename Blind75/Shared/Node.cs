namespace Blind75.Shared;

public class Node
{
#pragma warning disable IDE1006 // Naming Styles
    public int val;
#pragma warning restore IDE1006 // Naming Styles
#pragma warning disable IDE1006 // Naming Styles
    public IList<Node?> neighbors;
#pragma warning restore IDE1006 // Naming Styles

    public Node()
    {
        val = 0;
        neighbors = [];
    }

#pragma warning disable IDE1006 // Naming Styles
    public Node(int _val)
#pragma warning restore IDE1006 // Naming Styles
    {
        val = _val;
        neighbors = [];
    }

#pragma warning disable IDE1006 // Naming Styles
    public Node(int _val, List<Node?> _neighbors)
#pragma warning restore IDE1006 // Naming Styles
    {
        val = _val;
        neighbors = _neighbors;
    }

}
