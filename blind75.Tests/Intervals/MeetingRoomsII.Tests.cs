public class MeetingRoomsIITests
{
    [Fact]
    public void MinMeetingRoomsWhenCalledReturns2()
    {
        // Arrange
        int[][] intervals = new int[][]
        {
            new int[] { 0, 30 },
            new int[] { 5, 10 },
            new int[] { 15, 20 }
        };
        // Act
        var result = MeetingRoomsII.MinMeetingRooms(intervals);
        // Assert
        Assert.Equal(2, result);
    }

    [Fact]
    public void MinMeetingRoomsWhenCalledReturns1()
    {
        // Arrange
        int[][] intervals = new int[][] { new int[] { 7, 10 }, new int[] { 2, 4 } };
        // Act
        var result = MeetingRoomsII.MinMeetingRooms(intervals);
        // Assert
        Assert.Equal(1, result);
    }

    [Fact]
    public void MinMeetingRoomsWhenCalledReturns1_2()
    {
        // Arrange
        int[][] intervals = new int[][] { new int[] { 2, 4 }, new int[] { 5, 10 }, };
        // Act
        var result = MeetingRoomsII.MinMeetingRooms(intervals);
        // Assert
        Assert.Equal(1, result);
    }
}
