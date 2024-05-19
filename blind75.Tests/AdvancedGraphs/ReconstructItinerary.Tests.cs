namespace Blind75.Graphs;

public class ReconstructItineraryTests
{
    [Fact]
    public void Example1()
    {
        // Arrange
        List<IList<string>> input =
        [
            new List<string> { "MUC", "LHR" },
            new List<string> { "JFK", "MUC" },
            new List<string> { "SFO", "SJC" },
            new List<string> { "LHR", "SFO" }
        ];
        // Act
        IList<string> result = ReconstructItinerary.FindItinerary(input);
        // Assert
        Assert.Equal(new List<string> { "JFK", "MUC", "LHR", "SFO", "SJC" }, result);
    }
    [Fact]
    public void Example2()
    {
        // Arrange
        List<IList<string>> input =
        [
            new List<string> { "JFK", "SFO" },
            new List<string> { "JFK", "ATL" },
            new List<string> { "SFO", "ATL" },
            new List<string> { "ATL", "JFK" },
            new List<string> { "ATL", "SFO" }
        ];
        // Act
        IList<string> result = ReconstructItinerary.FindItinerary(input);
        // Assert
        Assert.Equal(new List<string> { "JFK", "ATL", "JFK", "SFO", "ATL", "SFO" }, result);
    }
}
