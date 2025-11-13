namespace Blind75.Tests.ArraysAndHashing;

public class LargestSame3DigitNumberTests
{
    [Fact]
    public void Example1()
    {
        // Arrange
        string num = "6777133339";
        string expected = "777";

        // Act
        string result = LargestSame3DigitNumber.LargestGoodInteger(num);
        // Assert
        result.ShouldBe(expected);
    }

    [Fact]
    public void Example2()
    {
        // Arrange
        string num = "2300019";
        string expected = "000";
        // Act
        string result = LargestSame3DigitNumber.LargestGoodInteger(num);
        // Assert
        result.ShouldBe(expected);
    }

    [Fact]
    public void Example3()
    {
        // Arrange
        string num = "42352338";
        string expected = "";
        // Act
        string result = LargestSame3DigitNumber.LargestGoodInteger(num);
        // Assert
        result.ShouldBe(expected);
    }

    [Fact]
    public void Example4()
    {
        // Arrange
        string num = "42222333";
        string expected = "333";
        // Act
        string result = LargestSame3DigitNumber.LargestGoodInteger(num);
        // Assert
        result.ShouldBe(expected);
    }
}
