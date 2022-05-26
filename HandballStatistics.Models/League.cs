using System.Collections.Generic;

namespace HandballStatistics.Models
{
    public class League : DomainObject
    {
        public string Name { get; set; }

        public string Abbrevation { get; set; }

        public int CountryId { get; set; }

        public ICollection<Team> Teams { get; set; }
    }
}
