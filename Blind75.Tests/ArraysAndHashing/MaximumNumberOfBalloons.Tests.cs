namespace Blind75.Tests.ArraysAndHashing;

public class MaximumNumberOfBalloonsTests
{
    [Fact]
    public void Example1()
    {
        string text = "nlaebolko";
        int expected = 1;
        Assert.Equal(expected, MaximumNumberOfBalloons.MaxNumberOfBalloons(text));
    }

    [Fact]
    public void Example2()
    {
        string text = "loonbalxballpoon";
        int expected = 2;
        Assert.Equal(expected, MaximumNumberOfBalloons.MaxNumberOfBalloons(text));
    }
    [Fact]
    public void Example3()
    {
        string text = "leetcode";
        int expected = 0;
        Assert.Equal(expected, MaximumNumberOfBalloons.MaxNumberOfBalloons(text));
    }
}
