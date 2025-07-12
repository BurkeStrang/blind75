namespace Blind75.Tests.ArraysAndHashing;

public class LargestSame3DigitNumberTests
{
    [Theory]
    [InlineData("6777133339", "777")]
    [InlineData("2300019", "000")]
    [InlineData("42352338", "")]
    public void LargestGoodInteger_ShouldReturnLargestGoodInteger(string num, string expected)
    {
        // Arrange
        // Act
        string result = LargestSame3DigitNumber.LargestGoodInteger(num);
        // Assert
        result.ShouldBe(expected);
    }
}
