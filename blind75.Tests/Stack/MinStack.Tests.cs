namespace Blind75.Stack;

public class MinStackTests
{
    [Fact]
    public void ExampleTest1()
    {
        MinStack minStack = new MinStack();
        minStack.Push(-2);
        minStack.Push(0);
        minStack.Push(-3);
        Assert.Equal(-3, minStack.GetMin());
        minStack.Pop();
        Assert.Equal(0, minStack.Top());
        Assert.Equal(-2, minStack.GetMin());
    }
}
