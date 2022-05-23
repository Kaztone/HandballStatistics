using HandballStatistics.EntityFramework.Contexts;
using HandballStatistics.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

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
            if (context.Users.Any())
            {
                return;
            }

            context.Users.AddRange(new List<User>()
            {
                new User()
                {
                    UserName = "admin",
                    Email = "admin@hotmail.com",
                    Password = "admin",
                    DateJoined = new DateTime(2022, 3, 23).Date
                }
            });
        }
    }
}
