using System.ComponentModel.DataAnnotations;

namespace QuizNova.Models
{
    public class Result
    {
        public int Id { get; set; }

        [Required]
        public string UserName { get; set; } = string.Empty;

        public int Score { get; set; }

        public DateTime QuizDate { get; set; } = DateTime.Now;
    }
}