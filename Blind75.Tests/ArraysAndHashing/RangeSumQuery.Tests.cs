namespace Blind75.Tests.ArraysAndHashing;

public class RangeSumQueryTests
{
    [Fact]
    public void Example1()
    {
        NumArray numArray = new([-2, 0, 3, -5, 2, -1]);
        numArray.SumRange(0, 2).ShouldBe(1);
        numArray.SumRange(2, 5).ShouldBe(-1);
        numArray.SumRange(0, 5).ShouldBe(-3);
        numArray.SumRange(0, 0).ShouldBe(-2);
    }

    [Fact]
    public void Example2()
    {
        NumArray numArray = new([1, 2, 3, 4, 5, 6]);
        numArray.SumRange(0, 2).ShouldBe(6);
        numArray.SumRange(2, 5).ShouldBe(18);
        numArray.SumRange(0, 5).ShouldBe(21);
        numArray.SumRange(0, 0).ShouldBe(1);
    }
}
