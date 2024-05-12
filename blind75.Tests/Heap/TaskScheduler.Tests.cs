namespace Blind75.Heap;

public class TaskSchedulerTests
{
    [Fact]
    public void Example1()
    {
        // Arrange
        char[] tasks = ['A', 'A', 'A', 'B', 'B', 'B'];
        int n = 2;
        TaskScheduler ts = new();
        // Act
        int result = ts.LeastInterval(tasks, n);
        // Assert
        Assert.Equal(8, result);
    }
    [Fact]
    public void Example2()
    {
        // Arrange
        char[] tasks = ['A', 'C', 'A', 'B', 'D', 'B'];
        int n = 1;
        TaskScheduler ts = new();
        // Act
        int result = ts.LeastInterval(tasks, n);
        // Assert
        Assert.Equal(6, result);
    }
    [Fact]
    public void Example3()
    {
        // Arrange
        char[] tasks = ['A', 'A', 'A', 'B', 'B', 'B'];
        int n = 3;
        TaskScheduler ts = new();
        // Act
        int result = ts.LeastInterval(tasks, n);
        // Assert
        Assert.Equal(10, result);
    }
}
