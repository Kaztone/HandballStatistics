using HandballStatistics.EntityFramework.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandballStatistics.EntityFramework.Factories
{
    public class HandballStatisticsDbContextFactory
    {
        public HandballStatisticsDbContext CreateContext()
        {
            return new HandballStatisticsDbContext();
        }
    }
}
