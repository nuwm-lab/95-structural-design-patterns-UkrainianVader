namespace LabWork.Adapters
{
    public interface ISocialClient
    {
        // Відправити пост/повідомлення
        void Post(string message);

        // Отримати останні пости (масив рядків для простоти)
        string[] GetRecentPosts(int count);
    }
}
