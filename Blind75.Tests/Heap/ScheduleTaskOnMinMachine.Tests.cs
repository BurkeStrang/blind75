namespace Blind75.Tests.Heap;

public class ScheduleTaskOnMinMachineTests
{
    [Fact]
    public void Example1()
    {
        int[][] input = [[1,1],[5,5],[8,8],[4,4],[6,6],[10,10],[7,7]];
        int expected = 1;

        int result = ScheduleTaskOnMinMachine.Tasks(input);

        result.ShouldBe(expected);
    }
}
