using System.Linq;

namespace LabWork.Adapters
{
    // Адаптер, який підлаштовує NewSocialApiClient під ISocialClient
    public class NewSocialApiAdapter : ISocialClient
    {
        private readonly NewSocialApiClient _client;

        public NewSocialApiAdapter(NewSocialApiClient client)
        {
            _client = client;
        }

        public void Post(string message)
        {
            // Перекладаємо виклик на метод нового API
            _client.PublishPost(message);
        }

        public string[] GetRecentPosts(int count)
        {
            var posts = _client.FetchPosts(count);
            return posts.ToArray();
        }
    }
}
