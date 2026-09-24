using Microsoft.AspNetCore.Mvc;

namespace QuizNova.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}