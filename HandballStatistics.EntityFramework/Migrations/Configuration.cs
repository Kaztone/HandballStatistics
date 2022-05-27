using HandballStatistics.EntityFramework.Contexts;
using HandballStatistics.Models;
using System.Data.Entity.Migrations;

namespace HandballStatistics.EntityFramework.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<HandballStatisticsDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(HandballStatisticsDbContext context)
        {
            //if (context.Users.Any())
            //{
            //    return;
            //}

            //User user = new User()
            //{
            //    UserName = "admin",
            //    Email = "admin@hotmail.com",
            //    Password = "admin",
            //    DateJoined = new DateTime(2022, 3, 23).Date
            //};

            //context.Users.AddRange(new List<User>()
            //{
            //    user
            //});

            //context.Accounts.AddRange(new List<Account>()
            //{
            //    new Account(user)
            //});

            //context.Countries.AddRange(new List<Country>()
            //{
            //    new Country() { Name = "Autria" },
            //    new Country() { Name = "Germany" },
            //    new Country() { Name = "France" },
            //    new Country() { Name = "Spain" },
            //    new Country() { Name = "Switzerland" }
            //});

            //context.Leagues.AddRange(new List<League>()
            //{
            //    new League() { Name = "Handball Liga Austria", Abbrevation = "HLA", CountryId = 1},
            //    new League() { Name = "Handball-Bundesliga", Abbrevation = "HBL", CountryId = 2},
            //    new League() { Name = "Lidl StarLigue", Abbrevation = "LNH", CountryId = 3},
            //    new League() { Name = "Liga Asobal", Abbrevation = "ASOBAL", CountryId = 4},
            //    new League() { Name = "Swiss Handball League", Abbrevation = "SHL", CountryId = 5}
            //});

            //context.Teams.AddRange(new List<Team>()
            //{
            //    new Team() { Name = "Handballclub Fivers Margareten", LeagueId = 1},
            //    new Team() { Name = "ERBER UHK Krems", LeagueId = 1}
            //});

            //context.Halls.AddRange(new List<Hall>()
            //{
            //    new Hall () { Name = "Sporthalle Margareten", Address = "Hollgasse 3, 1050 Wien", CountryId = 1},
            //    new Hall () { Name = "Sport.Halle.Krems", Address = "Strandbadstraße 3, 3500 Krems", CountryId = 1}
            //});
        }
    }
}
