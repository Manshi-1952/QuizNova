using System.ComponentModel.DataAnnotations;

namespace QuizNova.Models
{
    public class Question
    {
        public int Id { get; set; }

        [Required]
        public string QuestionText { get; set; } = string.Empty;

        [Required]
        public string OptionA { get; set; } = string.Empty;

        [Required]
        public string OptionB { get; set; } = string.Empty;

        [Required]
        public string OptionC { get; set; } = string.Empty;

        [Required]
        public string OptionD { get; set; } = string.Empty;

        [Required]
        public string CorrectAnswer { get; set; } = string.Empty;

        public string Explanation { get; set; } = string.Empty;

        public int CategoryId { get; set; }

        public Category? Category { get; set; }
    }
}