namespace QuizSystem.Data.Seeding.DTOs
{
    using Newtonsoft.Json;

    public class CategoriesDto
    {
        [JsonProperty("trivia_categories")]
        public CategoryDto[] Categories { get; set; }
    }
}
