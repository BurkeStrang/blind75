namespace Blind75.Tests.Heap;

public class ReorganizeStringTests
{
    [Fact]
    public void Example1()
    {
        //Given
        string s = "programming";

        //When
        string res = ReorganizeString.Reorganize(s);

        //Then
        string expected = "rmgrmgpaion";
        Assert.Equal(expected, res);
    }

}

