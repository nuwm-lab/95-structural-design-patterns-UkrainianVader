using System.Collections.Generic;

namespace LabWork.Adapters
{
    public interface ISocialClient
    {
        // Відправити пост/повідомлення
        void Post(string message);

        // Отримати останні пости. Використовуємо IReadOnlyList для гнучкості реалізацій
        IReadOnlyList<string> GetRecentPosts(int count);
    }
}
