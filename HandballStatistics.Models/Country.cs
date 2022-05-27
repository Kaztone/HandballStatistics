using System.Collections.Generic;

namespace HandballStatistics.Models
{
    /// <summary>
    /// Base class for Country.
    /// Derives from <see cref="DomainObject"/> class.
    /// </summary>
    public class Country : DomainObject
    {
        #region-----------------------------Properties, Indexer--------------------------------
        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Teams.
        /// </summary>
        public ICollection<Team> Teams { get; set; }

        /// <summary>
        /// Gets or sets Halls.
        /// </summary>
        public ICollection<Hall> Halls { get; set; }

        /// <summary>
        /// Gets or sets Leagues.
        /// </summary>
        public ICollection<League> Leagues { get; set; }
        #endregion
    }
}
