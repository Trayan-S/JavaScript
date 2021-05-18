namespace QuizSystem.Data.Seeding
{
    using System;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Threading.Tasks;

    public class Requester<T> : IRequester<T>
    {
        public async Task<T> RequestDataAsync(string path)
        {
            using var client = new HttpClient
            {
                BaseAddress = new Uri("https://opentdb.com/"),
            };
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var response = await client.GetAsync(path);
            var rootObject = await response.Content.ReadAsAsync<T>();

            return rootObject;
        }
    }
}
