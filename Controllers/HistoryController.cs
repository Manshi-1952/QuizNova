using Microsoft.AspNetCore.Mvc;
using QuizNova.Data;

namespace QuizNova.Controllers
{
    public class HistoryController : Controller
    {
        private readonly AppDbContext _context;

        public HistoryController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var history = _context.Results
                .OrderByDescending(x => x.QuizDate)
                .ToList();

            return View(history);
        }
    }
}