using Microsoft.AspNetCore.Mvc;
using QuizNova.Data;

namespace QuizNova.Controllers
{
    public class LeaderboardController : Controller
    {
        private readonly AppDbContext _context;

        public LeaderboardController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var results = _context.Results
                .OrderByDescending(x => x.Score)
                .ThenByDescending(x => x.QuizDate)
                .ToList();

            return View(results);
        }
    }
}