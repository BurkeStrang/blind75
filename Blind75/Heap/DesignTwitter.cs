namespace Blind75.Heap;

/*

Design a simplified version of Twitter where users can post tweets,
follow/unfollow another user, and is able to see the 10 most recent tweets in the user's news feed.

Implement the Twitter class:

Twitter() Initializes your twitter object.
void postTweet(int userId, int tweetId) Composes a new tweet with ID tweetId by the user userId.
Each call to this function will be made with a unique tweetId.
List<Integer> getNewsFeed(int userId) Retrieves the 10 most recent tweet IDs in the user's news feed.
Each item in the news feed must be posted by users who the user followed or by the user themself.
Tweets must be ordered from most recent to least recent.
void follow(int followerId, int followeeId) The user with ID followerId started following the user with ID followeeId.
void unfollow(int followerId, int followeeId) The user with ID followerId started unfollowing the user with ID followeeId.

Example 1:
Input
["Twitter", "postTweet", "getNewsFeed", "follow", "postTweet", "getNewsFeed", "unfollow", "getNewsFeed"]
[[], [1, 5], [1], [1, 2], [2, 6], [1], [1, 2], [1]]
Output
[null, null, [5], null, null, [6, 5], null, [5]]

Explanation
Twitter twitter = new Twitter();
twitter.postTweet(1, 5); // User 1 posts a new tweet (id = 5).
twitter.getNewsFeed(1);  // User 1's news feed should return a list with 1 tweet id -> [5]. return [5]
twitter.follow(1, 2);    // User 1 follows user 2.
twitter.postTweet(2, 6); // User 2 posts a new tweet (id = 6).
twitter.getNewsFeed(1);  // User 1's news feed should return a list with 2 tweet ids -> [6, 5]. Tweet id 6 should precede tweet id 5 because it is posted after tweet id 5.
twitter.unfollow(1, 2);  // User 1 unfollows user 2.
twitter.getNewsFeed(1);  // User 1's news feed should return a list with 1 tweet id -> [5], since user 1 is no longer following user 2.

Constraints:
1 <= userId, followerId, followeeId <= 500
0 <= tweetId <= 104
All the tweets have unique IDs.
At most 3 * 104 calls will be made to postTweet, getNewsFeed, follow, and unfollow.

*/

public class Twitter
{
    private readonly PriorityQueue<TweetInfo, int> _pq;
    private int _time;
    private readonly Dictionary<int, HashSet<int>> _followers;
    private readonly Dictionary<int, List<Tweet>> _tweets;

    public Twitter()
    {
        _time = 0;
        _pq = new PriorityQueue<TweetInfo, int>(new MaxHeap());
        _followers = [];
        _tweets = [];
    }

    //T: O(1)
    public void PostTweet(int userId, int tweetId)
    {
        _time++;
        if (!_tweets.ContainsKey(userId))
            _tweets.Add(userId, []);
        _tweets[userId].Add(new Tweet(_time, tweetId));
    }

    public IList<int> GetNewsFeed(int userId)
    {
        List<int> result = [];
        HashSet<int> followersOfUserId = [];
        if (_followers.TryGetValue(userId, out HashSet<int>? users))
            followersOfUserId = users;
        followersOfUserId.Add(userId);

        //We are just adding the last indexed tweet of the all the followers tweet
        foreach (int followeeId in followersOfUserId)
        {
            if (_tweets.TryGetValue(followeeId, out List<Tweet>? tweets))
            {
                int lastTweetIndex = tweets.Count - 1;
                Tweet tweet = tweets[lastTweetIndex];
                TweetInfo tweetInfo = new(
                    tweet.Time,
                    tweet.TweetId,
                    followeeId,
                    lastTweetIndex - 1
                );
                _pq.Enqueue(tweetInfo, tweet.Time);
            }
        }

        while (_pq.Count > 0 && result.Count < 10)
        {
            TweetInfo tweetInfo = _pq.Dequeue();
            result.Add(tweetInfo.TweetId);

            if (tweetInfo.Index >= 0)
            {
                Tweet tweet = _tweets[tweetInfo.FolloweeId][tweetInfo.Index];
                TweetInfo tweetInfo2 = new(
                    tweet.Time,
                    tweet.TweetId,
                    tweetInfo.FolloweeId,
                    tweetInfo.Index - 1
                );
                _pq.Enqueue(tweetInfo2, tweet.Time);
            }
        }

        return result;
    }

    //T: O(1)
    public void Follow(int followerId, int followeeId)
    {
        if (!_followers.ContainsKey(followerId))
            _followers.Add(followerId, []);
        _followers[followerId].Add(followeeId);
    }

    // T: O(1) using HashSet for O(1) deletions
    public void Unfollow(int followerId, int followeeId)
    {
        if (!_followers.TryGetValue(followerId, out HashSet<int>? value))
            return;
        HashSet<int> followersList = value;
        if (followersList.Contains(followeeId))
            value.Remove(followeeId);
    }

    public class Tweet(int time, int tweetId)
    {
        public int Time = time;
        public int TweetId = tweetId;
    }

    public class TweetInfo : Tweet
    {
        public int Index;
        public int FolloweeId;

        public TweetInfo(int time, int tweetId, int followeeId, int index)
            : base(time, tweetId)
        {
            Index = index;
            FolloweeId = followeeId;
            Time = time;
            TweetId = tweetId;
        }
    }

    public class MaxHeap : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            return x < y
                ? 1
                : x > y
                    ? -1
                    : 0;
        }
    }
}
