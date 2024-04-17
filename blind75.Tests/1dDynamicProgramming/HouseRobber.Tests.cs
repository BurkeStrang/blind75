public class HouseRobberTests
{
  [Fact]
  public void Test1()
  {
    int[] nums = [1, 2, 3, 1];
    int expected = 4;
    Assert.Equal(expected, HouseRobber.Rob(nums));
  }
  [Fact]
  public void Test2()
  {
    int[] nums = { 2, 7, 9, 3, 1 };
    int expected = 12;
    Assert.Equal(expected, HouseRobber.Rob(nums));
  }
  [Fact]
  public void Test3()
  {
    int[] nums = { 2, 1, 1, 2 };
    int expected = 4;
    Assert.Equal(expected, HouseRobber.Rob(nums));
  }
}
