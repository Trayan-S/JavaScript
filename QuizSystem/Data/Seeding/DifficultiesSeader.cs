namespace QuizSystem.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using QuizSystem.Models;

    public class DifficultiesSeader : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Difficulties.Any())
            {
                return;
            }

            var difficulties = new string[]
            {
                "Easy",
                "Medium",
                "Hard",
            };

            foreach (var difficulty in difficulties)
            {
                await dbContext.Difficulties.AddAsync(new Difficulty
                {
                    Name = difficulty,
                });
            }
        }
    }
}
