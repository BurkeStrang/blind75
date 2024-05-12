namespace Blind75.Tests.Heap
{
    public class DesignTwitterTests
    {
        [Fact]
        public void TestName()
        {
            Twitter twitter = new();
            twitter.PostTweet(1, 5);
            Assert.Equal(new List<int> { 5 }, twitter.GetNewsFeed(1));
            twitter.Follow(1, 2);
            twitter.PostTweet(2, 6);
            Assert.Equal(new List<int> { 6, 5 }, twitter.GetNewsFeed(1));
            twitter.Unfollow(1, 2);
            Assert.Equal(new List<int> { 5 }, twitter.GetNewsFeed(1));
        }
    }
}
