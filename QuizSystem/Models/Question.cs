namespace QuizSystem.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Question
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(500, MinimumLength = 5)]
        public string Text { get; set; }

        [Required]
        [StringLength(500, MinimumLength = 3)]
        public string IncorrectAnswers { get; set; }

        [Required]
        [MaxLength(200)]
        public string CorrectAnswer { get; set; }

        [Required]
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        [Required]
        public int DifficultyId { get; set; }

        public virtual Difficulty Difficulty { get; set; }

        [Required]
        public int TypeId { get; set; }

        public virtual Type Type { get; set; }
    }
}
