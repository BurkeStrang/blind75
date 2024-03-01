public class FindMedian
{
    [Fact]
    public void FindMedianCorrect()
    {
        MedianFinder medianFinder = new MedianFinder();
        medianFinder.AddNum(1);    // arr = [1]
        medianFinder.AddNum(2);    // arr = [1, 2]
        double res = medianFinder.FindMedian(); // return 1.5 (i.e., (1 + 2) / 2)
        double exp = 1.5;
        Assert.Equal(exp, res);
        medianFinder.AddNum(3);    // arr[1, 2, 3]
        res = medianFinder.FindMedian(); // return 2.0
        exp = 2.0;
        Assert.Equal(exp, res);
    }
}
