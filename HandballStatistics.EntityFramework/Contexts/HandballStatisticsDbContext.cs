using HandballStatistics.Models;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Text;

namespace HandballStatistics.EntityFramework.Contexts
{
    public class HandballStatisticsDbContext : DbContext
    {
        #region ------------------------------ Properties, Indexer --------------------------------------------------

        public DbSet<User> Users { get; set; }

        public DbSet<Account> Accounts { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Hall> Halls { get; set; }

        public DbSet<League> Leagues { get; set; }

        public DbSet<Match> Matches { get; set; }

        public DbSet<Player> Players { get; set; }

        public DbSet<Team> Teams { get; set; }

        #endregion

        #region ------------------------------ Constructor, Destructor, Dispose, Clone ------------------------------
        public HandballStatisticsDbContext() : base("HandballStatistics")
        { }

        #endregion

        #region ------------------------------ Helper-Methods -------------------------------------------------------

        public HandballStatisticsDbContext CreateContext()
        {
            return new HandballStatisticsDbContext();
        }

        public override int SaveChanges()
        {
            try
            {
                return base.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                var sb = new StringBuilder();

                foreach (var failure in ex.EntityValidationErrors)
                {
                    sb.AppendFormat("{0} failed validation\n", failure.Entry.Entity.GetType());
                    foreach (var error in failure.ValidationErrors)
                    {
                        sb.AppendFormat("- {0} : {1}", error.PropertyName, error.ErrorMessage);
                        sb.AppendLine();
                    }
                }

                throw new DbEntityValidationException(
                    "Entity Validation Failed - errors follow:\n" +
                    sb.ToString(), ex
                );
            }
        }

        #endregion
    }
}
