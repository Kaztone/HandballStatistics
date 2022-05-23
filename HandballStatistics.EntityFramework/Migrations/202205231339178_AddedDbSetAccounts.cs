namespace HandballStatistics.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDbSetAccounts : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AccountHolderId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.AccountHolderId, cascadeDelete: true)
                .Index(t => t.AccountHolderId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Accounts", "AccountHolderId", "dbo.Users");
            DropIndex("dbo.Accounts", new[] { "AccountHolderId" });
            DropTable("dbo.Accounts");
        }
    }
}
