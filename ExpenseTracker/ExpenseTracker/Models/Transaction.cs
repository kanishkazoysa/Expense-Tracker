using System.ComponentModel.DataAnnotations;

namespace ExpenseTracker.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int Amount { get; set; }
        public string? Note { get; set; }
        public string Date { get; set; } = DateTime.Now.ToString("yyyy-MM-dd");
    }
}
