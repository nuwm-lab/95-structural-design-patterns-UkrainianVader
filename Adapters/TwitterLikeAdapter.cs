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

        public System.Collections.Generic.IReadOnlyList<string> GetRecentPosts(int count)
        {
            return _api.GetTimeline(count).ToList();
        }
    }
}
