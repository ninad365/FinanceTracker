namespace FinanceTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ConnectTransactionUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Transactions", "FK_UserId", c => c.Int(nullable: false));
            AddColumn("dbo.Users", "Password", c => c.String(nullable: false));
            CreateIndex("dbo.Transactions", "FK_UserId");
            AddForeignKey("dbo.Transactions", "FK_UserId", "dbo.Users", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Transactions", "FK_UserId", "dbo.Users");
            DropIndex("dbo.Transactions", new[] { "FK_UserId" });
            DropColumn("dbo.Users", "Password");
            DropColumn("dbo.Transactions", "FK_UserId");
        }
    }
}
