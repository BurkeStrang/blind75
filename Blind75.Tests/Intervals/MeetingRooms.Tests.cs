namespace Blind75.Tests.Intervals;

public class MeetingRoomsTests
{
    [Fact]
    public void CanAttendMeetingsWhenCalledReturnsFalse()
    {
        // Arrange
        int[][] intervals =
        [
            [0, 30],
            [5, 10],
            [15, 20]
        ];
        // Act
        bool result = MeetingRooms.CanAttendMeetings(intervals);
        // Assert
        Assert.False(result);
    }

    [Fact]
    public void CanAttendMeetingsWhenCalledReturnsTrue()
    {
        // Arrange
        int[][] intervals = [[7, 10], [2, 4]];
        // Act
        bool result = MeetingRooms.CanAttendMeetings(intervals);
        // Assert
        Assert.True(result);
    }

    [Fact]
    public void CanAttendMeetingsWhenCalledReturnsFalse2()
    {
        // Arrange
        int[][] intervals = [[2, 7], [5, 10],];
        // Act
        bool result = MeetingRooms.CanAttendMeetings(intervals);
        // Assert
        Assert.False(result);
    }
}
