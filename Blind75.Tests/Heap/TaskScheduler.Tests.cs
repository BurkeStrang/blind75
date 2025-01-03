namespace Blind75.Tests.Heap;
//ambiguous ref
using TaskScheduler = Blind75.Heap.TaskScheduler;

public class TaskSchedulerTests
{
    [Fact]
    public void Example1()
    {
        // Arrange
        char[] tasks = ['A', 'A', 'A', 'B', 'B', 'B'];
        int n = 2;
        // Act
        int result = TaskScheduler.LeastInterval(tasks, n);
        // Assert
        Assert.Equal(8, result);
    }
    [Fact]
    public void Example2()
    {
        // Arrange
        char[] tasks = ['A', 'C', 'A', 'B', 'D', 'B'];
        int n = 1;
        // Act
        int result = TaskScheduler.LeastInterval(tasks, n);
        // Assert
        Assert.Equal(6, result);
    }
    [Fact]
    public void Example3()
    {
        // Arrange
        char[] tasks = ['A', 'A', 'A', 'B', 'B', 'B'];
        int n = 3;
        // Act
        int result = TaskScheduler.LeastInterval(tasks, n);
        // Assert
        Assert.Equal(10, result);
    }
}
