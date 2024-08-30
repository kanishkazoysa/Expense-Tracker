using Microsoft.EntityFrameworkCore;
using ExpenseTracker.Models;

namespace ExpenseTracker.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options): base(options)
        { }

        public DbSet<Transaction> Transaction { get; set; }
        public DbSet<Transaction> Categories { get; set; }
        public DbSet<ExpenseTracker.Models.Category> Category { get; set; } = default!;



    }
}
