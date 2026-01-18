namespace Blind75.Tests.Heap;


public class ProcessQueriesTests
{
    [Fact]
    public void TestExampleQueries()
    {
        List<int[]> queries =
            [
                [0, 10],
                [2, 10],
                [0, 20],
                [1, 10],
                [2, 10],
                [3, 15],
                [3, 21]
            ];

        List<int> expected = [1, 10, 2, 1, -1, 20, -1];
        List<int> result = QueryProcessor.ProcessQueries(queries);

        Assert.Equal(expected, result);
    }
}
