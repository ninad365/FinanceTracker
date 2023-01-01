using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using FinanceTracker.Models;

namespace FinanceTracker
{
    public class DefaultConnection : DbContext
    {
        public DefaultConnection() : base("name=DefaultConnection")
        {
        }

        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<User> Users { get; set; }
    }
}