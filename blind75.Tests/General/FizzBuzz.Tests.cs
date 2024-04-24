namespace blind75.General;

public class FizzBuzzTests
{
    [Fact]
    public void PrintFizzBuzzWhenCalledPrintsFizzBuzz()
    {
        // Arrange
        int n = 15;
        // Act
        string output = FizzBuzz.PrintFizzBuzz(n);
        // Assert
        Assert.Equal("1\n2\nFizz\n4\nBuzz\nFizz\n7\n8\nFizz\nBuzz\n11\nFizz\n13\n14\nFizzBuzz\n", output.ToString());
    }
}
