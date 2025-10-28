using System;
using LabWork.Adapters;

namespace LabWork
{
    class Program
    {
        static void Main(string[] args)
        {
            // Демонстрація патерну Adapter: підключення різних API соцмереж
            Console.WriteLine("Adapter pattern demo\n");

            // Створюємо адаптери над різними API і використовуємо один інтерфейс
            var twitterAdapter = new TwitterLikeAdapter(new TwitterLikeApi());
            var newSocialAdapter = new NewSocialApiAdapter(new NewSocialApiClient());

            ISocialClient[] clients = { twitterAdapter, newSocialAdapter };

            foreach (var client in clients)
            {
                client.Post("Привіт від Adapter demo!");
                var posts = client.GetRecentPosts(3);
                Console.WriteLine("Recent posts:");
                foreach (var p in posts) Console.WriteLine($" - {p}");
                Console.WriteLine();
            }
        }
    }
}
