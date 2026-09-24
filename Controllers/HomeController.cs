using Microsoft.AspNetCore.Mvc;
using QuizNova.Data;
using QuizNova.Models;

namespace QuizNova.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            SeedData();

            ViewBag.Categories = _context.Categories.ToList();
            ViewBag.QuestionCounts = _context.Questions
    .GroupBy(q => q.CategoryId)
    .ToDictionary(g => g.Key, g => g.Count());

            ViewBag.TotalCategories = _context.Categories.Count();

            ViewBag.TotalQuestions = _context.Questions.Count();

            ViewBag.TotalAttempts = _context.Results.Count();

            return View();
        }

        private void SeedData()
        {
            if (!_context.Categories.Any())
            {
                _context.Categories.AddRange(
                    new Category { Name = "Programming" },
                    new Category { Name = "General Knowledge" },
                    new Category { Name = "Sports" }
                );

                _context.SaveChanges();
            }

            if (!_context.Questions.Any())
            {
                _context.Questions.AddRange(

                    new Question
                    {
                        QuestionText = "What does HTML stand for?",
                        OptionA = "Hyper Text Markup Language",
                        OptionB = "High Text Machine Language",
                        OptionC = "Hyper Tool Multi Language",
                        OptionD = "Home Text Markup Language",
                        CorrectAnswer = "A",
                        Explanation = "HTML stands for Hyper Text Markup Language.",
                        CategoryId = 1
                    },

                    new Question
                    {
                        QuestionText = "Which language is used in ASP.NET Core?",
                        OptionA = "Java",
                        OptionB = "Python",
                        OptionC = "C#",
                        OptionD = "PHP",
                        CorrectAnswer = "C",
                        Explanation = "ASP.NET Core applications are mainly written in C#.",
                        CategoryId = 1
                    },

                    new Question
                    {
                        QuestionText = "Capital of India?",
                        OptionA = "Mumbai",
                        OptionB = "New Delhi",
                        OptionC = "Ahmedabad",
                        OptionD = "Surat",
                        CorrectAnswer = "B",
                        Explanation = "New Delhi is the capital of India.",
                        CategoryId = 2
                    },

                    new Question
                    {
                        QuestionText = "How many players are there in a cricket team?",
                        OptionA = "9",
                        OptionB = "10",
                        OptionC = "11",
                        OptionD = "12",
                        CorrectAnswer = "C",
                        Explanation = "A cricket team has 11 players.",
                        CategoryId = 3
                    },
                    new Question
                    {
                        QuestionText = "Which keyword is used to declare a class in C#?",
                        OptionA = "class",
                        OptionB = "Class",
                        OptionC = "struct",
                        OptionD = "object",
                        CorrectAnswer = "A",
                        Explanation = "The 'class' keyword is used to declare a class in C#.",
                        CategoryId = 1
                    },

new Question
{
    QuestionText = "Which symbol is used to end a statement in C#?",
    OptionA = ".",
    OptionB = ",",
    OptionC = ";",
    OptionD = ":",
    CorrectAnswer = "C",
    Explanation = "Statements in C# end with a semicolon (;).",
    CategoryId = 1
},

new Question
{
    QuestionText = "Which company developed C#?",
    OptionA = "Google",
    OptionB = "Microsoft",
    OptionC = "Apple",
    OptionD = "IBM",
    CorrectAnswer = "B",
    Explanation = "C# was developed by Microsoft.",
    CategoryId = 1
},

new Question
{
    QuestionText = "Which HTML tag creates a hyperlink?",
    OptionA = "<a>",
    OptionB = "<link>",
    OptionC = "<href>",
    OptionD = "<url>",
    CorrectAnswer = "A",
    Explanation = "The <a> tag is used to create hyperlinks.",
    CategoryId = 1
},

new Question
{
    QuestionText = "CSS stands for?",
    OptionA = "Computer Style Sheets",
    OptionB = "Creative Style Sheets",
    OptionC = "Cascading Style Sheets",
    OptionD = "Colorful Style Sheets",
    CorrectAnswer = "C",
    Explanation = "CSS stands for Cascading Style Sheets.",
    CategoryId = 1
},

new Question
{
    QuestionText = "JavaScript is mainly used for?",
    OptionA = "Styling web pages",
    OptionB = "Adding interactivity",
    OptionC = "Database management",
    OptionD = "Operating systems",
    CorrectAnswer = "B",
    Explanation = "JavaScript adds dynamic behavior to web pages.",
    CategoryId = 1
},

new Question
{
    QuestionText = "Which database is commonly used with ASP.NET Core?",
    OptionA = "SQL Server",
    OptionB = "MS Paint",
    OptionC = "Photoshop",
    OptionD = "Excel",
    CorrectAnswer = "A",
    Explanation = "SQL Server is commonly used with ASP.NET Core.",
    CategoryId = 1
},
new Question
{
    QuestionText = "Which planet is known as the Red Planet?",
    OptionA = "Mars",
    OptionB = "Venus",
    OptionC = "Earth",
    OptionD = "Jupiter",
    CorrectAnswer = "A",
    Explanation = "Mars is known as the Red Planet.",
    CategoryId = 2
},

new Question
{
    QuestionText = "Which is the largest ocean?",
    OptionA = "Indian Ocean",
    OptionB = "Atlantic Ocean",
    OptionC = "Pacific Ocean",
    OptionD = "Arctic Ocean",
    CorrectAnswer = "C",
    Explanation = "The Pacific Ocean is the largest ocean.",
    CategoryId = 2
},

new Question
{
    QuestionText = "Who wrote the Indian National Anthem?",
    OptionA = "Mahatma Gandhi",
    OptionB = "Rabindranath Tagore",
    OptionC = "Subhash Chandra Bose",
    OptionD = "Jawaharlal Nehru",
    CorrectAnswer = "B",
    Explanation = "Rabindranath Tagore wrote Jana Gana Mana.",
    CategoryId = 2
},

new Question
{
    QuestionText = "Which is the tallest mountain in the world?",
    OptionA = "Mount Everest",
    OptionB = "K2",
    OptionC = "Kanchenjunga",
    OptionD = "Makalu",
    CorrectAnswer = "A",
    Explanation = "Mount Everest is the world's tallest mountain.",
    CategoryId = 2
},

new Question
{
    QuestionText = "Which is the national animal of India?",
    OptionA = "Lion",
    OptionB = "Tiger",
    OptionC = "Elephant",
    OptionD = "Leopard",
    CorrectAnswer = "B",
    Explanation = "The Bengal Tiger is India's national animal.",
    CategoryId = 2
},

new Question
{
    QuestionText = "How many continents are there?",
    OptionA = "5",
    OptionB = "6",
    OptionC = "7",
    OptionD = "8",
    CorrectAnswer = "C",
    Explanation = "There are seven continents.",
    CategoryId = 2
},

new Question
{
    QuestionText = "Which country is known as the Land of the Rising Sun?",
    OptionA = "China",
    OptionB = "Japan",
    OptionC = "Thailand",
    OptionD = "South Korea",
    CorrectAnswer = "B",
    Explanation = "Japan is known as the Land of the Rising Sun.",
    CategoryId = 2
},
new Question
{
    QuestionText = "How many players are there in a football team?",
    OptionA = "9",
    OptionB = "10",
    OptionC = "11",
    OptionD = "12",
    CorrectAnswer = "C",
    Explanation = "A football team has 11 players on the field.",
    CategoryId = 3
},

new Question
{
    QuestionText = "Which country won the Cricket World Cup 2023?",
    OptionA = "India",
    OptionB = "Australia",
    OptionC = "England",
    OptionD = "Pakistan",
    CorrectAnswer = "B",
    Explanation = "Australia won the ICC Cricket World Cup 2023.",
    CategoryId = 3
},

new Question
{
    QuestionText = "Which sport uses a shuttlecock?",
    OptionA = "Tennis",
    OptionB = "Badminton",
    OptionC = "Table Tennis",
    OptionD = "Squash",
    CorrectAnswer = "B",
    Explanation = "Badminton is played using a shuttlecock.",
    CategoryId = 3
},

new Question
{
    QuestionText = "Which country hosted the FIFA World Cup 2022?",
    OptionA = "Brazil",
    OptionB = "Qatar",
    OptionC = "Russia",
    OptionD = "Germany",
    CorrectAnswer = "B",
    Explanation = "Qatar hosted the FIFA World Cup 2022.",
    CategoryId = 3
},

new Question
{
    QuestionText = "Which sport is Wimbledon associated with?",
    OptionA = "Football",
    OptionB = "Tennis",
    OptionC = "Cricket",
    OptionD = "Golf",
    CorrectAnswer = "B",
    Explanation = "Wimbledon is the oldest tennis tournament.",
    CategoryId = 3
},

new Question
{
    QuestionText = "How many rings are there on the Olympic flag?",
    OptionA = "4",
    OptionB = "5",
    OptionC = "6",
    OptionD = "7",
    CorrectAnswer = "B",
    Explanation = "The Olympic flag has five interlocking rings.",
    CategoryId = 3
},

new Question
{
    QuestionText = "Which sport is Virat Kohli associated with?",
    OptionA = "Football",
    OptionB = "Cricket",
    OptionC = "Hockey",
    OptionD = "Tennis",
    CorrectAnswer = "B",
    Explanation = "Virat Kohli is an Indian international cricketer.",
    CategoryId = 3
}

                );

                _context.SaveChanges();
            }
        }
    }
}