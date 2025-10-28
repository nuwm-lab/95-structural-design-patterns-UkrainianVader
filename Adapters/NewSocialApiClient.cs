using System.Collections.Generic;

namespace LabWork.Adapters
{
    // Імітація зовнішньої бібліотеки / нового API соцмережі
    public class NewSocialApiClient
    {
        // Нове API публікує повідомлення через інший метод
        public void PublishPost(string content)
        {
            System.Console.WriteLine("[NewSocialApi] Publishing: " + content);
        }

        // Повертає список постів як List<string>
        public List<string> FetchPosts(int limit)
        {
            var list = new List<string>();
            for (int i = 1; i <= limit; i++) list.Add($"Post {i} from NewSocialApi");
            return list;
        }
    }
}
