namespace Blind75.Tests.Intervals;

public class MeetingRoomsIITests
{
    [Fact]
    public void MinMeetingRoomsWhenCalledReturns2()
    {
        // Arrange
        int[][] intervals =
        [
            [0, 30],
            [5, 10],
            [15, 20]
        ];
        // Act
        int result = MeetingRoomsII.MinMeetingRooms(intervals);
        // Assert
        Assert.Equal(2, result);
    }

    [Fact]
    public void MinMeetingRoomsWhenCalledReturns1()
    {
        // Arrange
        int[][] intervals = [[7, 10], [2, 4]];
        // Act
        int result = MeetingRoomsII.MinMeetingRooms(intervals);
        // Assert
        Assert.Equal(1, result);
    }

    [Fact]
    public void MinMeetingRoomsWhenCalledReturns1_2()
    {
        // Arrange
        int[][] intervals = [[2, 4], [5, 10],];
        // Act
        int result = MeetingRoomsII.MinMeetingRooms(intervals);
        // Assert
        Assert.Equal(1, result);
    }
}
