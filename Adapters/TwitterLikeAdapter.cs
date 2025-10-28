using System.Linq;

namespace LabWork.Adapters
{
    // Адаптер для TwitterLikeApi
    public class TwitterLikeAdapter : ISocialClient
    {
        private readonly TwitterLikeApi _api;

        public TwitterLikeAdapter(TwitterLikeApi api)
        {
            _api = api;
        }

        public void Post(string message)
        {
            _api.SendTweet(message);
        }

        public string[] GetRecentPosts(int count)
        {
            return _api.GetTimeline(count).ToArray();
        }
    }
}
