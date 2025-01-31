namespace Blind75.Tests.Heap;

public class ReorganizeStringTests
{

    [Fact]
    public void Example1()
    {
        //Given
        string s = "aaabbc";

        //When
        string res = ReorganizeString.Reorganize(s);

        //Then
        string expected = "ababac";
        Assert.Equal(expected, res);
    }

    [Fact]
    public void Example2()
    {
        //Given
        string s = "programming";

        //When
        string res = ReorganizeString.Reorganize(s);

        //Then
        string expected = "rmgmgiparon";
        Assert.Equal(expected, res);
    }

    [Fact]
    public void Example3()
    {
        //Given
        string s = "aa";

        //When
        string res = ReorganizeString.Reorganize(s);

        //Then
        string expected = "";
        Assert.Equal(expected, res);
    }

    [Fact]
    public void Example4()
    {
        //Given
        string s = "bbbaac";

        //When
        string res = ReorganizeString.Reorganize(s);

        //Then
        string expected = "bababc";
        Assert.Equal(expected, res);
    }

    [Fact]
    public void Example6()
    {
        //Given
        string s = "aab";

        //When
        string res = ReorganizeString.Reorganize(s);

        //Then
        string expected = "aba";
        Assert.Equal(expected, res);
    }

    [Fact]
    public void Example7()
    {
        //Given
        string s = "aaab";

        //When
        string res = ReorganizeString.Reorganize(s);

        //Then
        string expected = "";
        Assert.Equal(expected, res);
    }

}

