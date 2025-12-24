
namespace Blind75.Tests.ArraysAndHashing;

public class CalMinDistTests
{
    [Fact]
    public void CalculateMinDistances_ReturnsCorrectResults()
    {
        // Arrange
        string[] words = ["apple", "banana", "apple", "orange", "banana", "apple"];
        Dictionary<string, int> expected = new()
        {
                { "apple", 2 },   // min distances: 2 (0->2), 3 (2->5) => min is 2
                { "banana", 3 }   // min distance: 3 (1->4)
            };

        // Act
        Dictionary<string, int> actual = Solution.CalculateMinDistances(words);

        // Assert
        Assert.Equal(expected.Count, actual.Count);
        foreach (KeyValuePair<string, int> kv in expected)
        {
            Assert.True(actual.ContainsKey(kv.Key));
            Assert.Equal(kv.Value, actual[kv.Key]);
        }
    }
}
