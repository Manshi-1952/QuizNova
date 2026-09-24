using QuizNova.Models;

namespace QuizNova.ViewModels
{
    public class QuizViewModel
    {
        public string UserName { get; set; } = "";

        public int CategoryId { get; set; }

        public int CurrentQuestion { get; set; }

        public int Score { get; set; }

        public List<Question> Questions { get; set; } = new();

        public string? SelectedAnswer { get; set; }

        public bool LifelineUsed { get; set; }

        public string? CorrectAnswer { get; set; }

        public string? Explanation { get; set; }

        public bool ShowExplanation { get; set; }

        public int TotalQuestions { get; set; }

        public bool IsSubmitted { get; set; }
    }
}