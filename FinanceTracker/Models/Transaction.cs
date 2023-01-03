using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinanceTracker.Models
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        [Required]
        [Column(TypeName = "decimal")]
        public decimal Amount { get; set; }
        public string Description { get; set; }
        // Add foreign key for User
        [ForeignKey("User")]
        public int FK_UserId { get; set; }
        public virtual User User { get; set; }
        public enum TransactionCategory
        {
            Income = 1,
            Expense = -1,
        }
        public bool IsExpense { get; set; }
    }
}