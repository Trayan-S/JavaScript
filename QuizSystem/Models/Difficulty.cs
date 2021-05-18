namespace QuizSystem.Models
{
    using System.Collections.Generic;
    using System.IO;

    public class Difficulty
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Question> Questions { get; set; }
    }
}
