using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandballStatistics.Models
{
    public class Country : DomainObject
    {
        public string Name { get; set; }

        public ICollection<Team> Teams { get; set; }

        public ICollection<Hall> Halls { get; set; }
    }
}
