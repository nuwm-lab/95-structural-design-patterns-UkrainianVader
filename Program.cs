using System;

namespace LabWork
{
    // Даний проект є шаблоном для виконання лабораторних робіт
    // з курсу "Об'єктно-орієнтоване програмування та патерни проектування"
    // Необхідно змінювати і дописувати код лише в цьому проекті
    // Відео-інструкції щодо роботи з github можна переглянути 
    // за посиланням https://www.youtube.com/@ViktorZhukovskyy/videos 
    class Program
    {
        static void Main(string[] args)
        {
            // Демонстрація патерну Adapter: підключення різних API соцмереж
            Console.WriteLine("Adapter pattern demo\n");

            // Створюємо адаптери над різними API і використовуємо один інтерфейс
            var twitterAdapter = new Adapters.TwitterLikeAdapter(new Adapters.TwitterLikeApi());
            var newSocialAdapter = new Adapters.NewSocialApiAdapter(new Adapters.NewSocialApiClient());

            Adapters.ISocialClient[] clients = { twitterAdapter, newSocialAdapter };

            foreach (var client in clients)
            {
                client.Post("Привіт від Adapter demo!");
                var posts = client.GetRecentPosts(3);
                Console.WriteLine("Recent posts:");
                foreach (var p in posts) Console.WriteLine(" - " + p);
                Console.WriteLine();
            }
        }
    }
}
