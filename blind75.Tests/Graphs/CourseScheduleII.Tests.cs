namespace Blind75.Graphs;

public class CourseScheduelIITests
{
    [Fact]
    public void Example1()
    {
        // Arrange
        int numCourses = 2;
        int[][] prerequisites =
        [
            [1, 0]
        ];
        int[] expected = [0, 1];
        // Act
        int[] actual = new CourseScheduleII().FindOrder(numCourses, prerequisites);
        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Example2()
    {
        // Arrange
        int numCourses = 4;
        int[][] prerequisites =
        [
            [1, 0],
            [2, 0],
            [3, 1],
            [3, 2]
        ];
        int[] expected = [0, 1, 2, 3];
        // Act
        int[] actual = new CourseScheduleII().FindOrder(numCourses, prerequisites);
        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Example3()
    {
        // Arrange
        int numCourses = 1;
        int[][] prerequisites = [];
        int[] expected = [0];
        // Act
        int[] actual = new CourseScheduleII().FindOrder(numCourses, prerequisites);
        // Assert
        Assert.Equal(expected, actual);
    }
}
