namespace Blind75.Tests.Graphs;

public class CourseSchedule
{
    [Fact]
    public void CourseScheduleFalse()
    {
        // Input: numCourses = 2, prerequisites = [[1,0],[0,1]]
        // Output: false
        // Explanation: There are a total of 2 courses to take.
        // To take course 1 you should have finished course 0,
        // and to take course 0 you should also have finished course 1. So it is impossible.
        int numCourses = 2;
        int[][] prerequisites = [[1, 0], [0, 1]];
        Assert.False(CourseScheduleClass.CanFinish(numCourses, prerequisites));
    }

    [Fact]
    public void CourseScheduleTrue()
    {
        int numCourses = 2;
        int[][] prerequisites = [[0, 1]];
        Assert.True(CourseScheduleClass.CanFinish(numCourses, prerequisites));
    }
}
