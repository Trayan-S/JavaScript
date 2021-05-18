namespace QuizSystem.Data.Seeding
{
    using System.Threading.Tasks;

    public interface IRequester<T>
    {
        Task<T> RequestDataAsync(string path);
    }
}
