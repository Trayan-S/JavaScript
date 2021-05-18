namespace QuizSystem.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using QuizSystem.Data.Seeding.DTOs;
    using QuizSystem.Models;

    public class CategoriesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Categories.Any())
            {
                return;
            }

            var requester = new Requester<CategoriesDto>();
            var result = await requester.RequestDataAsync("api_category.php");

            foreach (var category in result.Categories)
            {
                await dbContext.Categories.AddAsync(
                    new Category
                    {
                        Name = category.Name,
                    });
            }
        }
    }
}
