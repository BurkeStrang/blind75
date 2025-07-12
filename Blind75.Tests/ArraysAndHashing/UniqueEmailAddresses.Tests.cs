namespace Blind75.Tests.ArraysAndHashing;

public class UniqueEmailAddressesTests
{
    [Fact]
    public void Example1()
    {
        // Arrange
        string[] emails =
        [
            "test.email+alex@leetcode.com",
            "test.e.mail+bob.cathy@leetcode.com",
            "testemail+david@lee.tcode.com"
        ];
        int expected = 2;

        // Act
        int actual = UniqueEmailAddresses.NumUniqueEmails(emails);
        actual.ShouldBe(expected);
    }

    [Fact]
    public void Example2()
    {
        // Arrange
        string[] emails = ["a@leetcode.com", "b@leetcode.com", "c@leetcode.com"];
        int expected = 3;

        // Act
        int actual = UniqueEmailAddresses.NumUniqueEmails(emails);
        actual.ShouldBe(expected);
    }
}
