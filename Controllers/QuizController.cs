using Microsoft.AspNetCore.Mvc;
using QuizNova.Data;
using QuizNova.ViewModels;

namespace QuizNova.Controllers
{
    public class QuizController : Controller
    {
        private readonly AppDbContext _context;

        public QuizController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Start(string userName, int categoryId)
        {
            var vm = new QuizViewModel
            {
                UserName = userName,
                CategoryId = categoryId,
                CurrentQuestion = 0,
                Score = 0,
                Questions = _context.Questions
                    .Where(x => x.CategoryId == categoryId)
                    .ToList(),
                TotalQuestions = _context.Questions.Count(x => x.CategoryId == categoryId),
            };

            return View(vm);
        }

        [HttpPost]
        public IActionResult Next(QuizViewModel vm)
        {
            ModelState.Clear();

            Console.WriteLine($"IsSubmitted = {vm.IsSubmitted}");
            Console.WriteLine($"CurrentQuestion = {vm.CurrentQuestion}");

            vm.Questions = _context.Questions
                .Where(x => x.CategoryId == vm.CategoryId)
                .ToList();

            var current = vm.Questions[vm.CurrentQuestion];

            // First click (Submit Answer)
            if (!vm.IsSubmitted)
            {
                if (vm.SelectedAnswer == current.CorrectAnswer)
                {
                    vm.Score++;
                }

                vm.CorrectAnswer = current.CorrectAnswer;
                vm.Explanation = current.Explanation;
                vm.ShowExplanation = true;
                vm.IsSubmitted = true;

                return View("Start", vm);
            }

            // Second click (Next Question)
            vm.CurrentQuestion++;

            if (vm.CurrentQuestion >= vm.Questions.Count)
            {
                return RedirectToAction(
                    "Index",
                    "Result",
                    new
                    {
                        userName = vm.UserName,
                        score = vm.Score,
                        categoryId = vm.CategoryId
                    });
            }

            vm.SelectedAnswer = null;
            vm.ShowExplanation = false;
            vm.IsSubmitted = false;
            vm.CorrectAnswer = null;
            vm.Explanation = null;

            return View("Start", vm);
        }
    }
}