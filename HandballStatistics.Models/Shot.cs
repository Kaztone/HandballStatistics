using System;

namespace HandballStatistics.Models
{
    public class Shot : DomainObject
    {
        public int MatchId { get; set; }

        public bool Goal { get; set; }

        public int SquareNumber { get; set; }

        public DateTime Time { get; set; }

        public int PlayerId { get; set; }

        public int TeamId { get; set; }
    }
}
