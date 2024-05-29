namespace Blind75.MathAndGeo;

public class DetectSquaresTests
{
    [Fact]
    public void Example1()
    {
        DetectSquares detectSquares = new();

        detectSquares.Add([3, 10]);
        detectSquares.Add([11, 2]);
        detectSquares.Add([3, 2]);
        Assert.Equal(1, detectSquares.Count([11, 10])); // returns 1

        Assert.Equal(0, detectSquares.Count([14, 8])); // returns 0

        detectSquares.Add([11, 2]);
        Assert.Equal(2, detectSquares.Count([11, 10])); // returns 2
    }
}
