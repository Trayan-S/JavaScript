namespace QuizSystem.Models
{
    using System.Collections.Generic;

    public class Question
    {
        public int Id { get; set; }

        public string Text { get; set; }

        public string IncorrectAnswers { get; set; }

        public string CorrectAnswer { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public int DifficultyId { get; set; }

        public virtual Difficulty Difficulty { get; set; }
    }
}
