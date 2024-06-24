namespace Blind75.DynamicProgramming;

public class InterleavingStringClass
{
    [Fact]
    public void Example1()
    {
        // Arrange
        string s1 = "aabcc", s2 = "dbbca", s3 = "aadbbcbcac";
        // Act & Assert
        Assert.True(InterleavingString.IsInterleave(s1, s2, s3));
    }
    [Fact]
    public void Example2()
    {
        // Arrange
        string s1 = "aabcc", s2 = "dbbca", s3 = "aadbbbaccc";
        // Act & Assert
        Assert.False(InterleavingString.IsInterleave(s1, s2, s3));
    }
    [Fact]
    public void Example3()
    {
        // Arrange
        string s1 = "", s2 = "", s3 = "";
        // Act & Assert
        Assert.True(InterleavingString.IsInterleave(s1, s2, s3));
    }
}
