namespace Blind75.Tests.Backtracking;

public class LetterCasePermutationsTests
{
    [Fact]
    public void Example1()
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

    [Fact]
    public void Example2()
    {
        // Arrange
        string input = "3z4";
        List<string> expected = ["3z4", "3Z4"];

        // Act
        IList<string> result = LetterCasePermutations.LetterCasePermutation(input);

        // Assert
        Assert.Equal(expected.Count, result.Count);
        foreach (string permutation in expected)
        {
            Assert.Contains(permutation, result);
        }
    }
    [Fact]
    public void Example3()
    {
        // Arrange
        string input = "12345";
        List<string> expected = ["12345"];

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
