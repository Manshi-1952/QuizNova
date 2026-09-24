using Microsoft.EntityFrameworkCore;
using QuizNova.Models;

namespace QuizNova.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories => Set<Category>();
        public DbSet<Question> Questions => Set<Question>();
        public DbSet<Result> Results => Set<Result>();
    }
}