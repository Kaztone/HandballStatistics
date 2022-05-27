namespace HandballStatistics.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedMissingModels : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Halls",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        CountryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.CountryId, cascadeDelete: true)
                .Index(t => t.CountryId);
            
            CreateTable(
                "dbo.Leagues",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Abbrevation = c.String(),
                        CountryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.CountryId, cascadeDelete: true)
                .Index(t => t.CountryId);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CountryId = c.Int(nullable: false),
                        LeagueId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Leagues", t => t.LeagueId, cascadeDelete: true)
                .ForeignKey("dbo.Countries", t => t.CountryId, cascadeDelete: true)
                .Index(t => t.CountryId)
                .Index(t => t.LeagueId);
            
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        JerseyNumber = c.Int(nullable: false),
                        Goals = c.Int(nullable: false),
                        TeamId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Teams", t => t.TeamId, cascadeDelete: true)
                .Index(t => t.TeamId);
            
            CreateTable(
                "dbo.Matches",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Date = c.DateTime(nullable: false),
                        FileName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Shots",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MatchId = c.Int(nullable: false),
                        Goal = c.Boolean(nullable: false),
                        SquareNumber = c.Int(nullable: false),
                        Time = c.DateTime(nullable: false),
                        PlayerId = c.Int(nullable: false),
                        TeamId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Matches", t => t.MatchId, cascadeDelete: true)
                .Index(t => t.MatchId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Shots", "MatchId", "dbo.Matches");
            DropForeignKey("dbo.Teams", "CountryId", "dbo.Countries");
            DropForeignKey("dbo.Leagues", "CountryId", "dbo.Countries");
            DropForeignKey("dbo.Teams", "LeagueId", "dbo.Leagues");
            DropForeignKey("dbo.Players", "TeamId", "dbo.Teams");
            DropForeignKey("dbo.Halls", "CountryId", "dbo.Countries");
            DropIndex("dbo.Shots", new[] { "MatchId" });
            DropIndex("dbo.Players", new[] { "TeamId" });
            DropIndex("dbo.Teams", new[] { "LeagueId" });
            DropIndex("dbo.Teams", new[] { "CountryId" });
            DropIndex("dbo.Leagues", new[] { "CountryId" });
            DropIndex("dbo.Halls", new[] { "CountryId" });
            DropTable("dbo.Shots");
            DropTable("dbo.Matches");
            DropTable("dbo.Players");
            DropTable("dbo.Teams");
            DropTable("dbo.Leagues");
            DropTable("dbo.Halls");
            DropTable("dbo.Countries");
        }
    }
}
