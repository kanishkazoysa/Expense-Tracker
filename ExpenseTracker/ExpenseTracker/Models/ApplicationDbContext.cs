using Microsoft.EntityFrameworkCore;

namespace ExpenseTracker.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options): base(options)
        { }

        public DbSet<Transaction> Transaction { get; set; }
        public DbSet<Transaction> Categories { get; set; }



    }
}
