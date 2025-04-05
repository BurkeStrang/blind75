namespace Blind75.Tests.Backtracking;

public class LetterCasePermutationsTests
{
    [Fact]
    public void TestLetterCasePermutation()
    {
        // Arrange
        string input = "a1b2";
        List<string> expected = ["a1b2", "A1b2", "a1B2", "A1B2"];

        // Act
        IList<string> result = LetterCasePermutations.LetterCasePermutation(input);

        // Assert
        Assert.Equal(expected.Count, result.Count);
        foreach (string permutation in expected)
        {
            Assert.Contains(permutation, result);
        }
    }
}
