namespace Blind75.Tests.General;

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
        if (Environment.NewLine == "\r\n")
        {
            Assert.Equal(
                "1\r\n2\r\nFizz\r\n4\r\nBuzz\r\nFizz\r\n7\r\n8\r\nFizz\r\nBuzz\r\n11\r\nFizz\r\n13\r\n14\r\nFizzBuzz\r\n",
                output
            );
        }
        else
        {
            Assert.Equal(
                "1\n2\nFizz\n4\nBuzz\nFizz\n7\n8\nFizz\nBuzz\n11\nFizz\n13\n14\nFizzBuzz\n",
                output
            );
        }
    }

    [Fact]
    public void FizzBuzzLinqWhenCalledPrintsFizzBuzz()
    {
        // Arrange
        int n = 15;
        // Act
        IEnumerable<string> output = FizzBuzz.FizzBuzzLinq(n);
        // Assert
        Assert.Equal(
            [
                "1",
                "2",
                "Fizz",
                "4",
                "Buzz",
                "Fizz",
                "7",
                "8",
                "Fizz",
                "Buzz",
                "11",
                "Fizz",
                "13",
                "14",
                "FizzBuzz"
            ],
            output
        );
    }
}
