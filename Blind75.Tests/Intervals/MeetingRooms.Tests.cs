public class MeetingRoomsTests
{
    [Fact]
    public void CanAttendMeetingsWhenCalledReturnsFalse()
    {
        // Arrange
        int[][] intervals = new int[][]
        {
            new int[] { 0, 30 },
            new int[] { 5, 10 },
            new int[] { 15, 20 }
        };
        // Act
        var result = MeetingRooms.CanAttendMeetings(intervals);
        // Assert
        Assert.False(result);
    }

    [Fact]
    public void CanAttendMeetingsWhenCalledReturnsTrue()
    {
        // Arrange
        int[][] intervals = new int[][] { new int[] { 7, 10 }, new int[] { 2, 4 } };
        // Act
        var result = MeetingRooms.CanAttendMeetings(intervals);
        // Assert
        Assert.True(result);
    }

    [Fact]
    public void CanAttendMeetingsWhenCalledReturnsFalse2()
    {
        // Arrange
        int[][] intervals = new int[][] { new int[] { 2, 7 }, new int[] { 5, 10 }, };
        // Act
        var result = MeetingRooms.CanAttendMeetings(intervals);
        // Assert
        Assert.False(result);
    }
}
