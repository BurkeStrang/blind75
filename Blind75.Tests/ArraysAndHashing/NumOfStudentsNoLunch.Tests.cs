namespace Blind75.Tests.ArraysAndHashing;

public class NumOfStudentsNoLunchTests
{
    [Fact]
    public void Example1()
    {
        // Arrange
        int[] students = [1, 1, 0, 0];
        int[] sandwiches = [0, 1, 0, 1];
        int expected = 0;
        // Act
        int actual = NumOfStudentsNoLunch.CountStudents(students, sandwiches);
        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Example2()
    {
        // Arrange
        int[] students = [1, 1, 1, 0, 0, 1];
        int[] sandwiches = [1, 0, 0, 0, 1, 1];
        int expected = 3;
        // Act
        int actual = NumOfStudentsNoLunch.CountStudents(students, sandwiches);
        // Assert
        Assert.Equal(expected, actual);
    }
}
