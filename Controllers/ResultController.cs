using Microsoft.AspNetCore.Mvc;
using QuizNova.Data;
using QuizNova.Models;

namespace QuizNova.Controllers
{
    public class ResultController : Controller
    {
        private readonly AppDbContext _context;

        public ResultController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(string userName, int score, int categoryId)
        {
            var result = new Result
            {
                UserName = userName,
                Score = score,
                QuizDate = DateTime.Now
            };

            _context.Results.Add(result);
            _context.SaveChanges();

            ViewBag.TotalQuestions = _context.Questions
                .Count(q => q.CategoryId == categoryId);

            ViewBag.Category = _context.Categories
    .FirstOrDefault(c => c.Id == categoryId)?.Name;


            ViewBag.Accuracy = ViewBag.TotalQuestions > 0
                ? (double)score / ViewBag.TotalQuestions * 100
                : 0;


            return View("Result", result);
        }
    }
}