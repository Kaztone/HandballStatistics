using HandballStatistics.EntityFramework.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandballStatistics.EntityFramework.Factories
{
    public class HandballStatisticsDbContextFactory : HandballStatisticsDbContext
    {
        public HandballStatisticsDbContext Context { get; }
        
        public HandballStatisticsDbContextFactory()
        {
            this.Context = new HandballStatisticsDbContext();
        }
    }
}
