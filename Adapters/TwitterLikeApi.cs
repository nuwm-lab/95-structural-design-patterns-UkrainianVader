using System.Collections.Generic;

namespace LabWork.Adapters
{
    // Імітація іншого (старого) API, яке система могла використовувати раніше
    public class TwitterLikeApi
    {
        public void SendTweet(string text)
        {
            System.Console.WriteLine("[TwitterLike] Tweeted: " + text);
        }

        public IEnumerable<string> GetTimeline(int count)
        {
            var res = new List<string>();
            for (int i = 1; i <= count; i++) res.Add($"Tweet {i} from TwitterLike");
            return res;
        }
    }
}
