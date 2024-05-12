

namespace Blind75.Backtracking;

public class PermutationsTests
{
    [Fact]
    public void Example1()
    {
        // Arrange
        int[] nums = [1, 2, 3];
        ListComparer listComparer = new();
        // Act
        IList<IList<int>> result = Permutations.Permute(nums);
        // Assert
        Assert.True(result.Contains([1, 2, 3], listComparer));
        Assert.True(result.Contains([1, 3, 2], listComparer));
        Assert.True(result.Contains([2, 1, 3], listComparer));
        Assert.True(result.Contains([2, 3, 1], listComparer));
        Assert.True(result.Contains([3, 1, 2], listComparer));
        Assert.True(result.Contains([3, 2, 1], listComparer));
    }
    [Fact]
    public void Example2()
    {
        // Arrange
        int[] nums = [0, 1];
        ListComparer listComparer = new();
        // Act
        IList<IList<int>> result = Permutations.Permute(nums);
        // Assert
        Assert.True(result.Contains([0, 1], listComparer));
        Assert.True(result.Contains([1, 0], listComparer));
    }
    [Fact]
    public void Example3()
    {
        // Arrange
        int[] nums = [1];
        ListComparer listComparer = new();
        // Act
        IList<IList<int>> result = Permutations.Permute(nums);
        // Assert
        Assert.True(result.Contains([1], listComparer));
    }
    public class PermutationsBenchmarks
    {

        readonly int[] _nums = [1, 2, 3, 4, 5, 6];
        [Benchmark]
        public IList<IList<int>> Permute() => Permutations.Permute(_nums);
    }

    /*  [Fact(Skip = "Benchmark")]
     public void Benchmarks()
     {
         BenchmarkRunner.Run<PermutationsBenchmarks>();
     }
     */
}

