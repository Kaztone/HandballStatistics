using System.Collections.Generic;

namespace HandballStatistics.Models
{
    /// <summary>
    /// Base class for Team.
    /// Derives from <see cref="DomainObject"/> class.
    /// </summary>
    public class Team : DomainObject
    {
        #region-----------------------------Properties, Indexer--------------------------------
        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets LeagueId.
        /// </summary>
        public int LeagueId { get; set; }

        /// <summary>
        /// Gets or sets players.
        /// </summary>
        public ICollection<Player> Players { get; set; }
        #endregion
    }
}
