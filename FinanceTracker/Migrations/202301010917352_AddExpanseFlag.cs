namespace FinanceTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddExpanseFlag : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Transactions", "IsExpense", c => c.Boolean(nullable: false));
            DropColumn("dbo.Transactions", "Category");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Transactions", "Category", c => c.String(nullable: false));
            DropColumn("dbo.Transactions", "IsExpense");
        }
    }
}
