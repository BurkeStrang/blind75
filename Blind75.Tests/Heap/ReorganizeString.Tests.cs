namespace Blind75.Tests.Heap;

public class ReorganizeStringTests
{

    [Fact]
    public void Example1()
    {
        string s = "aaabbc";

        string res = ReorganizeString.Reorganize(s);

        if (res.Length != s.Length)
        {
            Assert.Fail(
                $"'{res}' is not the same length as '{s}'. Expected length: {s.Length}.");
        }


        for (int i = 1; i < res.Length; i++)
        {
            if (res[i] == res[i - 1])
            {
                Assert.Fail(
                $"'{res}' has adjacent duplicates: '{res[i - 1]}' at index {i - 1} and '{res[i]}' at index {i}.");
            }
        }

    }

    [Fact]
    public void Example2()
    {
        string s = "programming";

        string res = ReorganizeString.Reorganize(s);


        if (res.Length != s.Length)
        {
            Assert.Fail(
                $"'{res}' is not the same length as '{s}'. Expected length: {s.Length}.");
        }

        for (int i = 1; i < res.Length; i++)
        {
            if (res[i] == res[i - 1])
            {
                Assert.Fail(
                $"'{res}' has adjacent duplicates: '{res[i - 1]}' at index {i - 1} and '{res[i]}' at index {i}.");
            }
        }
    }

    [Fact]
    public void Example3()
    {
        string s = "aa";

        string res = ReorganizeString.Reorganize(s);

        string expected = "";
        Assert.Equal(expected, res);
    }

    [Fact]
    public void Example4()
    {
        string s = "bbbaac";

        string res = ReorganizeString.Reorganize(s);


        if (res.Length != s.Length)
        {
            Assert.Fail(
                $"'{res}' is not the same length as '{s}'. Expected length: {s.Length}.");
        }

        for (int i = 1; i < res.Length; i++)
        {
            if (res[i] == res[i - 1])
            {
                Assert.Fail(
                $"'{res}' has adjacent duplicates: '{res[i - 1]}' at index {i - 1} and '{res[i]}' at index {i}.");
            }
        }
    }

    [Fact]
    public void Example6()
    {
        string s = "aab";

        string res = ReorganizeString.Reorganize(s);


        if (res.Length != s.Length)
        {
            Assert.Fail(
                $"'{res}' is not the same length as '{s}'. Expected length: {s.Length}.");
        }

        for (int i = 1; i < res.Length; i++)
        {
            if (res[i] == res[i - 1])
            {
                Assert.Fail(
                $"'{res}' has adjacent duplicates: '{res[i - 1]}' at index {i - 1} and '{res[i]}' at index {i}.");
            }
        }
    }

    [Fact]
    public void Example7()
    {
        string s = "aaab";

        string res = ReorganizeString.Reorganize(s);

        string expected = "";
        Assert.Equal(expected, res);
    }

}

