# 🎯 QuizNova

**QuizNova** is an interactive quiz management web application developed
using **ASP.NET Core MVC, C#, Entity Framework Core, and SQL Server**.

The application allows users to choose a quiz category, attempt timed
questions, use a **50-50 lifeline**, receive instant feedback, and view
their quiz history and leaderboard performance.

------------------------------------------------------------------------

## 📌 Project Overview

QuizNova provides a simple and engaging platform for online quiz
practice and assessment.

The application includes:

-   Multiple quiz categories
-   Timed questions
-   50-50 lifeline
-   Instant answer feedback
-   Quiz score and result calculation
-   Quiz history
-   Leaderboard with search
-   Responsive and modern user interface
-   SQL Server database integration

------------------------------------------------------------------------

## ✨ Features

### 🏠 Home Page

The home page provides an overview of the available quiz content.

It displays:

-   Total number of categories
-   Total number of questions
-   Number of quiz attempts
-   Available quiz categories
-   Name input
-   Category selection
-   Quiz start option

### 📚 Quiz Categories

QuizNova currently contains three categories:

-   💻 **Programming**
-   🌍 **General Knowledge**
-   ⚽ **Sports**

The current project contains **25 questions** distributed across these
categories.

### ⏱️ Timed Quiz

Each question has a **15-second time limit**.

If the user does not submit an answer before the timer reaches zero, the
quiz automatically proceeds through the implemented submission flow.

### 50-50 Lifeline

The quiz includes a **50-50 lifeline** that removes two answer choices
to help the user answer the current question.

### 💡 Instant Feedback

After submitting an answer, the application provides feedback about the
selected answer and displays:

-   Correct answer
-   Explanation
-   Answer status

### 📊 Quiz Results

After completing a quiz, QuizNova calculates the user's performance and
displays the result.

The result includes information such as:

-   Score
-   Accuracy
-   Category
-   Quiz date
-   Performance status

### 📜 Quiz History

The History page stores completed quiz attempts and displays information
such as:

-   User name
-   Score
-   Date of attempt

### 🏆 Leaderboard

The Leaderboard displays quiz performance in ranked order.

It includes:

-   Rank
-   Participant name
-   Score
-   Date
-   Search by participant name

------------------------------------------------------------------------

## 🖥️ Screenshots

### Home Page

![QuizNova Home Page](QuizNova/home.png)

### Quiz History

![QuizNova History](QuizNova/quiz_history.png)

### Leaderboard

![QuizNova Leaderboard](QuizNova/leaderboard.png)

> **Note:** Add your three screenshots to a `screenshots` folder in the
> repository using the filenames `home.png`, `history.png`, and
> `leaderboard.png`.

------------------------------------------------------------------------

## 🛠️ Technologies Used

  Technology                  Purpose
  --------------------------- ----------------------------------------------
  **C#**                      Application programming language
  **ASP.NET Core MVC**        Web application framework
  **Entity Framework Core**   ORM and database interaction
  **SQL Server**              Database management
  **Razor Views**             Dynamic web page rendering
  **HTML5**                   Page structure
  **CSS3**                    Styling and layout
  **JavaScript**              Timer, lifeline and client-side interactions
  **Bootstrap**               Responsive UI components
  **.NET**                    Application runtime and framework

------------------------------------------------------------------------

## 🏗️ Project Architecture

QuizNova follows the **Model-View-Controller (MVC)** architecture.

``` text
                    ┌─────────────────────┐
                    │       User          │
                    │     Web Browser     │
                    └──────────┬──────────┘
                               │
                               ▼
                    ┌─────────────────────┐
                    │    Controllers      │
                    │  Request Handling   │
                    └──────────┬──────────┘
                               │
                ┌──────────────┴──────────────┐
                ▼                             ▼
       ┌─────────────────┐          ┌─────────────────┐
       │     Models      │          │  Razor Views    │
       │  Quiz Data      │          │      UI         │
       └────────┬────────┘          └─────────────────┘
                │
                ▼
       ┌─────────────────────┐
       │ Entity Framework    │
       │       Core          │
       └──────────┬──────────┘
                  │
                  ▼
       ┌─────────────────────┐
       │     SQL Server      │
       │      Database       │
       └─────────────────────┘
```

------------------------------------------------------------------------

## 📂 Project Structure

``` text
QuizNova/
│
├── Controllers/
│   ├── HomeController.cs
│   ├── QuizController.cs
│   ├── ResultController.cs
│   ├── HistoryController.cs
│   └── LeaderboardController.cs
│
├── Models/
│   ├── Category.cs
│   ├── Question.cs
│   └── Result.cs
│
├── ViewModels/
│   └── QuizViewModel.cs
│
├── Views/
│   ├── Home/
│   ├── Quiz/
│   ├── Result/
│   ├── History/
│   ├── Leaderboard/
│   └── Shared/
│
├── Data/
│   └── AppDbContext.cs
│
├── Migrations/
│
├── wwwroot/
│   ├── css/
│   ├── js/
│   └── images/
│
├── Properties/
│
├── appsettings.json
├── Program.cs
├── QuizNova.csproj
└── .gitignore
```

------------------------------------------------------------------------

## 🔄 Quiz Workflow

``` text
Start
  │
  ▼
Enter Name
  │
  ▼
Select Category
  │
  ▼
Start Quiz
  │
  ▼
Display Question
  │
  ▼
15-Second Timer
  │
  ├──── Use 50-50 ────► Remove Two Options
  │
  ▼
Submit Answer
  │
  ▼
Show Correct Answer + Explanation
  │
  ▼
Next Question
  │
  ▼
Quiz Completed
  │
  ▼
Calculate Score
  │
  ▼
Save Result
  │
  ▼
Display Result
  │
  ├────────► History
  │
  └────────► Leaderboard
```

------------------------------------------------------------------------

## 🗄️ Database

QuizNova uses **SQL Server** with **Entity Framework Core**.

The main entities include:

### Category

Stores quiz category information.

``` text
Category
├── Id
└── Name
```

### Question

Stores quiz questions and their options.

``` text
Question
├── Id
├── QuestionText
├── OptionA
├── OptionB
├── OptionC
├── OptionD
├── CorrectAnswer
├── Explanation
└── CategoryId
```

### Result

Stores completed quiz attempts.

``` text
Result
├── Id
├── UserName
├── Score
└── QuizDate
```

------------------------------------------------------------------------

## ⚙️ How to Run the Project

### Prerequisites

Make sure the following are installed:

-   Visual Studio 2022 or a compatible .NET IDE
-   .NET SDK compatible with the project
-   SQL Server / SQL Server LocalDB
-   SQL Server Management Studio (optional)

### 1. Clone the Repository

``` bash
git clone https://github.com/Manshi-1952/QuizNova.git
```

### 2. Open the Project

Open:

``` text
QuizNova.csproj
```

in Visual Studio.

### 3. Configure the Database

Open:

``` text
appsettings.json
```

and configure the SQL Server connection string according to your local
environment.

Example:

``` json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\MSSQLLocalDB;Database=QuizNovaDB;Trusted_Connection=True;TrustServerCertificate=True;"
  }
}
```

> Do not commit real database passwords, API keys, or other secrets to a
> public repository.

### 4. Apply Migrations

From the Package Manager Console:

``` powershell
Update-Database
```

Or using the .NET CLI:

``` bash
dotnet ef database update
```

### 5. Run the Application

Using Visual Studio:

``` text
Press F5 / Ctrl + F5
```

Or using the terminal:

``` bash
dotnet run
```

The application will open in the browser using the local ASP.NET Core
development URL.

------------------------------------------------------------------------

## 🧪 Main Functional Modules

  -----------------------------------------------------------------------
  Module                              Description
  ----------------------------------- -----------------------------------
  **Home**                            Displays categories, question count
                                      and quiz start controls

  **Quiz**                            Handles questions, answers, timer
                                      and 50-50 lifeline

  **Result**                          Calculates and displays quiz
                                      performance

  **History**                         Displays previous quiz attempts

  **Leaderboard**                     Ranks quiz scores and supports name
                                      search

  **About**                           Provides information about the
                                      application
  -----------------------------------------------------------------------

------------------------------------------------------------------------

## 🔮 Future Enhancements

The project can be extended with:

-   🔐 User registration and login
-   👤 User-specific quiz history
-   🛠️ Admin dashboard
-   ➕ Add/edit/delete questions
-   🎲 Randomized questions and answer options
-   📈 Performance analytics and charts
-   🏅 Badges and achievement system
-   🌐 Cloud deployment
-   📱 Improved mobile-first interface
-   🔔 Notifications and quiz reminders
-   📚 Larger question bank
-   🔒 Improved authentication and authorization

------------------------------------------------------------------------

## 🎓 Learning Outcomes

This project demonstrates practical knowledge of:

-   ASP.NET Core MVC
-   C# programming
-   MVC architecture
-   Entity Framework Core
-   SQL Server
-   Database migrations
-   Razor Views
-   HTML/CSS
-   JavaScript
-   Bootstrap
-   CRUD/data management concepts
-   Form handling
-   Server-side and client-side interaction

------------------------------------------------------------------------

## 👩‍💻 Developer

**Manshi Gohil**

GitHub: [Manshi-1952](https://github.com/Manshi-1952)

Project Repository: [QuizNova](https://github.com/Manshi-1952/QuizNova)

------------------------------------------------------------------------

## 📄 License

This project is developed for **academic and educational purposes**.

------------------------------------------------------------------------

⭐ If you find this project useful, consider giving the repository a
star!
