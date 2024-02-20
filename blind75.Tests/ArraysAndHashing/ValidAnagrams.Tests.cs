public class ValidAnagramsTests
{
    [Fact]
    public void ReturnsTrueIfAnagrams()
    {
        // Arrange
        string s = "anagram";
        string t = "nagaram";
        Assert.True(ValidAnagramClass.IsAnagram(s, t));
    }

    [Fact]
    public void ReturnsFalseIfNotAnagrams()
    {
        // Arrange
        string s = "rat";
        string t = "car";
        Assert.False(ValidAnagramClass.IsAnagram(s, t));
    }
}