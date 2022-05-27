using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandballStatistics.Models
{
    public class Team : DomainObject
    {
        public string Name { get; set; }

        public int LeagueId { get; set; }

        public ICollection<Player> Players { get; set; }
    }
}
