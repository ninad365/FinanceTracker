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
        public DateTime Date { get; set; }
        [Required]
        [Column(TypeName = "decimal")]
        public decimal Amount { get; set; }
        [Required]
        public string Category { get; set; }
        public string Description { get; set; }
        // Add foreign key for User
        [ForeignKey("User")]
        public int FK_UserId { get; set; }
        public virtual User User { get; set; }
    }
}